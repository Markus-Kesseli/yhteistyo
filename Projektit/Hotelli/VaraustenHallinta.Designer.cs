namespace Hotelli
{
    partial class VaraustenHallinta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VarausLisaaBT = new System.Windows.Forms.Button();
            this.VarausMuokkaaBT = new System.Windows.Forms.Button();
            this.VarausPoistaBT = new System.Windows.Forms.Button();
            this.VarausTyhjennaBT = new System.Windows.Forms.Button();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            this.VaraustenHallintaDG = new System.Windows.Forms.DataGridView();
            this.VarausAsiakasNroCB = new System.Windows.Forms.ComboBox();
            this.VarausHuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.VarausHuoneNroCB = new System.Windows.Forms.ComboBox();
            this.VarausSisaanDTB = new System.Windows.Forms.DateTimePicker();
            this.VarausUlosDTB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.VaraustenHallintaDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varaus nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asiakas nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huoneen nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sisään:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ulos:";
            // 
            // VarausLisaaBT
            // 
            this.VarausLisaaBT.Location = new System.Drawing.Point(40, 234);
            this.VarausLisaaBT.Name = "VarausLisaaBT";
            this.VarausLisaaBT.Size = new System.Drawing.Size(75, 23);
            this.VarausLisaaBT.TabIndex = 6;
            this.VarausLisaaBT.Text = "Lisää";
            this.VarausLisaaBT.UseVisualStyleBackColor = true;
            this.VarausLisaaBT.Click += new System.EventHandler(this.VarausLisaaBT_Click);
            // 
            // VarausMuokkaaBT
            // 
            this.VarausMuokkaaBT.Location = new System.Drawing.Point(121, 234);
            this.VarausMuokkaaBT.Name = "VarausMuokkaaBT";
            this.VarausMuokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.VarausMuokkaaBT.TabIndex = 7;
            this.VarausMuokkaaBT.Text = "Muokkaa";
            this.VarausMuokkaaBT.UseVisualStyleBackColor = true;
            this.VarausMuokkaaBT.Click += new System.EventHandler(this.VarausMuokkaaBT_Click);
            // 
            // VarausPoistaBT
            // 
            this.VarausPoistaBT.Location = new System.Drawing.Point(40, 263);
            this.VarausPoistaBT.Name = "VarausPoistaBT";
            this.VarausPoistaBT.Size = new System.Drawing.Size(75, 23);
            this.VarausPoistaBT.TabIndex = 8;
            this.VarausPoistaBT.Text = "Poista";
            this.VarausPoistaBT.UseVisualStyleBackColor = true;
            this.VarausPoistaBT.Click += new System.EventHandler(this.VarausPoistaBT_Click);
            // 
            // VarausTyhjennaBT
            // 
            this.VarausTyhjennaBT.Location = new System.Drawing.Point(121, 263);
            this.VarausTyhjennaBT.Name = "VarausTyhjennaBT";
            this.VarausTyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.VarausTyhjennaBT.TabIndex = 9;
            this.VarausTyhjennaBT.Text = "Tyhjennä";
            this.VarausTyhjennaBT.UseVisualStyleBackColor = true;
            this.VarausTyhjennaBT.Click += new System.EventHandler(this.VarausTyhjennaBT_Click);
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.Location = new System.Drawing.Point(121, 36);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(125, 20);
            this.VarausNroTB.TabIndex = 10;
            this.VarausNroTB.TextChanged += new System.EventHandler(this.VarausNroTB_TextChanged);
            // 
            // VaraustenHallintaDG
            // 
            this.VaraustenHallintaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VaraustenHallintaDG.Location = new System.Drawing.Point(286, 12);
            this.VaraustenHallintaDG.Name = "VaraustenHallintaDG";
            this.VaraustenHallintaDG.Size = new System.Drawing.Size(502, 274);
            this.VaraustenHallintaDG.TabIndex = 16;
            this.VaraustenHallintaDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VaraustenHallintaDG_CellClick);
            // 
            // VarausAsiakasNroCB
            // 
            this.VarausAsiakasNroCB.FormattingEnabled = true;
            this.VarausAsiakasNroCB.Location = new System.Drawing.Point(121, 63);
            this.VarausAsiakasNroCB.Name = "VarausAsiakasNroCB";
            this.VarausAsiakasNroCB.Size = new System.Drawing.Size(125, 21);
            this.VarausAsiakasNroCB.TabIndex = 17;
            // 
            // VarausHuonetyyppiCB
            // 
            this.VarausHuonetyyppiCB.FormattingEnabled = true;
            this.VarausHuonetyyppiCB.Location = new System.Drawing.Point(121, 90);
            this.VarausHuonetyyppiCB.Name = "VarausHuonetyyppiCB";
            this.VarausHuonetyyppiCB.Size = new System.Drawing.Size(125, 21);
            this.VarausHuonetyyppiCB.TabIndex = 18;
            this.VarausHuonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.VarausHuonetyyppiCB_SelectedIndexChanged);
            // 
            // VarausHuoneNroCB
            // 
            this.VarausHuoneNroCB.FormattingEnabled = true;
            this.VarausHuoneNroCB.Location = new System.Drawing.Point(121, 117);
            this.VarausHuoneNroCB.Name = "VarausHuoneNroCB";
            this.VarausHuoneNroCB.Size = new System.Drawing.Size(125, 21);
            this.VarausHuoneNroCB.TabIndex = 19;
            // 
            // VarausSisaanDTB
            // 
            this.VarausSisaanDTB.Location = new System.Drawing.Point(121, 144);
            this.VarausSisaanDTB.Name = "VarausSisaanDTB";
            this.VarausSisaanDTB.Size = new System.Drawing.Size(125, 20);
            this.VarausSisaanDTB.TabIndex = 22;
            // 
            // VarausUlosDTB
            // 
            this.VarausUlosDTB.Location = new System.Drawing.Point(121, 170);
            this.VarausUlosDTB.Name = "VarausUlosDTB";
            this.VarausUlosDTB.Size = new System.Drawing.Size(125, 20);
            this.VarausUlosDTB.TabIndex = 23;
            this.VarausUlosDTB.ValueChanged += new System.EventHandler(this.VarausUlosDTB_ValueChanged);
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.VarausUlosDTB);
            this.Controls.Add(this.VarausSisaanDTB);
            this.Controls.Add(this.VarausHuoneNroCB);
            this.Controls.Add(this.VarausHuonetyyppiCB);
            this.Controls.Add(this.VarausAsiakasNroCB);
            this.Controls.Add(this.VaraustenHallintaDG);
            this.Controls.Add(this.VarausNroTB);
            this.Controls.Add(this.VarausTyhjennaBT);
            this.Controls.Add(this.VarausPoistaBT);
            this.Controls.Add(this.VarausMuokkaaBT);
            this.Controls.Add(this.VarausLisaaBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VaraustenHallinta";
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VaraustenHallintaDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button VarausLisaaBT;
        private System.Windows.Forms.Button VarausMuokkaaBT;
        private System.Windows.Forms.Button VarausPoistaBT;
        private System.Windows.Forms.Button VarausTyhjennaBT;
        private System.Windows.Forms.TextBox VarausNroTB;
        private System.Windows.Forms.DataGridView VaraustenHallintaDG;
        private System.Windows.Forms.ComboBox VarausAsiakasNroCB;
        private System.Windows.Forms.ComboBox VarausHuonetyyppiCB;
        private System.Windows.Forms.ComboBox VarausHuoneNroCB;
        private System.Windows.Forms.DateTimePicker VarausSisaanDTB;
        private System.Windows.Forms.DateTimePicker VarausUlosDTB;
    }
}