namespace Cv_RealnaCisla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cislaListBox = new System.Windows.Forms.ListBox();
            this.generovatButton = new System.Windows.Forms.Button();
            this.nacistButton = new System.Windows.Forms.Button();
            this.ulozitButton = new System.Windows.Forms.Button();
            this.jazykComboBox = new System.Windows.Forms.ComboBox();
            this.konecButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cislaListBox
            // 
            this.cislaListBox.FormattingEnabled = true;
            this.cislaListBox.Location = new System.Drawing.Point(12, 12);
            this.cislaListBox.MultiColumn = true;
            this.cislaListBox.Name = "cislaListBox";
            this.cislaListBox.ScrollAlwaysVisible = true;
            this.cislaListBox.Size = new System.Drawing.Size(237, 173);
            this.cislaListBox.TabIndex = 0;
            // 
            // generovatButton
            // 
            this.generovatButton.Location = new System.Drawing.Point(12, 191);
            this.generovatButton.Name = "generovatButton";
            this.generovatButton.Size = new System.Drawing.Size(75, 23);
            this.generovatButton.TabIndex = 1;
            this.generovatButton.Text = "Generovat";
            this.generovatButton.UseVisualStyleBackColor = true;
            this.generovatButton.Click += new System.EventHandler(this.generovatButton_Click);
            // 
            // nacistButton
            // 
            this.nacistButton.Location = new System.Drawing.Point(93, 191);
            this.nacistButton.Name = "nacistButton";
            this.nacistButton.Size = new System.Drawing.Size(75, 23);
            this.nacistButton.TabIndex = 2;
            this.nacistButton.Text = "Načíst...";
            this.nacistButton.UseVisualStyleBackColor = true;
            this.nacistButton.Click += new System.EventHandler(this.nacistButton_Click);
            // 
            // ulozitButton
            // 
            this.ulozitButton.Location = new System.Drawing.Point(174, 191);
            this.ulozitButton.Name = "ulozitButton";
            this.ulozitButton.Size = new System.Drawing.Size(75, 23);
            this.ulozitButton.TabIndex = 3;
            this.ulozitButton.Text = "Uložit...";
            this.ulozitButton.UseVisualStyleBackColor = true;
            this.ulozitButton.Click += new System.EventHandler(this.ulozitButton_Click);
            // 
            // jazykComboBox
            // 
            this.jazykComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jazykComboBox.FormattingEnabled = true;
            this.jazykComboBox.Items.AddRange(new object[] {
            "Default (Windows)",
            "Čeština (ČR)",
            "Angličtina (GB)",
            "Portugalština (PT)"});
            this.jazykComboBox.Location = new System.Drawing.Point(12, 220);
            this.jazykComboBox.Name = "jazykComboBox";
            this.jazykComboBox.Size = new System.Drawing.Size(156, 21);
            this.jazykComboBox.TabIndex = 4;
            this.jazykComboBox.SelectedIndexChanged += new System.EventHandler(this.jazykComboBox_SelectedIndexChanged);
            // 
            // konecButton
            // 
            this.konecButton.Location = new System.Drawing.Point(174, 220);
            this.konecButton.Name = "konecButton";
            this.konecButton.Size = new System.Drawing.Size(75, 23);
            this.konecButton.TabIndex = 5;
            this.konecButton.Text = "Konec";
            this.konecButton.UseVisualStyleBackColor = true;
            this.konecButton.Click += new System.EventHandler(this.konecButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Binární soubor (*.bin)|*.bin";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "cisla";
            this.saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Binární soubor (*.bin)|*.bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 251);
            this.Controls.Add(this.konecButton);
            this.Controls.Add(this.jazykComboBox);
            this.Controls.Add(this.ulozitButton);
            this.Controls.Add(this.nacistButton);
            this.Controls.Add(this.generovatButton);
            this.Controls.Add(this.cislaListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Reálná čísla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cislaListBox;
        private System.Windows.Forms.Button generovatButton;
        private System.Windows.Forms.Button nacistButton;
        private System.Windows.Forms.Button ulozitButton;
        private System.Windows.Forms.ComboBox jazykComboBox;
        private System.Windows.Forms.Button konecButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

