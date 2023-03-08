namespace Hotelli
{
    partial class AsiakkaidenHallinta
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
            this.AsiakkaatDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LisaaUusiAsiakasBT = new System.Windows.Forms.Button();
            this.AsiakasMuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaKentatBT = new System.Windows.Forms.Button();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.LahiosoiteTB = new System.Windows.Forms.TextBox();
            this.PostinumeroTB = new System.Windows.Forms.TextBox();
            this.PostitoimipaikkaTB = new System.Windows.Forms.TextBox();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // AsiakkaatDG
            // 
            this.AsiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsiakkaatDG.Location = new System.Drawing.Point(323, 72);
            this.AsiakkaatDG.Name = "AsiakkaatDG";
            this.AsiakkaatDG.RowHeadersWidth = 51;
            this.AsiakkaatDG.RowTemplate.Height = 24;
            this.AsiakkaatDG.Size = new System.Drawing.Size(465, 338);
            this.AsiakkaatDG.TabIndex = 0;
            this.AsiakkaatDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakkaatDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lähiosoite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postinumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postitoimipaikka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Käyttäjätunnus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salasana:";
            // 
            // LisaaUusiAsiakasBT
            // 
            this.LisaaUusiAsiakasBT.Location = new System.Drawing.Point(39, 330);
            this.LisaaUusiAsiakasBT.Name = "LisaaUusiAsiakasBT";
            this.LisaaUusiAsiakasBT.Size = new System.Drawing.Size(154, 32);
            this.LisaaUusiAsiakasBT.TabIndex = 8;
            this.LisaaUusiAsiakasBT.Text = "Lisää uusi asiakas";
            this.LisaaUusiAsiakasBT.UseVisualStyleBackColor = true;
            this.LisaaUusiAsiakasBT.Click += new System.EventHandler(this.LisaaUusiAsiakasBT_Click);
            // 
            // AsiakasMuokkaaBT
            // 
            this.AsiakasMuokkaaBT.Location = new System.Drawing.Point(213, 334);
            this.AsiakasMuokkaaBT.Name = "AsiakasMuokkaaBT";
            this.AsiakasMuokkaaBT.Size = new System.Drawing.Size(95, 28);
            this.AsiakasMuokkaaBT.TabIndex = 9;
            this.AsiakasMuokkaaBT.Text = "Muokkaa";
            this.AsiakasMuokkaaBT.UseVisualStyleBackColor = true;
            this.AsiakasMuokkaaBT.Click += new System.EventHandler(this.AsiakasMuokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(213, 381);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(104, 29);
            this.PoistaBT.TabIndex = 10;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TyhjennaKentatBT
            // 
            this.TyhjennaKentatBT.Location = new System.Drawing.Point(39, 381);
            this.TyhjennaKentatBT.Name = "TyhjennaKentatBT";
            this.TyhjennaKentatBT.Size = new System.Drawing.Size(148, 29);
            this.TyhjennaKentatBT.TabIndex = 11;
            this.TyhjennaKentatBT.Text = "Tyhjennä kentät";
            this.TyhjennaKentatBT.UseVisualStyleBackColor = true;
            this.TyhjennaKentatBT.Click += new System.EventHandler(this.TyhjennaKentatBT_Click);
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.BackColor = System.Drawing.Color.Gold;
            this.EtunimiTB.Location = new System.Drawing.Point(157, 79);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(127, 22);
            this.EtunimiTB.TabIndex = 12;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.BackColor = System.Drawing.Color.Gold;
            this.SukunimiTB.Location = new System.Drawing.Point(157, 115);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(127, 22);
            this.SukunimiTB.TabIndex = 13;
            // 
            // LahiosoiteTB
            // 
            this.LahiosoiteTB.BackColor = System.Drawing.Color.Gold;
            this.LahiosoiteTB.Location = new System.Drawing.Point(157, 150);
            this.LahiosoiteTB.Name = "LahiosoiteTB";
            this.LahiosoiteTB.Size = new System.Drawing.Size(127, 22);
            this.LahiosoiteTB.TabIndex = 14;
            // 
            // PostinumeroTB
            // 
            this.PostinumeroTB.BackColor = System.Drawing.Color.Gold;
            this.PostinumeroTB.Location = new System.Drawing.Point(157, 184);
            this.PostinumeroTB.Name = "PostinumeroTB";
            this.PostinumeroTB.Size = new System.Drawing.Size(127, 22);
            this.PostinumeroTB.TabIndex = 15;
            // 
            // PostitoimipaikkaTB
            // 
            this.PostitoimipaikkaTB.BackColor = System.Drawing.Color.Gold;
            this.PostitoimipaikkaTB.Location = new System.Drawing.Point(157, 214);
            this.PostitoimipaikkaTB.Name = "PostitoimipaikkaTB";
            this.PostitoimipaikkaTB.Size = new System.Drawing.Size(127, 22);
            this.PostitoimipaikkaTB.TabIndex = 16;
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.BackColor = System.Drawing.Color.Gold;
            this.KayttajatunnusTB.Location = new System.Drawing.Point(157, 250);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(127, 22);
            this.KayttajatunnusTB.TabIndex = 17;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.BackColor = System.Drawing.Color.Gold;
            this.SalasanaTB.Location = new System.Drawing.Point(157, 284);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(127, 22);
            this.SalasanaTB.TabIndex = 18;
            // 
            // AsiakkaidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.KayttajatunnusTB);
            this.Controls.Add(this.PostitoimipaikkaTB);
            this.Controls.Add(this.PostinumeroTB);
            this.Controls.Add(this.LahiosoiteTB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.TyhjennaKentatBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.AsiakasMuokkaaBT);
            this.Controls.Add(this.LisaaUusiAsiakasBT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsiakkaatDG);
            this.Name = "AsiakkaidenHallinta";
            this.Text = "AsiakkaidenHallinta";
            this.Load += new System.EventHandler(this.AsiakkaidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AsiakkaatDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LisaaUusiAsiakasBT;
        private System.Windows.Forms.Button AsiakasMuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaKentatBT;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox LahiosoiteTB;
        private System.Windows.Forms.TextBox PostinumeroTB;
        private System.Windows.Forms.TextBox PostitoimipaikkaTB;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.TextBox SalasanaTB;
    }
}