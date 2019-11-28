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
            this.chkbxForge = new System.Windows.Forms.CheckBox();
            this.chkbxPTRPackage = new System.Windows.Forms.CheckBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btsSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.groupOptions.SuspendLayout();
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
            this.txtURL.Size = new System.Drawing.Size(188, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "ftp://mc.mlcgaming.com/modpacks/BuddyPals_Modpack_X.Y.Z.zip";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 74);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(188, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "BuddyPals_Modpack_X.Y.Z.zip";
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // txtVersionName
            // 
            this.txtVersionName.Location = new System.Drawing.Point(106, 52);
            this.txtVersionName.Name = "txtVersionName";
            this.txtVersionName.Size = new System.Drawing.Size(188, 20);
            this.txtVersionName.TabIndex = 2;
            this.txtVersionName.Text = "<Name> Expansion";
            // 
            // txtIDString
            // 
            this.txtIDString.Location = new System.Drawing.Point(106, 30);
            this.txtIDString.Name = "txtIDString";
            this.txtIDString.Size = new System.Drawing.Size(188, 20);
            this.txtIDString.TabIndex = 1;
            this.txtIDString.Text = "X.Y.Z";
            this.txtIDString.TextChanged += new System.EventHandler(this.txtIDString_TextChanged);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.chkbxForge);
            this.groupOptions.Controls.Add(this.chkbxPTRPackage);
            this.groupOptions.Controls.Add(this.chkbxActive);
            this.groupOptions.Controls.Add(this.chkbxMods);
            this.groupOptions.Controls.Add(this.chkbxConfigs);
            this.groupOptions.Controls.Add(this.chkbxResourcePacks);
            this.groupOptions.Controls.Add(this.chkbxShaders);
            this.groupOptions.Location = new System.Drawing.Point(15, 122);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(157, 178);
            this.groupOptions.TabIndex = 18;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // chkbxForge
            // 
            this.chkbxForge.AutoSize = true;
            this.chkbxForge.Location = new System.Drawing.Point(6, 134);
            this.chkbxForge.Name = "chkbxForge";
            this.chkbxForge.Size = new System.Drawing.Size(120, 17);
            this.chkbxForge.TabIndex = 11;
            this.chkbxForge.Text = "Includes Forge Files";
            this.chkbxForge.UseVisualStyleBackColor = true;
            this.chkbxForge.CheckedChanged += new System.EventHandler(this.chkbxForge_CheckedChanged);
            // 
            // chkbxPTRPackage
            // 
            this.chkbxPTRPackage.AutoSize = true;
            this.chkbxPTRPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxPTRPackage.Location = new System.Drawing.Point(6, 157);
            this.chkbxPTRPackage.Name = "chkbxPTRPackage";
            this.chkbxPTRPackage.Size = new System.Drawing.Size(105, 17);
            this.chkbxPTRPackage.TabIndex = 10;
            this.chkbxPTRPackage.Text = "PTR Package";
            this.chkbxPTRPackage.UseVisualStyleBackColor = true;
            this.chkbxPTRPackage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(198, 158);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 19;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(198, 187);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btsSave
            // 
            this.btsSave.Location = new System.Drawing.Point(198, 216);
            this.btsSave.Name = "btsSave";
            this.btsSave.Size = new System.Drawing.Size(75, 23);
            this.btsSave.TabIndex = 21;
            this.btsSave.Text = "Save File";
            this.btsSave.UseVisualStyleBackColor = true;
            this.btsSave.Click += new System.EventHandler(this.btsSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 311);
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
        private System.Windows.Forms.CheckBox chkbxPTRPackage;
        private System.Windows.Forms.CheckBox chkbxForge;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btsSave;
        private System.Windows.Forms.Button btnExit;
    }
}

