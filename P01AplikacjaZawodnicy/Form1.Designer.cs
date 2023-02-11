namespace P01AplikacjaZawodnicy
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
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnSrednieWzrosty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(103, 12);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(261, 20);
            this.txtSciezka.TabIndex = 0;
            this.txtSciezka.Text = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ścieżka do pliku";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(370, 9);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 2;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Items.AddRange(new object[] {
            "ala",
            "ma",
            "kota"});
            this.lbDane.Location = new System.Drawing.Point(15, 52);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(349, 264);
            this.lbDane.TabIndex = 3;
            // 
            // btnSrednieWzrosty
            // 
            this.btnSrednieWzrosty.Location = new System.Drawing.Point(370, 52);
            this.btnSrednieWzrosty.Name = "btnSrednieWzrosty";
            this.btnSrednieWzrosty.Size = new System.Drawing.Size(75, 57);
            this.btnSrednieWzrosty.TabIndex = 4;
            this.btnSrednieWzrosty.Text = "Średnie wzrosty";
            this.btnSrednieWzrosty.UseVisualStyleBackColor = true;
            this.btnSrednieWzrosty.Click += new System.EventHandler(this.btnSrednieWzrosty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.btnSrednieWzrosty);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSciezka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnSrednieWzrosty;
    }
}

