namespace PespaFasade
{
    partial class Statistika
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblDateFillimi = new System.Windows.Forms.Label();
            this.lblDateMbarimi = new System.Windows.Forms.Label();
            this.dtpDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.dtpDateMbarimi = new System.Windows.Forms.DateTimePicker();
            this.gbStatistika = new Janus.Windows.EditControls.UIGroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsPespa = new PespaFasade.DsPespa();
            this.rbEmerProjekti = new Janus.Windows.EditControls.UIRadioButton();
            this.rbDate = new Janus.Windows.EditControls.UIRadioButton();
            this.txtEmerProjekti = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.dsStatistikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatistika = new PespaFasade.DsStatistika();
            this.projekteTableAdapter = new PespaFasade.DsStatistikaTableAdapters.PROJEKTETableAdapter();
            this.btnPrinto = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.iDPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMERPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShumaProjekti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHUMA_REALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatistika)).BeginInit();
            this.gbStatistika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnPrinto);
            this.panelEx1.Controls.Add(this.btnKerko);
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Controls.Add(this.gbStatistika);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(831, 582);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.txtEmerProjekti);
            this.uiGroupBox1.Controls.Add(this.rbDate);
            this.uiGroupBox1.Controls.Add(this.rbEmerProjekti);
            this.uiGroupBox1.Controls.Add(this.lblDateFillimi);
            this.uiGroupBox1.Controls.Add(this.lblDateMbarimi);
            this.uiGroupBox1.Controls.Add(this.dtpDateFillimi);
            this.uiGroupBox1.Controls.Add(this.dtpDateMbarimi);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 21);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(602, 114);
            this.uiGroupBox1.TabIndex = 38;
            this.uiGroupBox1.Text = "Kerko sipas...";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblDateFillimi
            // 
            this.lblDateFillimi.AutoSize = true;
            this.lblDateFillimi.Location = new System.Drawing.Point(190, 22);
            this.lblDateFillimi.Name = "lblDateFillimi";
            this.lblDateFillimi.Size = new System.Drawing.Size(54, 13);
            this.lblDateFillimi.TabIndex = 37;
            this.lblDateFillimi.Text = "Date fillimi";
            // 
            // lblDateMbarimi
            // 
            this.lblDateMbarimi.AutoSize = true;
            this.lblDateMbarimi.Location = new System.Drawing.Point(379, 22);
            this.lblDateMbarimi.Name = "lblDateMbarimi";
            this.lblDateMbarimi.Size = new System.Drawing.Size(68, 13);
            this.lblDateMbarimi.TabIndex = 36;
            this.lblDateMbarimi.Text = "Date mbarimi";
            // 
            // dtpDateFillimi
            // 
            this.dtpDateFillimi.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFillimi.Location = new System.Drawing.Point(150, 38);
            this.dtpDateFillimi.Name = "dtpDateFillimi";
            this.dtpDateFillimi.ShowUpDown = true;
            this.dtpDateFillimi.Size = new System.Drawing.Size(139, 20);
            this.dtpDateFillimi.TabIndex = 1;
            // 
            // dtpDateMbarimi
            // 
            this.dtpDateMbarimi.CustomFormat = "dd/MM/yyyy";
            this.dtpDateMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateMbarimi.Location = new System.Drawing.Point(350, 38);
            this.dtpDateMbarimi.Name = "dtpDateMbarimi";
            this.dtpDateMbarimi.ShowUpDown = true;
            this.dtpDateMbarimi.Size = new System.Drawing.Size(139, 20);
            this.dtpDateMbarimi.TabIndex = 2;
            // 
            // gbStatistika
            // 
            this.gbStatistika.BackColor = System.Drawing.Color.Transparent;
            this.gbStatistika.Controls.Add(this.dataGridView1);
            this.gbStatistika.Location = new System.Drawing.Point(12, 153);
            this.gbStatistika.Name = "gbStatistika";
            this.gbStatistika.Size = new System.Drawing.Size(737, 369);
            this.gbStatistika.TabIndex = 33;
            this.gbStatistika.Text = "Statistikat e projekteve";
            this.gbStatistika.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPROJEKTIDataGridViewTextBoxColumn,
            this.eMERPROJEKTIDataGridViewTextBoxColumn,
            this.dATAPROJEKTIDataGridViewTextBoxColumn,
            this.colShumaProjekti,
            this.SHUMA_REALE,
            this.DIFERENCA});
            this.dataGridView1.DataMember = "PROJEKTE";
            this.dataGridView1.DataSource = this.dsStatistikaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsPespa
            // 
            this.dsPespa.DataSetName = "DsPespa";
            this.dsPespa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbEmerProjekti
            // 
            this.rbEmerProjekti.Location = new System.Drawing.Point(15, 74);
            this.rbEmerProjekti.Name = "rbEmerProjekti";
            this.rbEmerProjekti.Size = new System.Drawing.Size(104, 23);
            this.rbEmerProjekti.TabIndex = 38;
            this.rbEmerProjekti.Text = "Emrit te projektit";
            // 
            // rbDate
            // 
            this.rbDate.Location = new System.Drawing.Point(15, 35);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(104, 23);
            this.rbDate.TabIndex = 39;
            this.rbDate.Text = "Dates";
            // 
            // txtEmerProjekti
            // 
            this.txtEmerProjekti.Location = new System.Drawing.Point(150, 77);
            this.txtEmerProjekti.Name = "txtEmerProjekti";
            this.txtEmerProjekti.Size = new System.Drawing.Size(139, 20);
            this.txtEmerProjekti.TabIndex = 40;
            // 
            // btnKerko
            // 
            this.btnKerko.Location = new System.Drawing.Point(655, 79);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(75, 23);
            this.btnKerko.TabIndex = 41;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // dsStatistikaBindingSource
            // 
            this.dsStatistikaBindingSource.DataSource = this.dsStatistika;
            this.dsStatistikaBindingSource.Position = 0;
            // 
            // dsStatistika
            // 
            this.dsStatistika.DataSetName = "DsStatistika";
            this.dsStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projekteTableAdapter
            // 
            this.projekteTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrinto
            // 
            this.btnPrinto.Location = new System.Drawing.Point(324, 528);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(75, 23);
            this.btnPrinto.TabIndex = 42;
            this.btnPrinto.Text = "Printo";
            this.btnPrinto.UseVisualStyleBackColor = true;
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // iDPROJEKTIDataGridViewTextBoxColumn
            // 
            this.iDPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.HeaderText = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.Name = "iDPROJEKTIDataGridViewTextBoxColumn";
            this.iDPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Visible = false;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Width = 5;
            // 
            // eMERPROJEKTIDataGridViewTextBoxColumn
            // 
            this.eMERPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "EMER_PROJEKTI";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Projekti";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Name = "eMERPROJEKTIDataGridViewTextBoxColumn";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Width = 200;
            // 
            // dATAPROJEKTIDataGridViewTextBoxColumn
            // 
            this.dATAPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "DATA_PROJEKTI";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Data e projektit";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Name = "dATAPROJEKTIDataGridViewTextBoxColumn";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Width = 150;
            // 
            // colShumaProjekti
            // 
            this.colShumaProjekti.DataPropertyName = "PREVENTIVI";
            this.colShumaProjekti.HeaderText = "Preventivi i projektit";
            this.colShumaProjekti.Name = "colShumaProjekti";
            this.colShumaProjekti.ReadOnly = true;
            // 
            // SHUMA_REALE
            // 
            this.SHUMA_REALE.DataPropertyName = "VLERA_REALE";
            this.SHUMA_REALE.HeaderText = "Vlera reale";
            this.SHUMA_REALE.Name = "SHUMA_REALE";
            this.SHUMA_REALE.ReadOnly = true;
            // 
            // DIFERENCA
            // 
            this.DIFERENCA.DataPropertyName = "DIFERENCA";
            this.DIFERENCA.HeaderText = "Diferenca";
            this.DIFERENCA.Name = "DIFERENCA";
            this.DIFERENCA.ReadOnly = true;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(831, 608);
            this.Controls.Add(this.panelEx1);
            this.Name = "Statistika";
            this.Text = "Statistikat e projekteve";
            this.Load += new System.EventHandler(this.Statistika_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatistika)).EndInit();
            this.gbStatistika.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DsPespa dsPespa;
        private Janus.Windows.EditControls.UIGroupBox gbStatistika;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label lblDateFillimi;
        private System.Windows.Forms.Label lblDateMbarimi;
        private System.Windows.Forms.DateTimePicker dtpDateFillimi;
        private System.Windows.Forms.DateTimePicker dtpDateMbarimi;
        private System.Windows.Forms.BindingSource dsStatistikaBindingSource;
        private DsStatistika dsStatistika;
        private Janus.Windows.EditControls.UIRadioButton rbDate;
        private Janus.Windows.EditControls.UIRadioButton rbEmerProjekti;
        private System.Windows.Forms.TextBox txtEmerProjekti;
        private System.Windows.Forms.Button btnKerko;
        private PespaFasade.DsStatistikaTableAdapters.PROJEKTETableAdapter projekteTableAdapter;
        private System.Windows.Forms.Button btnPrinto;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMERPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShumaProjekti;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHUMA_REALE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCA;
    }
}
