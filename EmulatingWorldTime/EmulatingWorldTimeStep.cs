using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimioAPI;
using SimioAPI.Extensions;

namespace EmulatingWorldTime
{

    /// <summary>
    /// The EmulationSyncStep is used to adjust the simulation time to world  time.
    /// During its initial run, it records the starting times.
    /// After that, it suspends the thread when necessary.
    /// The Simulation Time is the Simio clock; a double which represents the hours since the simulation began.
    /// The World Time is the .NET DateTime UTC time.
    /// </summary>
    class EmulationSyncStepDefinition : IStepDefinition
    {
        #region IStepDefinition Members

        /// <summary>
        /// Property returning the full name for this type of step. The name should contain no spaces.
        /// </summary>
        public string Name
        {
            get { return "EmulationSyncStep"; }
        }

        /// <summary>
        /// Property returning a short description of what the step does.
        /// </summary>
        public string Description
        {
            get { return "Make the simulation proceed in World (wall-clock) time"; }
        }

        /// <summary>
        /// Property returning an icon to display for the step in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Property returning a unique static GUID for the step.
        /// </summary>
        public Guid UniqueID
        {
            get { return MY_ID; }
        }
        static readonly Guid MY_ID = new Guid("{193D4F75-299A-4AE6-A3B9-D7DD5021084E}");

        /// <summary>
        /// Property returning the number of exits out of the step. Can return either 1 or 2.
        /// </summary>
        public int NumberOfExits
        {
            get { return 1; }
        }

        /// <summary>
        /// Method called that defines the property schema for the step.
        /// </summary>
        public void DefineSchema(IPropertyDefinitions schema)
        {
        }

        /// <summary>
        /// Method called to create a new instance of this step type to place in a process.
        /// Returns an instance of the class implementing the IStep interface.
        /// </summary>
        public IStep CreateStep(IPropertyReaders properties)
        {
            return new EmulationSyncStep(properties);
        }

        #endregion
    }

    /// <summary>
    /// This type of step emulates the communication with an external device.
    /// </summary>
    class EmulationSyncStep : IStep
    {
        IPropertyReaders _properties;

        public EmulationSyncStep(IPropertyReaders properties)
        {
            _properties = properties;
        }

        #region IStep Members

        /// <summary>
        /// Method called when a process token executes the step.
        /// Synchronize the step with World-Time.
        /// </summary>
        public ExitType Execute(IStepExecutionContext context)
        {
            EmulatingWorldTimeSingleton eContext = EmulatingWorldTimeSingleton.Instance;

            eContext.SyncTimes(context.Calendar.TimeNow);

            return ExitType.FirstExit;
        }

        #endregion
    }

}
