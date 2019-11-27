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

        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        private void InitializeMainForm()
        {
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
                string savePath = folderBrowserDialog.SelectedPath;
                VersionFile newFile = new VersionFile(Convert.ToInt32(numID.Value), chkbxActive.Checked, txtIDString.Text, txtVersionName.Text, txtFileName.Text, txtURL.Text, chkbxMods.Checked, chkbxConfigs.Checked, chkbxResourcePacks.Checked, chkbxShaders.Checked);
                string newFileJson = JsonConvert.SerializeObject(newFile, Formatting.Indented);
                File.WriteAllText(Path.Combine(savePath, "modpack.ver"), newFileJson);
                Options.SetLastSavePath(Path.Combine(savePath, "modpack.ver"));
                string optionString = JsonConvert.SerializeObject(Options, Formatting.Indented);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BuddyPals\\VFC\\settings.conf", optionString);
                MessageBox.Show("File Saved to " + Path.Combine(savePath, "modpack.ver") + "!");
            }
        }

        private void newVersionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMainForm();
        }
        private void openVersionFileToolStripMenuItem_Click(object sender, EventArgs e)
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
                    txtFileName.Text = "modpack.ver";
                    txtURL.Text = versionFile.URL;
                    chkbxActive.Checked = versionFile.IsActive;
                    chkbxMods.Checked = versionFile.IncludesMods;
                    chkbxConfigs.Checked = versionFile.IncludesConfig;
                    chkbxResourcePacks.Checked = versionFile.IncludesResourcePack;
                    chkbxShaders.Checked = versionFile.IncludesShaders;
                }
                catch
                {
                    MessageBox.Show("Selected File is not a Modpack Version File.");
                }
            }
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
            if(chkbxPTRPackage.Checked == false)
            {
                txtURL.Text = "ftp://mc.mlcgaming.com/modpack/" + txtFileName.Text;
            }
            else
            {
                txtURL.Text = "ftp://mc.mlcgaming.com/modpack/PTR/" + txtFileName.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxPTRPackage.Checked == true)
            {
                txtFileName.Text = txtFileName.Text = "BuddyPals_Modpack_" + txtIDString.Text + "_PTR.zip";
                chkbxActive.Enabled = false;
                chkbxMods.Enabled = false;
                chkbxConfigs.Enabled = false;
                chkbxResourcePacks.Enabled = false;
                chkbxShaders.Enabled = false;

                chkbxActive.Checked = true;
                chkbxMods.Checked = true;
                chkbxConfigs.Checked = true;
                chkbxResourcePacks.Checked = true;
                chkbxShaders.Checked = true;
            }
            else
            {
                txtFileName.Text = "BuddyPals_Modpack_" + txtIDString.Text + ".zip";
                chkbxActive.Enabled = true;
                chkbxMods.Enabled = true;
                chkbxConfigs.Enabled = true;
                chkbxResourcePacks.Enabled = true;
                chkbxShaders.Enabled = true;
            }
        }
    }
}
