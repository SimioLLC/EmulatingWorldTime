22-Jan-2019 Dan Houck
The DLL should go the users > {your-name} > Documents > SimioUserExtensions folder, where Simio can find it as it starts.
The Device Emulator can be anywhere, but note that its configuration file indicates the folder used for the Request-Reponse messages.
  The default folder is c:\(test)\  but feel free to change and make sure that its value matches the DeviceStep FolderPath property.
  

