namespace SharpEditor
{
    partial class frmSharpEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSharpEditor));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionAndOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpFirst = new System.Windows.Forms.TabPage();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslWC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWCV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslL = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLnV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalics = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsbStrikeout = new System.Windows.Forms.ToolStripButton();
            this.msMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpFirst.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Honeydew;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.editToolStripMenuItem,
            this.encryptionToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(980, 28);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Add_File;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Save_All;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Close_Window;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.close;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordwrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordwrapToolStripMenuItem
            // 
            this.wordwrapToolStripMenuItem.Name = "wordwrapToolStripMenuItem";
            this.wordwrapToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.wordwrapToolStripMenuItem.Text = "Word Wrap";
            this.wordwrapToolStripMenuItem.Click += new System.EventHandler(this.wordwrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.fontToolStripMenuItem.Text = "Font..";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::SharpEditor.Properties.Resources.icons8_Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptAndSaveToolStripMenuItem,
            this.decryptionAndOpenToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            // 
            // encryptAndSaveToolStripMenuItem
            // 
            this.encryptAndSaveToolStripMenuItem.Name = "encryptAndSaveToolStripMenuItem";
            this.encryptAndSaveToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.encryptAndSaveToolStripMenuItem.Text = "Encrypt and Save";
            this.encryptAndSaveToolStripMenuItem.Click += new System.EventHandler(this.encryptAndSaveToolStripMenuItem_Click);
            // 
            // decryptionAndOpenToolStripMenuItem
            // 
            this.decryptionAndOpenToolStripMenuItem.Name = "decryptionAndOpenToolStripMenuItem";
            this.decryptionAndOpenToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.decryptionAndOpenToolStripMenuItem.Text = "Decrypt and Open";
            this.decryptionAndOpenToolStripMenuItem.Click += new System.EventHandler(this.decryptionAndOpenToolStripMenuItem_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpFirst);
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(0, 66);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(980, 517);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpFirst
            // 
            this.tpFirst.Controls.Add(this.rtbMain);
            this.tpFirst.Location = new System.Drawing.Point(4, 29);
            this.tpFirst.Name = "tpFirst";
            this.tpFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tpFirst.Size = new System.Drawing.Size(972, 484);
            this.tpFirst.TabIndex = 0;
            this.tpFirst.Text = "New";
            this.tpFirst.UseVisualStyleBackColor = true;
            // 
            // rtbMain
            // 
            this.rtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(972, 488);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.WordWrap = false;
            this.rtbMain.SelectionChanged += new System.EventHandler(this.rtbMain_SelectionChanged);
            this.rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            this.rtbMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMain_KeyDown);
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.Color.Honeydew;
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWC,
            this.tsslWCV,
            this.tsslL,
            this.tsslLV,
            this.tsslLn,
            this.tsslLnV});
            this.ssStatus.Location = new System.Drawing.Point(0, 582);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(980, 30);
            this.ssStatus.TabIndex = 3;
            // 
            // tsslWC
            // 
            this.tsslWC.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.tsslWC.Name = "tsslWC";
            this.tsslWC.Size = new System.Drawing.Size(99, 20);
            this.tsslWC.Text = "Word Count : ";
            // 
            // tsslWCV
            // 
            this.tsslWCV.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.tsslWCV.Name = "tsslWCV";
            this.tsslWCV.Size = new System.Drawing.Size(17, 20);
            this.tsslWCV.Text = "0";
            // 
            // tsslL
            // 
            this.tsslL.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.tsslL.Name = "tsslL";
            this.tsslL.Size = new System.Drawing.Size(65, 20);
            this.tsslL.Text = "Length : ";
            // 
            // tsslLV
            // 
            this.tsslLV.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.tsslLV.Name = "tsslLV";
            this.tsslLV.Size = new System.Drawing.Size(17, 20);
            this.tsslLV.Text = "0";
            // 
            // tsslLn
            // 
            this.tsslLn.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.tsslLn.Name = "tsslLn";
            this.tsslLn.Size = new System.Drawing.Size(35, 20);
            this.tsslLn.Text = "Ln : ";
            // 
            // tsslLnV
            // 
            this.tsslLnV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tsslLnV.Name = "tsslLnV";
            this.tsslLnV.Size = new System.Drawing.Size(17, 20);
            this.tsslLnV.Text = "1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.Color.White;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbSaveAll,
            this.toolStripSeparator1,
            this.tsbBold,
            this.tsbItalics,
            this.tsbUnderline,
            this.tsbStrikeout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 28);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(980, 27);
            this.toolStripMain.TabIndex = 4;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::SharpEditor.Properties.Resources.icons8_Add_File;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(24, 24);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::SharpEditor.Properties.Resources.icons8_Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(24, 24);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::SharpEditor.Properties.Resources.icons8_Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(24, 24);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAll
            // 
            this.tsbSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAll.Image = global::SharpEditor.Properties.Resources.icons8_Save_All;
            this.tsbSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAll.Name = "tsbSaveAll";
            this.tsbSaveAll.Size = new System.Drawing.Size(24, 24);
            this.tsbSaveAll.Text = "SaveAll";
            this.tsbSaveAll.Click += new System.EventHandler(this.tsbSaveAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbBold
            // 
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = global::SharpEditor.Properties.Resources.icons8_Bold;
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(24, 24);
            this.tsbBold.Text = "Bold";
            this.tsbBold.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // tsbItalics
            // 
            this.tsbItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalics.Image = global::SharpEditor.Properties.Resources.icons8_Italic;
            this.tsbItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalics.Name = "tsbItalics";
            this.tsbItalics.Size = new System.Drawing.Size(24, 24);
            this.tsbItalics.Text = "Italics";
            this.tsbItalics.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = global::SharpEditor.Properties.Resources.icons8_Underline1;
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(24, 24);
            this.tsbUnderline.Text = "Underline";
            this.tsbUnderline.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // tsbStrikeout
            // 
            this.tsbStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStrikeout.Image = global::SharpEditor.Properties.Resources.icons8_Strikethrough1;
            this.tsbStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStrikeout.Name = "tsbStrikeout";
            this.tsbStrikeout.Size = new System.Drawing.Size(24, 24);
            this.tsbStrikeout.Text = "Strikethrough";
            this.tsbStrikeout.Click += new System.EventHandler(this.strikeoutToolStripMenuItem_Click);
            // 
            // frmSharpEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(980, 612);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmSharpEditor";
            this.Text = "SharpEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSharpEditor_FormClosing);
            this.Load += new System.EventHandler(this.frmSharpEditor_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpFirst.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordwrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpFirst;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslWC;
        private System.Windows.Forms.ToolStripStatusLabel tsslL;
        private System.Windows.Forms.ToolStripStatusLabel tsslLn;
        private System.Windows.Forms.ToolStripStatusLabel tsslWCV;
        private System.Windows.Forms.ToolStripStatusLabel tsslLV;
        private System.Windows.Forms.ToolStripStatusLabel tsslLnV;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalics;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.ToolStripButton tsbStrikeout;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptionAndOpenToolStripMenuItem;
    }
}

