using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CvRozhrani
{
    public partial class CeleCisloDialog : Form
    {
        public CeleCisloDialog()
        {
            InitializeComponent();
        }
        public int Cislo { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            celeCisloTextBox.Text = Cislo.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult == DialogResult.OK && !e.Cancel)
            {
                int cislo;
                if (!int.TryParse(celeCisloTextBox.Text, out cislo))
                {
                    MessageBox.Show("Neplatné číslo", "chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (DialogResult == DialogResult.OK)
                Cislo = int.Parse(celeCisloTextBox.Text);
        }
    }
}
