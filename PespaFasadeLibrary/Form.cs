using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasadeLibrary
{
    public partial class Form : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form mainForm;
        
        private string parentName;
        private bool tabControl = false;
        private string defaultErrorMessage;
        private bool shfaqTitull;
        /// <summary>
        /// Fushe private qe mban emrin e perdoruesit. Sherben
        /// per propertine Perdorues
        /// </summary>
        private string perdorues = "";

        public Form()
        {
            InitializeComponent();
            //this.panelEx1.SendToBack();
        }

        #region Public Properties


        [Description("Jep emrin e perdoruesit qe eshte loguar ne program")]
        [Category("Properti te shtuara")]
        public string Perdorues
        {
            get
            {
                return this.perdorues;
            }
            set
            {
                this.perdorues = value;
            }
        }


        public bool HasChanges
        {
            get
            {
                return false;
            }
        }




        /// <summary>
        /// Referon ne formen main
        /// </summary>
        [Description("Referon ne MainForm per kete forme")]
        [Category("Properti te shtuara")]
        public System.Windows.Forms.Form Main
        {
            get
            {
                return mainForm;
            }
            set
            {
                this.mainForm = value;
            }
        }


        /// <value>
        /// Ketu sherben vetem per IValidatable
        /// </value>
        [Description("Percakton mesazhin default te gabimit per formen")]
        [Category("Properti te shtuara")]
        public string DefaultErrorMessage
        {
            get
            {
                return defaultErrorMessage;
            }
            set
            {
                defaultErrorMessage = value;
            }
        }


        /// <summary>
        /// Properti booleane qe percakton nese labeli i titullit eshte visible ose jo
        /// </summary>
        [Description("Percakton nese labeli i titullit do te shfaqet apo jo")]
        [Category("Properti te shtuara")]
        public bool ShfaqTitull
        {
            get
            {
                return this.shfaqTitull;
            }
            set
            {
                this.shfaqTitull = value;
                if (this.shfaqTitull)
                    this.exPnStatus.TitleHeight = 26;
                else
                    this.exPnStatus.TitleHeight = 0;
            }
        }

        #endregion

        
        private void Form_Load(object sender, EventArgs e)
        {
            //this.panelEx1.SendToBack();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.exPnStatus.SendToBack();
            base.OnLoad(e);
            //this.lblStatus.Font = new Font("Arial", 10, FontStyle.Regular);
            //this.lblStatus.Text = "<font size=\"15\"> </font> <b> <font color=\"MidnightBlue\">" + this.Text + "</font></b>   <font color=\"desktop\" ><i>" 
            //    + DateTime.Now.ToString("dd/MM/yyyy - HH:mm") + "</i></font>";
            this.exPnStatus.Font = new Font("Arial", 10, FontStyle.Regular);
            this.exPnStatus.TitleText = "<font size=\"15\"> </font> <b> <font color=\"MidnightBlue\">" + this.Text + "</font></b>   <font color=\"desktop\" ><i>"
                + DateTime.Now.ToString("dd/MM/yyyy - HH:mm") + "</i></font>";
        }
    }
}