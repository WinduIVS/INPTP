namespace CvRozhrani
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatNaZačátekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatNaKonecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vymazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vymazatDuplicityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seřaditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.celaCislaListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pocetLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seznamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seznamToolStripMenuItem
            // 
            this.seznamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generovatToolStripMenuItem,
            this.přidatNaZačátekToolStripMenuItem,
            this.přidatNaKonecToolStripMenuItem,
            this.toolStripSeparator1,
            this.vymazatToolStripMenuItem,
            this.vymazatDuplicityToolStripMenuItem,
            this.toolStripSeparator2,
            this.seřaditToolStripMenuItem,
            this.toolStripSeparator3,
            this.ukončitToolStripMenuItem});
            this.seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            this.seznamToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.seznamToolStripMenuItem.Text = "Seznam";
            // 
            // generovatToolStripMenuItem
            // 
            this.generovatToolStripMenuItem.Name = "generovatToolStripMenuItem";
            this.generovatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generovatToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.generovatToolStripMenuItem.Text = "Generovat";
            this.generovatToolStripMenuItem.Click += new System.EventHandler(this.generovatToolStripMenuItem_Click);
            // 
            // přidatNaZačátekToolStripMenuItem
            // 
            this.přidatNaZačátekToolStripMenuItem.Name = "přidatNaZačátekToolStripMenuItem";
            this.přidatNaZačátekToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.přidatNaZačátekToolStripMenuItem.Text = "Přidat na začátek...";
            this.přidatNaZačátekToolStripMenuItem.Click += new System.EventHandler(this.přidatNaZačátekToolStripMenuItem_Click);
            // 
            // přidatNaKonecToolStripMenuItem
            // 
            this.přidatNaKonecToolStripMenuItem.Name = "přidatNaKonecToolStripMenuItem";
            this.přidatNaKonecToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.přidatNaKonecToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.přidatNaKonecToolStripMenuItem.Text = "Přidat na konec...";
            this.přidatNaKonecToolStripMenuItem.Click += new System.EventHandler(this.přidatNaKonecToolStripMenuItem_Click);
            // 
            // vymazatToolStripMenuItem
            // 
            this.vymazatToolStripMenuItem.Name = "vymazatToolStripMenuItem";
            this.vymazatToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.vymazatToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.vymazatToolStripMenuItem.Text = "Vymazat";
            this.vymazatToolStripMenuItem.Click += new System.EventHandler(this.vymazatToolStripMenuItem_Click);
            // 
            // vymazatDuplicityToolStripMenuItem
            // 
            this.vymazatDuplicityToolStripMenuItem.Name = "vymazatDuplicityToolStripMenuItem";
            this.vymazatDuplicityToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.vymazatDuplicityToolStripMenuItem.Text = "Vymazat duplicity";
            this.vymazatDuplicityToolStripMenuItem.Click += new System.EventHandler(this.vymazatDuplicityToolStripMenuItem_Click);
            // 
            // seřaditToolStripMenuItem
            // 
            this.seřaditToolStripMenuItem.Name = "seřaditToolStripMenuItem";
            this.seřaditToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.seřaditToolStripMenuItem.Text = "Seřadit";
            this.seřaditToolStripMenuItem.Click += new System.EventHandler(this.seřaditToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ukončitToolStripMenuItem.Text = "Ukončit";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // celaCislaListBox
            // 
            this.celaCislaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.celaCislaListBox.FormattingEnabled = true;
            this.celaCislaListBox.Location = new System.Drawing.Point(0, 24);
            this.celaCislaListBox.Name = "celaCislaListBox";
            this.celaCislaListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.celaCislaListBox.Size = new System.Drawing.Size(292, 242);
            this.celaCislaListBox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pocetLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Počet položek: ";
            // 
            // pocetLabel
            // 
            this.pocetLabel.Name = "pocetLabel";
            this.pocetLabel.Size = new System.Drawing.Size(13, 17);
            this.pocetLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.celaCislaListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Celá čísla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatNaZačátekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatNaKonecToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vymazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vymazatDuplicityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seřaditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.ListBox celaCislaListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel pocetLabel;
    }
}

