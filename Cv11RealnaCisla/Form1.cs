using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Globalization;
using System.IO;

namespace Cv_RealnaCisla
{
    public partial class Form1 : Form
    {
        private ArrayList cisla = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            jazykComboBox.SelectedIndex = 0;
        }

        private void konecButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void naplnListBox()
        {
            cislaListBox.BeginUpdate();
            try
            {
                cislaListBox.Items.Clear();
                foreach (double item in cisla)
                {
                    cislaListBox.Items.Add(item.ToString("N"));
                }
            }
            finally
            {
                cislaListBox.EndUpdate();
            }
        }

        private void generovatButton_Click(object sender, EventArgs e)
        {
            const int pocet = 22;
            const int minHodnota = 100;
            const int maxHodnota = 10000;
            cisla.Clear();
            cisla.Capacity = pocet;
            Random random = new Random();
            for (int i = 0; i < pocet; i++)
            {
                cisla.Add(random.NextDouble() * (maxHodnota - minHodnota) + minHodnota);
            }
            naplnListBox();
        }

        private void jazykComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (jazykComboBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture =
                       InputLanguage.DefaultInputLanguage.Culture;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                    break;
                case 3:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-PT");
                    break;
            }
            naplnListBox();
        }


        private void UlozTxtSoubor(string soubor)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(soubor, FileMode.Create, FileAccess.Write)))
            {
                foreach (double item in cisla)
                {
                    sw.WriteLine(item.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        private void UlozBinSoubor(string soubor)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create(soubor)))
            {
                foreach (double item in cisla)
                {
                    bw.Write(item);
                }
            }
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        UlozTxtSoubor(saveFileDialog.FileName);
                        break;
                    case 2:
                        UlozBinSoubor(saveFileDialog.FileName);
                        break;
                }
            }
        }

        private void NactiTxtSoubor(string soubor)
        {
            string retezec;
            using (StreamReader sr = new StreamReader(File.OpenRead(soubor)))
            {
                while (!sr.EndOfStream)
                {
                    retezec = sr.ReadLine();
                    cisla.Add(double.Parse(retezec, CultureInfo.InvariantCulture));
                }
            }
        }

        private void NactiBinSoubor(string soubor)
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(soubor)))
            {
                int pocet;
                pocet = (int)(br.BaseStream.Length / 8);
                cisla.Capacity = pocet;
                for (int i = 0; i < pocet; i++)
                {
                    cisla.Add(br.ReadDouble());
                }
            }
        }

        private void nacistButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cisla.Clear();
                try
                {
                    switch (openFileDialog.FilterIndex)
                    {
                        case 1:
                            NactiTxtSoubor(openFileDialog.FileName);
                            break;
                        case 2:
                            NactiBinSoubor(openFileDialog.FileName);
                            break;
                    }
                }
                catch
                {
                    cisla.Clear();
                }
                naplnListBox();
            }
        }


    }
}
