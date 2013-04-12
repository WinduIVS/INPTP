using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cv05Beehive
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            Worker[] workers = new Worker[]{
                new Worker(new string[] {"Patrol", "Egg care"}),
                new Worker(new string[] {"Baby bee tutoring", "Honey manufacturing"}),
                new Worker(new string[] {"Nectar collector"}),
                new Worker(new string[] {"Honey manufacturing", "Patrol", "Nectar collector"})

            };

            queen = new Queen(workers);
        }

        private void work_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)numericUpDown1.Value))
                MessageBox.Show("The job " + comboBox1.Text);


            else
                MessageBox.Show("něco");

        }

        private void assign_Click(object sender, EventArgs e)
        {
            report.AppendText("\r\n" + queen.WorkTheNextShift());
        }
    }
}
