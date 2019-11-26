using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BuddyPalVersionFileCreator
{
    public class OptionsConfigFile
    {
        public string LastSavePath { get; protected set; }
        public string SavePathDirectory { get; protected set; }
        public List<string> RecentFiles { get; protected set; }

        public OptionsConfigFile()
        {
            LastSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SavePathDirectory = LastSavePath;
            RecentFiles = new List<string>();
        }

        [JsonConstructor]
        public OptionsConfigFile(string lastSavePath, string savePathDirectory, List<string> recentFiles)
        {
            LastSavePath = lastSavePath;
            SavePathDirectory = savePathDirectory;
            RecentFiles = recentFiles;
        }

        public void SetLastSavePath(string savePath)
        {
            LastSavePath = savePath;
        }
    }
}
