namespace Hotel_System
{
    partial class Salasana
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
            this.EncryptBT = new System.Windows.Forms.Button();
            this.DecryptBT = new System.Windows.Forms.Button();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.DecryptTB = new System.Windows.Forms.TextBox();
            this.EncryptTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EncryptBT
            // 
            this.EncryptBT.Location = new System.Drawing.Point(324, 217);
            this.EncryptBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptBT.Name = "EncryptBT";
            this.EncryptBT.Size = new System.Drawing.Size(86, 32);
            this.EncryptBT.TabIndex = 0;
            this.EncryptBT.Text = "Encrypt";
            this.EncryptBT.UseVisualStyleBackColor = true;
            this.EncryptBT.Click += new System.EventHandler(this.EncryptBT_Click);
            // 
            // DecryptBT
            // 
            this.DecryptBT.Location = new System.Drawing.Point(324, 266);
            this.DecryptBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptBT.Name = "DecryptBT";
            this.DecryptBT.Size = new System.Drawing.Size(86, 32);
            this.DecryptBT.TabIndex = 1;
            this.DecryptBT.Text = "Decrypt";
            this.DecryptBT.UseVisualStyleBackColor = true;
            this.DecryptBT.Click += new System.EventHandler(this.DecryptBT_Click);
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.Location = new System.Drawing.Point(62, 79);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(95, 25);
            this.SalasanaLB.TabIndex = 2;
            this.SalasanaLB.Text = "Salasana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decrypt:";
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(174, 84);
            this.SalasanaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(224, 27);
            this.SalasanaTB.TabIndex = 5;
            // 
            // DecryptTB
            // 
            this.DecryptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptTB.Location = new System.Drawing.Point(174, 169);
            this.DecryptTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptTB.Name = "DecryptTB";
            this.DecryptTB.Size = new System.Drawing.Size(224, 27);
            this.DecryptTB.TabIndex = 6;
            // 
            // EncryptTB
            // 
            this.EncryptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTB.Location = new System.Drawing.Point(174, 127);
            this.EncryptTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptTB.Name = "EncryptTB";
            this.EncryptTB.Size = new System.Drawing.Size(224, 27);
            this.EncryptTB.TabIndex = 7;
            // 
            // Salasana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(554, 382);
            this.Controls.Add(this.EncryptTB);
            this.Controls.Add(this.DecryptTB);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalasanaLB);
            this.Controls.Add(this.DecryptBT);
            this.Controls.Add(this.EncryptBT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Salasana";
            this.Text = "Salasana";
            this.Load += new System.EventHandler(this.Salasana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptBT;
        private System.Windows.Forms.Button DecryptBT;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox DecryptTB;
        private System.Windows.Forms.TextBox EncryptTB;
    }
}