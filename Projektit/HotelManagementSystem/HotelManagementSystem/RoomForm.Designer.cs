namespace HotelManagementSystem
{
    partial class RoomForm
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
            this.huoneetDG = new System.Windows.Forms.DataGridView();
            this.CleanAS = new System.Windows.Forms.Button();
            this.deleteAS = new System.Windows.Forms.Button();
            this.updateAS = new System.Windows.Forms.Button();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.huonePUH = new System.Windows.Forms.TextBox();
            this.huoneid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.huoneCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.huonevarattu = new System.Windows.Forms.RadioButton();
            this.huonevapaa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(297, 12);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.RowHeadersWidth = 51;
            this.huoneetDG.Size = new System.Drawing.Size(496, 359);
            this.huoneetDG.TabIndex = 11;
            this.huoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.huoneetDG_CellClick);
            // 
            // CleanAS
            // 
            this.CleanAS.Location = new System.Drawing.Point(153, 346);
            this.CleanAS.Name = "CleanAS";
            this.CleanAS.Size = new System.Drawing.Size(75, 25);
            this.CleanAS.TabIndex = 28;
            this.CleanAS.Text = "Tyhjennä";
            this.CleanAS.UseVisualStyleBackColor = true;
            this.CleanAS.Click += new System.EventHandler(this.CleanAS_Click);
            // 
            // deleteAS
            // 
            this.deleteAS.Location = new System.Drawing.Point(153, 304);
            this.deleteAS.Name = "deleteAS";
            this.deleteAS.Size = new System.Drawing.Size(75, 25);
            this.deleteAS.TabIndex = 27;
            this.deleteAS.Text = "Poista";
            this.deleteAS.UseVisualStyleBackColor = true;
            this.deleteAS.Click += new System.EventHandler(this.deleteAS_Click);
            // 
            // updateAS
            // 
            this.updateAS.Location = new System.Drawing.Point(14, 346);
            this.updateAS.Name = "updateAS";
            this.updateAS.Size = new System.Drawing.Size(75, 25);
            this.updateAS.TabIndex = 26;
            this.updateAS.Text = "Päivitä";
            this.updateAS.UseVisualStyleBackColor = true;
            this.updateAS.Click += new System.EventHandler(this.updateAS_Click);
            // 
            // lisaaBT
            // 
            this.lisaaBT.Location = new System.Drawing.Point(14, 304);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(75, 25);
            this.lisaaBT.TabIndex = 25;
            this.lisaaBT.Text = "Lisää";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // huonePUH
            // 
            this.huonePUH.Location = new System.Drawing.Point(153, 119);
            this.huonePUH.Name = "huonePUH";
            this.huonePUH.Size = new System.Drawing.Size(100, 31);
            this.huonePUH.TabIndex = 22;
            // 
            // huoneid
            // 
            this.huoneid.Location = new System.Drawing.Point(153, 30);
            this.huoneid.Name = "huoneid";
            this.huoneid.Size = new System.Drawing.Size(100, 31);
            this.huoneid.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tila:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puhelin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Huoneen tyyppi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Huoneen nro:";
            // 
            // huoneCB
            // 
            this.huoneCB.FormattingEnabled = true;
            this.huoneCB.Location = new System.Drawing.Point(153, 75);
            this.huoneCB.Name = "huoneCB";
            this.huoneCB.Size = new System.Drawing.Size(100, 29);
            this.huoneCB.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.huonevarattu);
            this.groupBox1.Controls.Add(this.huonevapaa);
            this.groupBox1.Location = new System.Drawing.Point(107, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 40);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // huonevarattu
            // 
            this.huonevarattu.AutoSize = true;
            this.huonevarattu.Location = new System.Drawing.Point(72, 8);
            this.huonevarattu.Name = "huonevarattu";
            this.huonevarattu.Size = new System.Drawing.Size(88, 25);
            this.huonevarattu.TabIndex = 1;
            this.huonevarattu.TabStop = true;
            this.huonevarattu.Text = "varattu";
            this.huonevarattu.UseVisualStyleBackColor = true;
            // 
            // huonevapaa
            // 
            this.huonevapaa.AutoSize = true;
            this.huonevapaa.Location = new System.Drawing.Point(6, 8);
            this.huonevapaa.Name = "huonevapaa";
            this.huonevapaa.Size = new System.Drawing.Size(78, 25);
            this.huonevapaa.TabIndex = 0;
            this.huonevapaa.TabStop = true;
            this.huonevapaa.Text = "vapaa";
            this.huonevapaa.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(805, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.huoneCB);
            this.Controls.Add(this.CleanAS);
            this.Controls.Add(this.deleteAS);
            this.Controls.Add(this.updateAS);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.huonePUH);
            this.Controls.Add(this.huoneid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.huoneetDG);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView huoneetDG;
        private System.Windows.Forms.Button CleanAS;
        private System.Windows.Forms.Button deleteAS;
        private System.Windows.Forms.Button updateAS;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.TextBox huonePUH;
        private System.Windows.Forms.TextBox huoneid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox huoneCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton huonevarattu;
        private System.Windows.Forms.RadioButton huonevapaa;
    }
}