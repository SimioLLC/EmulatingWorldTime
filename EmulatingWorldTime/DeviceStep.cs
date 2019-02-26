using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LoggertonHelpers;
using SimioAPI;
using SimioAPI.Extensions;

namespace EmulatingWorldTime
{
    class DeviceStepDefinition : IStepDefinition
    {
        #region IStepDefinition Members

        /// <summary>
        /// Property returning the full name for this type of step. The name should contain no spaces.
        /// </summary>
        public string Name
        {
            get { return "DeviceStep"; }
        }

        /// <summary>
        /// Property returning a short description of what the step does.
        /// </summary>
        public string Description
        {
            get { return "A simple Device communication (file drop) step."; }
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
        static readonly Guid MY_ID = new Guid("{5873595b-fccb-46cd-8075-03fc4643587d}");

        /// <summary>
        /// Property returning the number of exits out of the step. Can return either 1 or 2.
        /// </summary>
        public int NumberOfExits
        {
            get { return 2; }
        }

        /// <summary>
        /// Method called that defines the property schema for the step.
        /// </summary>
        public void DefineSchema(IPropertyDefinitions schema)
        {
            // Example of how to add a property definition to the step.
            IPropertyDefinition pd;
            pd = schema.AddStringProperty("FolderPath", @"c:\(test)");
            pd.DisplayName = "FolderPath";
            pd.Description = "The FolderPath that is used to simulate an external Device.";
            pd.Required = true;
        }

        /// <summary>
        /// Method called to create a new instance of this step type to place in a process.
        /// Returns an instance of the class implementing the IStep interface.
        /// </summary>
        public IStep CreateStep(IPropertyReaders properties)
        {
            return new DeviceStep(properties);
        }

        #endregion
    }


    class DeviceStep : IStep
    {
        IPropertyReaders _properties;

        public DeviceStep(IPropertyReaders properties)
        {
            _properties = properties;
        }

        #region IStep Members

        /// <summary>
        /// Send a device request by placing a file into the TestDevice folder (which
        /// is a property created for this step).
        /// Then go into a loop and poll for the response.
        /// When found, log some information and continue.
        /// </summary>
        public ExitType Execute(IStepExecutionContext context)
        {
            // Get the reference to our singleton.
            EntityDataSingleton eds = EntityDataSingleton.Instance;

            // Just a 'one shot' to store our folder path
            if ( string.IsNullOrEmpty(eds.FolderPath))
            {
                IPropertyReader reader = _properties.GetProperty("FolderPath") as IPropertyReader;
                string folder = reader.GetStringValue(context);
                eds.FolderPath = folder;
            }

            var simioEntity = context.AssociatedObject; 
            string name = simioEntity.HierarchicalDisplayName;

            string key = "";
            if (!name.StartsWith("DefaultEntity"))
                return ExitType.FirstExit;

            string[] tokens = name.Split('.');
            key = name.Replace('.', '$'); // Makes it more convenient for parsing later.

            // Fetch or create our entity data that will accompany the entity.
            // This data is stored in the singleton's dictionary, and fetched by key.
            EntityData eData = null;
            if (!eds.EntityDataDict.TryGetValue(key, out eData))
            {
                eData = new EntityData(key);
                eds.EntityDataDict.TryAdd(eData.Key, eData);
            }

            eData.TimeRequestMade = DateTime.UtcNow;

            string folderPath = eds.FolderPath;
            string requestFilePath = Path.Combine(folderPath, $"Request-{key}.txt");

            // If the request file is there, then we are waiting for a response, so
            // don't generate another request
            if (!File.Exists(requestFilePath))
            {
                logit(EnumLogFlags.Information, $"Request file written to={requestFilePath}");

                // Put a request file, and then we'll poll for the response.
                File.WriteAllText(requestFilePath, "(data body: info the device might want)");
            }

            // Look for the Response file. If found, then Exit First, if not, then exit Alternate
            string responseFilePath = Path.Combine(folderPath, $"Response-{key}.txt");

            if (File.Exists(responseFilePath))
            {
                string contents = File.ReadAllText(responseFilePath);
                File.Delete(responseFilePath);

                logit(EnumLogFlags.Information, $"Found file={responseFilePath} Contents={contents}");
                return ExitType.FirstExit;
            }
            else
            {
                return ExitType.AlternateExit;
            }
            
        }

        #endregion

        private void logit( EnumLogFlags flag, string message)
        {
            Loggerton.Instance.LogIt(flag, message);
        }
    } // class
}
