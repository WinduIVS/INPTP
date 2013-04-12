using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LigaMistru
{
    public partial class LigaMistruForm : Form
    {
        private Hraci hraci = new Hraci();
        public LigaMistruForm()
        {
            InitializeComponent();
        }

        private void NastavHrace(Hrac hrac, ListViewItem lvi)
        {
            lvi.SubItems[0].Text = hrac.Jmeno;
            lvi.SubItems[1].Text = FotbalovyKlubInfo.DejNazev(hrac.Klub);
            //lvi.SubItems[1].Text = hrac.Klub.ToString();
            lvi.SubItems[2].Text = hrac.GolPocet.ToString();
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            using (HracDialog dlg = new HracDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    hraci.Pridej(dlg.Hrac);
                    ListViewItem lvi = new ListViewItem(new string[3]);
                    NastavHrace(dlg.Hrac, lvi);
                    hraciListView.Items.Add(lvi);
                }
            }
        }

        private void vymazatButton_Click(object sender, EventArgs e)
        {
            if (hraciListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Není vybrán žádný hráč", "Chyba",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hraciListView.BeginUpdate();
            try
            {
                while (hraciListView.SelectedIndices.Count > 0)
                {
                    hraci.Vymaz(hraciListView.SelectedIndices[0]);
                    hraciListView.Items.RemoveAt(hraciListView.SelectedIndices[0]);
                }
            }
            finally
            {
                hraciListView.EndUpdate();
            }
        }

        private void upravitButton_Click(object sender, EventArgs e)
        {
            if (hraciListView.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Není vybrán jeden hráč", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (HracDialog dlg = new HracDialog())
            {
                int selectedIndex = hraciListView.SelectedIndices[0];
                dlg.Hrac = hraci.DejHrace(selectedIndex);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    NastavHrace(dlg.Hrac, hraciListView.SelectedItems[0]);
                }
            }
        }
       
        private void konecButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hraciListView_DoubleClick(object sender, EventArgs e)
        {
            upravitButton.PerformClick();
        }

        private void nejlepsiButton_Click(object sender, EventArgs e)
        {
            FotbalovyKlub[] kluby;
            int golPocet;
            hraci.NajdiNejlepsiKluby(out kluby, out golPocet);
            using (NejlepsiKlubyDialog dlg = new NejlepsiKlubyDialog())
            {
                dlg.Kluby = kluby;
                dlg.GolPocet = golPocet;
                dlg.ShowDialog();
            }

        }

        private void registrovatButton_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen += new PocetZmenenEventHandler(hraci_PocetZmenen);
            protokolTextBox.AppendText("Registrován handler události.\r\n");
        }

        void hraci_PocetZmenen(object sender, PocetEventArgs e)
        {
            //protokolTextBox.Text += "=> Změněn počet hráčů, původní počet: " + e.Pocet + ", nový počet: " + hraci.Pocet + ".\r\n";
            protokolTextBox.AppendText("=> Změněn počet hráčů, původní počet: " + e.Pocet + ", nový počet: " + hraci.Pocet + ".\r\n");
        }

        private void zrusitButton_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen -= new PocetZmenenEventHandler(hraci_PocetZmenen);
            protokolTextBox.AppendText("Zrušena registrace handleru události.\r\n");
        }

        private void hraciListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
