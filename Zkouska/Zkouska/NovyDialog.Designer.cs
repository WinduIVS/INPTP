namespace Zkouska
{
    partial class NovyDialog
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
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.narozenLabel = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.novyButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(82, 42);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(44, 13);
            this.jmenoLabel.TabIndex = 0;
            this.jmenoLabel.Text = "Jméno: ";
            // 
            // narozenLabel
            // 
            this.narozenLabel.AutoSize = true;
            this.narozenLabel.Location = new System.Drawing.Point(37, 66);
            this.narozenLabel.Name = "narozenLabel";
            this.narozenLabel.Size = new System.Drawing.Size(89, 13);
            this.narozenLabel.TabIndex = 1;
            this.narozenLabel.Text = "Datum narození: ";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(143, 39);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(200, 20);
            this.jmenoTextBox.TabIndex = 2;
            // 
            // novyButton
            // 
            this.novyButton.Location = new System.Drawing.Point(143, 90);
            this.novyButton.Name = "novyButton";
            this.novyButton.Size = new System.Drawing.Size(200, 25);
            this.novyButton.TabIndex = 4;
            this.novyButton.Text = "vytvořit";
            this.novyButton.UseVisualStyleBackColor = true;
            this.novyButton.Click += new System.EventHandler(this.novyButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // NovyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 150);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.novyButton);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.narozenLabel);
            this.Controls.Add(this.jmenoLabel);
            this.Name = "NovyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NovyDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.Label narozenLabel;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.Button novyButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}