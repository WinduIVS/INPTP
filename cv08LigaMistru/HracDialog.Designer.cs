namespace LigaMistru
{
    partial class HracDialog
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
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.klubLabel = new System.Windows.Forms.Label();
            this.klubComboBox = new System.Windows.Forms.ComboBox();
            this.golLabel = new System.Windows.Forms.Label();
            this.golyTextBox = new System.Windows.Forms.TextBox();
            this.pridatButton = new System.Windows.Forms.Button();
            this.stornoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(12, 9);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(38, 13);
            this.jmenoLabel.TabIndex = 0;
            this.jmenoLabel.Text = "Jméno";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(56, 6);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(121, 20);
            this.jmenoTextBox.TabIndex = 1;
            // 
            // klubLabel
            // 
            this.klubLabel.AutoSize = true;
            this.klubLabel.Location = new System.Drawing.Point(12, 40);
            this.klubLabel.Name = "klubLabel";
            this.klubLabel.Size = new System.Drawing.Size(28, 13);
            this.klubLabel.TabIndex = 2;
            this.klubLabel.Text = "Klub";
            // 
            // klubComboBox
            // 
            this.klubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klubComboBox.FormattingEnabled = true;
            this.klubComboBox.Location = new System.Drawing.Point(56, 37);
            this.klubComboBox.Name = "klubComboBox";
            this.klubComboBox.Size = new System.Drawing.Size(121, 21);
            this.klubComboBox.Sorted = true;
            this.klubComboBox.TabIndex = 3;
            // 
            // golLabel
            // 
            this.golLabel.AutoSize = true;
            this.golLabel.Location = new System.Drawing.Point(12, 72);
            this.golLabel.Name = "golLabel";
            this.golLabel.Size = new System.Drawing.Size(29, 13);
            this.golLabel.TabIndex = 4;
            this.golLabel.Text = "Gólů";
            // 
            // golyTextBox
            // 
            this.golyTextBox.Location = new System.Drawing.Point(56, 72);
            this.golyTextBox.Name = "golyTextBox";
            this.golyTextBox.Size = new System.Drawing.Size(52, 20);
            this.golyTextBox.TabIndex = 5;
            // 
            // pridatButton
            // 
            this.pridatButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pridatButton.Location = new System.Drawing.Point(12, 117);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(75, 23);
            this.pridatButton.TabIndex = 6;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.UseVisualStyleBackColor = true;
            // 
            // stornoButton
            // 
            this.stornoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stornoButton.Location = new System.Drawing.Point(102, 117);
            this.stornoButton.Name = "stornoButton";
            this.stornoButton.Size = new System.Drawing.Size(75, 23);
            this.stornoButton.TabIndex = 7;
            this.stornoButton.Text = "Storno";
            this.stornoButton.UseVisualStyleBackColor = true;
            // 
            // HracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 153);
            this.Controls.Add(this.stornoButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.golyTextBox);
            this.Controls.Add(this.golLabel);
            this.Controls.Add(this.klubComboBox);
            this.Controls.Add(this.klubLabel);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.jmenoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HracForm";
            this.Text = "Přidat hráče";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.Label klubLabel;
        private System.Windows.Forms.ComboBox klubComboBox;
        private System.Windows.Forms.Label golLabel;
        private System.Windows.Forms.TextBox golyTextBox;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Button stornoButton;
    }
}