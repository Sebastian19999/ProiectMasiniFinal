namespace Meniu
{
    partial class TopMasini
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cautat31 = new Meniu.Cautat3();
            this.cautat21 = new Meniu.Cautat2();
            this.cautat11 = new Meniu.Cautat1();
            this.cautaAltaMasinaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cautat31
            // 
            this.cautat31.BackColor = System.Drawing.Color.Turquoise;
            this.cautat31.Location = new System.Drawing.Point(558, 31);
            this.cautat31.Name = "cautat31";
            this.cautat31.Size = new System.Drawing.Size(222, 304);
            this.cautat31.TabIndex = 2;
            // 
            // cautat21
            // 
            this.cautat21.BackColor = System.Drawing.Color.Turquoise;
            this.cautat21.Location = new System.Drawing.Point(294, 31);
            this.cautat21.Name = "cautat21";
            this.cautat21.Size = new System.Drawing.Size(222, 304);
            this.cautat21.TabIndex = 1;
            this.cautat21.Load += new System.EventHandler(this.cautat21_Load);
            // 
            // cautat11
            // 
            this.cautat11.BackColor = System.Drawing.Color.Turquoise;
            this.cautat11.Location = new System.Drawing.Point(29, 31);
            this.cautat11.Name = "cautat11";
            this.cautat11.Size = new System.Drawing.Size(222, 304);
            this.cautat11.TabIndex = 0;
            // 
            // cautaAltaMasinaBtn
            // 
            this.cautaAltaMasinaBtn.Location = new System.Drawing.Point(264, 364);
            this.cautaAltaMasinaBtn.Name = "cautaAltaMasinaBtn";
            this.cautaAltaMasinaBtn.Size = new System.Drawing.Size(288, 51);
            this.cautaAltaMasinaBtn.TabIndex = 3;
            this.cautaAltaMasinaBtn.Text = "Cauta altă mașină";
            this.cautaAltaMasinaBtn.UseVisualStyleBackColor = true;
            this.cautaAltaMasinaBtn.Click += new System.EventHandler(this.cautaAltaMasinaBtn_Click);
            // 
            // TopMasini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cautaAltaMasinaBtn);
            this.Controls.Add(this.cautat31);
            this.Controls.Add(this.cautat21);
            this.Controls.Add(this.cautat11);
            this.Name = "TopMasini";
            this.Size = new System.Drawing.Size(807, 437);
            this.Load += new System.EventHandler(this.TopMasini_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Cautat1 cautat11;
        private Cautat2 cautat21;
        private Cautat3 cautat31;
        private System.Windows.Forms.Button cautaAltaMasinaBtn;
    }
}
