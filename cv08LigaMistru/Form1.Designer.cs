namespace LigaMistru
{
    partial class LigaMistruForm
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
            this.hraciListView = new System.Windows.Forms.ListView();
            this.jmenoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.klubColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.golyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pridatButton = new System.Windows.Forms.Button();
            this.vymazatButton = new System.Windows.Forms.Button();
            this.upravitButton = new System.Windows.Forms.Button();
            this.nejlepsiButton = new System.Windows.Forms.Button();
            this.registrovatButton = new System.Windows.Forms.Button();
            this.zrusitButton = new System.Windows.Forms.Button();
            this.konecButton = new System.Windows.Forms.Button();
            this.protokolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hraciListView
            // 
            this.hraciListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hraciListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jmenoColumn,
            this.klubColumn,
            this.golyColumn});
            this.hraciListView.FullRowSelect = true;
            this.hraciListView.GridLines = true;
            this.hraciListView.Location = new System.Drawing.Point(12, 12);
            this.hraciListView.Name = "hraciListView";
            this.hraciListView.Size = new System.Drawing.Size(368, 195);
            this.hraciListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.hraciListView.TabIndex = 0;
            this.hraciListView.UseCompatibleStateImageBehavior = false;
            this.hraciListView.View = System.Windows.Forms.View.Details;
            this.hraciListView.SelectedIndexChanged += new System.EventHandler(this.hraciListView_SelectedIndexChanged);
            this.hraciListView.DoubleClick += new System.EventHandler(this.hraciListView_DoubleClick);
            // 
            // jmenoColumn
            // 
            this.jmenoColumn.Text = "Jméno";
            this.jmenoColumn.Width = 107;
            // 
            // klubColumn
            // 
            this.klubColumn.Text = "Klub";
            this.klubColumn.Width = 93;
            // 
            // golyColumn
            // 
            this.golyColumn.Text = "Góly";
            // 
            // pridatButton
            // 
            this.pridatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pridatButton.Location = new System.Drawing.Point(386, 12);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(75, 21);
            this.pridatButton.TabIndex = 1;
            this.pridatButton.Text = "&Přidat...";
            this.pridatButton.UseVisualStyleBackColor = true;
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // vymazatButton
            // 
            this.vymazatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vymazatButton.Location = new System.Drawing.Point(386, 39);
            this.vymazatButton.Name = "vymazatButton";
            this.vymazatButton.Size = new System.Drawing.Size(75, 23);
            this.vymazatButton.TabIndex = 2;
            this.vymazatButton.Text = "&Vymazat";
            this.vymazatButton.UseVisualStyleBackColor = true;
            this.vymazatButton.Click += new System.EventHandler(this.vymazatButton_Click);
            // 
            // upravitButton
            // 
            this.upravitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upravitButton.Location = new System.Drawing.Point(386, 68);
            this.upravitButton.Name = "upravitButton";
            this.upravitButton.Size = new System.Drawing.Size(75, 23);
            this.upravitButton.TabIndex = 3;
            this.upravitButton.Text = "&Upravit...";
            this.upravitButton.UseVisualStyleBackColor = true;
            this.upravitButton.Click += new System.EventHandler(this.upravitButton_Click);
            // 
            // nejlepsiButton
            // 
            this.nejlepsiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nejlepsiButton.Location = new System.Drawing.Point(386, 97);
            this.nejlepsiButton.Name = "nejlepsiButton";
            this.nejlepsiButton.Size = new System.Drawing.Size(75, 23);
            this.nejlepsiButton.TabIndex = 4;
            this.nejlepsiButton.Text = "&Nejlepší...";
            this.nejlepsiButton.UseVisualStyleBackColor = true;
            this.nejlepsiButton.Click += new System.EventHandler(this.nejlepsiButton_Click);
            // 
            // registrovatButton
            // 
            this.registrovatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrovatButton.Location = new System.Drawing.Point(386, 126);
            this.registrovatButton.Name = "registrovatButton";
            this.registrovatButton.Size = new System.Drawing.Size(75, 23);
            this.registrovatButton.TabIndex = 5;
            this.registrovatButton.Text = "&Registrovat";
            this.registrovatButton.UseVisualStyleBackColor = true;
            this.registrovatButton.Click += new System.EventHandler(this.registrovatButton_Click);
            // 
            // zrusitButton
            // 
            this.zrusitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zrusitButton.Location = new System.Drawing.Point(386, 155);
            this.zrusitButton.Name = "zrusitButton";
            this.zrusitButton.Size = new System.Drawing.Size(75, 23);
            this.zrusitButton.TabIndex = 6;
            this.zrusitButton.Text = "&Zrušit";
            this.zrusitButton.UseVisualStyleBackColor = true;
            this.zrusitButton.Click += new System.EventHandler(this.zrusitButton_Click);
            // 
            // konecButton
            // 
            this.konecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.konecButton.Location = new System.Drawing.Point(386, 184);
            this.konecButton.Name = "konecButton";
            this.konecButton.Size = new System.Drawing.Size(75, 23);
            this.konecButton.TabIndex = 7;
            this.konecButton.Text = "U&končit";
            this.konecButton.UseVisualStyleBackColor = true;
            this.konecButton.Click += new System.EventHandler(this.konecButton_Click);
            // 
            // protokolTextBox
            // 
            this.protokolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.protokolTextBox.Location = new System.Drawing.Point(12, 236);
            this.protokolTextBox.Multiline = true;
            this.protokolTextBox.Name = "protokolTextBox";
            this.protokolTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.protokolTextBox.Size = new System.Drawing.Size(446, 56);
            this.protokolTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Protokol událostí";
            // 
            // LigaMistruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.protokolTextBox);
            this.Controls.Add(this.konecButton);
            this.Controls.Add(this.zrusitButton);
            this.Controls.Add(this.registrovatButton);
            this.Controls.Add(this.nejlepsiButton);
            this.Controls.Add(this.upravitButton);
            this.Controls.Add(this.vymazatButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.hraciListView);
            this.MinimumSize = new System.Drawing.Size(486, 342);
            this.Name = "LigaMistruForm";
            this.Text = "Liga Mistrů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView hraciListView;
        private System.Windows.Forms.ColumnHeader jmenoColumn;
        private System.Windows.Forms.ColumnHeader klubColumn;
        private System.Windows.Forms.ColumnHeader golyColumn;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Button vymazatButton;
        private System.Windows.Forms.Button upravitButton;
        private System.Windows.Forms.Button nejlepsiButton;
        private System.Windows.Forms.Button registrovatButton;
        private System.Windows.Forms.Button zrusitButton;
        private System.Windows.Forms.Button konecButton;
        private System.Windows.Forms.TextBox protokolTextBox;
        private System.Windows.Forms.Label label1;
    }
}

