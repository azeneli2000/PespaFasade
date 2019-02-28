using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class ShtoStruktural : PespaFasadeLibrary.Form
    {
        public DataTable dtProjekteDataReturn = null;
        DataTable dtProjekteData;
        DataRow drProfileV;
        DataRow drProfileH;
        DataRow drKaset;
        int idProjekti = 0;
        public decimal gjatesi = 0;
        public decimal lartesi = 0;
        public decimal siperfaqe = 0;
        public decimal akseVert = 0;
        public decimal akseHor = 0;
        public ShtoStruktural()
        {
            InitializeComponent();
        }

        public ShtoStruktural(int idProjekt)
        {
            InitializeComponent();
            this.idProjekti = idProjekt;
            dtProjekteData = this.dsPespa.PROJEKTE_DATA;
            dtProjekteData.Rows.Clear();
        }

        private void ShtoStruktural_Load(object sender, EventArgs e)
        {
            // Krijojme dy rreshta te rinj: 1 per profilin horizontal dhe 1 per profilin vertikal
            drProfileH = this.dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
            drProfileV = this.dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
            drKaset = this.dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
            drProfileV["ID_PROFILE"] = 1;
            drProfileV["ID_PROJEKTE"] = idProjekti;
            drProfileH["ID_PROFILE"] = 2;
            drProfileH["ID_PROJEKTE"] = idProjekti;
            drKaset["ID_FASADA"] = 1;
            drKaset["ID_PROJEKTE"] = idProjekti;
            this.aksesoreTableAdapter.FillByIdProfili(dsPespa.AKSESORE, 1);
            this.aksesoreTableAdapter.FillByIdProfili(dsPespa1.AKSESORE, 2);
            this.aksesoreTableAdapter.FillByIdFasada(this.dsPespa2.AKSESORE, 1);
            this.numPV.Value = this.akseVert;
            this.numPH.Value = this.akseHor;
            if (this.akseVert > 0)
                this.numGjatPV.Value = this.gjatesi / this.akseVert;
            if (this.akseHor > 0)
                this.numGjatPH.Value = this.lartesi / this.akseHor;
            this.numKaset.Value = (this.akseHor - 1) * (this.akseVert - 1);
            this.numSipKaset.Value = this.numGjatPV.Value * this.numGjatPH.Value;
            this.numKaset.Value = Math.Floor((numPV.Value + numPH.Value) / 3);
            this.numGjatKaset.Value = (this.numGjatPV.Value * 2) + (this.numGjatPH.Value * 2);
        }

        #region Profile EventHandlers
        private void numPV_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per profilin vertikal atehere
            // do te hidhet nje vlere per profilin vertikal
            if (this.dtProjekteData.Select("ID_PROFILE = 1").Length == 0)
            {
                drProfileV["ID_FASADA"] = Convert.DBNull;
                drProfileV["ID_PROFILE"] = 1;
                drProfileV["ID_AKSESORE"] = Convert.DBNull;
                drProfileV["SASIA_COPE"] = this.numPV.Value;
                drProfileV["SASIA_ML"] = this.numSasiaPV.Value;
                this.dtProjekteData.Rows.Add(drProfileV);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve vertikale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_PROFILE = 1").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_COPE"] = this.numPV.Value;
            }

            // Bejme modifikimet e nevojshme per te futur te dhenat per sasine
            DataTable dt = aksesoreTableAdapter.GetDataByIdProfili(1);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga numri i profileve
                    if (varesia == "PrCop")
                    {
                        this.dgPV[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numPV.Value);
                    }
                    else if (varesia != "PrGjat")
                    {
                        // TODO: Kjo varesi nuk eshte e sakte. Eshte e tille per efekt prove.
                        this.dgPV[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.dgPV[3, 2].Value);
                    }
                }
            }
        }

        private void dgPV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblAksesori.Text = this.dgPV[1, e.RowIndex].Value.ToString();
            if (this.dgPV[3, e.RowIndex].Value != null)
                this.numSasiaPV.Value = Convert.ToDecimal(this.dgPV[3, e.RowIndex].Value);
            this.lblAksesori.Visible = true;
            this.numSasiaPV.Visible = true;
        }

        private void numGjatPV_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per profilin vertikal atehere
            // do te hidhet nje vlere per profilin vertikal
            if (this.dtProjekteData.Select("ID_PROFILE = 1").Length == 0)
            {
                drProfileV["ID_FASADA"] = Convert.DBNull;
                drProfileV["ID_PROFILE"] = 1;
                drProfileV["ID_AKSESORE"] = Convert.DBNull;
                drProfileV["SASIA_COPE"] = this.numPV.Value;
                drProfileV["SASIA_ML"] = this.numSasiaPV.Value;
                this.dtProjekteData.Rows.Add(drProfileV);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve vertikale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_PROFILE = 1").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_ML"] = this.numPV.Value;
            }
            DataTable dt = aksesoreTableAdapter.GetDataByIdProfili(1);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga numri i profileve
                    if (varesia == "PrGjat")
                    {
                        this.dgPV[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numGjatPV.Value);
                    }
                }
            }
        }

        private void numSasiaPV_Validated(object sender, EventArgs e)
        {
            if (this.dgPV.SelectedRows.Count > 0)
                this.dgPV[3, this.dgPV.SelectedRows[0].Index].Value = this.numSasiaPV.Value;
        }

        private void numPH_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per profilin horizontal atehere
            // do te hidhet nje vlere per profilin horizontal
            if (this.dtProjekteData.Select("ID_PROFILE = 2").Length == 0)
            {
                drProfileH["ID_FASADA"] = Convert.DBNull;
                drProfileH["ID_PROFILE"] = 2;
                drProfileH["ID_AKSESORE"] = Convert.DBNull;
                drProfileH["SASIA_COPE"] = this.numPH.Value;
                drProfileH["SASIA_ML"] = this.numSasiaPH.Value;
                this.dtProjekteData.Rows.Add(drProfileH);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve horizontale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_PROFILE = 2").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_COPE"] = this.numPH.Value;
            }

            // Bejme modifikimet e nevojshme per te futur te dhenat per sasine
            DataTable dt = aksesoreTableAdapter.GetDataByIdProfili(2);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga numri i profileve
                    if (varesia == "PrCop")
                    {
                        this.dgPH[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numPH.Value);
                    }
                    else if (varesia != "PrGjat")
                    {
                        // TODO: Kjo varesi nuk eshte e sakte. Eshte e tille per efekt prove.
                        this.dgPH[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.dgPH[3, 2].Value);
                    }
                }
            }
        }

        private void dgPH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblSasiaPH.Text = this.dgPH[1, e.RowIndex].Value.ToString();
            if (this.dgPH[3, e.RowIndex].Value != null)
                this.numSasiaPH.Value = Convert.ToDecimal(this.dgPH[3, e.RowIndex].Value);
            this.lblSasiaPH.Visible = true;
            this.numSasiaPH.Visible = true;
        }

        private void numGjatPH_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per profilin horizontal atehere
            // do te hidhet nje vlere per profilin horizontal
            if (this.dtProjekteData.Select("ID_PROFILE = 2").Length == 0)
            {
                drProfileH["ID_FASADA"] = Convert.DBNull;
                drProfileH["ID_PROFILE"] = 1;
                drProfileH["ID_AKSESORE"] = Convert.DBNull;
                drProfileH["SASIA_COPE"] = this.numPV.Value;
                drProfileH["SASIA_ML"] = this.numSasiaPV.Value;
                this.dtProjekteData.Rows.Add(drProfileH);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve vertikale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_PROFILE = 2").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_ML"] = this.numPV.Value;
            }
            DataTable dt = aksesoreTableAdapter.GetDataByIdProfili(1);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga numri i profileve
                    if (varesia == "PrGjat")
                    {
                        this.dgPH[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numGjatPH.Value);
                    }
                }
            }
        }

        private void numSasiaPH_Validated(object sender, EventArgs e)
        {
            if (this.dgPH.SelectedRows.Count > 0)
                this.dgPH[3, this.dgPH.SelectedRows[0].Index].Value = this.numSasiaPH.Value;
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                // Shtojme rreshtat e grides se profileve vertikale ne tabelen PROJEKTE_DATA
                for (int i = 0; i < this.dgPV.Rows.Count; i++)
                {
                    dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                    dr["ID_FASADA"] = Convert.DBNull;
                    dr["ID_PROFILE"] = Convert.DBNull;
                    dr["ID_AKSESORE"] = Convert.ToInt32(dgPV[0, i].Value);
                    if (Convert.ToInt32(dgPV[4, i].Value) == 0)
                    {
                        dr["SASIA_COPE"] = Convert.ToInt32(dgPV[3, i].Value);
                        dr["SASIA_ML"] = Convert.DBNull;
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    else if (Convert.ToInt32(dgPV[4, 1].Value) == 1)
                    {
                        dr["SASIA_COPE"] = Convert.DBNull;
                        dr["SASIA_ML"] = Convert.ToInt32(dgPV[3, i].Value);
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                }
                // Shtojme nje rresht ne tabelen PROJEKTE_DATA, qe i korrespondon profilit vertikal
                dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                dr["ID_FASADA"] = Convert.DBNull;
                dr["ID_PROFILE"] = 1;
                dr["ID_AKSESORE"] = Convert.DBNull;
                dr["SASIA_COPE"] = this.numPV.Value;
                dr["SASIA_ML"] = this.numGjatPV.Value;
                dr["SASIA_M2"] = Convert.DBNull;
                dr["SASIA_KG"] = Convert.DBNull;
                dr["ID_PROJEKTE"] = idProjekti;
                dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                // Shtojme rreshtat e grides se profileve horizontale ne tabelen PROJEKTE_DATA
                for (int i = 0; i < this.dgPH.Rows.Count; i++)
                {
                    dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                    dr["ID_FASADA"] = Convert.DBNull;
                    dr["ID_PROFILE"] = Convert.DBNull;
                    dr["ID_AKSESORE"] = Convert.ToInt32(dgPH[0, i].Value);
                    if (Convert.ToInt32(dgPH[4, i].Value) == 0)
                    {
                        dr["SASIA_COPE"] = Convert.ToInt32(dgPH[3, i].Value);
                        dr["SASIA_ML"] = Convert.DBNull;
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    else if (Convert.ToInt32(dgPV[4, 1].Value) == 1)
                    {
                        dr["SASIA_COPE"] = Convert.DBNull;
                        dr["SASIA_ML"] = Convert.ToInt32(dgPH[3, i].Value);
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                }
                // Shtojme nje rresht ne tabelen PROJEKTE_DATA, qe i korrespondon profilit vertikal
                dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                dr["ID_FASADA"] = Convert.DBNull;
                dr["ID_PROFILE"] = 2;
                dr["ID_AKSESORE"] = Convert.DBNull;
                dr["SASIA_COPE"] = this.numPH.Value;
                dr["SASIA_ML"] = this.numGjatPH.Value;
                dr["SASIA_M2"] = Convert.DBNull;
                dr["SASIA_KG"] = Convert.DBNull;
                dr["ID_PROJEKTE"] = idProjekti;
                dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                //projekte_dataTableAdapter.Update(this.dsPespa.PROJEKTE_DATA);
                MbushKasetat();
                //dtProjekteData.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate hedhjes se te dhenave", "Hedhja e te dhenave",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Kaseta EventHandlers
        /// <summary>
        /// Mbush te dhenat per kasetat duke i marre nga te dhenat e plotesuara me pare nga
        /// profilet vertikale dhe horizontale
        /// </summary>
        private void MbushKasetat()
        {
            this.numKaset.Value = this.numPV.Value / 2;
            this.numGjatKaset.Value = (this.numGjatPV.Value * 2) + (this.numGjatPH.Value * 2);
            this.numSipKaset.Value = (this.numGjatPV.Value * this.numGjatPH.Value);
        }

        private void numKaset_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per kaseten atehere
            // do te hidhet nje vlere per kaseten
            if (this.dtProjekteData.Select("ID_FASADA = 1").Length == 0)
            {
                drKaset["ID_FASADA"] = 1;
                drKaset["ID_PROFILE"] = Convert.DBNull;
                drKaset["ID_AKSESORE"] = Convert.DBNull;
                drKaset["SASIA_COPE"] = this.numKaset.Value;
                drKaset["SASIA_ML"] = this.numGjatKaset.Value;
                drKaset["SASIA_M2"] = this.numSipKaset.Value;
                this.dtProjekteData.Rows.Add(drKaset);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve vertikale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_FASADA = 1").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_COPE"] = this.numKaset.Value;
            }

            // Bejme modifikimet e nevojshme per te futur te dhenat per sasine
            DataTable dt = aksesoreTableAdapter.GetDataByIdFasada(1);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga numri i profileve
                    if (varesia == "KasCop")
                    {
                        this.dgKaset[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numKaset.Value);
                    }
                    else if (varesia != "KasGjat")
                    {
                        // TODO: Kjo varesi nuk eshte e sakte. Eshte e tille per efekt prove.
                        this.dgKaset[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.dgKaset[3, 2].Value);
                    }
                }
            }
        }

        private void numGjatKaset_Validated(object sender, EventArgs e)
        {
            // Nese akoma nuk kemi hedhur vlere ne dtProjekteData  per kaseten atehere
            // do te hidhet nje vlere per kaseten
            if (this.dtProjekteData.Select("ID_FASADA = 1").Length == 0)
            {
                drKaset["ID_FASADA"] = 1;
                drKaset["ID_PROFILE"] = Convert.DBNull;
                drProfileV["ID_AKSESORE"] = Convert.DBNull;
                drKaset["SASIA_COPE"] = this.numKaset.Value;
                drKaset["SASIA_ML"] = this.numGjatKaset.Value;
                drKaset["SASIA_M2"] = this.numSipKaset.Value;
                this.dtProjekteData.Rows.Add(drKaset);
            }
            // Perndryshe modifikojme vetem vleren per numrin e copeve te profileve vertikale
            else
            {
                DataRow dr1 = (DataRow)this.dtProjekteData.Select("ID_FASADA = 1").GetValue(0);
                dtProjekteData.Rows.Find(dr1["ID_PROJEKTE_DATA"])["SASIA_ML"] = this.numPV.Value;
            }
            DataTable dt = aksesoreTableAdapter.GetDataByIdFasada(1);
            double koeficient1 = 1;
            string varesia = "";
            foreach (DataRow dr in dt.Rows)
            {
                string formula = dr[5].ToString();
                string[] str = formula.Split('*');
                if (str.Length == 2)
                {
                    koeficient1 = Convert.ToDouble(str[0]);
                    varesia = str[1];
                    // Nese aksesori varet nga gjatesia e kasetes
                    if (varesia == "KasGjat")
                    {
                        this.dgKaset[3, dt.Rows.IndexOf(dr)].Value = koeficient1 * Convert.ToDouble(this.numGjatKaset.Value);
                    }
                }
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                // Shtojme rreshtat e grides se profileve vertikale ne tabelen PROJEKTE_DATA
                for (int i = 0; i < this.dgKaset.Rows.Count; i++)
                {
                    dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                    dr["ID_FASADA"] = Convert.DBNull;
                    dr["ID_PROFILE"] = Convert.DBNull;
                    dr["ID_AKSESORE"] = Convert.ToInt32(dgKaset[0, i].Value);
                    if (Convert.ToInt32(dgKaset[4, i].Value) == 0)
                    {
                        dr["SASIA_COPE"] = Convert.ToInt32(dgKaset[3, i].Value);
                        dr["SASIA_ML"] = Convert.DBNull;
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    else if (Convert.ToInt32(dgKaset[4, i].Value) == 1)
                    {
                        dr["SASIA_COPE"] = Convert.DBNull;
                        dr["SASIA_ML"] = Convert.ToInt32(dgKaset[3, i].Value);
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                }
                // Shtojme nje rresht ne tabelen PROJEKTE_DATA, qe i korrespondon kasetes
                dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                dr["ID_FASADA"] = 1;
                dr["ID_PROFILE"] = Convert.DBNull;
                dr["ID_AKSESORE"] = Convert.DBNull;
                dr["SASIA_COPE"] = this.numKaset.Value;
                dr["SASIA_ML"] = this.numGjatKaset.Value;
                dr["SASIA_M2"] = this.numSipKaset.Value;
                dr["SASIA_KG"] = Convert.DBNull;
                dr["ID_PROJEKTE"] = idProjekti;
                dsPespa.PROJEKTE_DATA.Rows.Add(dr);

                // Shtojme rreshtat e grides se profileve vertikale ne tabelen PROJEKTE_DATA
                for (int i = 0; i < this.dgPV.Rows.Count; i++)
                {
                    dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                    dr["ID_FASADA"] = Convert.DBNull;
                    dr["ID_PROFILE"] = Convert.DBNull;
                    dr["ID_AKSESORE"] = Convert.ToInt32(dgPV[0, i].Value);
                    if (Convert.ToInt32(dgPV[4, i].Value) == 0)
                    {
                        dr["SASIA_COPE"] = Convert.ToInt32(dgPV[3, i].Value);
                        dr["SASIA_ML"] = Convert.DBNull;
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    else if (Convert.ToInt32(dgPV[4, 1].Value) == 1)
                    {
                        dr["SASIA_COPE"] = Convert.DBNull;
                        dr["SASIA_ML"] = Convert.ToInt32(dgPV[3, i].Value);
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                }
                // Shtojme nje rresht ne tabelen PROJEKTE_DATA, qe i korrespondon profilit vertikal
                dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                dr["ID_FASADA"] = Convert.DBNull;
                dr["ID_PROFILE"] = 1;
                dr["ID_AKSESORE"] = Convert.DBNull;
                dr["SASIA_COPE"] = this.numPV.Value;
                dr["SASIA_ML"] = this.numGjatPV.Value;
                dr["SASIA_M2"] = Convert.DBNull;
                dr["SASIA_KG"] = Convert.DBNull;
                dr["ID_PROJEKTE"] = idProjekti;
                dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                // Shtojme rreshtat e grides se profileve horizontale ne tabelen PROJEKTE_DATA
                for (int i = 0; i < this.dgPH.Rows.Count; i++)
                {
                    dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                    dr["ID_FASADA"] = Convert.DBNull;
                    dr["ID_PROFILE"] = Convert.DBNull;
                    dr["ID_AKSESORE"] = Convert.ToInt32(dgPH[0, i].Value);
                    if (Convert.ToInt32(dgPH[4, i].Value) == 0)
                    {
                        dr["SASIA_COPE"] = Convert.ToInt32(dgPH[3, i].Value);
                        dr["SASIA_ML"] = Convert.DBNull;
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    else if (Convert.ToInt32(dgPV[4, 1].Value) == 1)
                    {
                        dr["SASIA_COPE"] = Convert.DBNull;
                        dr["SASIA_ML"] = Convert.ToInt32(dgPH[3, i].Value);
                        dr["SASIA_M2"] = Convert.DBNull;
                        dr["SASIA_KG"] = Convert.DBNull;
                        dr["ID_PROJEKTE"] = idProjekti;
                    }
                    dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                }
                // Shtojme nje rresht ne tabelen PROJEKTE_DATA, qe i korrespondon profilit vertikal
                dr = dsPespa.PROJEKTE_DATA.NewPROJEKTE_DATARow();
                dr["ID_FASADA"] = Convert.DBNull;
                dr["ID_PROFILE"] = 2;
                dr["ID_AKSESORE"] = Convert.DBNull;
                dr["SASIA_COPE"] = this.numPH.Value;
                dr["SASIA_ML"] = this.numGjatPH.Value;
                dr["SASIA_M2"] = Convert.DBNull;
                dr["SASIA_KG"] = Convert.DBNull;
                dr["ID_PROJEKTE"] = idProjekti;
                dsPespa.PROJEKTE_DATA.Rows.Add(dr);
                //projekte_dataTableAdapter.Update(this.dsPespa.PROJEKTE_DATA);

                this.dtProjekteDataReturn = dsPespa.PROJEKTE_DATA;
                MessageBox.Show("Te dhenat u ruajten me sukses.", "Hedhja e te dhenave", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate hedhjes se te dhenave", "Hedhja e te dhenave",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgKaset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblSasiaKaset.Text = this.dgKaset[1, e.RowIndex].Value.ToString();
            if (this.dgKaset[3, e.RowIndex].Value != null)
                this.numSasiaKaset.Value = Convert.ToDecimal(this.dgKaset[3, e.RowIndex].Value);
            this.lblSasiaKaset.Visible = true;
            this.numSasiaKaset.Visible = true;
        }
        
        private void numSasiaKaset_Validated(object sender, EventArgs e)
        {
            if (this.dgKaset.SelectedRows.Count > 0)
                this.dgKaset[3, this.dgKaset.SelectedRows[0].Index].Value = this.numSasiaKaset.Value;
        }

        #endregion

    }
}

