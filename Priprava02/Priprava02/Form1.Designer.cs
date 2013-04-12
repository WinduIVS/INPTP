namespace Priprava02
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.generujButton = new System.Windows.Forms.Button();
            this.ulozButton = new System.Windows.Forms.Button();
            this.nactiButton = new System.Windows.Forms.Button();
            this.vymazatButton = new System.Windows.Forms.Button();
            this.konecButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 160);
            this.listBox1.TabIndex = 0;
            // 
            // generujButton
            // 
            this.generujButton.Location = new System.Drawing.Point(22, 179);
            this.generujButton.Name = "generujButton";
            this.generujButton.Size = new System.Drawing.Size(75, 23);
            this.generujButton.TabIndex = 1;
            this.generujButton.Text = "Generuj";
            this.generujButton.UseVisualStyleBackColor = true;
            this.generujButton.Click += new System.EventHandler(this.generujButton_Click);
            // 
            // ulozButton
            // 
            this.ulozButton.Location = new System.Drawing.Point(103, 179);
            this.ulozButton.Name = "ulozButton";
            this.ulozButton.Size = new System.Drawing.Size(75, 23);
            this.ulozButton.TabIndex = 2;
            this.ulozButton.Text = "Uloz";
            this.ulozButton.UseVisualStyleBackColor = true;
            // 
            // nactiButton
            // 
            this.nactiButton.Location = new System.Drawing.Point(184, 179);
            this.nactiButton.Name = "nactiButton";
            this.nactiButton.Size = new System.Drawing.Size(75, 23);
            this.nactiButton.TabIndex = 3;
            this.nactiButton.Text = "Nacti";
            this.nactiButton.UseVisualStyleBackColor = true;
            // 
            // vymazatButton
            // 
            this.vymazatButton.Location = new System.Drawing.Point(22, 209);
            this.vymazatButton.Name = "vymazatButton";
            this.vymazatButton.Size = new System.Drawing.Size(75, 23);
            this.vymazatButton.TabIndex = 4;
            this.vymazatButton.Text = "Vymaz";
            this.vymazatButton.UseVisualStyleBackColor = true;
            // 
            // konecButton
            // 
            this.konecButton.Location = new System.Drawing.Point(184, 209);
            this.konecButton.Name = "konecButton";
            this.konecButton.Size = new System.Drawing.Size(75, 23);
            this.konecButton.TabIndex = 5;
            this.konecButton.Text = "Konec";
            this.konecButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.konecButton);
            this.Controls.Add(this.vymazatButton);
            this.Controls.Add(this.nactiButton);
            this.Controls.Add(this.ulozButton);
            this.Controls.Add(this.generujButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button generujButton;
        private System.Windows.Forms.Button ulozButton;
        private System.Windows.Forms.Button nactiButton;
        private System.Windows.Forms.Button vymazatButton;
        private System.Windows.Forms.Button konecButton;
    }
}

