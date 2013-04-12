namespace cv02HraPismen
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMissed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAccurancy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDificult = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 96;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(703, 131);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCorrect,
            this.toolStripMissed,
            this.toolStripTotal,
            this.toolStripAccurancy,
            this.toolStripDificult,
            this.difficultProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 109);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCorrect
            // 
            this.toolStripCorrect.Name = "toolStripCorrect";
            this.toolStripCorrect.Size = new System.Drawing.Size(58, 17);
            this.toolStripCorrect.Text = "Correct: 0";
            // 
            // toolStripMissed
            // 
            this.toolStripMissed.Name = "toolStripMissed";
            this.toolStripMissed.Size = new System.Drawing.Size(56, 17);
            this.toolStripMissed.Text = "Missed: 0";
            // 
            // toolStripTotal
            // 
            this.toolStripTotal.Name = "toolStripTotal";
            this.toolStripTotal.Size = new System.Drawing.Size(46, 17);
            this.toolStripTotal.Text = "Total: 0";
            // 
            // toolStripAccurancy
            // 
            this.toolStripAccurancy.Name = "toolStripAccurancy";
            this.toolStripAccurancy.Size = new System.Drawing.Size(85, 17);
            this.toolStripAccurancy.Text = "Accurancy: 0%";
            // 
            // toolStripDificult
            // 
            this.toolStripDificult.Name = "toolStripDificult";
            this.toolStripDificult.Size = new System.Drawing.Size(310, 17);
            this.toolStripDificult.Spring = true;
            this.toolStripDificult.Text = "Dificult";
            this.toolStripDificult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultProgressBar
            // 
            this.difficultProgressBar.Maximum = 1000;
            this.difficultProgressBar.Name = "difficultProgressBar";
            this.difficultProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 131);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hra";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCorrect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMissed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAccurancy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDificult;
        private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

