namespace Hotelli
{
    partial class HuoneidenHallinta
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
            this.HuoneHallintaDG = new System.Windows.Forms.DataGridView();
            this.HuoneHallintaPuhelinTB = new System.Windows.Forms.TextBox();
            this.HuoneHallintaNroTB = new System.Windows.Forms.TextBox();
            this.HuoneTyhjennaBT = new System.Windows.Forms.Button();
            this.HuoneTallennaBT = new System.Windows.Forms.Button();
            this.HuoneMuokkaaBT = new System.Windows.Forms.Button();
            this.HuoneLisaaBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HuoneHallintaTyyppiTB = new System.Windows.Forms.ComboBox();
            this.HuoneVapaaRB = new System.Windows.Forms.RadioButton();
            this.HuoneeiRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneHallintaDG)).BeginInit();
            this.SuspendLayout();
            // 
            // HuoneHallintaDG
            // 
            this.HuoneHallintaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HuoneHallintaDG.Location = new System.Drawing.Point(274, 12);
            this.HuoneHallintaDG.Name = "HuoneHallintaDG";
            this.HuoneHallintaDG.Size = new System.Drawing.Size(514, 219);
            this.HuoneHallintaDG.TabIndex = 33;
            // 
            // HuoneHallintaPuhelinTB
            // 
            this.HuoneHallintaPuhelinTB.Location = new System.Drawing.Point(115, 84);
            this.HuoneHallintaPuhelinTB.Name = "HuoneHallintaPuhelinTB";
            this.HuoneHallintaPuhelinTB.Size = new System.Drawing.Size(125, 20);
            this.HuoneHallintaPuhelinTB.TabIndex = 32;
            // 
            // HuoneHallintaNroTB
            // 
            this.HuoneHallintaNroTB.Location = new System.Drawing.Point(115, 30);
            this.HuoneHallintaNroTB.Name = "HuoneHallintaNroTB";
            this.HuoneHallintaNroTB.Size = new System.Drawing.Size(125, 20);
            this.HuoneHallintaNroTB.TabIndex = 30;
            // 
            // HuoneTyhjennaBT
            // 
            this.HuoneTyhjennaBT.Location = new System.Drawing.Point(115, 187);
            this.HuoneTyhjennaBT.Name = "HuoneTyhjennaBT";
            this.HuoneTyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.HuoneTyhjennaBT.TabIndex = 26;
            this.HuoneTyhjennaBT.Text = "Tyhjennä";
            this.HuoneTyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // HuoneTallennaBT
            // 
            this.HuoneTallennaBT.Location = new System.Drawing.Point(34, 187);
            this.HuoneTallennaBT.Name = "HuoneTallennaBT";
            this.HuoneTallennaBT.Size = new System.Drawing.Size(75, 23);
            this.HuoneTallennaBT.TabIndex = 25;
            this.HuoneTallennaBT.Text = "Tallenna";
            this.HuoneTallennaBT.UseVisualStyleBackColor = true;
            // 
            // HuoneMuokkaaBT
            // 
            this.HuoneMuokkaaBT.Location = new System.Drawing.Point(115, 158);
            this.HuoneMuokkaaBT.Name = "HuoneMuokkaaBT";
            this.HuoneMuokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.HuoneMuokkaaBT.TabIndex = 24;
            this.HuoneMuokkaaBT.Text = "Muokkaa";
            this.HuoneMuokkaaBT.UseVisualStyleBackColor = true;
            // 
            // HuoneLisaaBT
            // 
            this.HuoneLisaaBT.Location = new System.Drawing.Point(34, 158);
            this.HuoneLisaaBT.Name = "HuoneLisaaBT";
            this.HuoneLisaaBT.Size = new System.Drawing.Size(75, 23);
            this.HuoneLisaaBT.TabIndex = 23;
            this.HuoneLisaaBT.Text = "Lisää";
            this.HuoneLisaaBT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Puhelin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Huonetyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Huoneen nro:";
            // 
            // HuoneHallintaTyyppiTB
            // 
            this.HuoneHallintaTyyppiTB.FormattingEnabled = true;
            this.HuoneHallintaTyyppiTB.Items.AddRange(new object[] {
            "Comfort double",
            "Comfort twin",
            "Deluxe"});
            this.HuoneHallintaTyyppiTB.Location = new System.Drawing.Point(115, 57);
            this.HuoneHallintaTyyppiTB.Name = "HuoneHallintaTyyppiTB";
            this.HuoneHallintaTyyppiTB.Size = new System.Drawing.Size(125, 21);
            this.HuoneHallintaTyyppiTB.TabIndex = 34;
            // 
            // HuoneVapaaRB
            // 
            this.HuoneVapaaRB.AutoSize = true;
            this.HuoneVapaaRB.Location = new System.Drawing.Point(115, 124);
            this.HuoneVapaaRB.Name = "HuoneVapaaRB";
            this.HuoneVapaaRB.Size = new System.Drawing.Size(56, 17);
            this.HuoneVapaaRB.TabIndex = 35;
            this.HuoneVapaaRB.TabStop = true;
            this.HuoneVapaaRB.Text = "Vapaa";
            this.HuoneVapaaRB.UseVisualStyleBackColor = true;
            // 
            // HuoneeiRB
            // 
            this.HuoneeiRB.AutoSize = true;
            this.HuoneeiRB.Location = new System.Drawing.Point(177, 124);
            this.HuoneeiRB.Name = "HuoneeiRB";
            this.HuoneeiRB.Size = new System.Drawing.Size(34, 17);
            this.HuoneeiRB.TabIndex = 36;
            this.HuoneeiRB.TabStop = true;
            this.HuoneeiRB.Text = "Ei";
            this.HuoneeiRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Vapaa:";
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HuoneeiRB);
            this.Controls.Add(this.HuoneVapaaRB);
            this.Controls.Add(this.HuoneHallintaTyyppiTB);
            this.Controls.Add(this.HuoneHallintaDG);
            this.Controls.Add(this.HuoneHallintaPuhelinTB);
            this.Controls.Add(this.HuoneHallintaNroTB);
            this.Controls.Add(this.HuoneTyhjennaBT);
            this.Controls.Add(this.HuoneTallennaBT);
            this.Controls.Add(this.HuoneMuokkaaBT);
            this.Controls.Add(this.HuoneLisaaBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            ((System.ComponentModel.ISupportInitialize)(this.HuoneHallintaDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HuoneHallintaDG;
        private System.Windows.Forms.TextBox HuoneHallintaPuhelinTB;
        private System.Windows.Forms.TextBox HuoneHallintaNroTB;
        private System.Windows.Forms.Button HuoneTyhjennaBT;
        private System.Windows.Forms.Button HuoneTallennaBT;
        private System.Windows.Forms.Button HuoneMuokkaaBT;
        private System.Windows.Forms.Button HuoneLisaaBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HuoneHallintaTyyppiTB;
        private System.Windows.Forms.RadioButton HuoneVapaaRB;
        private System.Windows.Forms.RadioButton HuoneeiRB;
        private System.Windows.Forms.Label label1;
    }
}