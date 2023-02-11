namespace P01AplikacjaZawodnicy
{
    partial class FrmMiasta
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 12);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(205, 173);
            this.lbDane.TabIndex = 0;
            // 
            // FrmMiasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 195);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmMiasta";
            this.Text = "FrmMiasta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
    }
}