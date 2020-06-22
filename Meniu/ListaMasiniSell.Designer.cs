namespace Meniu
{
    partial class ListaMasiniSell
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirmaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.culoareColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeVanzatorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pretColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optiuniColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.optiuniGrpBox = new System.Windows.Forms.GroupBox();
            this.leatherCheck = new System.Windows.Forms.CheckBox();
            this.masajCheck = new System.Windows.Forms.CheckBox();
            this.pilotCheck = new System.Windows.Forms.CheckBox();
            this.proiectoareCheck = new System.Windows.Forms.CheckBox();
            this.bluetoothCheck = new System.Windows.Forms.CheckBox();
            this.solarCheck = new System.Windows.Forms.CheckBox();
            this.cruiseCheck = new System.Windows.Forms.CheckBox();
            this.airbagCheck = new System.Windows.Forms.CheckBox();
            this.absCheck = new System.Windows.Forms.CheckBox();
            this.optiuniLbl = new System.Windows.Forms.Label();
            this.tipCmbBox = new System.Windows.Forms.ComboBox();
            this.pretTxt = new System.Windows.Forms.TextBox();
            this.numeCumparatorTxt = new System.Windows.Forms.TextBox();
            this.numeVanzatorTxt = new System.Windows.Forms.TextBox();
            this.tipMasinaLbl = new System.Windows.Forms.Label();
            this.pretLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.numeCumparatorLbl = new System.Windows.Forms.Label();
            this.numeVanzatorLbl = new System.Windows.Forms.Label();
            this.culoareGrpBox = new System.Windows.Forms.GroupBox();
            this.negruRdb = new System.Windows.Forms.RadioButton();
            this.maroRdb = new System.Windows.Forms.RadioButton();
            this.verdeRdb = new System.Windows.Forms.RadioButton();
            this.rosuRdb = new System.Windows.Forms.RadioButton();
            this.portocaliuRdb = new System.Windows.Forms.RadioButton();
            this.galbenRdb = new System.Windows.Forms.RadioButton();
            this.movRdb = new System.Windows.Forms.RadioButton();
            this.albastruRdb = new System.Windows.Forms.RadioButton();
            this.albRdb = new System.Windows.Forms.RadioButton();
            this.anFTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.firmaTxt = new System.Windows.Forms.TextBox();
            this.culoareLbl = new System.Windows.Forms.Label();
            this.anFLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.firmaLbl = new System.Windows.Forms.Label();
            this.optiuniGrpBox.SuspendLayout();
            this.culoareGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.FirmaColumn,
            this.modelColumn,
            this.anColumn,
            this.culoareColumn,
            this.numeVanzatorColumn,
            this.pretColumn,
            this.tipColumn,
            this.optiuniColumn});
            this.listView1.Location = new System.Drawing.Point(587, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 318);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            // 
            // FirmaColumn
            // 
            this.FirmaColumn.Text = "Firma";
            this.FirmaColumn.Width = 80;
            // 
            // modelColumn
            // 
            this.modelColumn.Text = "Model";
            this.modelColumn.Width = 80;
            // 
            // anColumn
            // 
            this.anColumn.Text = "An fabricație";
            this.anColumn.Width = 100;
            // 
            // culoareColumn
            // 
            this.culoareColumn.Text = "Culoare";
            this.culoareColumn.Width = 80;
            // 
            // numeVanzatorColumn
            // 
            this.numeVanzatorColumn.Text = "Nume vânzător";
            this.numeVanzatorColumn.Width = 140;
            // 
            // pretColumn
            // 
            this.pretColumn.Text = "Pret";
            // 
            // tipColumn
            // 
            this.tipColumn.Text = "Tip mașină";
            this.tipColumn.Width = 100;
            // 
            // optiuniColumn
            // 
            this.optiuniColumn.Text = "Opțiuni";
            this.optiuniColumn.Width = 200;
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(246, 376);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(204, 22);
            this.dataTxt.TabIndex = 57;
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(138, 635);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(312, 36);
            this.adaugaBtn.TabIndex = 56;
            this.adaugaBtn.Text = "Adauga masina";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            // 
            // optiuniGrpBox
            // 
            this.optiuniGrpBox.Controls.Add(this.leatherCheck);
            this.optiuniGrpBox.Controls.Add(this.masajCheck);
            this.optiuniGrpBox.Controls.Add(this.pilotCheck);
            this.optiuniGrpBox.Controls.Add(this.proiectoareCheck);
            this.optiuniGrpBox.Controls.Add(this.bluetoothCheck);
            this.optiuniGrpBox.Controls.Add(this.solarCheck);
            this.optiuniGrpBox.Controls.Add(this.cruiseCheck);
            this.optiuniGrpBox.Controls.Add(this.airbagCheck);
            this.optiuniGrpBox.Controls.Add(this.absCheck);
            this.optiuniGrpBox.Location = new System.Drawing.Point(74, 514);
            this.optiuniGrpBox.Name = "optiuniGrpBox";
            this.optiuniGrpBox.Size = new System.Drawing.Size(466, 100);
            this.optiuniGrpBox.TabIndex = 55;
            this.optiuniGrpBox.TabStop = false;
            // 
            // leatherCheck
            // 
            this.leatherCheck.AutoSize = true;
            this.leatherCheck.Location = new System.Drawing.Point(310, 66);
            this.leatherCheck.Name = "leatherCheck";
            this.leatherCheck.Size = new System.Drawing.Size(105, 21);
            this.leatherCheck.TabIndex = 8;
            this.leatherCheck.Text = "Full Leather";
            this.leatherCheck.UseVisualStyleBackColor = true;
            // 
            // masajCheck
            // 
            this.masajCheck.AutoSize = true;
            this.masajCheck.Location = new System.Drawing.Point(129, 68);
            this.masajCheck.Name = "masajCheck";
            this.masajCheck.Size = new System.Drawing.Size(119, 21);
            this.masajCheck.TabIndex = 7;
            this.masajCheck.Text = "Scaune masaj";
            this.masajCheck.UseVisualStyleBackColor = true;
            // 
            // pilotCheck
            // 
            this.pilotCheck.AutoSize = true;
            this.pilotCheck.Location = new System.Drawing.Point(6, 68);
            this.pilotCheck.Name = "pilotCheck";
            this.pilotCheck.Size = new System.Drawing.Size(112, 21);
            this.pilotCheck.TabIndex = 6;
            this.pilotCheck.Text = "Pilot automat";
            this.pilotCheck.UseVisualStyleBackColor = true;
            // 
            // proiectoareCheck
            // 
            this.proiectoareCheck.AutoSize = true;
            this.proiectoareCheck.Location = new System.Drawing.Point(310, 39);
            this.proiectoareCheck.Name = "proiectoareCheck";
            this.proiectoareCheck.Size = new System.Drawing.Size(142, 21);
            this.proiectoareCheck.TabIndex = 5;
            this.proiectoareCheck.Text = "Proiectoare ceata";
            this.proiectoareCheck.UseVisualStyleBackColor = true;
            // 
            // bluetoothCheck
            // 
            this.bluetoothCheck.AutoSize = true;
            this.bluetoothCheck.Location = new System.Drawing.Point(129, 40);
            this.bluetoothCheck.Name = "bluetoothCheck";
            this.bluetoothCheck.Size = new System.Drawing.Size(175, 21);
            this.bluetoothCheck.TabIndex = 4;
            this.bluetoothCheck.Text = "Conectivitate Bluetooth";
            this.bluetoothCheck.UseVisualStyleBackColor = true;
            // 
            // solarCheck
            // 
            this.solarCheck.AutoSize = true;
            this.solarCheck.Location = new System.Drawing.Point(6, 40);
            this.solarCheck.Name = "solarCheck";
            this.solarCheck.Size = new System.Drawing.Size(97, 21);
            this.solarCheck.TabIndex = 3;
            this.solarCheck.Text = "Solar Roof";
            this.solarCheck.UseVisualStyleBackColor = true;
            // 
            // cruiseCheck
            // 
            this.cruiseCheck.AutoSize = true;
            this.cruiseCheck.Location = new System.Drawing.Point(310, 12);
            this.cruiseCheck.Name = "cruiseCheck";
            this.cruiseCheck.Size = new System.Drawing.Size(119, 21);
            this.cruiseCheck.TabIndex = 2;
            this.cruiseCheck.Text = "Cruise Control";
            this.cruiseCheck.UseVisualStyleBackColor = true;
            // 
            // airbagCheck
            // 
            this.airbagCheck.AutoSize = true;
            this.airbagCheck.Location = new System.Drawing.Point(129, 12);
            this.airbagCheck.Name = "airbagCheck";
            this.airbagCheck.Size = new System.Drawing.Size(138, 21);
            this.airbagCheck.TabIndex = 1;
            this.airbagCheck.Text = "Airbaguri laterale";
            this.airbagCheck.UseVisualStyleBackColor = true;
            // 
            // absCheck
            // 
            this.absCheck.AutoSize = true;
            this.absCheck.Location = new System.Drawing.Point(6, 12);
            this.absCheck.Name = "absCheck";
            this.absCheck.Size = new System.Drawing.Size(57, 21);
            this.absCheck.TabIndex = 0;
            this.absCheck.Text = "ABS";
            this.absCheck.UseVisualStyleBackColor = true;
            // 
            // optiuniLbl
            // 
            this.optiuniLbl.AutoSize = true;
            this.optiuniLbl.Location = new System.Drawing.Point(71, 484);
            this.optiuniLbl.Name = "optiuniLbl";
            this.optiuniLbl.Size = new System.Drawing.Size(61, 17);
            this.optiuniLbl.TabIndex = 54;
            this.optiuniLbl.Text = "Optiuni: ";
            // 
            // tipCmbBox
            // 
            this.tipCmbBox.FormattingEnabled = true;
            this.tipCmbBox.Items.AddRange(new object[] {
            "Sedan",
            "Sport",
            "SUV",
            "Lux"});
            this.tipCmbBox.Location = new System.Drawing.Point(247, 430);
            this.tipCmbBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipCmbBox.Name = "tipCmbBox";
            this.tipCmbBox.Size = new System.Drawing.Size(128, 24);
            this.tipCmbBox.TabIndex = 53;
            // 
            // pretTxt
            // 
            this.pretTxt.Location = new System.Drawing.Point(246, 404);
            this.pretTxt.Name = "pretTxt";
            this.pretTxt.Size = new System.Drawing.Size(204, 22);
            this.pretTxt.TabIndex = 52;
            // 
            // numeCumparatorTxt
            // 
            this.numeCumparatorTxt.Location = new System.Drawing.Point(246, 347);
            this.numeCumparatorTxt.Name = "numeCumparatorTxt";
            this.numeCumparatorTxt.Size = new System.Drawing.Size(204, 22);
            this.numeCumparatorTxt.TabIndex = 51;
            // 
            // numeVanzatorTxt
            // 
            this.numeVanzatorTxt.Location = new System.Drawing.Point(246, 321);
            this.numeVanzatorTxt.Name = "numeVanzatorTxt";
            this.numeVanzatorTxt.Size = new System.Drawing.Size(204, 22);
            this.numeVanzatorTxt.TabIndex = 50;
            // 
            // tipMasinaLbl
            // 
            this.tipMasinaLbl.AutoSize = true;
            this.tipMasinaLbl.Location = new System.Drawing.Point(67, 433);
            this.tipMasinaLbl.Name = "tipMasinaLbl";
            this.tipMasinaLbl.Size = new System.Drawing.Size(85, 17);
            this.tipMasinaLbl.TabIndex = 49;
            this.tipMasinaLbl.Text = "Tip masina: ";
            // 
            // pretLbl
            // 
            this.pretLbl.AutoSize = true;
            this.pretLbl.Location = new System.Drawing.Point(67, 407);
            this.pretLbl.Name = "pretLbl";
            this.pretLbl.Size = new System.Drawing.Size(42, 17);
            this.pretLbl.TabIndex = 48;
            this.pretLbl.Text = "Pret: ";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(67, 379);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(112, 17);
            this.dataLbl.TabIndex = 47;
            this.dataLbl.Text = "Data tranzactie: ";
            // 
            // numeCumparatorLbl
            // 
            this.numeCumparatorLbl.AutoSize = true;
            this.numeCumparatorLbl.Location = new System.Drawing.Point(67, 350);
            this.numeCumparatorLbl.Name = "numeCumparatorLbl";
            this.numeCumparatorLbl.Size = new System.Drawing.Size(129, 17);
            this.numeCumparatorLbl.TabIndex = 46;
            this.numeCumparatorLbl.Text = "Nume cumparator: ";
            // 
            // numeVanzatorLbl
            // 
            this.numeVanzatorLbl.AutoSize = true;
            this.numeVanzatorLbl.Location = new System.Drawing.Point(67, 324);
            this.numeVanzatorLbl.Name = "numeVanzatorLbl";
            this.numeVanzatorLbl.Size = new System.Drawing.Size(112, 17);
            this.numeVanzatorLbl.TabIndex = 45;
            this.numeVanzatorLbl.Text = "Nume vanzator: ";
            // 
            // culoareGrpBox
            // 
            this.culoareGrpBox.Controls.Add(this.negruRdb);
            this.culoareGrpBox.Controls.Add(this.maroRdb);
            this.culoareGrpBox.Controls.Add(this.verdeRdb);
            this.culoareGrpBox.Controls.Add(this.rosuRdb);
            this.culoareGrpBox.Controls.Add(this.portocaliuRdb);
            this.culoareGrpBox.Controls.Add(this.galbenRdb);
            this.culoareGrpBox.Controls.Add(this.movRdb);
            this.culoareGrpBox.Controls.Add(this.albastruRdb);
            this.culoareGrpBox.Controls.Add(this.albRdb);
            this.culoareGrpBox.Location = new System.Drawing.Point(138, 209);
            this.culoareGrpBox.Name = "culoareGrpBox";
            this.culoareGrpBox.Size = new System.Drawing.Size(363, 100);
            this.culoareGrpBox.TabIndex = 44;
            this.culoareGrpBox.TabStop = false;
            // 
            // negruRdb
            // 
            this.negruRdb.AutoSize = true;
            this.negruRdb.Location = new System.Drawing.Point(241, 69);
            this.negruRdb.Name = "negruRdb";
            this.negruRdb.Size = new System.Drawing.Size(68, 21);
            this.negruRdb.TabIndex = 8;
            this.negruRdb.TabStop = true;
            this.negruRdb.Text = "Negru";
            this.negruRdb.UseVisualStyleBackColor = true;
            // 
            // maroRdb
            // 
            this.maroRdb.AutoSize = true;
            this.maroRdb.Location = new System.Drawing.Point(124, 69);
            this.maroRdb.Name = "maroRdb";
            this.maroRdb.Size = new System.Drawing.Size(61, 21);
            this.maroRdb.TabIndex = 7;
            this.maroRdb.TabStop = true;
            this.maroRdb.Text = "Maro";
            this.maroRdb.UseVisualStyleBackColor = true;
            // 
            // verdeRdb
            // 
            this.verdeRdb.AutoSize = true;
            this.verdeRdb.Location = new System.Drawing.Point(7, 69);
            this.verdeRdb.Name = "verdeRdb";
            this.verdeRdb.Size = new System.Drawing.Size(67, 21);
            this.verdeRdb.TabIndex = 6;
            this.verdeRdb.TabStop = true;
            this.verdeRdb.Text = "Verde";
            this.verdeRdb.UseVisualStyleBackColor = true;
            // 
            // rosuRdb
            // 
            this.rosuRdb.AutoSize = true;
            this.rosuRdb.Location = new System.Drawing.Point(241, 41);
            this.rosuRdb.Name = "rosuRdb";
            this.rosuRdb.Size = new System.Drawing.Size(62, 21);
            this.rosuRdb.TabIndex = 5;
            this.rosuRdb.TabStop = true;
            this.rosuRdb.Text = "Rosu";
            this.rosuRdb.UseVisualStyleBackColor = true;
            // 
            // portocaliuRdb
            // 
            this.portocaliuRdb.AutoSize = true;
            this.portocaliuRdb.Location = new System.Drawing.Point(124, 41);
            this.portocaliuRdb.Name = "portocaliuRdb";
            this.portocaliuRdb.Size = new System.Drawing.Size(92, 21);
            this.portocaliuRdb.TabIndex = 4;
            this.portocaliuRdb.TabStop = true;
            this.portocaliuRdb.Text = "Portocaliu";
            this.portocaliuRdb.UseVisualStyleBackColor = true;
            // 
            // galbenRdb
            // 
            this.galbenRdb.AutoSize = true;
            this.galbenRdb.Location = new System.Drawing.Point(7, 42);
            this.galbenRdb.Name = "galbenRdb";
            this.galbenRdb.Size = new System.Drawing.Size(75, 21);
            this.galbenRdb.TabIndex = 3;
            this.galbenRdb.TabStop = true;
            this.galbenRdb.Text = "Galben";
            this.galbenRdb.UseVisualStyleBackColor = true;
            // 
            // movRdb
            // 
            this.movRdb.AutoSize = true;
            this.movRdb.Location = new System.Drawing.Point(241, 13);
            this.movRdb.Name = "movRdb";
            this.movRdb.Size = new System.Drawing.Size(55, 21);
            this.movRdb.TabIndex = 2;
            this.movRdb.TabStop = true;
            this.movRdb.Text = "Mov";
            this.movRdb.UseVisualStyleBackColor = true;
            // 
            // albastruRdb
            // 
            this.albastruRdb.AutoSize = true;
            this.albastruRdb.Location = new System.Drawing.Point(124, 13);
            this.albastruRdb.Name = "albastruRdb";
            this.albastruRdb.Size = new System.Drawing.Size(81, 21);
            this.albastruRdb.TabIndex = 1;
            this.albastruRdb.TabStop = true;
            this.albastruRdb.Text = "Albastru";
            this.albastruRdb.UseVisualStyleBackColor = true;
            // 
            // albRdb
            // 
            this.albRdb.AutoSize = true;
            this.albRdb.Location = new System.Drawing.Point(7, 13);
            this.albRdb.Name = "albRdb";
            this.albRdb.Size = new System.Drawing.Size(49, 21);
            this.albRdb.TabIndex = 0;
            this.albRdb.TabStop = true;
            this.albRdb.Text = "Alb";
            this.albRdb.UseVisualStyleBackColor = true;
            // 
            // anFTxt
            // 
            this.anFTxt.Location = new System.Drawing.Point(246, 177);
            this.anFTxt.Name = "anFTxt";
            this.anFTxt.Size = new System.Drawing.Size(204, 22);
            this.anFTxt.TabIndex = 43;
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(246, 145);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(204, 22);
            this.modelTxt.TabIndex = 42;
            // 
            // firmaTxt
            // 
            this.firmaTxt.Location = new System.Drawing.Point(246, 116);
            this.firmaTxt.Name = "firmaTxt";
            this.firmaTxt.Size = new System.Drawing.Size(204, 22);
            this.firmaTxt.TabIndex = 41;
            // 
            // culoareLbl
            // 
            this.culoareLbl.AutoSize = true;
            this.culoareLbl.Location = new System.Drawing.Point(67, 209);
            this.culoareLbl.Name = "culoareLbl";
            this.culoareLbl.Size = new System.Drawing.Size(65, 17);
            this.culoareLbl.TabIndex = 40;
            this.culoareLbl.Text = "Culoare: ";
            // 
            // anFLbl
            // 
            this.anFLbl.AutoSize = true;
            this.anFLbl.Location = new System.Drawing.Point(67, 180);
            this.anFLbl.Name = "anFLbl";
            this.anFLbl.Size = new System.Drawing.Size(95, 17);
            this.anFLbl.TabIndex = 39;
            this.anFLbl.Text = "An fabricatie: ";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(67, 148);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(54, 17);
            this.modelLbl.TabIndex = 38;
            this.modelLbl.Text = "Model: ";
            // 
            // firmaLbl
            // 
            this.firmaLbl.AutoSize = true;
            this.firmaLbl.Location = new System.Drawing.Point(67, 119);
            this.firmaLbl.Name = "firmaLbl";
            this.firmaLbl.Size = new System.Drawing.Size(51, 17);
            this.firmaLbl.TabIndex = 37;
            this.firmaLbl.Text = "Firma: ";
            // 
            // ListaMasiniSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1099, 775);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.optiuniGrpBox);
            this.Controls.Add(this.optiuniLbl);
            this.Controls.Add(this.tipCmbBox);
            this.Controls.Add(this.pretTxt);
            this.Controls.Add(this.numeCumparatorTxt);
            this.Controls.Add(this.numeVanzatorTxt);
            this.Controls.Add(this.tipMasinaLbl);
            this.Controls.Add(this.pretLbl);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.numeCumparatorLbl);
            this.Controls.Add(this.numeVanzatorLbl);
            this.Controls.Add(this.culoareGrpBox);
            this.Controls.Add(this.anFTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.firmaTxt);
            this.Controls.Add(this.culoareLbl);
            this.Controls.Add(this.anFLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.firmaLbl);
            this.Controls.Add(this.listView1);
            this.Name = "ListaMasiniSell";
            this.Text = "ListaMasiniSell";
            this.Load += new System.EventHandler(this.ListaMasiniSell_Load);
            this.optiuniGrpBox.ResumeLayout(false);
            this.optiuniGrpBox.PerformLayout();
            this.culoareGrpBox.ResumeLayout(false);
            this.culoareGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader FirmaColumn;
        private System.Windows.Forms.ColumnHeader modelColumn;
        private System.Windows.Forms.ColumnHeader anColumn;
        private System.Windows.Forms.ColumnHeader culoareColumn;
        private System.Windows.Forms.ColumnHeader numeVanzatorColumn;
        private System.Windows.Forms.ColumnHeader pretColumn;
        private System.Windows.Forms.ColumnHeader tipColumn;
        private System.Windows.Forms.ColumnHeader optiuniColumn;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.GroupBox optiuniGrpBox;
        private System.Windows.Forms.CheckBox leatherCheck;
        private System.Windows.Forms.CheckBox masajCheck;
        private System.Windows.Forms.CheckBox pilotCheck;
        private System.Windows.Forms.CheckBox proiectoareCheck;
        private System.Windows.Forms.CheckBox bluetoothCheck;
        private System.Windows.Forms.CheckBox solarCheck;
        private System.Windows.Forms.CheckBox cruiseCheck;
        private System.Windows.Forms.CheckBox airbagCheck;
        private System.Windows.Forms.CheckBox absCheck;
        private System.Windows.Forms.Label optiuniLbl;
        private System.Windows.Forms.ComboBox tipCmbBox;
        private System.Windows.Forms.TextBox pretTxt;
        private System.Windows.Forms.TextBox numeCumparatorTxt;
        private System.Windows.Forms.TextBox numeVanzatorTxt;
        private System.Windows.Forms.Label tipMasinaLbl;
        private System.Windows.Forms.Label pretLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label numeCumparatorLbl;
        private System.Windows.Forms.Label numeVanzatorLbl;
        private System.Windows.Forms.GroupBox culoareGrpBox;
        private System.Windows.Forms.RadioButton negruRdb;
        private System.Windows.Forms.RadioButton maroRdb;
        private System.Windows.Forms.RadioButton verdeRdb;
        private System.Windows.Forms.RadioButton rosuRdb;
        private System.Windows.Forms.RadioButton portocaliuRdb;
        private System.Windows.Forms.RadioButton galbenRdb;
        private System.Windows.Forms.RadioButton movRdb;
        private System.Windows.Forms.RadioButton albastruRdb;
        private System.Windows.Forms.RadioButton albRdb;
        private System.Windows.Forms.TextBox anFTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.TextBox firmaTxt;
        private System.Windows.Forms.Label culoareLbl;
        private System.Windows.Forms.Label anFLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label firmaLbl;
    }
}