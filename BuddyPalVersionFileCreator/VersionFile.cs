﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace BuddyPalVersionFileCreator
{
    public class VersionFile
    {
        public int ID { get; private set; }
        public bool IsActive { get; private set; }
        public string Text { get; private set; }
        public string Name { get; private set; }
        public string FileName { get; private set; }
        public string URL { get; private set; }
        public bool IncludesMods, IncludesConfig, IncludesResourcePack, IncludesShaders, IncludesForge;
        public Forge Forge { get; private set; }

        public VersionFile(int id, string text, string name)
        {
            ID = id;
            IsActive = true;
            Text = text;
            Name = name;
            FileName = "";
            URL = "";
            IncludesConfig = true;
            IncludesMods = true;
            IncludesResourcePack = false;
            IncludesShaders = false;
            IncludesForge = false;
            Forge = null;
        }

        [JsonConstructor]
        public VersionFile(int id, bool isActive, string text, string name, string fileName, string url, bool includeMods, bool includeConfig, bool includeResourcePack = false, bool includesShaders = false, bool includesForge = false, Forge forge = null)
        {
            ID = id;
            IsActive = isActive;
            Text = text;
            Name = name;
            FileName = fileName;
            URL = url;
            IncludesConfig = includeConfig;
            IncludesMods = includeMods;
            IncludesResourcePack = includeResourcePack;
            IncludesShaders = includesShaders;
            IncludesForge = includesForge;
            Forge = forge;
        }
        public void SetWebGetURL(string url)
        {
            URL = url;
        }
        public void SetFileName(string name)
        {
            FileName = name;
        }
        public void AddForgeItem(Forge forge)
        {
            Forge = forge.Clone();
        }
    }
}
