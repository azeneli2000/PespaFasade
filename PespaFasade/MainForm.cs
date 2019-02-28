using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaFasade
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void shtoProjektToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new ShtoProjekt());
        }

        #region Private Methods
        private void AddNewTab(PespaFasadeLibrary.Form frm)
        {
            try
            {
                Type tipi = frm.GetType();
                int indeks = this.GetFormIndex(tipi);
                // Mund te kemi vetem nje forme te nje lloji te hapur
                if (indeks != -1)
                {
                    // Kemi nje forme te hapur ne MainForm
                    this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[indeks];
                    this.tabStrip1.SelectedTabIndex = indeks;
                    return;
                }
                DocumentManager.Document doc = new DocumentManager.Document(frm, frm.Text);
                frm.MdiParent = this;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Main = this;
                frm.ControlBox = false;
                // Vendosim propertine AutoScroll ne true, ne menyre qe programi te punoje me te gjitha
                // rezolucionet, megjithate aplikacioni punon me mire me rezolucionin 1024 x 768 
                if (frm.Name != "FaqeKryesore")
                {
                    frm.AutoScroll = true;
                    //this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
                    //this.pnlNdihme.AutoHideActive = false;
                    //this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
                    //this.faqeKryesore = false;
                }
                else
                {
                    frm.AutoScroll = false;
                    //this.pnlNdihme.Width = 200;
                    //this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                    //this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                    //this.faqeKryesore = true;
                }
                this.docManager.AddDocument(doc);
                DevComponents.DotNetBar.TabItem tab = new DevComponents.DotNetBar.TabItem();
                tab.Text = frm.Text;
                this.tabStrip1.Tabs.Add(tab);
                this.docManager.FocusedDocument = doc;
                this.tabStrip1.SelectedTabIndex = this.docManager.TabStrips[0].Documents.Count - 1;
            }
            catch (Exception ex)
            {
                //VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
                return;
            }

        }

        /// <summary>
        /// Kthen indeksin e formes ne tab, nese kjo forme gjendet; perndryshe kthen -1
        /// </summary>
        /// <param name="formType">Forma</param>
        /// <returns>Indeksin</returns>
        private int GetFormIndex(Type formType)
        {
            if (this.docManager.TabStrips.Count > 0)
            {
                for (int i = 0; i < this.docManager.TabStrips[0].Documents.Count; i++)
                {
                    if (this.docManager.TabStrips[0].Documents[i].Control.GetType() == formType)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AddNewTab(new FaqeKryesore());
        }

        private void profileVertikaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimePrVertikale());
        }

        private void profileHorizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimePrHorizontale());
        }

        private void docManager_CloseButtonPressed(object sender, DocumentManager.CloseButtonPressedEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaFasadeLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaFasadeLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
            }
        }

        private bool CloseForm(System.Windows.Forms.Form sysForm, DocumentManager.Document focusedDocument)
        {
            if (sysForm != null)
            {
                sysForm.ActiveControl = null;
                this.docManager.FocusedDocument = focusedDocument;
                sysForm.Close();
                return true;

            }
            return false;
        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kasetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(new KonfigurimeKasete());
        }

        private void tabStrip1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[tabStrip1.SelectedTabIndex];
        }

        private void tabStrip1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaFasadeLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaFasadeLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
                this.tabStrip1.Tabs.RemoveAt(this.tabStrip1.SelectedTabIndex);
            }
        }

        private void futVlereRealePerProjektinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FutVlereReale futVlere = new FutVlereReale();
            futVlere.ShowDialog();
        }

        private void diferencaEProjekteveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(new Statistika());
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

    }
}