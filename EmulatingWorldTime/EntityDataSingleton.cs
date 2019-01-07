using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulatingWorldTime
{

    /// <summary>
    /// Any data we wish to store with each entity.
    /// </summary>
    public class EntityData
    {
        /// <summary>
        /// Lowercase key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// How long the device took
        /// </summary>
        public TimeSpan TimeForDevice { get; set; }

        /// <summary>
        /// When the custom Step made the request.
        /// </summary>
        public DateTime TimeRequestMade { get; set; }

        /// <summary>
        /// When the device found the request.
        /// </summary>
        public DateTime TimeRequestFound { get; set; }

        /// <summary>
        /// When the device sent the response.
        /// </summary>
        public DateTime TimeResponseSent { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public EntityData(string key)
        {
            Key = key.ToLower();
        }
    }

    /// <summary>
    /// A singleton class to hold our data
    /// </summary>
    public class EntityDataSingleton
    {
        private static EntityDataSingleton _instance;

        /// <summary>
        /// The folder where the device files are kept.
        /// </summary>
        public string FolderPath { get; set; }

        /// <summary>
        /// A place to store information at runtime
        /// </summary>
        public ConcurrentDictionary<string, EntityData> EntityDataDict { get; set; }

        /// <summary>
        /// The singleton constructor
        /// </summary>
        private EntityDataSingleton()
        {
            EntityDataDict = new ConcurrentDictionary<string, EntityData>();

        }

        /// <summary>
        /// The singleton pattern implemented.
        /// </summary>
        public static EntityDataSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EntityDataSingleton();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Get runtime info according to case-insensitive key.
        /// The key is built from the Entity name (which is unique over a simulation run)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool GetEntityData(string key, out EntityData info)
        {
            if (!EntityDataDict.TryGetValue(key.ToLower(), out info))
                return false;

            return true;
        }

        /// <summary>
        /// Store or replace EntityData info
        /// </summary>
        /// <param name="key"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool PutEntityData(string key, EntityData info)
        {
            EntityDataDict.AddOrUpdate(key.ToLower(), info, (k, v) => info);

            return true;
        }
    }
}
