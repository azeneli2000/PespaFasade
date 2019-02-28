namespace PespaFasade
{
    partial class FutVlereReale
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
            this.components = new System.ComponentModel.Container();
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbProjekti = new Janus.Windows.EditControls.UIComboBox();
            this.pROJEKTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPespa1 = new PespaFasade.DsPespa();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projekteTableAdapter1 = new PespaFasade.DsPespaTableAdapters.PROJEKTETableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEKTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnRuaj);
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(574, 252);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btnRuaj
            // 
            this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuaj.Image = global::PespaFasade.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(219, 200);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(87, 31);
            this.btnRuaj.TabIndex = 5;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.numericUpDown1);
            this.uiGroupBox1.Controls.Add(this.cmbProjekti);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Location = new System.Drawing.Point(29, 55);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(481, 112);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Fut vlerat reale per projektet";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(338, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // cmbProjekti
            // 
            this.cmbProjekti.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJEKTEBindingSource, "EMER_PROJEKTI", true));
            this.cmbProjekti.DataMember = "PROJEKTE";
            this.cmbProjekti.DataSource = this.dsPespa1;
            this.cmbProjekti.DisplayMember = "EMER_PROJEKTI";
            this.cmbProjekti.Location = new System.Drawing.Point(60, 28);
            this.cmbProjekti.Name = "cmbProjekti";
            this.cmbProjekti.Size = new System.Drawing.Size(176, 20);
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.FitBlackBox | System.Drawing.StringFormatFlags.NoWrap)
                        | System.Drawing.StringFormatFlags.NoClip)));
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.cmbProjekti.StringFormat = stringFormat1;
            this.cmbProjekti.TabIndex = 3;
            this.cmbProjekti.ValueMember = "ID_PROJEKTI";
            this.cmbProjekti.SelectedIndexChanged += new System.EventHandler(this.cmbProjekti_SelectedIndexChanged);
            // 
            // pROJEKTEBindingSource
            // 
            this.pROJEKTEBindingSource.DataMember = "PROJEKTE";
            this.pROJEKTEBindingSource.DataSource = this.dsPespa1;
            // 
            // dsPespa1
            // 
            this.dsPespa1.DataSetName = "DsPespa";
            this.dsPespa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlera reale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekti";
            // 
            // projekteTableAdapter1
            // 
            this.projekteTableAdapter1.ClearBeforeFill = true;
            // 
            // FutVlereReale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 278);
            this.ControlBox = true;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FutVlereReale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fut vlere reale per projektet";
            this.Load += new System.EventHandler(this.FutVlereReale_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEKTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Janus.Windows.EditControls.UIComboBox cmbProjekti;
        private DsPespa dsPespa1;
        private PespaFasade.DsPespaTableAdapters.PROJEKTETableAdapter projekteTableAdapter1;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.BindingSource pROJEKTEBindingSource;
    }
}
