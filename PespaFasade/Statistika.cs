using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace PespaFasade
{
    public partial class Statistika : PespaFasadeLibrary.Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            decimal diferenca = 0;
            this.projekteTableAdapter.Fill(this.dsStatistika.PROJEKTE);
            // Vendosim vlerat e diferences per cdo rresht te tabeles PROJEKTE
            foreach (DataRow dr in this.dsStatistika.PROJEKTE.Rows)
            {
                diferenca = Convert.ToDecimal(dr["VLERA_REALE"]) - Convert.ToDecimal(dr["PREVENTIVI"]);
                dr["DIFERENCA"] = diferenca.ToString(".0");
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            decimal diferenca = 0;
            if (this.rbDate.Checked)
            {
                this.projekteTableAdapter.FillByDataProjekti(dsStatistika.PROJEKTE, this.dtpDateFillimi.Value,
                    this.dtpDateMbarimi.Value);
            }
            else if (this.rbEmerProjekti.Checked)
            {
                this.projekteTableAdapter.FillByEmer(dsStatistika.PROJEKTE, txtEmerProjekti.Text);
            }
            else
            {
                this.projekteTableAdapter.Fill(dsStatistika.PROJEKTE);
            }
            foreach (DataRow dr in this.dsStatistika.PROJEKTE.Rows)
            {
                diferenca = Convert.ToDecimal(dr["VLERA_REALE"]) - Convert.ToDecimal(dr["PREVENTIVI"]);
                dr["DIFERENCA"] = diferenca.ToString(".0");
            }
        }

        private void btnPrinto_Click(object sender, EventArgs e)
        {
            CrStatistika crStatistika = new CrStatistika();
            PrintDocument pDoc = new PrintDocument();
            string printerName = "";
            short printCopies = 1;
            pDoc.DocumentName = "Statistikat";
            printDialog.Document = pDoc;
            if (printDialog.ShowDialog() != DialogResult.OK)
                return;
            printerName = printDialog.PrinterSettings.PrinterName;
            printCopies = printDialog.PrinterSettings.Copies;
            crStatistika.SetDataSource(dsStatistika);
            crStatistika.PrintOptions.PrinterName = printerName;
            crStatistika.PrintToPrinter(printCopies, true, 0, 0);
        }
    }
}

