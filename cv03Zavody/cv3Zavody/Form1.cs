using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cv3Zavody
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        bool f1,f2,f3;

        Guy Al = new Guy();
        Guy Joe = new Guy();
        Guy Bob = new Guy();  

        Dog Pes1 = new Dog("Pes 1");
        Dog Pes2 = new Dog("Pes 2");
        Dog Pes3 = new Dog("Pes 3");

        Dog[] dog = new Dog[3];
        List<Dog> poradiPsu = new List<Dog>();

        Bet betAl = new Bet();
        Bet betJoe = new Bet();
        Bet betBob = new Bet();
             
        
        public Form1()
        {
            InitializeComponent();
            
            dog[0] = Pes1;
            dog[1] = Pes2;
            dog[2] = Pes3;
            
        }

        private void vsadit_Click(object sender, EventArgs e)
        {

            if (Al.getMoney() < (int)sazkaAl.Value & pesAl.Text != "")
            {
                MessageBox.Show("Al nemá dostatek peněz");
                return;
            }
            if (Bob.getMoney() < (int)sazkaBob.Value & pesBob.Text != "")
            {
                MessageBox.Show("Bob nemá dostatek peněz");
                return;
            }
            if (Joe.getMoney() < (int)sazkaJoe.Value & pesJoe.Text != "")
            {
                MessageBox.Show("Joe nemá dostatek peněz");
                return;
            }

            //Al
            if (pesAl.Text == "")
            {
                betAl.vsadit(null, null, 0);
                vypisAl.Text = "Al nevsadil.";

            }
            else
            {
                betAl.vsadit(Al, dog[pesAl.SelectedIndex], (int)sazkaAl.Value);
                vypisAl.Text = "Al vsadil na: " + betAl.getPes().jmeno + " za: " + (int)sazkaAl.Value + "$";
            }


            //Bob
            if (pesBob.Text == "")
            {
                betBob.vsadit(null, null, 0);
                vypisBob.Text = "Bob nevsadil.";
            }
            else
            {
                betBob.vsadit(Bob, dog[pesBob.SelectedIndex], (int)sazkaBob.Value);
                vypisBob.Text = "Bob vsadil na: " + dog[pesBob.SelectedIndex].jmeno + " za: " + (int)sazkaBob.Value + "$";
            }

            //Joe
            if (pesJoe.Text == "")
            {
                betJoe.vsadit(null, null, 0);
                vypisJoe.Text = "Joe nevsadil.";
            }
            else
            {
                betJoe.vsadit(Joe, dog[pesJoe.SelectedIndex], (int)sazkaJoe.Value);
                vypisJoe.Text = "Joe vsadil na: " + dog[pesJoe.SelectedIndex].jmeno + " za: " + (int)sazkaJoe.Value + "$";
            }

            alPenize.Text = "Al (" + Al.getMoney().ToString() + "$)";
            bobPenize.Text = "Bob (" + Bob.getMoney().ToString() + "$)";
            joePenize.Text = "Joe (" + Joe.getMoney().ToString() + "$)";

            vsadit.Enabled = false;        

        }

        private void zavodit_Click(object sender, EventArgs e)
        {
            f1 = f2 = f3 = true;
            dog1.Left = dog2.Left = dog3.Left = -100;
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dog1.Left = dog1.Left + random.Next(2,25);           
            if (dog1.Left >= 800 & f1)
            {
                poradiPsu.Add(Pes1);
                prepisPoradi();
                f1 = false;
            }

            dog2.Left = dog2.Left + random.Next(2,25);
            if (dog2.Left >= 800 & f2)
            {
                poradiPsu.Add(Pes2);
                prepisPoradi();
                f2 = false;
            }

            dog3.Left = dog3.Left + random.Next(2,25); ;
            if (dog3.Left >= 800 & f3)
            {
                poradiPsu.Add(Pes3);
                prepisPoradi();
                f3 = false;
            }

            if (!f1 & !f2 & !f3)//konec zavodu
            {
                vypisPoradi.Text += "-----------";
                timer1.Stop();
                vypisAl.Text = vypisBob.Text = vypisJoe.Text = "";
                if (betAl.getPes() == poradiPsu[0])
                {
                    betAl.vyhra();
                    vypisAl.Text = "Al vyhrál.";
                }
                if (betBob.getPes() == poradiPsu[0])
                {
                    betBob.vyhra();
                    vypisBob.Text = "Bob vyhrál.";
                }
                if (betJoe.getPes() == poradiPsu[0])
                {
                    betJoe.vyhra();
                    vypisJoe.Text = "Joe vyhrál.";
                }

                alPenize.Text = "Al (" + Al.getMoney().ToString() + "$)";
                bobPenize.Text = "Bob (" + Bob.getMoney().ToString() + "$)";
                joePenize.Text = "Joe (" + Joe.getMoney().ToString() + "$)";

                pesAl.ResetText();
                pesJoe.ResetText();
                pesBob.ResetText();

                poradiPsu.Clear();

                vsadit.Enabled = true;
            }
            
        }


        private void prepisPoradi()
        {
            string jm = "";
            for (int i = 0; i < poradiPsu.Count; i++)
            {
                jm += i+1 + ": " + poradiPsu.ElementAt(i).jmeno + "\n";
            }
            vypisPoradi.Text = jm;
        }

        
    }
}
