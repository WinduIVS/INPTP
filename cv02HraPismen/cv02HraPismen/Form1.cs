using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cv02HraPismen
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats statistika = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));

            if (listBox1.Items.Count > 7)
            {                
                timer1.Stop();
                MessageBox.Show("Game over!");
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over!");
            }

           

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > 400)
                    timer1.Interval -= 15;
                if (timer1.Interval > 250)
                    timer1.Interval -= 9;
                if (timer1.Interval > 100)
                    timer1.Interval -= 3;

                difficultProgressBar.Value = difficultProgressBar.Maximum - timer1.Interval;

                statistika.Update(true);
            }
            else
            {
                statistika.Update(false);
            }

            toolStripCorrect.Text = "Correct: " + statistika.Correct;
            toolStripMissed.Text = "Missed: " + statistika.Missed;
            toolStripTotal.Text = "Total: " + (statistika.Correct + statistika.Missed);
            toolStripAccurancy.Text = "Accuracy: " + statistika.Accuracy + " %";
        }
    }
}
