namespace Hotelli
{
    partial class Kirjautumisikkuna
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
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KirjautuminenLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KirjauduPainike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::Hotelli.Properties.Resources.login_user;
            this.loginPictureBox.Location = new System.Drawing.Point(188, 25);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(119, 94);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.KirjautuminenLB);
            this.panel1.Location = new System.Drawing.Point(82, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 72);
            this.panel1.TabIndex = 1;
            // 
            // KirjautuminenLB
            // 
            this.KirjautuminenLB.AutoSize = true;
            this.KirjautuminenLB.BackColor = System.Drawing.Color.Gold;
            this.KirjautuminenLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjautuminenLB.Location = new System.Drawing.Point(63, 22);
            this.KirjautuminenLB.Name = "KirjautuminenLB";
            this.KirjautuminenLB.Size = new System.Drawing.Size(210, 32);
            this.KirjautuminenLB.TabIndex = 0;
            this.KirjautuminenLB.Text = "Kirjaudu sisään";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KirjauduPainike);
            this.groupBox1.Controls.Add(this.SalasanaLB);
            this.groupBox1.Controls.Add(this.KayttajaLB);
            this.groupBox1.Controls.Add(this.SalasanaTB);
            this.groupBox1.Controls.Add(this.KayttajaTB);
            this.groupBox1.Location = new System.Drawing.Point(82, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.BackColor = System.Drawing.Color.Gold;
            this.KayttajaTB.Location = new System.Drawing.Point(130, 19);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(173, 22);
            this.KayttajaTB.TabIndex = 0;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.BackColor = System.Drawing.Color.Gold;
            this.SalasanaTB.Location = new System.Drawing.Point(130, 57);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(173, 22);
            this.SalasanaTB.TabIndex = 1;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KayttajaLB.Location = new System.Drawing.Point(21, 22);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(82, 16);
            this.KayttajaLB.TabIndex = 2;
            this.KayttajaLB.Text = "Käyttäjänimi:";
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalasanaLB.Location = new System.Drawing.Point(21, 60);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(68, 16);
            this.SalasanaLB.TabIndex = 3;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KirjauduPainike
            // 
            this.KirjauduPainike.BackColor = System.Drawing.Color.DarkMagenta;
            this.KirjauduPainike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KirjauduPainike.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KirjauduPainike.Location = new System.Drawing.Point(24, 98);
            this.KirjauduPainike.Name = "KirjauduPainike";
            this.KirjauduPainike.Size = new System.Drawing.Size(279, 37);
            this.KirjauduPainike.TabIndex = 4;
            this.KirjauduPainike.Text = "Kirjaudu";
            this.KirjauduPainike.UseVisualStyleBackColor = false;
            this.KirjauduPainike.Click += new System.EventHandler(this.KirjauduPainike_Click);
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(520, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPictureBox);
            this.Name = "Kirjautumisikkuna";
            this.Text = "Kirjautumisikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KirjautuminenLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Button KirjauduPainike;
    }
}

