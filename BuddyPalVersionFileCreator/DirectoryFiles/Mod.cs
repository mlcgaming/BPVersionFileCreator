using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyPalVersionFileCreator.DirectoryFiles
{
    public class Mod
    {
        public string Name { get; private set; }
        public string Latest { get; private set; }
        public List<string> History { get; private set; }

        public Mod(string name)
        {
            Name = name;
            Latest = "";
            History = new List<string>();
        }
        [JsonConstructor]
        public Mod(string name, string latest, List<string> history)
        {
            Name = name;
            Latest = latest;
            History = new List<string>(history);
        }

        public void AddToHistory(string fileName)
        {
            if(History.Count != 0)
            {
                foreach(string file in History)
                {
                    if(file == fileName)
                    {
                        return;
                    }
                }

                History.Add(fileName);
            }
            else
            {
                History.Add(fileName);
            }
        }
        public void UpdateLatest(string file)
        {
            if(Latest == "")
            {
                Latest = file;
            }
            else
            {
                AddToHistory(Latest);
                Latest = file;
            }
        }
    }
}
