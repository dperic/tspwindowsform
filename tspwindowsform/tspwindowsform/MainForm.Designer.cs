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
            this.brojVozilaLabel = new System.Windows.Forms.Label();
            this.putButton = new System.Windows.Forms.Button();
            this.rutaLabel = new System.Windows.Forms.Label();
            this.nazivUliceLabel = new System.Windows.Forms.Label();
            this.kucniBrojLabel = new System.Windows.Forms.Label();
            this.postanskiBrojLabel = new System.Windows.Forms.Label();
            this.mjestoLabel = new System.Windows.Forms.Label();
            this.nazivUliceTextBox = new System.Windows.Forms.TextBox();
            this.kucniBrojTextBox = new System.Windows.Forms.TextBox();
            this.postanskiBrojTextBox = new System.Windows.Forms.TextBox();
            this.mjestoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pocetnaAdresaTextBox
            // 
            this.pocetnaAdresaTextBox.Location = new System.Drawing.Point(438, 40);
            this.pocetnaAdresaTextBox.Name = "pocetnaAdresaTextBox";
            this.pocetnaAdresaTextBox.Size = new System.Drawing.Size(242, 20);
            this.pocetnaAdresaTextBox.TabIndex = 0;
            // 
            // brojVozilaTextBox
            // 
            this.brojVozilaTextBox.Location = new System.Drawing.Point(15, 179);
            this.brojVozilaTextBox.Name = "brojVozilaTextBox";
            this.brojVozilaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojVozilaTextBox.TabIndex = 1;
            // 
            // pocetnaAdresaLabel
            // 
            this.pocetnaAdresaLabel.AutoSize = true;
            this.pocetnaAdresaLabel.Location = new System.Drawing.Point(435, 24);
            this.pocetnaAdresaLabel.Name = "pocetnaAdresaLabel";
            this.pocetnaAdresaLabel.Size = new System.Drawing.Size(90, 13);
            this.pocetnaAdresaLabel.TabIndex = 2;
            this.pocetnaAdresaLabel.Text = "Polazišna adresa:";
            // 
            // brojVozilaLabel
            // 
            this.brojVozilaLabel.AutoSize = true;
            this.brojVozilaLabel.Location = new System.Drawing.Point(12, 163);
            this.brojVozilaLabel.Name = "brojVozilaLabel";
            this.brojVozilaLabel.Size = new System.Drawing.Size(58, 13);
            this.brojVozilaLabel.TabIndex = 3;
            this.brojVozilaLabel.Text = "Broj vozila:";
            // 
            // putButton
            // 
            this.putButton.Location = new System.Drawing.Point(76, 219);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(97, 23);
            this.putButton.TabIndex = 4;
            this.putButton.Text = "Pronađi put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // rutaLabel
            // 
            this.rutaLabel.AutoSize = true;
            this.rutaLabel.Location = new System.Drawing.Point(12, 273);
            this.rutaLabel.Name = "rutaLabel";
            this.rutaLabel.Size = new System.Drawing.Size(52, 13);
            this.rutaLabel.TabIndex = 5;
            this.rutaLabel.Text = "  dsfsddsf";
            // 
            // nazivUliceLabel
            // 
            this.nazivUliceLabel.AutoSize = true;
            this.nazivUliceLabel.Location = new System.Drawing.Point(12, 9);
            this.nazivUliceLabel.Name = "nazivUliceLabel";
            this.nazivUliceLabel.Size = new System.Drawing.Size(62, 13);
            this.nazivUliceLabel.TabIndex = 6;
            this.nazivUliceLabel.Text = "Naziv ulice:";
            // 
            // kucniBrojLabel
            // 
            this.kucniBrojLabel.AutoSize = true;
            this.kucniBrojLabel.Location = new System.Drawing.Point(12, 48);
            this.kucniBrojLabel.Name = "kucniBrojLabel";
            this.kucniBrojLabel.Size = new System.Drawing.Size(57, 13);
            this.kucniBrojLabel.TabIndex = 7;
            this.kucniBrojLabel.Text = "Kućni broj:";
            // 
            // postanskiBrojLabel
            // 
            this.postanskiBrojLabel.AutoSize = true;
            this.postanskiBrojLabel.Location = new System.Drawing.Point(12, 85);
            this.postanskiBrojLabel.Name = "postanskiBrojLabel";
            this.postanskiBrojLabel.Size = new System.Drawing.Size(76, 13);
            this.postanskiBrojLabel.TabIndex = 8;
            this.postanskiBrojLabel.Text = "Poštanski broj:";
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Location = new System.Drawing.Point(12, 124);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(74, 13);
            this.mjestoLabel.TabIndex = 9;
            this.mjestoLabel.Text = "Mjesto ili grad:";
            // 
            // nazivUliceTextBox
            // 
            this.nazivUliceTextBox.Location = new System.Drawing.Point(15, 25);
            this.nazivUliceTextBox.Name = "nazivUliceTextBox";
            this.nazivUliceTextBox.Size = new System.Drawing.Size(210, 20);
            this.nazivUliceTextBox.TabIndex = 10;
            // 
            // kucniBrojTextBox
            // 
            this.kucniBrojTextBox.Location = new System.Drawing.Point(15, 62);
            this.kucniBrojTextBox.Name = "kucniBrojTextBox";
            this.kucniBrojTextBox.Size = new System.Drawing.Size(100, 20);
            this.kucniBrojTextBox.TabIndex = 11;
            // 
            // postanskiBrojTextBox
            // 
            this.postanskiBrojTextBox.Location = new System.Drawing.Point(15, 101);
            this.postanskiBrojTextBox.Name = "postanskiBrojTextBox";
            this.postanskiBrojTextBox.Size = new System.Drawing.Size(100, 20);
            this.postanskiBrojTextBox.TabIndex = 12;
            // 
            // mjestoTextBox
            // 
            this.mjestoTextBox.Location = new System.Drawing.Point(15, 140);
            this.mjestoTextBox.Name = "mjestoTextBox";
            this.mjestoTextBox.Size = new System.Drawing.Size(210, 20);
            this.mjestoTextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AcceptButton = this.putButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 455);
            this.Controls.Add(this.mjestoTextBox);
            this.Controls.Add(this.postanskiBrojTextBox);
            this.Controls.Add(this.kucniBrojTextBox);
            this.Controls.Add(this.nazivUliceTextBox);
            this.Controls.Add(this.mjestoLabel);
            this.Controls.Add(this.postanskiBrojLabel);
            this.Controls.Add(this.kucniBrojLabel);
            this.Controls.Add(this.nazivUliceLabel);
            this.Controls.Add(this.rutaLabel);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.brojVozilaLabel);
            this.Controls.Add(this.pocetnaAdresaLabel);
            this.Controls.Add(this.brojVozilaTextBox);
            this.Controls.Add(this.pocetnaAdresaTextBox);
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
        private System.Windows.Forms.Label brojVozilaLabel;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Label rutaLabel;
        private System.Windows.Forms.Label nazivUliceLabel;
        private System.Windows.Forms.Label kucniBrojLabel;
        private System.Windows.Forms.Label postanskiBrojLabel;
        private System.Windows.Forms.Label mjestoLabel;
        private System.Windows.Forms.TextBox nazivUliceTextBox;
        private System.Windows.Forms.TextBox kucniBrojTextBox;
        private System.Windows.Forms.TextBox postanskiBrojTextBox;
        private System.Windows.Forms.TextBox mjestoTextBox;
    }
}

