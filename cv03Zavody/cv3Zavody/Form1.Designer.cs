namespace cv3Zavody
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sazky = new System.Windows.Forms.GroupBox();
            this.vypisPoradi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zavodit = new System.Windows.Forms.Button();
            this.vsadit = new System.Windows.Forms.Button();
            this.vypisAl = new System.Windows.Forms.Label();
            this.vypisBob = new System.Windows.Forms.Label();
            this.vypisJoe = new System.Windows.Forms.Label();
            this.pesAl = new System.Windows.Forms.ComboBox();
            this.pesBob = new System.Windows.Forms.ComboBox();
            this.pesJoe = new System.Windows.Forms.ComboBox();
            this.sazkaAl = new System.Windows.Forms.NumericUpDown();
            this.sazkaBob = new System.Windows.Forms.NumericUpDown();
            this.sazkaJoe = new System.Windows.Forms.NumericUpDown();
            this.alPenize = new System.Windows.Forms.Label();
            this.bobPenize = new System.Windows.Forms.Label();
            this.joePenize = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.zavod = new System.Windows.Forms.GroupBox();
            this.sazky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaBob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaJoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            this.zavod.SuspendLayout();
            this.SuspendLayout();
            // 
            // sazky
            // 
            this.sazky.Controls.Add(this.vypisPoradi);
            this.sazky.Controls.Add(this.label5);
            this.sazky.Controls.Add(this.zavodit);
            this.sazky.Controls.Add(this.vsadit);
            this.sazky.Controls.Add(this.vypisAl);
            this.sazky.Controls.Add(this.vypisBob);
            this.sazky.Controls.Add(this.vypisJoe);
            this.sazky.Controls.Add(this.pesAl);
            this.sazky.Controls.Add(this.pesBob);
            this.sazky.Controls.Add(this.pesJoe);
            this.sazky.Controls.Add(this.sazkaAl);
            this.sazky.Controls.Add(this.sazkaBob);
            this.sazky.Controls.Add(this.sazkaJoe);
            this.sazky.Controls.Add(this.alPenize);
            this.sazky.Controls.Add(this.bobPenize);
            this.sazky.Controls.Add(this.joePenize);
            this.sazky.Location = new System.Drawing.Point(12, 250);
            this.sazky.Name = "sazky";
            this.sazky.Size = new System.Drawing.Size(800, 179);
            this.sazky.TabIndex = 0;
            this.sazky.TabStop = false;
            this.sazky.Text = "Sázky";
            // 
            // vypisPoradi
            // 
            this.vypisPoradi.AutoSize = true;
            this.vypisPoradi.Location = new System.Drawing.Point(616, 51);
            this.vypisPoradi.Name = "vypisPoradi";
            this.vypisPoradi.Size = new System.Drawing.Size(25, 13);
            this.vypisPoradi.TabIndex = 16;
            this.vypisPoradi.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(615, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pořadí";
            // 
            // zavodit
            // 
            this.zavodit.Location = new System.Drawing.Point(230, 147);
            this.zavodit.Name = "zavodit";
            this.zavodit.Size = new System.Drawing.Size(75, 23);
            this.zavodit.TabIndex = 14;
            this.zavodit.Text = "Zavodit";
            this.zavodit.UseVisualStyleBackColor = true;
            this.zavodit.Click += new System.EventHandler(this.zavodit_Click);
            // 
            // vsadit
            // 
            this.vsadit.Location = new System.Drawing.Point(105, 147);
            this.vsadit.Name = "vsadit";
            this.vsadit.Size = new System.Drawing.Size(75, 23);
            this.vsadit.TabIndex = 13;
            this.vsadit.Text = "Vsadit";
            this.vsadit.UseVisualStyleBackColor = true;
            this.vsadit.Click += new System.EventHandler(this.vsadit_Click);
            // 
            // vypisAl
            // 
            this.vypisAl.AutoSize = true;
            this.vypisAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vypisAl.Location = new System.Drawing.Point(390, 115);
            this.vypisAl.Name = "vypisAl";
            this.vypisAl.Size = new System.Drawing.Size(70, 20);
            this.vypisAl.TabIndex = 12;
            this.vypisAl.Text = "Al vsadil:";
            // 
            // vypisBob
            // 
            this.vypisBob.AutoSize = true;
            this.vypisBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vypisBob.Location = new System.Drawing.Point(390, 84);
            this.vypisBob.Name = "vypisBob";
            this.vypisBob.Size = new System.Drawing.Size(81, 20);
            this.vypisBob.TabIndex = 11;
            this.vypisBob.Text = "Bob vsadil";
            // 
            // vypisJoe
            // 
            this.vypisJoe.AutoSize = true;
            this.vypisJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vypisJoe.Location = new System.Drawing.Point(390, 51);
            this.vypisJoe.Name = "vypisJoe";
            this.vypisJoe.Size = new System.Drawing.Size(86, 20);
            this.vypisJoe.TabIndex = 10;
            this.vypisJoe.Text = "Joe vsadil: ";
            // 
            // pesAl
            // 
            this.pesAl.FormattingEnabled = true;
            this.pesAl.Items.AddRange(new object[] {
            "Pes 1",
            "Pes 2",
            "Pes 3"});
            this.pesAl.Location = new System.Drawing.Point(220, 113);
            this.pesAl.Name = "pesAl";
            this.pesAl.Size = new System.Drawing.Size(121, 21);
            this.pesAl.TabIndex = 9;
            // 
            // pesBob
            // 
            this.pesBob.FormattingEnabled = true;
            this.pesBob.Items.AddRange(new object[] {
            "Pes 1",
            "Pes 2",
            "Pes 3"});
            this.pesBob.Location = new System.Drawing.Point(220, 81);
            this.pesBob.Name = "pesBob";
            this.pesBob.Size = new System.Drawing.Size(121, 21);
            this.pesBob.TabIndex = 8;
            // 
            // pesJoe
            // 
            this.pesJoe.FormattingEnabled = true;
            this.pesJoe.Items.AddRange(new object[] {
            "Pes 1",
            "Pes 2",
            "Pes 3"});
            this.pesJoe.Location = new System.Drawing.Point(220, 48);
            this.pesJoe.Name = "pesJoe";
            this.pesJoe.Size = new System.Drawing.Size(121, 21);
            this.pesJoe.TabIndex = 7;
            // 
            // sazkaAl
            // 
            this.sazkaAl.Location = new System.Drawing.Point(118, 113);
            this.sazkaAl.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.sazkaAl.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sazkaAl.Name = "sazkaAl";
            this.sazkaAl.Size = new System.Drawing.Size(52, 20);
            this.sazkaAl.TabIndex = 6;
            this.sazkaAl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // sazkaBob
            // 
            this.sazkaBob.Location = new System.Drawing.Point(119, 81);
            this.sazkaBob.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.sazkaBob.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sazkaBob.Name = "sazkaBob";
            this.sazkaBob.Size = new System.Drawing.Size(51, 20);
            this.sazkaBob.TabIndex = 5;
            this.sazkaBob.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // sazkaJoe
            // 
            this.sazkaJoe.Location = new System.Drawing.Point(120, 49);
            this.sazkaJoe.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.sazkaJoe.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sazkaJoe.Name = "sazkaJoe";
            this.sazkaJoe.Size = new System.Drawing.Size(50, 20);
            this.sazkaJoe.TabIndex = 4;
            this.sazkaJoe.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // alPenize
            // 
            this.alPenize.AutoSize = true;
            this.alPenize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alPenize.Location = new System.Drawing.Point(25, 114);
            this.alPenize.Name = "alPenize";
            this.alPenize.Size = new System.Drawing.Size(73, 20);
            this.alPenize.TabIndex = 3;
            this.alPenize.Text = "Al (100$)";
            // 
            // bobPenize
            // 
            this.bobPenize.AutoSize = true;
            this.bobPenize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bobPenize.Location = new System.Drawing.Point(10, 81);
            this.bobPenize.Name = "bobPenize";
            this.bobPenize.Size = new System.Drawing.Size(88, 20);
            this.bobPenize.TabIndex = 2;
            this.bobPenize.Text = "Bob (100$)";
            // 
            // joePenize
            // 
            this.joePenize.AutoSize = true;
            this.joePenize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.joePenize.Location = new System.Drawing.Point(13, 48);
            this.joePenize.Name = "joePenize";
            this.joePenize.Size = new System.Drawing.Size(85, 20);
            this.joePenize.TabIndex = 1;
            this.joePenize.Text = "Joe (100$)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(-154, 96);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(200, 61);
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(-154, 163);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(200, 61);
            this.dog3.TabIndex = 2;
            this.dog3.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(-154, 19);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(200, 61);
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // zavod
            // 
            this.zavod.BackColor = System.Drawing.Color.White;
            this.zavod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zavod.BackgroundImage")));
            this.zavod.Controls.Add(this.dog1);
            this.zavod.Controls.Add(this.dog3);
            this.zavod.Controls.Add(this.dog2);
            this.zavod.Location = new System.Drawing.Point(11, 12);
            this.zavod.Name = "zavod";
            this.zavod.Size = new System.Drawing.Size(800, 230);
            this.zavod.TabIndex = 4;
            this.zavod.TabStop = false;
            this.zavod.Text = "Závod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 441);
            this.Controls.Add(this.zavod);
            this.Controls.Add(this.sazky);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sazky.ResumeLayout(false);
            this.sazky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaBob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sazkaJoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            this.zavod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sazky;
        private System.Windows.Forms.Label vypisAl;
        private System.Windows.Forms.Label vypisBob;
        private System.Windows.Forms.Label vypisJoe;
        private System.Windows.Forms.ComboBox pesAl;
        private System.Windows.Forms.ComboBox pesBob;
        private System.Windows.Forms.ComboBox pesJoe;
        private System.Windows.Forms.NumericUpDown sazkaAl;
        private System.Windows.Forms.NumericUpDown sazkaBob;
        private System.Windows.Forms.NumericUpDown sazkaJoe;
        private System.Windows.Forms.Label alPenize;
        private System.Windows.Forms.Label bobPenize;
        private System.Windows.Forms.Label joePenize;
        private System.Windows.Forms.Button zavodit;
        private System.Windows.Forms.Button vsadit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.GroupBox zavod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vypisPoradi;
    }
}

