using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zkouska
{
    public partial class NovyDialog : Form
    {
        public Pes Pes { get; set; }

        public NovyDialog()
        {
            InitializeComponent();

        }
  
        private void novyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jmenoTextBox.Text))
            {
                MessageBox.Show("Jméno není vyplněno.", "Chyba", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                Pes = new Pes(jmenoTextBox.Text, DateTime.Now);
                Close();
            }

            
        }
    }
}
