using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyPalVersionFileCreator.DirectoryFiles
{
    public class ModpackManifest
    {
        public List<Mod> Manifest { get; private set; }

        public ModpackManifest()
        {
            Manifest = new List<Mod>();
        }

        [JsonConstructor]
        public ModpackManifest(List<Mod> manifest)
        {
            Manifest = new List<Mod>(manifest);
        }
    }
}
