using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BuddyPalVersionFileCreator
{
    public class ModpackVerFile
    {
        public int ID { get; private set; }
        public int FormatID { get; protected set; }
        public bool IsActive { get; private set; }
        public string Text { get; private set; }
        public string Name { get; private set; }
        public string FileName { get; private set; }
        public string URL { get; private set; }
        public Dictionary<string, bool> ToBeUpdated { get; private set; }
        public Dictionary<string, string> ModpackFolders { get; private set; }
        
        public Forge Forge { get; private set; }

        public ModpackVerFile(int id, string text, string name)
        {
            ID = id;
            FormatID = 2;
            IsActive = true;
            Text = text;
            Name = name;
            FileName = "";
            URL = "";
            ToBeUpdated = new Dictionary<string, bool>();
            ToBeUpdated.Add("mods", true);
            ToBeUpdated.Add("config", true);
            ToBeUpdated.Add("resourcePacks", false);
            ToBeUpdated.Add("shaderPacks", false);
            ToBeUpdated.Add("scripts", false);
            ToBeUpdated.Add("forgeFiles", false);

            SetModpackFolders();
        }

        [JsonConstructor]
        public ModpackVerFile(int id, bool isActive, string text, string name, string fileName, string url, Dictionary<string, bool> toBeupdated = null, int format = 1, Forge forge = null)
        {
            ID = id;
            IsActive = isActive;
            Text = text;
            Name = name;
            FileName = fileName;
            URL = url;
            Forge = forge;

            if (toBeupdated != null)
            {
                // Using newer version of VersionFile
                ToBeUpdated = new Dictionary<string, bool>(toBeupdated);
                FormatID = 2;
            }
            else
            {
                FormatID = 1;
                ToBeUpdated = new Dictionary<string, bool>();
                ToBeUpdated.Add("mods", true);
                ToBeUpdated.Add("config", true);
                ToBeUpdated.Add("resourcePacks", false);
                ToBeUpdated.Add("shaderPacks", false);
                ToBeUpdated.Add("scripts", false);
                ToBeUpdated.Add("forgeFiles", false);
            }

            SetModpackFolders();
        }
        public static ModpackVerFile ConvertFromVersionFile(VersionFile obj)
        {
            Dictionary<string, bool> includedFiles = new Dictionary<string, bool>();
            includedFiles.Add("mods", obj.IncludesMods);
            includedFiles.Add("config", obj.IncludesConfig);
            includedFiles.Add("resourcePacks", obj.IncludesResourcePack);
            includedFiles.Add("shaderPacks", obj.IncludesShaders);
            includedFiles.Add("scripts", false);
            includedFiles.Add("forgeFiles", obj.IncludesForge);

            return new ModpackVerFile(obj.ID, obj.IsActive, obj.Text, obj.Name, obj.FileName, obj.URL, includedFiles, 2, obj.Forge);
        }
        public void AddForgeItem(Forge forge)
        {
            Forge = forge.Clone();
        }
        private void SetModpackFolders()
        {
            ModpackFolders = new Dictionary<string, string>();

            if(ToBeUpdated["mods"] == true)
            {
                ModpackFolders.Add("mods", "mods\\");
            }

            if(ToBeUpdated["config"] == true)
            {
                ModpackFolders.Add("config", "config\\");
            }

            if(ToBeUpdated["resourcePacks"] == true)
            {
                ModpackFolders.Add("resourcePacks", "resourcepacks\\");
            }

            if(ToBeUpdated["shaderPacks"] == true)
            {
                ModpackFolders.Add("shaderPacks", "shaderpacks\\");
            }

            if(ToBeUpdated["scripts"] == true)
            {
                ModpackFolders.Add("scripts", "scripts");
            }

            if(ToBeUpdated["forgeFiles"] == true)
            {
                ModpackFolders.Add("forgeJarRoot", "forge\\libraries");
                ModpackFolders.Add("forgeJsonRoot", "forge\\versions");
            }
        }
    }
}
