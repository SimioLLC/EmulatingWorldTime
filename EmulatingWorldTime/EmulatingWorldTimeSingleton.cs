using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulatingWorldTime
{
    /// <summary>
    /// Indicates if our time-scaling factors are:
    /// Fixed - Based on the time at start, or
    /// Variable - Based on the last sampling
    /// </summary>
    public enum EnumEmulationMode
    {
        Fixed = 0,
        Variable = 1
    }

    /// <summary>
    /// A singleton class to hold our data
    /// </summary>
    public class EmulatingWorldTimeSingleton
    {
        private static EmulatingWorldTimeSingleton _instance;

        /// <summary>
        /// Sim-Time at start, which is 0.0
        /// </summary>
        public double StartSimHour { get; set; }

        /// <summary>
        /// World-Time at start, which is reported
        /// by DateTime's UtcNow
        /// </summary>
        public DateTime StartWorldTime { get; set; }

        private FormEmulator MyEmulatorForm { get; set; }

        /// <summary>
        /// The current simulation time, which is an hour
        /// reported by context.Calendar as the simulation starts.
        /// </summary>
        public double CurrentSimHour { get; set; }

        public double PreviousSimHour { get; set; }

        public DateTime PreviousWorldTime { get; set; }

        /// <summary>
        /// Fixed or Variable.
        /// When fixed, we are doing differences between start and now, and the WorldTimeFactor
        /// should not be altered after start.
        /// When Variable, we are doing difference between the last sync and now and the WorldTimeFactor
        /// can be altered at each step.
        /// </summary>
        public EnumEmulationMode EmulationMode { get; set; }

        /// <summary>
        /// A value from 0.0 to 1000.0
        /// The default is 1.0, which means the simulation will
        /// proceed at normal "Wall-clock" time.
        /// Setting this to 0.0 means that the simulation will proceed as it normally would,
        /// without synchronizing and therefore without regard to World-Time.
        /// Setting it positive controls how the simulation time is sync'd to World-Time. Examples:
        /// Setting this to 0.5 means the simulation is in fast motion, and specifically twice as fast "Wall-Clock" time.
        /// Setting this to 2.0 means the simulation is in slow motion, and specifically half as fast as "Wall-Clock" time.
        /// </summary>
        public double WorldTimeFactor { get; set; }

        /// <summary>
        /// Synchronize the thread according to World-Time.
        /// </summary>
        /// <param name="simTime"></param>
        public void SyncTimes(double simTime)
        {
            try
            {
                MyEmulatorForm.DoEvents();
                DateTime worldTimeNow = DateTime.UtcNow;

                // One time initialization; happens whenever the simulation starts again
                if (simTime == 0)
                {
                    StartSimHour = simTime;
                    StartWorldTime = worldTimeNow;
                }

                // Usually, simulation time will be ahead of (faster than) world time, so we'll slow it down,
                // by calculating where we are (sim-time) vs where we should be (adjusted world-time)
                double deltaSimSeconds = 0.0;
                double deltaWorldSeconds = 0.0;

                switch ( EmulationMode )
                {
                    case EnumEmulationMode.Fixed:
                        deltaSimSeconds = (simTime - StartSimHour) * 3600.00;
                        deltaWorldSeconds = worldTimeNow.Subtract(StartWorldTime).TotalSeconds;
                        break;

                    case EnumEmulationMode.Variable:
                        deltaSimSeconds = (simTime - PreviousSimHour) * 3600.00;
                        deltaWorldSeconds = worldTimeNow.Subtract(PreviousWorldTime).TotalSeconds;
                        break;

                }

                double adjustmentSeconds = deltaSimSeconds - deltaWorldSeconds;
                adjustmentSeconds = WorldTimeFactor * adjustmentSeconds;

                if (adjustmentSeconds > 0)
                {
                    // This will suspend the thread for the given number of milliseconds, which
                    // allows the simulation time to sync with world time.
                    System.Threading.Thread.Sleep((int)(1000.0 * (adjustmentSeconds)));
                }
                else // This would likely only happen during debugging
                { }

                PreviousSimHour = simTime;
                PreviousWorldTime = worldTimeNow;

                if ( MyEmulatorForm != null )
                    WorldTimeFactor = Convert.ToDouble( MyEmulatorForm.ClockSpeed );

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Err={ex}");
            }
        }

        /// <summary>
        /// The singleton constructor
        /// </summary>
        private EmulatingWorldTimeSingleton()
        {
            WorldTimeFactor = 1.0;  // 1.0='wall-clock', 0.1=10 times faster, 10.0=10 times slower
            EmulationMode = EnumEmulationMode.Variable;

            MyEmulatorForm = new FormEmulator();
            MyEmulatorForm.SetSlower();
            MyEmulatorForm.Show();
        }


        /// <summary>
        /// The singleton pattern implemented.
        /// </summary>
        public static EmulatingWorldTimeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmulatingWorldTimeSingleton();
                }
                return _instance;
            }
        }


    }
}


