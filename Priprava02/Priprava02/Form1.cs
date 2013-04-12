using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Priprava02
{
    public partial class Form1 : Form
    {
        ArrayList cisla = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void generujButton_Click(object sender, EventArgs e)
        {
            int pocet = 20;
            int max = 10000;
            int min = 100;

            Random random = new Random();
            for (int i = 0; i < pocet; i++)
            {
                cisla.Add(((max - min) * random.NextDouble()) + min);
            }

            foreach (var item in cisla)
            {
                listBox1.Items.Add(item);   
            }
            
        }
    }
}
