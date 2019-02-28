using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class ShtoProjekt : PespaFasadeLibrary.Form
    {
        DataRow drProjekte;
        private int idProjekti = 0;
        public ShtoProjekt()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            //drProjektAksesore["ID_AKSESORE"] = 
        }

        private void ShtoProjekt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPespa.AKSESORE' table. You can move, or remove it, as needed.
            this.aksesoreTableAdapter.Fill(this.dsPespa.AKSESORE);
            projekteTableAdapter.Fill(dsPespa.PROJEKTE);
            //drProjekte = this.dsPespa.PROJEKTE.NewPROJEKTERow();
            //drProjekte["EMER_PROJEKTI"] = "";
            //drProjekte["DATA_PROJEKTI"] = dtpDataProjekti.Value;
            //this.dsPespa.PROJEKTE.Rows.Add(drProjekte);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }

        private void dtpDataProjekti_ValueChanged(object sender, EventArgs e)
        {
        }


        private void btnAnullo_Click(object sender, EventArgs e)
        {
            //this.dsPespa.Clear();
        }

        private void txtEmerProjekti_Validated(object sender, EventArgs e)
        {
            //this.projekteTableAdapter.InsertQuery(this.txtEmerProjekti.Text, this.dtpDataProjekti.Value);
        }

        private void btnShto_Click_2(object sender, EventArgs e)
        {
            if (this.txtEmerProjekti.Text.Trim() == "")
            {
                MessageBox.Show("Me pare duhet te percaktoni nje emer per projektin!", "Projekt i ri", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            DataRow dr = this.dsPespa.PROJEKTE.NewPROJEKTERow();
            dr["EMER_PROJEKTI"] = this.txtEmerProjekti.Text;
            dr["DATA_PROJEKTI"] = this.dtpDataProjekti.Value;
            dsPespa.PROJEKTE.Rows.Add(dr);
            this.projekteTableAdapter.InsertQuery1(this.txtEmerProjekti.Text, this.dtpDataProjekti.Value);
            this.dsPespa.PROJEKTE.Rows.Clear();
            this.projekteTableAdapter.Fill(dsPespa.PROJEKTE);
            idProjekti = Convert.ToInt32(this.dsPespa.PROJEKTE.Rows[dsPespa.PROJEKTE.Rows.Count - 1]["ID_PROJEKTI"]);
            MessageBox.Show("Projekti i ri u shtua me sukses!" + Environment.NewLine + "Zgjidhni njerin nga opsionet e dhena per te vazhduar me tej.",
                "Projekti i ri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btnShto.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtEmerProjekti.Text.Trim() == "")
            {
                MessageBox.Show("Me pare duhet te percaktoni  nje emer per projektin!", "Projekt i ri", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //this.projekteTableAdapter.InsertQuery(this.txtEmerProjekti.Text, this.dtpDataProjekti.Value);
            idProjekti = Convert.ToInt32(this.dsPespa.PROJEKTE.Rows[dsPespa.PROJEKTE.Rows.Count - 1]["ID_PROJEKTI"]);
            if (this.rbStruktural.Checked)
            {
                Siperfaqe siperfaqe = new Siperfaqe();
                siperfaqe.ShowDialog();
                ShtoStruktural struktural = new ShtoStruktural(idProjekti);
                struktural.lartesi = siperfaqe.lartesi;
                struktural.gjatesi = siperfaqe.gjatesi;
                struktural.siperfaqe = siperfaqe.siperfaqe;
                struktural.akseVert = siperfaqe.akseVertikal;
                struktural.akseHor = siperfaqe.akseHorizontal;
                struktural.ShowDialog();
                if (struktural.dtProjekteDataReturn != null)
                    this.dsPespa.PROJEKTE_DATA.Merge(struktural.dtProjekteDataReturn);
            }
        }

        private void btnRuaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.projekte_dataTableAdapter.Update(this.dsPespa.PROJEKTE_DATA);
                this.projekteTableAdapter.Update(this.dsPespa.PROJEKTE);
                decimal kosto = this.LlogaritKostoTotale();
                int idProjekti = Convert.ToInt32(this.dsPespa.PROJEKTE.Rows[dsPespa.PROJEKTE.Rows.Count - 1]["ID_PROJEKTI"]);
                this.projekteTableAdapter.UpdateQueryByPreventivi(kosto, idProjekti);
                MessageBox.Show("Hedhja e te dhenave ne baze u krye me sukses!", "Hedhja e te dhenave",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate hedhjes se te dhenave ne baze!", "Hedhja e te dhenave",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnShto.Enabled = true;
            }
        }

        private void btnAnullo_Click_1(object sender, EventArgs e)
        {
            this.dsPespa.PROJEKTE.Rows.Clear();
            this.projekteTableAdapter.Fill(dsPespa.PROJEKTE);
            if (this.dsPespa.PROJEKTE.Rows.Find(idProjekti) != null)
            {
                this.projekteTableAdapter.DeleteQueryByIdProjekti(idProjekti);
                this.dsPespa.PROJEKTE.Rows.Clear();
                this.projekteTableAdapter.Fill(dsPespa.PROJEKTE);
            }
        }

        /// <summary>
        /// Llogarit koston e aksesoreve dhe profileve te perdorura ne projekt, ne menyre qe 
        /// kjo kosto te ruhet ne bazen e te dhenave si preventiv.
        /// </summary>
        /// <returns></returns>
        private decimal LlogaritKostoTotale()
        {
            decimal kosto = 0;
            int idProjekti = 0;
            int idAksesori = 0;
            int cmimi = 0;
            decimal sasia = 0;
            // Percaktojme projektin e fundit qe eshte hedhur ne baze
            idProjekti = Convert.ToInt32(this.dsPespa.PROJEKTE.Rows[dsPespa.PROJEKTE.Rows.Count - 1]["ID_PROJEKTI"]);
            // Per cdo aksesor te perdorur ne projekt percaktojme cmimin total te tyre
            projekte_dataTableAdapter.FillByIdProjekti(dsPespa.PROJEKTE_DATA, idProjekti);
            foreach (DataRow dr in this.dsPespa.PROJEKTE_DATA.Rows)
            {
                // Nese aksesori i zgjedhur eshte aksesor, dmth as profil dhe as fasade
                if (Convert.IsDBNull(dr["ID_PROFILE"]) && Convert.IsDBNull(dr["ID_FASADA"]))
                {
                    idAksesori = Convert.ToInt32(dr["ID_AKSESORE"]);
                    cmimi = Convert.ToInt32(aksesoreTableAdapter.ScalarQueryByCmimi(idAksesori));
                }
                // Nese aksesori i zgjedhur eshte profil, dmth as aksesor i thjeshte dhe as fasade
                else if (Convert.IsDBNull(dr["ID_FASADA"]) && Convert.IsDBNull(dr["ID_AKSESORE"]))
                {
                    idAksesori = Convert.ToInt32(dr["ID_PROFILE"]);
                    cmimi = Convert.ToInt32(profileTableAdapter.ScalarQueryByCmimi((Int32)dr["ID_PROFILE"]));
                }
                // Nese aksesori i zgjedhur eshte fasade, dmth as aksesor i thjeshte dhe as profil
                else if (Convert.IsDBNull(dr["ID_PROFILE"]) && Convert.IsDBNull(dr["ID_AKSESORE"]))
                {
                    idAksesori = Convert.ToInt32(dr["ID_FASADA"]);
                    cmimi = Convert.ToInt32(fasadaTableAdapter.ScalarQueryByCmimi((Int32)dr["ID_FASADA"]));
                }
                // Pasi percaktojme cmimin per aksesor, percaktojme edhe sasine e cdo aksesori
                // Nese sasia eshte vetem ne cope
                if (!Convert.IsDBNull(dr["SASIA_COPE"]) && Convert.IsDBNull(dr["SASIA_ML"]) && Convert.IsDBNull(dr["SASIA_M2"])
                    && Convert.IsDBNull(dr["SASIA_KG"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIA_COPE"]);
                }
                // Nese sasia eshte vetem ne meter lineare
                else if (Convert.IsDBNull(dr["SASIA_COPE"]) && !Convert.IsDBNull(dr["SASIA_ML"]) && Convert.IsDBNull(dr["SASIA_M2"])
                    && Convert.IsDBNull(dr["SASIA_KG"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIA_ML"]);
                }
                // Nese sasia eshte vetem ne meter katrore
                else if (Convert.IsDBNull(dr["SASIA_COPE"]) && Convert.IsDBNull(dr["SASIA_ML"]) && !Convert.IsDBNull(dr["SASIA_M2"])
                    && Convert.IsDBNull(dr["SASIA_KG"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIAM2"]);
                }
                // Nese sasia eshte vetem ne kilogram
                else if (Convert.IsDBNull(dr["SASIA_COPE"]) && Convert.IsDBNull(dr["SASIA_ML"]) && Convert.IsDBNull(dr["SASIA_M2"])
                    && !Convert.IsDBNull(dr["SASIA_KG"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIA_KG"]);
                }
                // Nese sasia eshte edhe ne cope edhe ne meter lineare do te percaktojme se me cfare matet
                else if (!Convert.IsDBNull(dr["SASIA_COPE"]) && !Convert.IsDBNull(dr["SASIA_ML"]) && Convert.IsDBNull(dr["SASIA_M2"])
                    && Convert.IsDBNull(dr["SASIA_KG"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIA_ML"]);
                }
                // Fasadat maten me siperfaqen e tyre
                else if (!Convert.IsDBNull(dr["ID_FASADA"]))
                {
                    sasia = Convert.ToDecimal(dr["SASIA_M2"]);
                }

                kosto += sasia * cmimi;
            }
            projekte_dataTableAdapter.Fill(dsPespa.PROJEKTE_DATA);
            return kosto;
        }
    }
}

