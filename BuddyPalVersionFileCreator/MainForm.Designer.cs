namespace BuddyPalVersionFileCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDText = new System.Windows.Forms.Label();
            this.lblVersionName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.chkbxActive = new System.Windows.Forms.CheckBox();
            this.chkbxMods = new System.Windows.Forms.CheckBox();
            this.chkbxConfigs = new System.Windows.Forms.CheckBox();
            this.chkbxResourcePacks = new System.Windows.Forms.CheckBox();
            this.chkbxShaders = new System.Windows.Forms.CheckBox();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtVersionName = new System.Windows.Forms.TextBox();
            this.txtIDString = new System.Windows.Forms.TextBox();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.chkbxScripts = new System.Windows.Forms.CheckBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btsSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMods = new System.Windows.Forms.GroupBox();
            this.lblModList = new System.Windows.Forms.Label();
            this.lblModOldFiles = new System.Windows.Forms.Label();
            this.cmbModFileHistory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbModConfigFiles = new System.Windows.Forms.ComboBox();
            this.lblModConfigType = new System.Windows.Forms.Label();
            this.lblModConfigName = new System.Windows.Forms.Label();
            this.radioModConfigTypeFile = new System.Windows.Forms.RadioButton();
            this.radioModConfigTypeNull = new System.Windows.Forms.RadioButton();
            this.radioModConfigTypeFolder = new System.Windows.Forms.RadioButton();
            this.chkboxModForced = new System.Windows.Forms.CheckBox();
            this.chkboxModEnabled = new System.Windows.Forms.CheckBox();
            this.lblModName = new System.Windows.Forms.Label();
            this.tboxModFileName = new System.Windows.Forms.TextBox();
            this.cmbModList = new System.Windows.Forms.ComboBox();
            this.lblRequiredForge = new System.Windows.Forms.Label();
            this.cboxRequiredForge = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.groupOptions.SuspendLayout();
            this.grpMods.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDText.Location = new System.Drawing.Point(12, 33);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(59, 13);
            this.lblIDText.TabIndex = 2;
            this.lblIDText.Text = "ID String:";
            // 
            // lblVersionName
            // 
            this.lblVersionName.AutoSize = true;
            this.lblVersionName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionName.Location = new System.Drawing.Point(12, 55);
            this.lblVersionName.Name = "lblVersionName";
            this.lblVersionName.Size = new System.Drawing.Size(84, 13);
            this.lblVersionName.TabIndex = 4;
            this.lblVersionName.Text = "Version Name:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 77);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(64, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File Name:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(12, 99);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(89, 13);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "Download Root:";
            // 
            // chkbxActive
            // 
            this.chkbxActive.AutoSize = true;
            this.chkbxActive.Location = new System.Drawing.Point(6, 19);
            this.chkbxActive.Name = "chkbxActive";
            this.chkbxActive.Size = new System.Drawing.Size(138, 17);
            this.chkbxActive.TabIndex = 5;
            this.chkbxActive.Text = "Available to Download?";
            this.chkbxActive.UseVisualStyleBackColor = true;
            // 
            // chkbxMods
            // 
            this.chkbxMods.AutoSize = true;
            this.chkbxMods.Location = new System.Drawing.Point(6, 42);
            this.chkbxMods.Name = "chkbxMods";
            this.chkbxMods.Size = new System.Drawing.Size(90, 17);
            this.chkbxMods.TabIndex = 6;
            this.chkbxMods.Text = "Update Mods";
            this.chkbxMods.UseVisualStyleBackColor = true;
            // 
            // chkbxConfigs
            // 
            this.chkbxConfigs.AutoSize = true;
            this.chkbxConfigs.Location = new System.Drawing.Point(6, 65);
            this.chkbxConfigs.Name = "chkbxConfigs";
            this.chkbxConfigs.Size = new System.Drawing.Size(99, 17);
            this.chkbxConfigs.TabIndex = 7;
            this.chkbxConfigs.Text = "Update Configs";
            this.chkbxConfigs.UseVisualStyleBackColor = true;
            // 
            // chkbxResourcePacks
            // 
            this.chkbxResourcePacks.AutoSize = true;
            this.chkbxResourcePacks.Enabled = false;
            this.chkbxResourcePacks.Location = new System.Drawing.Point(6, 88);
            this.chkbxResourcePacks.Name = "chkbxResourcePacks";
            this.chkbxResourcePacks.Size = new System.Drawing.Size(143, 17);
            this.chkbxResourcePacks.TabIndex = 8;
            this.chkbxResourcePacks.Text = "Include Resource Packs";
            this.chkbxResourcePacks.UseVisualStyleBackColor = true;
            // 
            // chkbxShaders
            // 
            this.chkbxShaders.AutoSize = true;
            this.chkbxShaders.Enabled = false;
            this.chkbxShaders.Location = new System.Drawing.Point(6, 111);
            this.chkbxShaders.Name = "chkbxShaders";
            this.chkbxShaders.Size = new System.Drawing.Size(103, 17);
            this.chkbxShaders.TabIndex = 9;
            this.chkbxShaders.Text = "Include Shaders";
            this.chkbxShaders.UseVisualStyleBackColor = true;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(106, 8);
            this.numID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(63, 20);
            this.numID.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(106, 96);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(313, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "ftp://mc.mlcgaming.com/modpacks/BuddyPals_Modpack_X.Y.Z.zip";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 74);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(313, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "BuddyPals_Modpack_X.Y.Z.zip";
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // txtVersionName
            // 
            this.txtVersionName.Location = new System.Drawing.Point(106, 52);
            this.txtVersionName.Name = "txtVersionName";
            this.txtVersionName.Size = new System.Drawing.Size(313, 20);
            this.txtVersionName.TabIndex = 2;
            this.txtVersionName.Text = "<Name> Expansion";
            // 
            // txtIDString
            // 
            this.txtIDString.Location = new System.Drawing.Point(106, 30);
            this.txtIDString.Name = "txtIDString";
            this.txtIDString.Size = new System.Drawing.Size(313, 20);
            this.txtIDString.TabIndex = 1;
            this.txtIDString.Text = "X.Y.Z";
            this.txtIDString.TextChanged += new System.EventHandler(this.txtIDString_TextChanged);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.chkbxScripts);
            this.groupOptions.Controls.Add(this.chkbxActive);
            this.groupOptions.Controls.Add(this.chkbxMods);
            this.groupOptions.Controls.Add(this.chkbxConfigs);
            this.groupOptions.Controls.Add(this.chkbxResourcePacks);
            this.groupOptions.Controls.Add(this.chkbxShaders);
            this.groupOptions.Location = new System.Drawing.Point(12, 154);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(157, 157);
            this.groupOptions.TabIndex = 18;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // chkbxScripts
            // 
            this.chkbxScripts.AutoSize = true;
            this.chkbxScripts.Location = new System.Drawing.Point(6, 133);
            this.chkbxScripts.Name = "chkbxScripts";
            this.chkbxScripts.Size = new System.Drawing.Size(101, 17);
            this.chkbxScripts.TabIndex = 12;
            this.chkbxScripts.Text = "Includes Scripts";
            this.chkbxScripts.UseVisualStyleBackColor = true;
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(12, 317);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 19;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(94, 317);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btsSave
            // 
            this.btsSave.Location = new System.Drawing.Point(12, 341);
            this.btsSave.Name = "btsSave";
            this.btsSave.Size = new System.Drawing.Size(75, 23);
            this.btsSave.TabIndex = 21;
            this.btsSave.Text = "Save File";
            this.btsSave.UseVisualStyleBackColor = true;
            this.btsSave.Click += new System.EventHandler(this.btsSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(94, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMods
            // 
            this.grpMods.Controls.Add(this.lblModList);
            this.grpMods.Controls.Add(this.lblModOldFiles);
            this.grpMods.Controls.Add(this.cmbModFileHistory);
            this.grpMods.Controls.Add(this.groupBox1);
            this.grpMods.Controls.Add(this.chkboxModForced);
            this.grpMods.Controls.Add(this.chkboxModEnabled);
            this.grpMods.Controls.Add(this.lblModName);
            this.grpMods.Controls.Add(this.tboxModFileName);
            this.grpMods.Controls.Add(this.cmbModList);
            this.grpMods.Location = new System.Drawing.Point(175, 154);
            this.grpMods.Name = "grpMods";
            this.grpMods.Size = new System.Drawing.Size(244, 210);
            this.grpMods.TabIndex = 23;
            this.grpMods.TabStop = false;
            this.grpMods.Text = "Mods";
            // 
            // lblModList
            // 
            this.lblModList.AutoSize = true;
            this.lblModList.Location = new System.Drawing.Point(6, 22);
            this.lblModList.Name = "lblModList";
            this.lblModList.Size = new System.Drawing.Size(31, 13);
            this.lblModList.TabIndex = 14;
            this.lblModList.Text = "Mod:";
            // 
            // lblModOldFiles
            // 
            this.lblModOldFiles.AutoSize = true;
            this.lblModOldFiles.Location = new System.Drawing.Point(5, 68);
            this.lblModOldFiles.Name = "lblModOldFiles";
            this.lblModOldFiles.Size = new System.Drawing.Size(50, 13);
            this.lblModOldFiles.TabIndex = 13;
            this.lblModOldFiles.Text = "Old Files:";
            // 
            // cmbModFileHistory
            // 
            this.cmbModFileHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModFileHistory.FormattingEnabled = true;
            this.cmbModFileHistory.Location = new System.Drawing.Point(61, 65);
            this.cmbModFileHistory.Name = "cmbModFileHistory";
            this.cmbModFileHistory.Size = new System.Drawing.Size(177, 21);
            this.cmbModFileHistory.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbModConfigFiles);
            this.groupBox1.Controls.Add(this.lblModConfigType);
            this.groupBox1.Controls.Add(this.lblModConfigName);
            this.groupBox1.Controls.Add(this.radioModConfigTypeFile);
            this.groupBox1.Controls.Add(this.radioModConfigTypeNull);
            this.groupBox1.Controls.Add(this.radioModConfigTypeFolder);
            this.groupBox1.Location = new System.Drawing.Point(6, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config Data";
            // 
            // cmbModConfigFiles
            // 
            this.cmbModConfigFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModConfigFiles.FormattingEnabled = true;
            this.cmbModConfigFiles.Location = new System.Drawing.Point(75, 50);
            this.cmbModConfigFiles.Name = "cmbModConfigFiles";
            this.cmbModConfigFiles.Size = new System.Drawing.Size(151, 21);
            this.cmbModConfigFiles.TabIndex = 15;
            // 
            // lblModConfigType
            // 
            this.lblModConfigType.AutoSize = true;
            this.lblModConfigType.Location = new System.Drawing.Point(63, 16);
            this.lblModConfigType.Name = "lblModConfigType";
            this.lblModConfigType.Size = new System.Drawing.Size(91, 13);
            this.lblModConfigType.TabIndex = 8;
            this.lblModConfigType.Text = "Mod Config Type:";
            // 
            // lblModConfigName
            // 
            this.lblModConfigName.AutoSize = true;
            this.lblModConfigName.Location = new System.Drawing.Point(12, 53);
            this.lblModConfigName.Name = "lblModConfigName";
            this.lblModConfigName.Size = new System.Drawing.Size(57, 13);
            this.lblModConfigName.TabIndex = 4;
            this.lblModConfigName.Text = "Cfg Name:";
            // 
            // radioModConfigTypeFile
            // 
            this.radioModConfigTypeFile.AutoSize = true;
            this.radioModConfigTypeFile.Location = new System.Drawing.Point(39, 32);
            this.radioModConfigTypeFile.Name = "radioModConfigTypeFile";
            this.radioModConfigTypeFile.Size = new System.Drawing.Size(41, 17);
            this.radioModConfigTypeFile.TabIndex = 5;
            this.radioModConfigTypeFile.TabStop = true;
            this.radioModConfigTypeFile.Text = "File";
            this.radioModConfigTypeFile.UseVisualStyleBackColor = true;
            this.radioModConfigTypeFile.CheckedChanged += new System.EventHandler(this.radioModConfigTypeFile_CheckedChanged);
            // 
            // radioModConfigTypeNull
            // 
            this.radioModConfigTypeNull.AutoSize = true;
            this.radioModConfigTypeNull.Location = new System.Drawing.Point(131, 32);
            this.radioModConfigTypeNull.Name = "radioModConfigTypeNull";
            this.radioModConfigTypeNull.Size = new System.Drawing.Size(51, 17);
            this.radioModConfigTypeNull.TabIndex = 7;
            this.radioModConfigTypeNull.TabStop = true;
            this.radioModConfigTypeNull.Text = "None";
            this.radioModConfigTypeNull.UseVisualStyleBackColor = true;
            this.radioModConfigTypeNull.CheckedChanged += new System.EventHandler(this.radioModConfigTypeNull_CheckedChanged);
            // 
            // radioModConfigTypeFolder
            // 
            this.radioModConfigTypeFolder.AutoSize = true;
            this.radioModConfigTypeFolder.Location = new System.Drawing.Point(80, 32);
            this.radioModConfigTypeFolder.Name = "radioModConfigTypeFolder";
            this.radioModConfigTypeFolder.Size = new System.Drawing.Size(54, 17);
            this.radioModConfigTypeFolder.TabIndex = 6;
            this.radioModConfigTypeFolder.TabStop = true;
            this.radioModConfigTypeFolder.Text = "Folder";
            this.radioModConfigTypeFolder.UseVisualStyleBackColor = true;
            this.radioModConfigTypeFolder.CheckedChanged += new System.EventHandler(this.radioModConfigTypeFolder_CheckedChanged);
            // 
            // chkboxModForced
            // 
            this.chkboxModForced.AutoSize = true;
            this.chkboxModForced.Location = new System.Drawing.Point(122, 91);
            this.chkboxModForced.Name = "chkboxModForced";
            this.chkboxModForced.Size = new System.Drawing.Size(97, 17);
            this.chkboxModForced.TabIndex = 10;
            this.chkboxModForced.Text = "Update Forced";
            this.chkboxModForced.UseVisualStyleBackColor = true;
            // 
            // chkboxModEnabled
            // 
            this.chkboxModEnabled.AutoSize = true;
            this.chkboxModEnabled.Location = new System.Drawing.Point(27, 91);
            this.chkboxModEnabled.Name = "chkboxModEnabled";
            this.chkboxModEnabled.Size = new System.Drawing.Size(89, 17);
            this.chkboxModEnabled.TabIndex = 9;
            this.chkboxModEnabled.Text = "Mod Enabled";
            this.chkboxModEnabled.UseVisualStyleBackColor = true;
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(3, 46);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(52, 13);
            this.lblModName.TabIndex = 2;
            this.lblModName.Text = "Filename:";
            // 
            // tboxModFileName
            // 
            this.tboxModFileName.Location = new System.Drawing.Point(61, 42);
            this.tboxModFileName.Name = "tboxModFileName";
            this.tboxModFileName.Size = new System.Drawing.Size(177, 20);
            this.tboxModFileName.TabIndex = 1;
            // 
            // cmbModList
            // 
            this.cmbModList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModList.FormattingEnabled = true;
            this.cmbModList.Location = new System.Drawing.Point(45, 19);
            this.cmbModList.Name = "cmbModList";
            this.cmbModList.Size = new System.Drawing.Size(193, 21);
            this.cmbModList.TabIndex = 0;
            this.cmbModList.SelectedIndexChanged += new System.EventHandler(this.cmbModList_SelectedIndexChanged);
            // 
            // lblRequiredForge
            // 
            this.lblRequiredForge.AutoSize = true;
            this.lblRequiredForge.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredForge.Location = new System.Drawing.Point(12, 122);
            this.lblRequiredForge.Name = "lblRequiredForge";
            this.lblRequiredForge.Size = new System.Drawing.Size(91, 13);
            this.lblRequiredForge.TabIndex = 24;
            this.lblRequiredForge.Text = "Required Forge:";
            // 
            // cboxRequiredForge
            // 
            this.cboxRequiredForge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRequiredForge.FormattingEnabled = true;
            this.cboxRequiredForge.Location = new System.Drawing.Point(106, 119);
            this.cboxRequiredForge.Name = "cboxRequiredForge";
            this.cboxRequiredForge.Size = new System.Drawing.Size(313, 21);
            this.cboxRequiredForge.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 376);
            this.Controls.Add(this.cboxRequiredForge);
            this.Controls.Add(this.lblRequiredForge);
            this.Controls.Add(this.grpMods);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btsSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.txtIDString);
            this.Controls.Add(this.txtVersionName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblVersionName);
            this.Controls.Add(this.lblIDText);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "BuddyPal VersionFile Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.grpMods.ResumeLayout(false);
            this.grpMods.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.Label lblVersionName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.CheckBox chkbxActive;
        private System.Windows.Forms.CheckBox chkbxMods;
        private System.Windows.Forms.CheckBox chkbxConfigs;
        private System.Windows.Forms.CheckBox chkbxResourcePacks;
        private System.Windows.Forms.CheckBox chkbxShaders;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtVersionName;
        private System.Windows.Forms.TextBox txtIDString;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btsSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkbxScripts;
        private System.Windows.Forms.GroupBox grpMods;
        private System.Windows.Forms.ComboBox cmbModList;
        private System.Windows.Forms.Label lblRequiredForge;
        private System.Windows.Forms.ComboBox cboxRequiredForge;
        private System.Windows.Forms.Label lblModList;
        private System.Windows.Forms.Label lblModOldFiles;
        private System.Windows.Forms.ComboBox cmbModFileHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblModConfigType;
        private System.Windows.Forms.Label lblModConfigName;
        private System.Windows.Forms.RadioButton radioModConfigTypeFile;
        private System.Windows.Forms.RadioButton radioModConfigTypeNull;
        private System.Windows.Forms.RadioButton radioModConfigTypeFolder;
        private System.Windows.Forms.CheckBox chkboxModForced;
        private System.Windows.Forms.CheckBox chkboxModEnabled;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.TextBox tboxModFileName;
        private System.Windows.Forms.ComboBox cmbModConfigFiles;
    }
}

