namespace Animation_Editor
{
    partial class Form1
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.YANMFileWindow = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMotion = new System.Windows.Forms.ToolStripMenuItem();
            this.openCamera000AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openYANMFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openYANMFilePreWWE2K15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertPreWWE2K15EntranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAnimationEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(12, 27);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // YANMFileWindow
            // 
            this.YANMFileWindow.Location = new System.Drawing.Point(131, 93);
            this.YANMFileWindow.Name = "YANMFileWindow";
            this.YANMFileWindow.Size = new System.Drawing.Size(657, 345);
            this.YANMFileWindow.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMotion,
            this.openCamera000AToolStripMenuItem,
            this.toolStripSeparator1,
            this.openYANMFileToolStripMenuItem,
            this.openYANMFilePreWWE2K15ToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMotion
            // 
            this.openMotion.Name = "openMotion";
            this.openMotion.Size = new System.Drawing.Size(248, 22);
            this.openMotion.Text = "Open Motion (0000)";
            this.openMotion.Click += new System.EventHandler(this.openAnimation0000000AToolStripMenuItem_Click);
            // 
            // openCamera000AToolStripMenuItem
            // 
            this.openCamera000AToolStripMenuItem.Name = "openCamera000AToolStripMenuItem";
            this.openCamera000AToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.openCamera000AToolStripMenuItem.Text = "Open Camera (000A)";
            this.openCamera000AToolStripMenuItem.Click += new System.EventHandler(this.openCamera000AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // openYANMFileToolStripMenuItem
            // 
            this.openYANMFileToolStripMenuItem.Name = "openYANMFileToolStripMenuItem";
            this.openYANMFileToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.openYANMFileToolStripMenuItem.Text = "Open YANM File (PC)";
            this.openYANMFileToolStripMenuItem.Click += new System.EventHandler(this.openYANMFileToolStripMenuItem_Click);
            // 
            // openYANMFilePreWWE2K15ToolStripMenuItem
            // 
            this.openYANMFilePreWWE2K15ToolStripMenuItem.Name = "openYANMFilePreWWE2K15ToolStripMenuItem";
            this.openYANMFilePreWWE2K15ToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.openYANMFilePreWWE2K15ToolStripMenuItem.Text = "Open YANM File (Pre WWE 2K15)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertPreWWE2K15EntranceToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // convertPreWWE2K15EntranceToolStripMenuItem
            // 
            this.convertPreWWE2K15EntranceToolStripMenuItem.Name = "convertPreWWE2K15EntranceToolStripMenuItem";
            this.convertPreWWE2K15EntranceToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.convertPreWWE2K15EntranceToolStripMenuItem.Text = "Convert pre-WWE 2K15 entrance";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAnimationEditorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutAnimationEditorToolStripMenuItem
            // 
            this.aboutAnimationEditorToolStripMenuItem.Name = "aboutAnimationEditorToolStripMenuItem";
            this.aboutAnimationEditorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutAnimationEditorToolStripMenuItem.Text = "About Animation Editor";
            this.aboutAnimationEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutAnimationEditorToolStripMenuItem_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(93, 27);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnExtractAll
            // 
            this.btnExtractAll.Location = new System.Drawing.Point(175, 27);
            this.btnExtractAll.Name = "btnExtractAll";
            this.btnExtractAll.Size = new System.Drawing.Size(75, 23);
            this.btnExtractAll.TabIndex = 4;
            this.btnExtractAll.Text = "Extract All";
            this.btnExtractAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExtractAll);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.YANMFileWindow);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Animation Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TreeView YANMFileWindow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMotion;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAnimationEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertPreWWE2K15EntranceToolStripMenuItem;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnExtractAll;
        private System.Windows.Forms.ToolStripMenuItem openCamera000AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openYANMFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openYANMFilePreWWE2K15ToolStripMenuItem;
    }
}

