 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class Siperfaqe : Form
    {
        public decimal siperfaqe = 0;
        public decimal gjatesi = 0;
        public decimal lartesi = 0;
        public decimal akseVertikal = 0;
        public decimal akseHorizontal = 0;
        public Siperfaqe()
        {
            InitializeComponent();
        }
 
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            gjatesi = this.numGjatesi.Value;
            lartesi = this.numLartesi.Value;
            siperfaqe = this.numGjatesi.Value * numLartesi.Value;
            akseVertikal = this.numAkseVert.Value;
            akseHorizontal = this.numAkseHor.Value;
            this.Close();
        }
    }
}