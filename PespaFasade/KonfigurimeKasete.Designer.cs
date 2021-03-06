namespace PespaFasade
{
    partial class KonfigurimeKasete
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.gbAksesoret = new Janus.Windows.EditControls.UIGroupBox();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.cmbNjesia = new System.Windows.Forms.ComboBox();
            this.lblNjesia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmerAksesori = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCmimi = new System.Windows.Forms.NumericUpDown();
            this.gbFormula = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbNjesiKoeficienti = new System.Windows.Forms.ComboBox();
            this.cmbVaresi = new System.Windows.Forms.ComboBox();
            this.numKoeficientVaresi = new System.Windows.Forms.NumericUpDown();
            this.lblShumezim = new System.Windows.Forms.Label();
            this.lblKoeficienti = new System.Windows.Forms.Label();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnElemino = new System.Windows.Forms.Button();
            this.btnModifikoAksesor = new System.Windows.Forms.Button();
            this.gbModifikoAksesoret = new Janus.Windows.EditControls.UIGroupBox();
            this.txtPershkrimAksesori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numKoeficientiModifiko = new System.Windows.Forms.Label();
            this.numKoeficienti = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmerModifiko = new System.Windows.Forms.TextBox();
            this.lblModifikoEmer = new System.Windows.Forms.Label();
            this.numCmimiModifiko = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aksesoreTableAdapter = new PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter();
            this.dsPespa = new PespaFasade.DsPespa();
            this.aksesoreTableAdapter1 = new PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).BeginInit();
            this.gbAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFormula)).BeginInit();
            this.gbFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficientVaresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).BeginInit();
            this.gbModifikoAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimiModifiko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnElemino);
            this.panelEx1.Controls.Add(this.btnModifikoAksesor);
            this.panelEx1.Controls.Add(this.gbModifikoAksesoret);
            this.panelEx1.Controls.Add(this.gbAksesoret);
            this.panelEx1.Controls.Add(this.btnShto);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(831, 565);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // gbAksesoret
            // 
            this.gbAksesoret.BackColor = System.Drawing.Color.Transparent;
            this.gbAksesoret.Controls.Add(this.txtPershkrimi);
            this.gbAksesoret.Controls.Add(this.lblPershkrimi);
            this.gbAksesoret.Controls.Add(this.cmbNjesia);
            this.gbAksesoret.Controls.Add(this.lblNjesia);
            this.gbAksesoret.Controls.Add(this.label7);
            this.gbAksesoret.Controls.Add(this.txtEmerAksesori);
            this.gbAksesoret.Controls.Add(this.label5);
            this.gbAksesoret.Controls.Add(this.numCmimi);
            this.gbAksesoret.Controls.Add(this.gbFormula);
            this.gbAksesoret.Location = new System.Drawing.Point(23, 21);
            this.gbAksesoret.Name = "gbAksesoret";
            this.gbAksesoret.Size = new System.Drawing.Size(457, 237);
            this.gbAksesoret.TabIndex = 40;
            this.gbAksesoret.Text = "Aksesoret";
            this.gbAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(193, 56);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(127, 20);
            this.txtPershkrimi.TabIndex = 63;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Location = new System.Drawing.Point(97, 59);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(77, 13);
            this.lblPershkrimi.TabIndex = 62;
            this.lblPershkrimi.Text = "Emri i aksesorit";
            // 
            // cmbNjesia
            // 
            this.cmbNjesia.FormattingEnabled = true;
            this.cmbNjesia.Items.AddRange(new object[] {
            "cope",
            "ml",
            "m�",
            "kg"});
            this.cmbNjesia.Location = new System.Drawing.Point(194, 110);
            this.cmbNjesia.Name = "cmbNjesia";
            this.cmbNjesia.Size = new System.Drawing.Size(56, 21);
            this.cmbNjesia.TabIndex = 61;
            // 
            // lblNjesia
            // 
            this.lblNjesia.AutoSize = true;
            this.lblNjesia.Location = new System.Drawing.Point(101, 113);
            this.lblNjesia.Name = "lblNjesia";
            this.lblNjesia.Size = new System.Drawing.Size(73, 13);
            this.lblNjesia.TabIndex = 60;
            this.lblNjesia.Text = "Njesia matese";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cmimi";
            // 
            // txtEmerAksesori
            // 
            this.txtEmerAksesori.Location = new System.Drawing.Point(193, 30);
            this.txtEmerAksesori.Name = "txtEmerAksesori";
            this.txtEmerAksesori.Size = new System.Drawing.Size(127, 20);
            this.txtEmerAksesori.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Kodi i aksesorit";
            // 
            // numCmimi
            // 
            this.numCmimi.DecimalPlaces = 2;
            this.numCmimi.Location = new System.Drawing.Point(193, 84);
            this.numCmimi.Name = "numCmimi";
            this.numCmimi.Size = new System.Drawing.Size(127, 20);
            this.numCmimi.TabIndex = 56;
            // 
            // gbFormula
            // 
            this.gbFormula.Controls.Add(this.cmbNjesiKoeficienti);
            this.gbFormula.Controls.Add(this.cmbVaresi);
            this.gbFormula.Controls.Add(this.numKoeficientVaresi);
            this.gbFormula.Controls.Add(this.lblShumezim);
            this.gbFormula.Controls.Add(this.lblKoeficienti);
            this.gbFormula.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.gbFormula.Location = new System.Drawing.Point(15, 159);
            this.gbFormula.Name = "gbFormula";
            this.gbFormula.Size = new System.Drawing.Size(424, 66);
            this.superTooltip1.SetSuperTooltip(this.gbFormula, new DevComponents.DotNetBar.SuperTooltipInfo("Percakton formulen e cila do te perdoret per te llogaritur sasine e aksesoreve qe" +
                        " do te perdoren", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.gbFormula.TabIndex = 55;
            this.gbFormula.Text = "Formula";
            this.gbFormula.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.gbFormula.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cmbNjesiKoeficienti
            // 
            this.cmbNjesiKoeficienti.Enabled = false;
            this.cmbNjesiKoeficienti.FormattingEnabled = true;
            this.cmbNjesiKoeficienti.Items.AddRange(new object[] {
            "cope",
            "ml",
            "m�",
            "kg"});
            this.cmbNjesiKoeficienti.Location = new System.Drawing.Point(301, 34);
            this.cmbNjesiKoeficienti.Name = "cmbNjesiKoeficienti";
            this.cmbNjesiKoeficienti.Size = new System.Drawing.Size(56, 21);
            this.cmbNjesiKoeficienti.TabIndex = 7;
            // 
            // cmbVaresi
            // 
            this.cmbVaresi.DataSource = this.dsPespa;
            this.cmbVaresi.DisplayMember = "AKSESORE.EMER_AKSESORI";
            this.cmbVaresi.FormattingEnabled = true;
            this.cmbVaresi.Location = new System.Drawing.Point(165, 34);
            this.cmbVaresi.Name = "cmbVaresi";
            this.cmbVaresi.Size = new System.Drawing.Size(121, 21);
            this.cmbVaresi.TabIndex = 6;
            this.cmbVaresi.ValueMember = "AKSESORE.ID_AKSESORI";
            this.cmbVaresi.SelectedIndexChanged += new System.EventHandler(this.cmbVaresi_SelectedIndexChanged);
            // 
            // numKoeficientVaresi
            // 
            this.numKoeficientVaresi.DecimalPlaces = 2;
            this.numKoeficientVaresi.Location = new System.Drawing.Point(72, 35);
            this.numKoeficientVaresi.Name = "numKoeficientVaresi";
            this.numKoeficientVaresi.Size = new System.Drawing.Size(63, 20);
            this.numKoeficientVaresi.TabIndex = 5;
            // 
            // lblShumezim
            // 
            this.lblShumezim.AutoSize = true;
            this.lblShumezim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShumezim.Location = new System.Drawing.Point(145, 35);
            this.lblShumezim.Name = "lblShumezim";
            this.lblShumezim.Size = new System.Drawing.Size(14, 16);
            this.lblShumezim.TabIndex = 2;
            this.lblShumezim.Text = "*";
            this.lblShumezim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKoeficienti
            // 
            this.lblKoeficienti.Location = new System.Drawing.Point(73, 19);
            this.lblKoeficienti.Name = "lblKoeficienti";
            this.lblKoeficienti.Size = new System.Drawing.Size(63, 21);
            this.lblKoeficienti.TabIndex = 0;
            this.lblKoeficienti.Text = "Koefi�enti";
            this.lblKoeficienti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShto
            // 
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.Image = global::PespaFasade.Properties.Resources.news_info;
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Location = new System.Drawing.Point(524, 125);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(87, 31);
            this.btnShto.TabIndex = 39;
            this.btnShto.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnElemino
            // 
            this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElemino.Image = global::PespaFasade.Properties.Resources.cancel;
            this.btnElemino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElemino.Location = new System.Drawing.Point(524, 400);
            this.btnElemino.Name = "btnElemino";
            this.btnElemino.Size = new System.Drawing.Size(87, 31);
            this.superTooltip1.SetSuperTooltip(this.btnElemino, new DevComponents.DotNetBar.SuperTooltipInfo("Fshin aksesorin e dhene", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnElemino.TabIndex = 43;
            this.btnElemino.Text = "Elemino";
            this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
            // 
            // btnModifikoAksesor
            // 
            this.btnModifikoAksesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifikoAksesor.Image = global::PespaFasade.Properties.Resources.edit;
            this.btnModifikoAksesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifikoAksesor.Location = new System.Drawing.Point(524, 359);
            this.btnModifikoAksesor.Name = "btnModifikoAksesor";
            this.btnModifikoAksesor.Size = new System.Drawing.Size(87, 31);
            this.superTooltip1.SetSuperTooltip(this.btnModifikoAksesor, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te kasetave", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnModifikoAksesor.TabIndex = 42;
            this.btnModifikoAksesor.Text = "Modifiko";
            this.btnModifikoAksesor.Click += new System.EventHandler(this.btnModifikoAksesor_Click);
            // 
            // gbModifikoAksesoret
            // 
            this.gbModifikoAksesoret.BackColor = System.Drawing.Color.Transparent;
            this.gbModifikoAksesoret.Controls.Add(this.txtPershkrimAksesori);
            this.gbModifikoAksesoret.Controls.Add(this.label1);
            this.gbModifikoAksesoret.Controls.Add(this.numKoeficientiModifiko);
            this.gbModifikoAksesoret.Controls.Add(this.numKoeficienti);
            this.gbModifikoAksesoret.Controls.Add(this.label6);
            this.gbModifikoAksesoret.Controls.Add(this.txtEmerModifiko);
            this.gbModifikoAksesoret.Controls.Add(this.lblModifikoEmer);
            this.gbModifikoAksesoret.Controls.Add(this.numCmimiModifiko);
            this.gbModifikoAksesoret.Controls.Add(this.listBox1);
            this.gbModifikoAksesoret.Controls.Add(this.label3);
            this.gbModifikoAksesoret.Location = new System.Drawing.Point(23, 310);
            this.gbModifikoAksesoret.Name = "gbModifikoAksesoret";
            this.gbModifikoAksesoret.Size = new System.Drawing.Size(457, 214);
            this.gbModifikoAksesoret.TabIndex = 41;
            this.gbModifikoAksesoret.Text = "Modifiko aksesoret";
            this.gbModifikoAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtPershkrimAksesori
            // 
            this.txtPershkrimAksesori.Location = new System.Drawing.Point(291, 83);
            this.txtPershkrimAksesori.Name = "txtPershkrimAksesori";
            this.txtPershkrimAksesori.Size = new System.Drawing.Size(127, 20);
            this.txtPershkrimAksesori.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Emri i aksesorit";
            // 
            // numKoeficientiModifiko
            // 
            this.numKoeficientiModifiko.AutoSize = true;
            this.numKoeficientiModifiko.Location = new System.Drawing.Point(213, 137);
            this.numKoeficientiModifiko.Name = "numKoeficientiModifiko";
            this.numKoeficientiModifiko.Size = new System.Drawing.Size(54, 13);
            this.numKoeficientiModifiko.TabIndex = 37;
            this.numKoeficientiModifiko.Text = "Koefi�enti";
            // 
            // numKoeficienti
            // 
            this.numKoeficienti.DecimalPlaces = 2;
            this.numKoeficienti.Location = new System.Drawing.Point(291, 135);
            this.numKoeficienti.Name = "numKoeficienti";
            this.numKoeficienti.Size = new System.Drawing.Size(63, 20);
            this.numKoeficienti.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cmimi i aksesorit";
            // 
            // txtEmerModifiko
            // 
            this.txtEmerModifiko.Location = new System.Drawing.Point(291, 55);
            this.txtEmerModifiko.Name = "txtEmerModifiko";
            this.txtEmerModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtEmerModifiko.TabIndex = 35;
            // 
            // lblModifikoEmer
            // 
            this.lblModifikoEmer.AutoSize = true;
            this.lblModifikoEmer.Location = new System.Drawing.Point(190, 58);
            this.lblModifikoEmer.Name = "lblModifikoEmer";
            this.lblModifikoEmer.Size = new System.Drawing.Size(78, 13);
            this.lblModifikoEmer.TabIndex = 34;
            this.lblModifikoEmer.Text = "Kodi i aksesorit";
            // 
            // numCmimiModifiko
            // 
            this.numCmimiModifiko.Location = new System.Drawing.Point(291, 109);
            this.numCmimiModifiko.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCmimiModifiko.Name = "numCmimiModifiko";
            this.numCmimiModifiko.Size = new System.Drawing.Size(127, 20);
            this.numCmimiModifiko.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dsPespa;
            this.listBox1.DisplayMember = "AKSESORE.EMER_AKSESORI";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 134);
            this.listBox1.TabIndex = 15;
            this.listBox1.ValueMember = "AKSESORE.ID_AKSESORI";
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aksesoret per profilet vertikale";
            // 
            // aksesoreTableAdapter
            // 
            this.aksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // dsPespa
            // 
            this.dsPespa.DataSetName = "DsPespa";
            this.dsPespa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aksesoreTableAdapter1
            // 
            this.aksesoreTableAdapter1.ClearBeforeFill = true;
            // 
            // KonfigurimeKasete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(831, 591);
            this.Controls.Add(this.panelEx1);
            this.Name = "KonfigurimeKasete";
            this.Text = "Kasetat";
            this.Load += new System.EventHandler(this.KonfigurimeKasete_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).EndInit();
            this.gbAksesoret.ResumeLayout(false);
            this.gbAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFormula)).EndInit();
            this.gbFormula.ResumeLayout(false);
            this.gbFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficientVaresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).EndInit();
            this.gbModifikoAksesoret.ResumeLayout(false);
            this.gbModifikoAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimiModifiko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.EditControls.UIGroupBox gbAksesoret;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.ComboBox cmbNjesia;
        private System.Windows.Forms.Label lblNjesia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmerAksesori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCmimi;
        private Janus.Windows.EditControls.UIGroupBox gbFormula;
        private System.Windows.Forms.ComboBox cmbNjesiKoeficienti;
        private System.Windows.Forms.ComboBox cmbVaresi;
        private System.Windows.Forms.NumericUpDown numKoeficientVaresi;
        private System.Windows.Forms.Label lblShumezim;
        private System.Windows.Forms.Label lblKoeficienti;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Button btnElemino;
        private System.Windows.Forms.Button btnModifikoAksesor;
        private Janus.Windows.EditControls.UIGroupBox gbModifikoAksesoret;
        private System.Windows.Forms.TextBox txtPershkrimAksesori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numKoeficientiModifiko;
        private System.Windows.Forms.NumericUpDown numKoeficienti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmerModifiko;
        private System.Windows.Forms.Label lblModifikoEmer;
        private System.Windows.Forms.NumericUpDown numCmimiModifiko;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter aksesoreTableAdapter;
        private DsPespa dsPespa;
        private PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter aksesoreTableAdapter1;
    }
}
