
namespace PES5_WE9_LE_BannerRelinker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.cboBannerBin = new System.Windows.Forms.ComboBox();
            this.cboBannerTextureId = new System.Windows.Forms.ComboBox();
            this.lblBannerBinName = new System.Windows.Forms.Label();
            this.lblBannerTextureId = new System.Windows.Forms.Label();
            this.lblBanners = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSupportersColours = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.cboStadium = new System.Windows.Forms.ComboBox();
            this.cboSuppColSec = new System.Windows.Forms.ComboBox();
            this.cboSuppColMain = new System.Windows.Forms.ComboBox();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(0, 26);
            this.lstTeams.Margin = new System.Windows.Forms.Padding(2);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(165, 355);
            this.lstTeams.TabIndex = 3;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // cboBannerBin
            // 
            this.cboBannerBin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBannerBin.Enabled = false;
            this.cboBannerBin.FormattingEnabled = true;
            this.cboBannerBin.Items.AddRange(new object[] {
            "unknow_11404.bin",
            "unknow_11405.bin",
            "unknow_11406.bin",
            "unknow_11407.bin",
            "unknow_11408.bin",
            "unknow_11409.bin",
            "unknow_11410.bin",
            "unknow_11411.bin",
            "unknow_11412.bin",
            "unknow_11413.bin",
            "unknow_11414.bin",
            "unknow_11415.bin"});
            this.cboBannerBin.Location = new System.Drawing.Point(274, 112);
            this.cboBannerBin.Margin = new System.Windows.Forms.Padding(2);
            this.cboBannerBin.Name = "cboBannerBin";
            this.cboBannerBin.Size = new System.Drawing.Size(114, 21);
            this.cboBannerBin.TabIndex = 4;
            this.cboBannerBin.SelectionChangeCommitted += new System.EventHandler(this.cboBannerBin_SelectionChangeCommitted);
            // 
            // cboBannerTextureId
            // 
            this.cboBannerTextureId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBannerTextureId.Enabled = false;
            this.cboBannerTextureId.FormattingEnabled = true;
            this.cboBannerTextureId.Location = new System.Drawing.Point(406, 112);
            this.cboBannerTextureId.Margin = new System.Windows.Forms.Padding(2);
            this.cboBannerTextureId.Name = "cboBannerTextureId";
            this.cboBannerTextureId.Size = new System.Drawing.Size(114, 21);
            this.cboBannerTextureId.TabIndex = 5;
            this.cboBannerTextureId.SelectionChangeCommitted += new System.EventHandler(this.cboBannerTextureId_SelectionChangeCommitted);
            // 
            // lblBannerBinName
            // 
            this.lblBannerBinName.AutoSize = true;
            this.lblBannerBinName.Location = new System.Drawing.Point(274, 91);
            this.lblBannerBinName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBannerBinName.Name = "lblBannerBinName";
            this.lblBannerBinName.Size = new System.Drawing.Size(51, 13);
            this.lblBannerBinName.TabIndex = 6;
            this.lblBannerBinName.Text = "Bin name";
            // 
            // lblBannerTextureId
            // 
            this.lblBannerTextureId.AutoSize = true;
            this.lblBannerTextureId.Location = new System.Drawing.Point(406, 91);
            this.lblBannerTextureId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBannerTextureId.Name = "lblBannerTextureId";
            this.lblBannerTextureId.Size = new System.Drawing.Size(115, 13);
            this.lblBannerTextureId.TabIndex = 7;
            this.lblBannerTextureId.Text = "Texture ID (GGS Style)";
            // 
            // lblBanners
            // 
            this.lblBanners.AutoSize = true;
            this.lblBanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanners.Location = new System.Drawing.Point(274, 66);
            this.lblBanners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanners.Name = "lblBanners";
            this.lblBanners.Size = new System.Drawing.Size(53, 13);
            this.lblBanners.TabIndex = 10;
            this.lblBanners.Text = "Banners";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblSupportersColours
            // 
            this.lblSupportersColours.AutoSize = true;
            this.lblSupportersColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupportersColours.Location = new System.Drawing.Point(274, 147);
            this.lblSupportersColours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupportersColours.Name = "lblSupportersColours";
            this.lblSupportersColours.Size = new System.Drawing.Size(114, 13);
            this.lblSupportersColours.TabIndex = 12;
            this.lblSupportersColours.Text = "Supporters Colours";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.Location = new System.Drawing.Point(274, 215);
            this.lblStadium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(88, 13);
            this.lblStadium.TabIndex = 13;
            this.lblStadium.Text = "Home Stadium";
            // 
            // cboStadium
            // 
            this.cboStadium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStadium.Enabled = false;
            this.cboStadium.FormattingEnabled = true;
            this.cboStadium.Location = new System.Drawing.Point(274, 244);
            this.cboStadium.Margin = new System.Windows.Forms.Padding(2);
            this.cboStadium.Name = "cboStadium";
            this.cboStadium.Size = new System.Drawing.Size(171, 21);
            this.cboStadium.TabIndex = 14;
            this.cboStadium.SelectionChangeCommitted += new System.EventHandler(this.cboStadium_SelectionChangeCommitted);
            // 
            // cboSuppColSec
            // 
            this.cboSuppColSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSuppColSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppColSec.Enabled = false;
            this.cboSuppColSec.FormattingEnabled = true;
            this.cboSuppColSec.Location = new System.Drawing.Point(409, 178);
            this.cboSuppColSec.Margin = new System.Windows.Forms.Padding(2);
            this.cboSuppColSec.Name = "cboSuppColSec";
            this.cboSuppColSec.Size = new System.Drawing.Size(114, 21);
            this.cboSuppColSec.TabIndex = 16;
            this.cboSuppColSec.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboTeamSuppColour_DrawItem);
            this.cboSuppColSec.SelectionChangeCommitted += new System.EventHandler(this.CboTeamSuppSecColour_SelectionChangeCommitted);
            // 
            // cboSuppColMain
            // 
            this.cboSuppColMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSuppColMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppColMain.Enabled = false;
            this.cboSuppColMain.FormattingEnabled = true;
            this.cboSuppColMain.Location = new System.Drawing.Point(277, 178);
            this.cboSuppColMain.Margin = new System.Windows.Forms.Padding(2);
            this.cboSuppColMain.Name = "cboSuppColMain";
            this.cboSuppColMain.Size = new System.Drawing.Size(114, 21);
            this.cboSuppColMain.TabIndex = 15;
            this.cboSuppColMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboTeamSuppColour_DrawItem);
            this.cboSuppColMain.SelectionChangeCommitted += new System.EventHandler(this.CboTeamSuppMainColour_SelectionChangeCommitted);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 382);
            this.Controls.Add(this.cboSuppColSec);
            this.Controls.Add(this.cboSuppColMain);
            this.Controls.Add(this.cboStadium);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblSupportersColours);
            this.Controls.Add(this.lblBanners);
            this.Controls.Add(this.lblBannerTextureId);
            this.Controls.Add(this.lblBannerBinName);
            this.Controls.Add(this.cboBannerTextureId);
            this.Controls.Add(this.cboBannerBin);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PES5/WE9/LE Banner Relinker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.ComboBox cboBannerBin;
        private System.Windows.Forms.ComboBox cboBannerTextureId;
        private System.Windows.Forms.Label lblBannerBinName;
        private System.Windows.Forms.Label lblBannerTextureId;
        private System.Windows.Forms.Label lblBanners;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblSupportersColours;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.ComboBox cboStadium;
        private System.Windows.Forms.ComboBox cboSuppColSec;
        private System.Windows.Forms.ComboBox cboSuppColMain;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

