﻿namespace ProiectMasini_FormsT10
{
    partial class idModifica
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
            this.introducereLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introducereLbl
            // 
            this.introducereLbl.AutoSize = true;
            this.introducereLbl.Location = new System.Drawing.Point(12, 28);
            this.introducereLbl.Name = "introducereLbl";
            this.introducereLbl.Size = new System.Drawing.Size(343, 17);
            this.introducereLbl.TabIndex = 1;
            this.introducereLbl.Text = "Introduceti ID-ul masinii pe care doriti sa o modificati: ";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(33, 68);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 22);
            this.idTxt.TabIndex = 3;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(229, 68);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // idModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 121);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.introducereLbl);
            this.Name = "idModifica";
            this.Text = "idModifica";
            this.Load += new System.EventHandler(this.idModifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introducereLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button okBtn;
    }
}