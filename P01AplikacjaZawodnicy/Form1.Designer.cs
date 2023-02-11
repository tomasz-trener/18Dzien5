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
            this.txtParamPolaczenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnSrednieWzrosty = new System.Windows.Forms.Button();
            this.rbPlik = new System.Windows.Forms.RadioButton();
            this.rbBaza = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParamPolaczenia
            // 
            this.txtParamPolaczenia.Location = new System.Drawing.Point(123, 28);
            this.txtParamPolaczenia.Name = "txtParamPolaczenia";
            this.txtParamPolaczenia.Size = new System.Drawing.Size(241, 20);
            this.txtParamPolaczenia.TabIndex = 0;
            this.txtParamPolaczenia.Text = "Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametr połączenia";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Enabled = false;
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
            this.btnSrednieWzrosty.Enabled = false;
            this.btnSrednieWzrosty.Location = new System.Drawing.Point(370, 52);
            this.btnSrednieWzrosty.Name = "btnSrednieWzrosty";
            this.btnSrednieWzrosty.Size = new System.Drawing.Size(75, 57);
            this.btnSrednieWzrosty.TabIndex = 4;
            this.btnSrednieWzrosty.Text = "Średnie wzrosty";
            this.btnSrednieWzrosty.UseVisualStyleBackColor = true;
            this.btnSrednieWzrosty.Click += new System.EventHandler(this.btnSrednieWzrosty_Click);
            // 
            // rbPlik
            // 
            this.rbPlik.AutoSize = true;
            this.rbPlik.Location = new System.Drawing.Point(123, 5);
            this.rbPlik.Name = "rbPlik";
            this.rbPlik.Size = new System.Drawing.Size(42, 17);
            this.rbPlik.TabIndex = 5;
            this.rbPlik.Text = "Plik";
            this.rbPlik.UseVisualStyleBackColor = true;
            this.rbPlik.CheckedChanged += new System.EventHandler(this.rbPlik_CheckedChanged);
            // 
            // rbBaza
            // 
            this.rbBaza.AutoSize = true;
            this.rbBaza.Location = new System.Drawing.Point(171, 5);
            this.rbBaza.Name = "rbBaza";
            this.rbBaza.Size = new System.Drawing.Size(49, 17);
            this.rbBaza.TabIndex = 6;
            this.rbBaza.Text = "Baza";
            this.rbBaza.UseVisualStyleBackColor = true;
            this.rbBaza.CheckedChanged += new System.EventHandler(this.rbBaza_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Typ połączenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbBaza);
            this.Controls.Add(this.rbPlik);
            this.Controls.Add(this.btnSrednieWzrosty);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParamPolaczenia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParamPolaczenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnSrednieWzrosty;
        private System.Windows.Forms.RadioButton rbPlik;
        private System.Windows.Forms.RadioButton rbBaza;
        private System.Windows.Forms.Label label2;
    }
}

