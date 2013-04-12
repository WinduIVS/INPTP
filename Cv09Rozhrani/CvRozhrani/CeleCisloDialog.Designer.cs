namespace CvRozhrani
{
    partial class CeleCisloDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.celeCisloTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.stornoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celé číslo";
            // 
            // celeCisloTextBox
            // 
            this.celeCisloTextBox.Location = new System.Drawing.Point(72, 6);
            this.celeCisloTextBox.Name = "celeCisloTextBox";
            this.celeCisloTextBox.Size = new System.Drawing.Size(100, 20);
            this.celeCisloTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 32);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // stornoButton
            // 
            this.stornoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stornoButton.Location = new System.Drawing.Point(97, 32);
            this.stornoButton.Name = "stornoButton";
            this.stornoButton.Size = new System.Drawing.Size(75, 23);
            this.stornoButton.TabIndex = 3;
            this.stornoButton.Text = "Storno";
            this.stornoButton.UseVisualStyleBackColor = true;
            // 
            // CeleCisloDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 67);
            this.Controls.Add(this.stornoButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.celeCisloTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CeleCisloDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Celé číslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox celeCisloTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button stornoButton;
    }
}