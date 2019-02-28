using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class FutVlereReale : PespaFasadeLibrary.Form
    {
        public FutVlereReale()
        {
            InitializeComponent();
        }

        private void FutVlereReale_Load(object sender, EventArgs e)
        {
            this.projekteTableAdapter1.Fill(this.dsPespa1.PROJEKTE);
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            this.projekteTableAdapter1.UpdateQueryByVleraReale(this.numericUpDown1.Value, (Int32)this.cmbProjekti.SelectedValue);
            MessageBox.Show("Vlerat u ruajten me sukses", "Hedhja e kostos se projekteve", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void cmbProjekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.Value = Convert.ToDecimal(this.projekteTableAdapter1.ScalarQueryByCmimi((Int32)this.cmbProjekti.SelectedValue));
            //this.projekteTableAdapter1.GetDataByIdProjekti(Convert.ToInt32(this.cmbProjekti.SelectedValue));
        }
    }
}

