using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuddyPals;
using BuddyPals.Versioning;
using Newtonsoft.Json;

namespace BuddyPalVersionFileCreator
{
    public partial class MainForm : Form
    {
        public VersionFile LoadedVersionFile { get; private set; }
        public string SelectedSaveDirectory { get; private set; }
        public static string AppConfigDirectory { get; private set; }
        
        public static string MCVersion { get; private set; }

        private OptionsConfigFile Options;
        private ForgeDataForm ForgeForm;
        private Forge LoadedForge;

        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        private void InitializeMainForm()
        {
            Library.Initialize();
            InitializeForgeDropdown();

            foreach(ModPackage mod in Library.Mods)
            {
                cmbModList.Items.Add(mod.Name);
            }
            cmbModList.SelectedIndex = 0;
            ResetMainForm();

            AppConfigDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BuddyPals\\VFC";

            if (Directory.Exists(AppConfigDirectory) == true)
            {
                if(File.Exists(AppConfigDirectory + "\\settings.conf") == true)
                {
                    Options = JsonConvert.DeserializeObject<OptionsConfigFile>(File.ReadAllText(AppConfigDirectory + "\\settings.conf"));
                    SelectedSaveDirectory = Options.SavePathDirectory;
                }
                else if(File.Exists(AppConfigDirectory + "\\config.json") == true)
                {
                    Options = JsonConvert.DeserializeObject<OptionsConfigFile>(File.ReadAllText(AppConfigDirectory + "\\config.json"));
                    string optionsFile = JsonConvert.SerializeObject(Options, Formatting.Indented);
                    File.WriteAllText(AppConfigDirectory + "\\settings.conf", optionsFile);
                    File.Delete(AppConfigDirectory + "\\config.json");
                }
                else
                {
                    Options = new OptionsConfigFile();
                    string optionsFile = JsonConvert.SerializeObject(Options, Formatting.Indented);
                    File.WriteAllText(AppConfigDirectory + "\\settings.conf", optionsFile);
                }
            }
            else
            {
                Directory.CreateDirectory(AppConfigDirectory);
                Options = new OptionsConfigFile();
                string optionsFile = JsonConvert.SerializeObject(Options, Formatting.Indented);
                File.WriteAllText(AppConfigDirectory + "\\settings.conf", optionsFile);
            }

            LoadedForge = null;
        }
        private void InitializeForgeDropdown()
        {
            cboxRequiredForge.Items.Add(Library.FORGE_VERSION_1_12_2_2772);
            cboxRequiredForge.Items.Add(Library.FORGE_VERSION_1_12_2_2779);
            cboxRequiredForge.Items.Add(Library.FORGE_VERSION_1_12_2_2838);
            cboxRequiredForge.Items.Add(Library.FORGE_VERSION_1_12_2_2847);
        }

        private void newVersionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMainForm();
        }
        private void openVersionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenVersionFile();
        }
        private void saveVersionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentVersionFile();
        }

        private void ResetMainForm()
        {
            numID.Value = 0;
            txtIDString.Text = "x.x.x";
            txtVersionName.Text = "<Name> Expansion";
            txtFileName.Text = "BuddyPals_Modpack_X.Y.Z.zip";
            txtURL.Text = "ftp://mc.mlcgaming.com/modpack/BuddyPals_Modpack_X.Y.Z.zip";
            chkbxActive.Checked = false;
            chkbxMods.Checked = false;
            chkbxConfigs.Checked = false;
            chkbxResourcePacks.Checked = false;
            chkbxShaders.Checked = false;
            cboxRequiredForge.SelectedItem = Library.LatestForgeVersion;
        }
        private void SaveCurrentVersionFile()
        {
            // GET SAVE LOCATION
            var folderBrowserDialog = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.SelectedPath = SelectedSaveDirectory;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Dictionary<string, bool> toBeUpdated = new Dictionary<string, bool>();
                toBeUpdated.Add("mods", chkbxMods.Checked);
                toBeUpdated.Add("config", chkbxConfigs.Checked);
                toBeUpdated.Add("resourcePacks", chkbxResourcePacks.Checked);
                toBeUpdated.Add("shaderPacks", chkbxShaders.Checked);
                toBeUpdated.Add("scripts", chkbxScripts.Checked);

                string savePath = folderBrowserDialog.SelectedPath;
                ModpackVerFile newFile = new ModpackVerFile(Convert.ToInt32(numID.Value), chkbxActive.Checked, txtIDString.Text, txtVersionName.Text, txtFileName.Text, txtURL.Text, toBeUpdated, 2);
                
                string newFileJson = JsonConvert.SerializeObject(newFile, Formatting.Indented);
                File.WriteAllText(Path.Combine(savePath, "modpack.ver"), newFileJson);
                Options.SetLastSavePath(Path.Combine(savePath, "modpack.ver"));
                string optionString = JsonConvert.SerializeObject(Options, Formatting.Indented);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BuddyPals\\VFC\\settings.conf", optionString);
                MessageBox.Show("File Saved to " + Path.Combine(savePath, "modpack.ver") + "!");
            }
        }
        private void OpenVersionFile()
        {
            // GET SAVE LOCATION
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Options.LastSavePath;
            openFileDialog1.Filter = "Modpack Version files (*.ver)|*.ver";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                try
                {
                    VersionFile versionFile = JsonConvert.DeserializeObject<VersionFile>(File.ReadAllText(selectedFileName));
                    numID.Value = versionFile.ID;
                    txtIDString.Text = versionFile.Text;
                    txtVersionName.Text = versionFile.Name;
                    txtFileName.Text = versionFile.FileName;
                    txtURL.Text = versionFile.URL;
                    chkbxActive.Checked = versionFile.IsActive;
                    chkbxMods.Checked = versionFile.IncludesMods;
                    chkbxConfigs.Checked = versionFile.IncludesConfig;
                    chkbxResourcePacks.Checked = versionFile.IncludesResourcePack;
                    chkbxShaders.Checked = versionFile.IncludesShaders;
                    //chkbxForge.Checked = versionFile.IncludesForge;
                }
                catch
                {
                    MessageBox.Show("Selected File is not a Modpack Version File.");
                }
            }
        }

        public void EnterForgeDataEntry(string forgeVersionId, string installationName)
        {
            LoadedForge = new Forge(installationName, forgeVersionId);
        }
        public void CancelForgeDataEntry()
        {
            //chkbxForge.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtIDString_TextChanged(object sender, EventArgs e)
        {
            txtFileName.Text = "BuddyPals_Modpack_" + txtIDString.Text + ".zip";
        }
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            txtURL.Text = "ftp://mc.mlcgaming.com/modpack/" + txtFileName.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtURL.Text = "ftp://mc.mlcgaming.com/modpack/" + txtFileName.Text;
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            ResetMainForm();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenVersionFile();
        }
        private void btsSave_Click(object sender, EventArgs e)
        {
            SaveCurrentVersionFile();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ForgeDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ForgeForm.IsDataEntered == false)
            {
                //chkbxForge.Checked = false;
            }
        }

        private void cmbModList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbModFileHistory.Items.Count > 0)
            {
                for(int i = cmbModFileHistory.Items.Count - 1; i >= 0; i--)
                {
                    cmbModFileHistory.Items.RemoveAt(i);
                }
            }
            if(cmbModConfigFiles.Items.Count > 0)
            {
                for (int i = cmbModConfigFiles.Items.Count - 1; i >= 0; i--)
                {
                    cmbModConfigFiles.Items.RemoveAt(i);
                }
            }

            foreach(ModPackage mod in Library.Mods)
            {
                if(mod.Name == cmbModList.Text)
                {
                    tboxModFileName.Text = mod.Latest;
                    chkboxModEnabled.Checked = mod.Enabled;
                    chkboxModForced.Checked = mod.Forced;
                    if(mod.History.Count > 0)
                    {
                        // Enable History Dropdown
                        cmbModFileHistory.Enabled = true;

                        foreach(string file in mod.History)
                        {
                            // Fill History Dropdown
                            cmbModFileHistory.Items.Add(file);
                        }

                        cmbModFileHistory.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbModFileHistory.Enabled = false;
                    }

                    switch (mod.Config.Type)
                    {
                        case ConfigPackage.ConfigType.File:
                            {
                                radioModConfigTypeFile.Checked = true;
                                radioModConfigTypeFolder.Checked = false;
                                radioModConfigTypeNull.Checked = false;
                                break;
                            }
                        case ConfigPackage.ConfigType.Directory:
                            {
                                radioModConfigTypeFile.Checked = false;
                                radioModConfigTypeFolder.Checked = true;
                                radioModConfigTypeNull.Checked = false;
                                break;
                            }
                        case ConfigPackage.ConfigType.Null:
                            {
                                radioModConfigTypeFile.Checked = false;
                                radioModConfigTypeFolder.Checked = false;
                                radioModConfigTypeNull.Checked = true;
                                break;
                            }
                    }

                    foreach(string file in mod.Config.PathName)
                    {
                        cmbModConfigFiles.Items.Add(file);
                    }

                    cmbModConfigFiles.SelectedIndex = 0;
                }
            }
        }

        private void radioModConfigTypeFile_CheckedChanged(object sender, EventArgs e)
        {
            if(radioModConfigTypeFile.Checked == true)
            {
                radioModConfigTypeFolder.Checked = false;
                radioModConfigTypeNull.Checked = false;
            }
        }
        private void radioModConfigTypeFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModConfigTypeFolder.Checked == true)
            {
                radioModConfigTypeFile.Checked = false;
                radioModConfigTypeNull.Checked = false;
            }
        }

        private void radioModConfigTypeNull_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModConfigTypeNull.Checked == true)
            {
                radioModConfigTypeFolder.Checked = false;
                radioModConfigTypeFile.Checked = false;
            }
        }
    }
}
