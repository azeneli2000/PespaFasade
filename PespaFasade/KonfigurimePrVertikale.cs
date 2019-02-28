using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class KonfigurimePrVertikale : PespaFasadeLibrary.Form
    {
        public KonfigurimePrVertikale()
        {
            InitializeComponent();
        }

        private void rbPaRaport_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.rbPaRaport.Checked)
                
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int idAksesori = 0;
                idAksesori = Convert.ToInt32(this.listBox1.SelectedValue);
                this.txtEmerModifiko.Text = this.aksesoreTableAdapter1.ScalarQuery(idAksesori);
                this.txtPershkrimAksesori.Text = this.aksesoreTableAdapter1.ScalarQueryPershkrimAksesori(idAksesori);
                this.numCmimiModifiko.Value = Convert.ToDecimal(this.aksesoreTableAdapter1.ScalarQueryByCmimi(idAksesori));
                string formula = this.aksesoreTableAdapter1.ScalarQueryFormula(idAksesori);
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    this.numKoeficienti.Value = Convert.ToDecimal(str[0]);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            int idAksesori = 0;
            idAksesori = Convert.ToInt32(this.listBox1.SelectedValue);
            string formula = this.aksesoreTableAdapter1.ScalarQueryFormula(idAksesori);
            string[] str = formula.Split('*');
            if (str.Length == 2)
            {
                str[0] = this.numCmimiModifiko.Value.ToString();
            }
            this.aksesoreTableAdapter1.UpdateQueryProfile(this.txtEmerModifiko.Text, this.txtPershkrimAksesori.Text,
                Convert.ToInt32(this.numCmimiModifiko.Value), str[0] + "*" + str[1], idAksesori);
            MessageBox.Show("Te dhenat per aksesorin u modifikuan", "Modifikimi i aksesoreve", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void KonfigurimePrVertikale_Load(object sender, EventArgs e)
        {
            this.aksesoreTableAdapter.FillByIdProfili(this.dsPespa.AKSESORE, 1);
            DataRow dr = this.dsPespa.AKSESORE.NewAKSESORERow();
            dr["EMER_AKSESORI"] = "Profil vertikal";
            dr["PERSHKRIM_AKSESORI"] = "Profil vertikal";
            this.dsPespa.AKSESORE.Rows.Add(dr);
        }

        private void cmbVaresi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbVaresi_Validated(object sender, EventArgs e)
        {
            if (cmbVaresi.Text == "")
                this.cmbNjesiKoeficienti.Visible = true;
            else
                this.cmbNjesiKoeficienti.Visible = false;
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            int njesiaMl = 0;
            if (this.cmbNjesia.SelectedIndex == 0)
                njesiaMl = 0;
            else if (this.cmbNjesia.SelectedIndex == 1)
                njesiaMl = 1;
            else if (this.cmbNjesia.SelectedIndex == 2)
                njesiaMl = 2;
            else if (this.cmbNjesia.SelectedIndex == 3)
                njesiaMl = 3;
            DataRow dr = this.dsPespa.AKSESORE.NewAKSESORERow();
            dr["EMER_AKSESORI"] = this.txtEmerAksesori.Text;
            dr["PERSHKRIM_AKSESORI"] = this.txtPershkrimAksesori.Text;
            dr["NJESI_MATESE"] = njesiaMl;
            dr["CMIMI"] = this.numCmimi.Value;
            dr["FORMULA"] = LlogaritFormulen();
            dr["ID_PROFILI"] = 1;
            dr["ID_FASADA"] = Convert.DBNull;
            this.aksesoreTableAdapter.InsertQuery(this.txtEmerAksesori.Text, this.txtPershkrimAksesori.Text,
                njesiaMl, Convert.ToInt32(this.numCmimi.Value), LlogaritFormulen(), 1, null);
        }

        private string LlogaritFormulen()
        {
            int njesiaMl = 0;
            decimal koeficienti = 0;
            string formula = "";
            string emerAksesori = this.cmbVaresi.SelectedItem.ToString();
            //string koeficienti = 
            if (this.cmbNjesiKoeficienti.SelectedIndex == 0)
                njesiaMl = 0;
            else if (this.cmbNjesiKoeficienti.SelectedIndex == 1)
                njesiaMl = 1;
            else if (this.cmbNjesiKoeficienti.SelectedIndex == 2)
                njesiaMl = 2;
            else if (this.cmbNjesiKoeficienti.SelectedIndex == 3)
                njesiaMl = 3;
            koeficienti = this.numKoeficientVaresi.Value;
            // Nese varesia nuk eshte nga profili atehere shkruajme formulen
            if (this.cmbNjesiKoeficienti.Enabled == false)
            {
                formula = koeficienti.ToString() + "*" + this.cmbVaresi.SelectedValue.ToString();
            }
            else
            {
                if (njesiaMl == 0)
                {
                    formula = koeficienti.ToString() + "PrCop";
                }
                else if (njesiaMl == 1)
                    formula = koeficienti.ToString() + "PrGjat";
            }
            return formula;
        }

        private void cmbVaresi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.cmbVaresi.Text == "Profil vertikal")
                this.cmbNjesiKoeficienti.Enabled = true;
            else
                this.cmbNjesiKoeficienti.Enabled = false;
        }

        private void cmbVaresi_SelectedValueChanged(object sender, EventArgs e)
        {
        }

    }
}

