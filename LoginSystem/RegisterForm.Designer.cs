namespace LoginSystem
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmareTxt = new System.Windows.Forms.TextBox();
            this.parolaTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.prenumeTxt = new System.Windows.Forms.TextBox();
            this.numeTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.regLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.confirmareTxt);
            this.panel1.Controls.Add(this.parolaTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.prenumeTxt);
            this.panel1.Controls.Add(this.numeTxt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 608);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aveti deja un cont? Logati-va";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(144, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "ÎNREGISTRARE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmareTxt
            // 
            this.confirmareTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmareTxt.Location = new System.Drawing.Point(61, 422);
            this.confirmareTxt.Multiline = true;
            this.confirmareTxt.Name = "confirmareTxt";
            this.confirmareTxt.Size = new System.Drawing.Size(505, 52);
            this.confirmareTxt.TabIndex = 6;
            this.confirmareTxt.Text = "confirmare parola";
            this.confirmareTxt.Enter += new System.EventHandler(this.confirmareTxt_Enter);
            this.confirmareTxt.Leave += new System.EventHandler(this.confirmareTxt_Leave);
            // 
            // parolaTxt
            // 
            this.parolaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaTxt.Location = new System.Drawing.Point(61, 355);
            this.parolaTxt.Multiline = true;
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.Size = new System.Drawing.Size(505, 52);
            this.parolaTxt.TabIndex = 5;
            this.parolaTxt.Text = "parola";
            this.parolaTxt.Enter += new System.EventHandler(this.parolaTxt_Enter);
            this.parolaTxt.Leave += new System.EventHandler(this.parolaTxt_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(61, 286);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(505, 54);
            this.usernameTxt.TabIndex = 4;
            this.usernameTxt.Text = "username";
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(61, 217);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(505, 53);
            this.emailTxt.TabIndex = 3;
            this.emailTxt.Text = "adresa email";
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // prenumeTxt
            // 
            this.prenumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeTxt.Location = new System.Drawing.Point(320, 147);
            this.prenumeTxt.Multiline = true;
            this.prenumeTxt.Name = "prenumeTxt";
            this.prenumeTxt.Size = new System.Drawing.Size(246, 52);
            this.prenumeTxt.TabIndex = 2;
            this.prenumeTxt.Text = "prenume";
            this.prenumeTxt.Enter += new System.EventHandler(this.prenumeTxt_Enter);
            this.prenumeTxt.Leave += new System.EventHandler(this.prenumeTxt_Leave);
            // 
            // numeTxt
            // 
            this.numeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeTxt.Location = new System.Drawing.Point(61, 147);
            this.numeTxt.Multiline = true;
            this.numeTxt.Name = "numeTxt";
            this.numeTxt.Size = new System.Drawing.Size(241, 52);
            this.numeTxt.TabIndex = 200;
            this.numeTxt.Text = "nume";
            this.numeTxt.Enter += new System.EventHandler(this.numeTxt_Enter);
            this.numeTxt.Leave += new System.EventHandler(this.numeTxt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.regLbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 96);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 201;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLbl.Location = new System.Drawing.Point(159, 26);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(313, 44);
            this.regLbl.TabIndex = 1;
            this.regLbl.Text = "ÎNREGISTRARE";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 608);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox confirmareTxt;
        private System.Windows.Forms.TextBox parolaTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox prenumeTxt;
        private System.Windows.Forms.TextBox numeTxt;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}