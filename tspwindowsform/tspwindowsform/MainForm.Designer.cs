namespace tspwindowsform
{
    partial class MainForm
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
            this.pocetnaAdresaTextBox = new System.Windows.Forms.TextBox();
            this.brojVozilaTextBox = new System.Windows.Forms.TextBox();
            this.pocetnaAdresaLabel = new System.Windows.Forms.Label();
            this.putButton = new System.Windows.Forms.Button();
            this.rutaLabel = new System.Windows.Forms.Label();
            this.brojVozilaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pocetnaAdresaTextBox
            // 
            this.pocetnaAdresaTextBox.Location = new System.Drawing.Point(20, 31);
            this.pocetnaAdresaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pocetnaAdresaTextBox.Name = "pocetnaAdresaTextBox";
            this.pocetnaAdresaTextBox.Size = new System.Drawing.Size(321, 22);
            this.pocetnaAdresaTextBox.TabIndex = 0;
            // 
            // brojVozilaTextBox
            // 
            this.brojVozilaTextBox.Location = new System.Drawing.Point(20, 79);
            this.brojVozilaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brojVozilaTextBox.Name = "brojVozilaTextBox";
            this.brojVozilaTextBox.Size = new System.Drawing.Size(132, 22);
            this.brojVozilaTextBox.TabIndex = 1;
            // 
            // pocetnaAdresaLabel
            // 
            this.pocetnaAdresaLabel.AutoSize = true;
            this.pocetnaAdresaLabel.Location = new System.Drawing.Point(16, 11);
            this.pocetnaAdresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pocetnaAdresaLabel.Name = "pocetnaAdresaLabel";
            this.pocetnaAdresaLabel.Size = new System.Drawing.Size(121, 17);
            this.pocetnaAdresaLabel.TabIndex = 2;
            this.pocetnaAdresaLabel.Text = "Polazišna adresa:";
            // 
            // putButton
            // 
            this.putButton.Location = new System.Drawing.Point(108, 111);
            this.putButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(129, 28);
            this.putButton.TabIndex = 4;
            this.putButton.Text = "Pronađi put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // rutaLabel
            // 
            this.rutaLabel.AutoSize = true;
            this.rutaLabel.Location = new System.Drawing.Point(16, 160);
            this.rutaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rutaLabel.Name = "rutaLabel";
            this.rutaLabel.Size = new System.Drawing.Size(16, 17);
            this.rutaLabel.TabIndex = 5;
            this.rutaLabel.Text = "  ";
            // 
            // brojVozilaLabel
            // 
            this.brojVozilaLabel.AutoSize = true;
            this.brojVozilaLabel.Location = new System.Drawing.Point(16, 59);
            this.brojVozilaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brojVozilaLabel.Name = "brojVozilaLabel";
            this.brojVozilaLabel.Size = new System.Drawing.Size(77, 17);
            this.brojVozilaLabel.TabIndex = 3;
            this.brojVozilaLabel.Text = "Broj vozila:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.putButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 560);
            this.Controls.Add(this.rutaLabel);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.brojVozilaLabel);
            this.Controls.Add(this.pocetnaAdresaLabel);
            this.Controls.Add(this.brojVozilaTextBox);
            this.Controls.Add(this.pocetnaAdresaTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveling salesman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pocetnaAdresaTextBox;
        private System.Windows.Forms.TextBox brojVozilaTextBox;
        private System.Windows.Forms.Label pocetnaAdresaLabel;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Label rutaLabel;
        private System.Windows.Forms.Label brojVozilaLabel;
    }
}

