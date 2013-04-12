using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Zkouska
{
    public partial class Form1 : Form
    {
        Pes pes;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            traveniTimer.Start();
            minutaTimer.Start();
        }

        private void GenerujZpravu()
        {
            int cislo;
            Random random = new Random();
            cislo = random.Next(0, 100);
            string udalost = " ";

            if (cislo <= pes.Nalada)
            {                
                cislo = random.Next(0, 3);
                switch (cislo)
                {
                    case 1:
                        udalost = "Pes radostně zaštěkal";
                        break;
                    case 2:
                        udalost = "Pes honil motyla";
                        break;
                    case 3:
                        udalost = "upřeně na něco čučí";
                        break;

                    default:
                        udalost = "upřeně na něco čučí..";
                        break;
                }
            }
            else
            {
                cislo = random.Next(0, 3);
                switch (cislo)
                {
                    case 1:
                        udalost = "Pes na něco štěká";
                        break;
                    case 2:
                        udalost = "Pes zavrčel";
                        break;
                    case 3:
                        udalost = "Pes zavrčel na vás";
                        break;

                    default:
                        udalost = "Pes zavrčel na vás..";
                        break;
                }
                 
            }

            MessageBox.Show(udalost);
        }

        private void novyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NovyDialog dlg = new NovyDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pes = dlg.Pes;
                    Prepis();
                }

                pes = dlg.Pes;

                if (pes != null)
                {                    
                    Prepis();
                }
            }
        }

        private void Prepis()
        {
            jmenoLabel.Text = pes.Jmeno;

            naladaLabel.Text = pes.Nalada.ToString();
            laskaLabel.Text = pes.Laska.ToString();
            zaludekLabel.Text = pes.StavZaludku.ToString();
            if (pes.Zivot)
                zivotLabel.Text = "žije";
            else
                zivotLabel.Text = "nežije";

        }

        private void ulozitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(Pes));
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    xs.Serialize(fs, pes);
                }


            }
        }

        private void nacistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Pes));
                    pes = (Pes)xs.Deserialize(fs);
                }

            }
            Random random = new Random();
            pes.Nalada = (byte) random.Next(0, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pes != null)
            {
                GenerujZpravu();               

            }

        }

        private void traveniTimer_Tick(object sender, EventArgs e)
        {
            if (pes.StavZaludku <= 7)
                pes.StavZaludku = 0;
            else
                pes.StavZaludku -= 7;
        }

        private void minutaTimer_Tick(object sender, EventArgs e)
        {
            if (pes.StavZaludku <= 10)
            {
                if (pes.Nalada <= 2)
                    pes.Nalada = 0;
                else
                    pes.Nalada -= 2;
            }

            if (pes.Nalada <= 5)
            {
                if (pes.Laska <= 1)
                    pes.Laska = 0;
                else
                    pes.Laska -= 1;
            }

        }

        private void nakrmitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            pes.Nakrmit();
            Prepis();
        }

        private void pochvalitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pes.Pochvalit();
            Prepis();
        }

        private void pomazlitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pes.Pomazlit();
            Prepis();
        }

        private void potrestatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pes.Potrestat();
            Prepis();
        }

        private void vyvencitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pes.Vyvencit();
            Prepis();
        }

        private void opustitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void utratitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pes.Utratit();
            Prepis();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Josef Bína");
        }


        
    }
}
