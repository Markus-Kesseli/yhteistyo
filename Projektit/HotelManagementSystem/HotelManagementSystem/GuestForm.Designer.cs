namespace HotelManagementSystem
{
    partial class GuestForm
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
            this.idAS = new System.Windows.Forms.TextBox();
            this.enimiAS = new System.Windows.Forms.TextBox();
            this.snimiAS = new System.Windows.Forms.TextBox();
            this.paikkakuntaAS = new System.Windows.Forms.TextBox();
            this.puhAS = new System.Windows.Forms.TextBox();
            this.asiakkaatDG = new System.Windows.Forms.DataGridView();
            this.saveAS = new System.Windows.Forms.Button();
            this.updateAS = new System.Windows.Forms.Button();
            this.deleteAS = new System.Windows.Forms.Button();
            this.CleanAS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Käyttäjätunnus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paikkakunta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Puhelin";
            // 
            // idAS
            // 
            this.idAS.Location = new System.Drawing.Point(154, 31);
            this.idAS.Name = "idAS";
            this.idAS.Size = new System.Drawing.Size(100, 26);
            this.idAS.TabIndex = 5;
            // 
            // enimiAS
            // 
            this.enimiAS.Location = new System.Drawing.Point(154, 76);
            this.enimiAS.Name = "enimiAS";
            this.enimiAS.Size = new System.Drawing.Size(100, 26);
            this.enimiAS.TabIndex = 6;
            // 
            // snimiAS
            // 
            this.snimiAS.Location = new System.Drawing.Point(154, 120);
            this.snimiAS.Name = "snimiAS";
            this.snimiAS.Size = new System.Drawing.Size(100, 26);
            this.snimiAS.TabIndex = 7;
            // 
            // paikkakuntaAS
            // 
            this.paikkakuntaAS.Location = new System.Drawing.Point(154, 165);
            this.paikkakuntaAS.Name = "paikkakuntaAS";
            this.paikkakuntaAS.Size = new System.Drawing.Size(100, 26);
            this.paikkakuntaAS.TabIndex = 8;
            // 
            // puhAS
            // 
            this.puhAS.Location = new System.Drawing.Point(154, 212);
            this.puhAS.Name = "puhAS";
            this.puhAS.Size = new System.Drawing.Size(100, 26);
            this.puhAS.TabIndex = 9;
            // 
            // asiakkaatDG
            // 
            this.asiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaatDG.Location = new System.Drawing.Point(297, 12);
            this.asiakkaatDG.Name = "asiakkaatDG";
            this.asiakkaatDG.Size = new System.Drawing.Size(496, 359);
            this.asiakkaatDG.TabIndex = 10;
            this.asiakkaatDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaatDG_CellContentClick);
            // 
            // saveAS
            // 
            this.saveAS.Location = new System.Drawing.Point(15, 305);
            this.saveAS.Name = "saveAS";
            this.saveAS.Size = new System.Drawing.Size(75, 25);
            this.saveAS.TabIndex = 11;
            this.saveAS.Text = "Tallenna";
            this.saveAS.UseVisualStyleBackColor = true;
            this.saveAS.Click += new System.EventHandler(this.saveAS_Click);
            // 
            // updateAS
            // 
            this.updateAS.Location = new System.Drawing.Point(15, 347);
            this.updateAS.Name = "updateAS";
            this.updateAS.Size = new System.Drawing.Size(75, 25);
            this.updateAS.TabIndex = 12;
            this.updateAS.Text = "Päivitä";
            this.updateAS.UseVisualStyleBackColor = true;
            this.updateAS.Click += new System.EventHandler(this.updateAS_Click);
            // 
            // deleteAS
            // 
            this.deleteAS.Location = new System.Drawing.Point(154, 305);
            this.deleteAS.Name = "deleteAS";
            this.deleteAS.Size = new System.Drawing.Size(75, 25);
            this.deleteAS.TabIndex = 13;
            this.deleteAS.Text = "Poista";
            this.deleteAS.UseVisualStyleBackColor = true;
            this.deleteAS.Click += new System.EventHandler(this.deleteAS_Click);
            // 
            // CleanAS
            // 
            this.CleanAS.Location = new System.Drawing.Point(154, 347);
            this.CleanAS.Name = "CleanAS";
            this.CleanAS.Size = new System.Drawing.Size(75, 25);
            this.CleanAS.TabIndex = 14;
            this.CleanAS.Text = "Tyhjennä";
            this.CleanAS.UseVisualStyleBackColor = true;
            this.CleanAS.Click += new System.EventHandler(this.CleanAS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "* = pakkoliset kentät";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 383);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CleanAS);
            this.Controls.Add(this.deleteAS);
            this.Controls.Add(this.updateAS);
            this.Controls.Add(this.saveAS);
            this.Controls.Add(this.asiakkaatDG);
            this.Controls.Add(this.puhAS);
            this.Controls.Add(this.paikkakuntaAS);
            this.Controls.Add(this.snimiAS);
            this.Controls.Add(this.enimiAS);
            this.Controls.Add(this.idAS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestForm";
            this.Text = "Asiakkaan hallinta";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idAS;
        private System.Windows.Forms.TextBox enimiAS;
        private System.Windows.Forms.TextBox snimiAS;
        private System.Windows.Forms.TextBox paikkakuntaAS;
        private System.Windows.Forms.TextBox puhAS;
        private System.Windows.Forms.DataGridView asiakkaatDG;
        private System.Windows.Forms.Button saveAS;
        private System.Windows.Forms.Button updateAS;
        private System.Windows.Forms.Button deleteAS;
        private System.Windows.Forms.Button CleanAS;
        private System.Windows.Forms.Label label6;
    }
}