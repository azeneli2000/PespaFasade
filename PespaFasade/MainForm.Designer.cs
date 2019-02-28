namespace PespaFasade
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shtoProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shtoProjektToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.futVlereRealePerProjektinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileVertikaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileHorizontaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferencaEProjekteveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndihmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndihmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docManager = new DocumentManager.DocumentManager();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shtoProjektToolStripMenuItem,
            this.konfigurimeToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.ndihmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shtoProjektToolStripMenuItem
            // 
            this.shtoProjektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shtoProjektToolStripMenuItem1,
            this.futVlereRealePerProjektinToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dilToolStripMenuItem});
            this.shtoProjektToolStripMenuItem.Name = "shtoProjektToolStripMenuItem";
            this.shtoProjektToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.shtoProjektToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.shtoProjektToolStripMenuItem.Text = "Skedar";
            // 
            // shtoProjektToolStripMenuItem1
            // 
            this.shtoProjektToolStripMenuItem1.Image = global::PespaFasade.Properties.Resources.generic;
            this.shtoProjektToolStripMenuItem1.Name = "shtoProjektToolStripMenuItem1";
            this.shtoProjektToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.shtoProjektToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.shtoProjektToolStripMenuItem1.Text = "Shto projekt";
            this.shtoProjektToolStripMenuItem1.Click += new System.EventHandler(this.shtoProjektToolStripMenuItem1_Click);
            // 
            // futVlereRealePerProjektinToolStripMenuItem
            // 
            this.futVlereRealePerProjektinToolStripMenuItem.Name = "futVlereRealePerProjektinToolStripMenuItem";
            this.futVlereRealePerProjektinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.futVlereRealePerProjektinToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.futVlereRealePerProjektinToolStripMenuItem.Text = "Fut vlere reale per projektin";
            this.futVlereRealePerProjektinToolStripMenuItem.Click += new System.EventHandler(this.futVlereRealePerProjektinToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 6);
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.Image = global::PespaFasade.Properties.Resources.cancel_f2;
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            this.dilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.dilToolStripMenuItem.Text = "Dil";
            this.dilToolStripMenuItem.Click += new System.EventHandler(this.dilToolStripMenuItem_Click);
            // 
            // konfigurimeToolStripMenuItem
            // 
            this.konfigurimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileVertikaleToolStripMenuItem,
            this.profileHorizontaleToolStripMenuItem,
            this.kasetaToolStripMenuItem});
            this.konfigurimeToolStripMenuItem.Name = "konfigurimeToolStripMenuItem";
            this.konfigurimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.konfigurimeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.konfigurimeToolStripMenuItem.Text = "Konfigurime";
            // 
            // profileVertikaleToolStripMenuItem
            // 
            this.profileVertikaleToolStripMenuItem.Name = "profileVertikaleToolStripMenuItem";
            this.profileVertikaleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.profileVertikaleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.profileVertikaleToolStripMenuItem.Text = "Profile vertikale";
            this.profileVertikaleToolStripMenuItem.Click += new System.EventHandler(this.profileVertikaleToolStripMenuItem_Click);
            // 
            // profileHorizontaleToolStripMenuItem
            // 
            this.profileHorizontaleToolStripMenuItem.Name = "profileHorizontaleToolStripMenuItem";
            this.profileHorizontaleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.profileHorizontaleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.profileHorizontaleToolStripMenuItem.Text = "Profile horizontale";
            this.profileHorizontaleToolStripMenuItem.Click += new System.EventHandler(this.profileHorizontaleToolStripMenuItem_Click);
            // 
            // kasetaToolStripMenuItem
            // 
            this.kasetaToolStripMenuItem.Name = "kasetaToolStripMenuItem";
            this.kasetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.kasetaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.kasetaToolStripMenuItem.Text = "Kaseta";
            this.kasetaToolStripMenuItem.Click += new System.EventHandler(this.kasetaToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diferencaEProjekteveToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // diferencaEProjekteveToolStripMenuItem
            // 
            this.diferencaEProjekteveToolStripMenuItem.Name = "diferencaEProjekteveToolStripMenuItem";
            this.diferencaEProjekteveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diferencaEProjekteveToolStripMenuItem.Text = "Diferenca";
            this.diferencaEProjekteveToolStripMenuItem.Click += new System.EventHandler(this.diferencaEProjekteveToolStripMenuItem_Click);
            // 
            // ndihmeToolStripMenuItem
            // 
            this.ndihmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ndihmaToolStripMenuItem});
            this.ndihmeToolStripMenuItem.Name = "ndihmeToolStripMenuItem";
            this.ndihmeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ndihmeToolStripMenuItem.Text = "Ndihme";
            // 
            // ndihmaToolStripMenuItem
            // 
            this.ndihmaToolStripMenuItem.Image = global::PespaFasade.Properties.Resources.help;
            this.ndihmaToolStripMenuItem.Name = "ndihmaToolStripMenuItem";
            this.ndihmaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ndihmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ndihmaToolStripMenuItem.Text = "Ndihma";
            // 
            // docManager
            // 
            this.docManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docManager.Location = new System.Drawing.Point(0, 24);
            this.docManager.Name = "docManager";
            this.docManager.Size = new System.Drawing.Size(853, 504);
            this.docManager.TabIndex = 1;
            this.docManager.CloseButtonPressed += new DocumentManager.DocumentManager.CloseButtonPressedEventHandler(this.docManager_CloseButtonPressed);
            // 
            // tabStrip1
            // 
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonVisible = true;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(0, 24);
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabStrip1.Size = new System.Drawing.Size(853, 23);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote;
            this.tabStrip1.TabIndex = 3;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabStrip1";
            this.tabStrip1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabStrip1_TabItemClose);
            this.tabStrip1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabStrip1_SelectedTabChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 528);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.docManager);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fasade";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shtoProjektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shtoProjektToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem futVlereRealePerProjektinToolStripMenuItem;
        private DocumentManager.DocumentManager docManager;
        private System.Windows.Forms.ToolStripMenuItem konfigurimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileVertikaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileHorizontaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndihmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndihmaToolStripMenuItem;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private System.Windows.Forms.ToolStripMenuItem diferencaEProjekteveToolStripMenuItem;
    }
}

