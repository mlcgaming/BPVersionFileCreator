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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVersionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVersionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVersionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chkbxPTRPackage = new System.Windows.Forms.CheckBox();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.groupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(301, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVersionFileToolStripMenuItem,
            this.openVersionFileToolStripMenuItem,
            this.saveVersionFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newVersionFileToolStripMenuItem
            // 
            this.newVersionFileToolStripMenuItem.Name = "newVersionFileToolStripMenuItem";
            this.newVersionFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newVersionFileToolStripMenuItem.Text = "New VersionFile";
            this.newVersionFileToolStripMenuItem.Click += new System.EventHandler(this.newVersionFileToolStripMenuItem_Click);
            // 
            // openVersionFileToolStripMenuItem
            // 
            this.openVersionFileToolStripMenuItem.Name = "openVersionFileToolStripMenuItem";
            this.openVersionFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openVersionFileToolStripMenuItem.Text = "Open VersionFile";
            this.openVersionFileToolStripMenuItem.Click += new System.EventHandler(this.openVersionFileToolStripMenuItem_Click);
            // 
            // saveVersionFileToolStripMenuItem
            // 
            this.saveVersionFileToolStripMenuItem.Name = "saveVersionFileToolStripMenuItem";
            this.saveVersionFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveVersionFileToolStripMenuItem.Text = "Save VersionFile";
            this.saveVersionFileToolStripMenuItem.Click += new System.EventHandler(this.saveVersionFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDText.Location = new System.Drawing.Point(12, 58);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(59, 13);
            this.lblIDText.TabIndex = 2;
            this.lblIDText.Text = "ID String:";
            // 
            // lblVersionName
            // 
            this.lblVersionName.AutoSize = true;
            this.lblVersionName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionName.Location = new System.Drawing.Point(12, 80);
            this.lblVersionName.Name = "lblVersionName";
            this.lblVersionName.Size = new System.Drawing.Size(84, 13);
            this.lblVersionName.TabIndex = 4;
            this.lblVersionName.Text = "Version Name:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 102);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(64, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File Name:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(12, 124);
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
            this.numID.Location = new System.Drawing.Point(106, 33);
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
            this.txtURL.Location = new System.Drawing.Point(106, 121);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(188, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "ftp://mc.mlcgaming.com/modpacks/BuddyPals_Modpack_X.Y.Z.zip";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 99);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(188, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "BuddyPals_Modpack_X.Y.Z.zip";
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // txtVersionName
            // 
            this.txtVersionName.Location = new System.Drawing.Point(106, 77);
            this.txtVersionName.Name = "txtVersionName";
            this.txtVersionName.Size = new System.Drawing.Size(188, 20);
            this.txtVersionName.TabIndex = 2;
            this.txtVersionName.Text = "<Name> Expansion";
            // 
            // txtIDString
            // 
            this.txtIDString.Location = new System.Drawing.Point(106, 55);
            this.txtIDString.Name = "txtIDString";
            this.txtIDString.Size = new System.Drawing.Size(188, 20);
            this.txtIDString.TabIndex = 1;
            this.txtIDString.Text = "X.Y.Z";
            this.txtIDString.TextChanged += new System.EventHandler(this.txtIDString_TextChanged);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.chkbxPTRPackage);
            this.groupOptions.Controls.Add(this.chkbxActive);
            this.groupOptions.Controls.Add(this.chkbxMods);
            this.groupOptions.Controls.Add(this.chkbxConfigs);
            this.groupOptions.Controls.Add(this.chkbxResourcePacks);
            this.groupOptions.Controls.Add(this.chkbxShaders);
            this.groupOptions.Location = new System.Drawing.Point(66, 147);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(157, 155);
            this.groupOptions.TabIndex = 18;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // chkbxPTRPackage
            // 
            this.chkbxPTRPackage.AutoSize = true;
            this.chkbxPTRPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxPTRPackage.Location = new System.Drawing.Point(6, 134);
            this.chkbxPTRPackage.Name = "chkbxPTRPackage";
            this.chkbxPTRPackage.Size = new System.Drawing.Size(105, 17);
            this.chkbxPTRPackage.TabIndex = 10;
            this.chkbxPTRPackage.Text = "PTR Package";
            this.chkbxPTRPackage.UseVisualStyleBackColor = true;
            this.chkbxPTRPackage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 310);
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
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "BuddyPal VersionFile Creator";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVersionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVersionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVersionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
    }
}

