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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pocetnaAdresaTextBox = new System.Windows.Forms.TextBox();
            this.brojVozilaTextBox = new System.Windows.Forms.TextBox();
            this.pocetnaAdresaLabel = new System.Windows.Forms.Label();
            this.putButton = new System.Windows.Forms.Button();
            this.rutaLabel = new System.Windows.Forms.Label();
            this.brojVozilaLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pocetnaAdresaTextBox
            // 
            this.pocetnaAdresaTextBox.Location = new System.Drawing.Point(15, 25);
            this.pocetnaAdresaTextBox.Name = "pocetnaAdresaTextBox";
            this.pocetnaAdresaTextBox.Size = new System.Drawing.Size(242, 20);
            this.pocetnaAdresaTextBox.TabIndex = 0;
            // 
            // brojVozilaTextBox
            // 
            this.brojVozilaTextBox.Location = new System.Drawing.Point(15, 64);
            this.brojVozilaTextBox.Name = "brojVozilaTextBox";
            this.brojVozilaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojVozilaTextBox.TabIndex = 1;
            // 
            // pocetnaAdresaLabel
            // 
            this.pocetnaAdresaLabel.AutoSize = true;
            this.pocetnaAdresaLabel.Location = new System.Drawing.Point(12, 9);
            this.pocetnaAdresaLabel.Name = "pocetnaAdresaLabel";
            this.pocetnaAdresaLabel.Size = new System.Drawing.Size(90, 13);
            this.pocetnaAdresaLabel.TabIndex = 2;
            this.pocetnaAdresaLabel.Text = "Polazišna adresa:";
            // 
            // putButton
            // 
            this.putButton.Location = new System.Drawing.Point(81, 90);
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
            this.rutaLabel.Location = new System.Drawing.Point(12, 130);
            this.rutaLabel.Name = "rutaLabel";
            this.rutaLabel.Size = new System.Drawing.Size(13, 13);
            this.rutaLabel.TabIndex = 5;
            this.rutaLabel.Text = "  ";
            // 
            // brojVozilaLabel
            // 
            this.brojVozilaLabel.AutoSize = true;
            this.brojVozilaLabel.Location = new System.Drawing.Point(12, 48);
            this.brojVozilaLabel.Name = "brojVozilaLabel";
            this.brojVozilaLabel.Size = new System.Drawing.Size(58, 13);
            this.brojVozilaLabel.TabIndex = 3;
            this.brojVozilaLabel.Text = "Broj vozila:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Maroon;
            this.imageList1.Images.SetKeyName(0, "class-diagram.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(322, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.putButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 455);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

