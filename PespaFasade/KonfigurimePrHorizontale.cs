using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class KonfigurimePrHorizontale : PespaFasadeLibrary.Form
    {
        public KonfigurimePrHorizontale()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmerModifiko.Text = Convert.ToString(this.listBox1.SelectedItem);
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
            dr["ID_PROFILI"] = 2;
            dr["ID_FASADA"] = Convert.DBNull;
            this.aksesoreTableAdapter.InsertQuery(this.txtEmerAksesori.Text, this.txtPershkrimAksesori.Text,
                njesiaMl, Convert.ToInt32(this.numCmimi.Value), LlogaritFormulen(), 2, null);
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

        private void KonfigurimePrHorizontale_Load(object sender, EventArgs e)
        {
            // Shtohet nje rresht per profilin ne tabele thjesht per efekt te paraqitjes se profilit ne
            // kombot e formulave
            this.aksesoreTableAdapter.FillByIdProfili(this.dsPespa.AKSESORE, 2);
            DataRow dr = this.dsPespa.AKSESORE.NewAKSESORERow();
            dr["EMER_AKSESORI"] = "Profil horizontal";
            dr["PERSHKRIM_AKSESORI"] = "Profil horizontal";
            this.dsPespa.AKSESORE.Rows.Add(dr);
        }

        private void cmbVaresi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbVaresi.Text == "Profil horizontal")
                this.cmbNjesiKoeficienti.Enabled = true;
            else
                this.cmbNjesiKoeficienti.Enabled = false;
        }

        private void cmbVaresi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbVaresi.SelectedValue.ToString() == "Profil horizontal")
                this.cmbNjesiKoeficienti.Enabled = true;
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            try
            {
                string formula = "";
                int idAksesori = 0;
                idAksesori = Convert.ToInt32(this.listBox1.SelectedValue);
                formula = this.aksesoreTableAdapter1.ScalarQueryFormula(idAksesori);
                string[] str = formula.Split('*');
                str[0] = this.numKoeficienti.Value.ToString();
                formula = str[0] + "*" + str[1];
                this.aksesoreTableAdapter1.UpdateQuery1(this.txtEmerModifiko.Text, this.txtPershkrimAksesori.Text,
                    Convert.ToInt32(this.numCmimiModifiko.Value), formula, idAksesori);
                MessageBox.Show("Aksesori u modifikua!", "Modifikimi i aksesoreve", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate modifikimit te aksesorit!", "Modifikimi i aksesoreve",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            string formula = "";
            int idAksesori = 0;
            idAksesori = Convert.ToInt32(this.listBox1.SelectedValue);
            this.txtEmerModifiko.Text = this.aksesoreTableAdapter1.ScalarQuery(idAksesori);
            this.txtPershkrimAksesori.Text = this.aksesoreTableAdapter1.ScalarQueryPershkrimAksesori(idAksesori);
            this.numCmimiModifiko.Value = Convert.ToDecimal(this.aksesoreTableAdapter1.ScalarQueryByCmimi(idAksesori));
            formula = this.aksesoreTableAdapter1.ScalarQueryFormula(idAksesori);
            string[] str = formula.Split('*');
            if (str.Length == 2)
            {
                this.numKoeficienti.Value = Convert.ToDecimal(str[0]);
            }
        }

        private void btnElemino_Click(object sender, EventArgs e)
        {
            try
            {
                int idAksesori = 0;
                idAksesori = Convert.ToInt32(this.listBox1.SelectedValue);
                this.aksesoreTableAdapter.DeleteQuery(idAksesori);
                aksesoreTableAdapter.Update(dsPespa);
                MessageBox.Show("Aksesori u fshi me sukses!", "Fshirja e aksesoreve", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate fshirjes se aksesorit. Aksesori nuk u fshi!",
                    "Fshirja e aksesoreve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

