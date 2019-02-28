namespace PespaFasade
{
    partial class ShtoProjekt
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
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbLlojStrukture = new Janus.Windows.EditControls.UIGroupBox();
            this.rbKompozitFuga = new System.Windows.Forms.RadioButton();
            this.rbKapak = new System.Windows.Forms.RadioButton();
            this.rbStruktural = new System.Windows.Forms.RadioButton();
            this.rbGjysemStruktural = new System.Windows.Forms.RadioButton();
            this.rbKompozitProfilH = new System.Windows.Forms.RadioButton();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbProjekti = new Janus.Windows.EditControls.UIGroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDataProjekti = new System.Windows.Forms.DateTimePicker();
            this.txtEmerProjekti = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.iDPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMERPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPespaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPespa = new PespaFasade.DsPespa();
            this.projekteTableAdapter = new PespaFasade.DsPespaTableAdapters.PROJEKTETableAdapter();
            this.aksesoreTableAdapter = new PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter();
            this.projekte_dataTableAdapter = new PespaFasade.DsPespaTableAdapters.PROJEKTE_DATATableAdapter();
            this.profileTableAdapter = new PespaFasade.DsPespaTableAdapters.PROFILETableAdapter();
            this.fasadaTableAdapter = new PespaFasade.DsPespaTableAdapters.FASADATableAdapter();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojStrukture)).BeginInit();
            this.gbLlojStrukture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbProjekti)).BeginInit();
            this.gbProjekti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.btnShto);
            this.expandablePanel2.Controls.Add(this.btnOK);
            this.expandablePanel2.Controls.Add(this.gbLlojStrukture);
            this.expandablePanel2.Controls.Add(this.btnAnullo);
            this.expandablePanel2.Controls.Add(this.btnRuaj);
            this.expandablePanel2.Controls.Add(this.dataGridView1);
            this.expandablePanel2.Controls.Add(this.gbProjekti);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 26);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(924, 698);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 20;
            this.expandablePanel2.TitleHeight = 0;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Title Bar";
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(710, 49);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 23);
            this.btnShto.TabIndex = 27;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_2);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(387, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbLlojStrukture
            // 
            this.gbLlojStrukture.Controls.Add(this.rbKompozitFuga);
            this.gbLlojStrukture.Controls.Add(this.rbKapak);
            this.gbLlojStrukture.Controls.Add(this.rbStruktural);
            this.gbLlojStrukture.Controls.Add(this.rbGjysemStruktural);
            this.gbLlojStrukture.Controls.Add(this.rbKompozitProfilH);
            this.gbLlojStrukture.Location = new System.Drawing.Point(27, 110);
            this.gbLlojStrukture.Name = "gbLlojStrukture";
            this.gbLlojStrukture.Size = new System.Drawing.Size(326, 199);
            this.gbLlojStrukture.TabIndex = 25;
            this.gbLlojStrukture.Text = "Zgjidhni llojin e struktures";
            this.gbLlojStrukture.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // rbKompozitFuga
            // 
            this.rbKompozitFuga.AutoSize = true;
            this.rbKompozitFuga.Location = new System.Drawing.Point(25, 132);
            this.rbKompozitFuga.Name = "rbKompozitFuga";
            this.rbKompozitFuga.Size = new System.Drawing.Size(186, 17);
            this.rbKompozitFuga.TabIndex = 24;
            this.rbKompozitFuga.Text = "Veshje Kompoziti (sistemi me fuga)";
            this.rbKompozitFuga.UseVisualStyleBackColor = true;
            // 
            // rbKapak
            // 
            this.rbKapak.AutoSize = true;
            this.rbKapak.Location = new System.Drawing.Point(25, 99);
            this.rbKapak.Name = "rbKapak";
            this.rbKapak.Size = new System.Drawing.Size(109, 17);
            this.rbKapak.TabIndex = 22;
            this.rbKapak.Text = "Sistemi me Kapak";
            this.rbKapak.UseVisualStyleBackColor = true;
            // 
            // rbStruktural
            // 
            this.rbStruktural.AutoSize = true;
            this.rbStruktural.Checked = true;
            this.rbStruktural.Location = new System.Drawing.Point(25, 34);
            this.rbStruktural.Name = "rbStruktural";
            this.rbStruktural.Size = new System.Drawing.Size(106, 17);
            this.rbStruktural.TabIndex = 21;
            this.rbStruktural.TabStop = true;
            this.rbStruktural.Text = "Sistemi Struktural";
            this.rbStruktural.UseVisualStyleBackColor = true;
            // 
            // rbGjysemStruktural
            // 
            this.rbGjysemStruktural.AutoSize = true;
            this.rbGjysemStruktural.Location = new System.Drawing.Point(25, 67);
            this.rbGjysemStruktural.Name = "rbGjysemStruktural";
            this.rbGjysemStruktural.Size = new System.Drawing.Size(143, 17);
            this.rbGjysemStruktural.TabIndex = 20;
            this.rbGjysemStruktural.Text = "Sistemi Gjysem Struktural";
            this.rbGjysemStruktural.UseVisualStyleBackColor = true;
            // 
            // rbKompozitProfilH
            // 
            this.rbKompozitProfilH.AutoSize = true;
            this.rbKompozitProfilH.Location = new System.Drawing.Point(25, 166);
            this.rbKompozitProfilH.Name = "rbKompozitProfilH";
            this.rbKompozitProfilH.Size = new System.Drawing.Size(198, 17);
            this.rbKompozitProfilH.TabIndex = 23;
            this.rbKompozitProfilH.Text = "Veshje Kompoziti (sistemi me profil H)";
            this.rbKompozitProfilH.UseVisualStyleBackColor = true;
            // 
            // btnAnullo
            // 
            this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnullo.Image = global::PespaFasade.Properties.Resources.cancel;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(766, 484);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(87, 31);
            this.btnAnullo.TabIndex = 24;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click_1);
            // 
            // btnRuaj
            // 
            this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuaj.Image = global::PespaFasade.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(766, 429);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(87, 31);
            this.btnRuaj.TabIndex = 23;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPROJEKTIDataGridViewTextBoxColumn,
            this.eMERPROJEKTIDataGridViewTextBoxColumn,
            this.dATAPROJEKTIDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "PROJEKTE";
            this.dataGridView1.DataSource = this.dsPespaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 211);
            this.dataGridView1.TabIndex = 22;
            // 
            // gbProjekti
            // 
            this.gbProjekti.Controls.Add(this.label16);
            this.gbProjekti.Controls.Add(this.dtpDataProjekti);
            this.gbProjekti.Controls.Add(this.txtEmerProjekti);
            this.gbProjekti.Controls.Add(this.label14);
            this.gbProjekti.Location = new System.Drawing.Point(27, 22);
            this.gbProjekti.Name = "gbProjekti";
            this.gbProjekti.Size = new System.Drawing.Size(616, 60);
            this.gbProjekti.TabIndex = 21;
            this.gbProjekti.Text = "Te dhenat per projektin";
            this.gbProjekti.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Data per projektin";
            // 
            // dtpDataProjekti
            // 
            this.dtpDataProjekti.CustomFormat = "dd/MM/yyy    HH:mm";
            this.dtpDataProjekti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataProjekti.Location = new System.Drawing.Point(397, 28);
            this.dtpDataProjekti.Name = "dtpDataProjekti";
            this.dtpDataProjekti.ShowUpDown = true;
            this.dtpDataProjekti.Size = new System.Drawing.Size(200, 20);
            this.dtpDataProjekti.TabIndex = 2;
            // 
            // txtEmerProjekti
            // 
            this.txtEmerProjekti.Location = new System.Drawing.Point(102, 29);
            this.txtEmerProjekti.Name = "txtEmerProjekti";
            this.txtEmerProjekti.Size = new System.Drawing.Size(141, 20);
            this.txtEmerProjekti.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Emri i projektit";
            // 
            // iDPROJEKTIDataGridViewTextBoxColumn
            // 
            this.iDPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.HeaderText = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Name = "iDPROJEKTIDataGridViewTextBoxColumn";
            this.iDPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Visible = false;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Width = 2;
            // 
            // eMERPROJEKTIDataGridViewTextBoxColumn
            // 
            this.eMERPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "EMER_PROJEKTI";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Projekti";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Name = "eMERPROJEKTIDataGridViewTextBoxColumn";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Width = 120;
            // 
            // dATAPROJEKTIDataGridViewTextBoxColumn
            // 
            this.dATAPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "DATA_PROJEKTI";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Data e projektit";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Name = "dATAPROJEKTIDataGridViewTextBoxColumn";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Width = 130;
            // 
            // dsPespaBindingSource
            // 
            this.dsPespaBindingSource.DataSource = this.dsPespa;
            this.dsPespaBindingSource.Position = 0;
            // 
            // dsPespa
            // 
            this.dsPespa.DataSetName = "DsPespa";
            this.dsPespa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projekteTableAdapter
            // 
            this.projekteTableAdapter.ClearBeforeFill = true;
            // 
            // aksesoreTableAdapter
            // 
            this.aksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // projekte_dataTableAdapter
            // 
            this.projekte_dataTableAdapter.ClearBeforeFill = true;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // fasadaTableAdapter
            // 
            this.fasadaTableAdapter.ClearBeforeFill = true;
            // 
            // ShtoProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(924, 724);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "ShtoProjekt";
            this.Text = "Shto projekt";
            this.Load += new System.EventHandler(this.ShtoProjekt_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojStrukture)).EndInit();
            this.gbLlojStrukture.ResumeLayout(false);
            this.gbLlojStrukture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbProjekti)).EndInit();
            this.gbProjekti.ResumeLayout(false);
            this.gbProjekti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DsPespa dsPespa;
        private PespaFasade.DsPespaTableAdapters.PROJEKTETableAdapter projekteTableAdapter;
        private System.Windows.Forms.BindingSource dsPespaBindingSource;
        private PespaFasade.DsPespaTableAdapters.AKSESORETableAdapter aksesoreTableAdapter;
        private PespaFasade.DsPespaTableAdapters.PROJEKTE_DATATableAdapter projekte_dataTableAdapter;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private System.Windows.Forms.Button btnOK;
        private Janus.Windows.EditControls.UIGroupBox gbLlojStrukture;
        private System.Windows.Forms.RadioButton rbKompozitFuga;
        private System.Windows.Forms.RadioButton rbKapak;
        private System.Windows.Forms.RadioButton rbStruktural;
        private System.Windows.Forms.RadioButton rbGjysemStruktural;
        private System.Windows.Forms.RadioButton rbKompozitProfilH;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMERPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPROJEKTIDataGridViewTextBoxColumn;
        private Janus.Windows.EditControls.UIGroupBox gbProjekti;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDataProjekti;
        private System.Windows.Forms.TextBox txtEmerProjekti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnShto;
        private PespaFasade.DsPespaTableAdapters.PROFILETableAdapter profileTableAdapter;
        private PespaFasade.DsPespaTableAdapters.FASADATableAdapter fasadaTableAdapter;
    }
}
