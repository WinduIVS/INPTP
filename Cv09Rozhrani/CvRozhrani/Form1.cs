using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CvRozhrani
{
    public partial class Form1 : Form
    {
        IntSeznam intSeznam = new IntSeznam();
        public Form1()
        {
            InitializeComponent();
        }

        private void NaplnListBox(IEnumerable kolekce)
        {
            celaCislaListBox.BeginUpdate();
            try
            {
                celaCislaListBox.Items.Clear();
                foreach (int item in kolekce)
                {
                    celaCislaListBox.Items.Add(item);
                }
            }
            finally
            {
                celaCislaListBox.EndUpdate();
                AktualizujLabel();
            }
        }

        private void generovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                intSeznam.PridejNaKonec(rnd.Next(30));
            }
            NaplnListBox(intSeznam);
        }

        private void přidatNaZačátekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CeleCisloDialog dlg = new CeleCisloDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    intSeznam.PridejNaZacatek(dlg.Cislo);
                    celaCislaListBox.Items.Insert(0, dlg.Cislo);
                    AktualizujLabel();
                }
            }
        }

        private void přidatNaKonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CeleCisloDialog dlg = new CeleCisloDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    intSeznam.PridejNaKonec(dlg.Cislo);
                    celaCislaListBox.Items.Add(dlg.Cislo);
                    AktualizujLabel();
                }
            }
        }

        private void vymazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (celaCislaListBox.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Nejsou vybrána žádná čísla", "chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            celaCislaListBox.BeginUpdate();
            try
            {
                while (celaCislaListBox.SelectedItem != null)
                {
                    intSeznam.Vymaz((int)celaCislaListBox.SelectedItems[0]);
                    celaCislaListBox.Items.RemoveAt(celaCislaListBox.SelectedIndices[0]);
                }
            }
            finally
            {
                celaCislaListBox.EndUpdate();
                AktualizujLabel();
            }
        }

        private void OdstranDuplicitu(ISeznam seznam)
        {
            Seznam pomSeznam = new Seznam();
            int index1 = 0, index2;
            foreach (var item in seznam)
            {
                index2 = 0;
                foreach (var item2 in seznam)
                {
                    if (item.Equals(item2) && index1 < index2)
                    {
                        pomSeznam.PridejNaKonec(item);
                    }
                    index2++;
                }
                index1++;
            }
            foreach (var item in pomSeznam)
            {
                seznam.Vymaz(item);
            }
        }

        private void vymazatDuplicityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdstranDuplicitu(intSeznam);
            NaplnListBox(intSeznam);
        }

        private void seřaditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intSeznam.Serad();
            NaplnListBox(intSeznam);
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Jste si jistí, že chcete zavřít program?",
                "Skurečně zavřít?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void AktualizujLabel()
        {
            pocetLabel.Text = celaCislaListBox.Items.Count.ToString();
        }
    }
}
