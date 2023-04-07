namespace HotelManagementSystem
{
    partial class ReservationForm
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
            this.tyhjennaVR = new System.Windows.Forms.Button();
            this.poistaVR = new System.Windows.Forms.Button();
            this.paivitaVR = new System.Windows.Forms.Button();
            this.lisaaVR = new System.Windows.Forms.Button();
            this.varauksetDG = new System.Windows.Forms.DataGridView();
            this.asiakasID = new System.Windows.Forms.TextBox();
            this.varausID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.huonenroCB = new System.Windows.Forms.ComboBox();
            this.huonetypeCB = new System.Windows.Forms.ComboBox();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tyhjennaVR
            // 
            this.tyhjennaVR.Location = new System.Drawing.Point(154, 346);
            this.tyhjennaVR.Name = "tyhjennaVR";
            this.tyhjennaVR.Size = new System.Drawing.Size(75, 25);
            this.tyhjennaVR.TabIndex = 29;
            this.tyhjennaVR.Text = "Tyhjennä";
            this.tyhjennaVR.UseVisualStyleBackColor = true;
            this.tyhjennaVR.Click += new System.EventHandler(this.tyhjennaVR_Click);
            // 
            // poistaVR
            // 
            this.poistaVR.Location = new System.Drawing.Point(154, 304);
            this.poistaVR.Name = "poistaVR";
            this.poistaVR.Size = new System.Drawing.Size(75, 25);
            this.poistaVR.TabIndex = 28;
            this.poistaVR.Text = "Poista";
            this.poistaVR.UseVisualStyleBackColor = true;
            this.poistaVR.Click += new System.EventHandler(this.poistaVR_Click);
            // 
            // paivitaVR
            // 
            this.paivitaVR.Location = new System.Drawing.Point(15, 346);
            this.paivitaVR.Name = "paivitaVR";
            this.paivitaVR.Size = new System.Drawing.Size(75, 25);
            this.paivitaVR.TabIndex = 27;
            this.paivitaVR.Text = "Päivitä";
            this.paivitaVR.UseVisualStyleBackColor = true;
            this.paivitaVR.Click += new System.EventHandler(this.paivitaVR_Click);
            // 
            // lisaaVR
            // 
            this.lisaaVR.Location = new System.Drawing.Point(15, 304);
            this.lisaaVR.Name = "lisaaVR";
            this.lisaaVR.Size = new System.Drawing.Size(75, 25);
            this.lisaaVR.TabIndex = 26;
            this.lisaaVR.Text = "Lisää";
            this.lisaaVR.UseVisualStyleBackColor = true;
            this.lisaaVR.Click += new System.EventHandler(this.lisaaVR_Click);
            // 
            // varauksetDG
            // 
            this.varauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDG.Location = new System.Drawing.Point(297, 11);
            this.varauksetDG.Name = "varauksetDG";
            this.varauksetDG.Size = new System.Drawing.Size(496, 359);
            this.varauksetDG.TabIndex = 25;
            this.varauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellClick);
            // 
            // asiakasID
            // 
            this.asiakasID.Location = new System.Drawing.Point(154, 78);
            this.asiakasID.Name = "asiakasID";
            this.asiakasID.Size = new System.Drawing.Size(100, 26);
            this.asiakasID.TabIndex = 21;
            // 
            // varausID
            // 
            this.varausID.Location = new System.Drawing.Point(154, 30);
            this.varausID.Name = "varausID";
            this.varausID.Size = new System.Drawing.Size(100, 26);
            this.varausID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lähtöpäivä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tulopäivä";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 129);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 16);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Huonetyyppi";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Asiakastunnus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Varaustunnus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Huone nro";
            // 
            // huonenroCB
            // 
            this.huonenroCB.FormattingEnabled = true;
            this.huonenroCB.Location = new System.Drawing.Point(154, 172);
            this.huonenroCB.Name = "huonenroCB";
            this.huonenroCB.Size = new System.Drawing.Size(100, 24);
            this.huonenroCB.TabIndex = 31;
            // 
            // huonetypeCB
            // 
            this.huonetypeCB.FormattingEnabled = true;
            this.huonetypeCB.Location = new System.Drawing.Point(154, 126);
            this.huonetypeCB.Name = "huonetypeCB";
            this.huonetypeCB.Size = new System.Drawing.Size(100, 24);
            this.huonetypeCB.TabIndex = 32;
            this.huonetypeCB.SelectedIndexChanged += new System.EventHandler(this.huonetypeCB_SelectedIndexChanged);
            // 
            // datein
            // 
            this.datein.CustomFormat = "dd/MM/yyyy";
            this.datein.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datein.Location = new System.Drawing.Point(154, 218);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(100, 26);
            this.datein.TabIndex = 33;
            // 
            // dateout
            // 
            this.dateout.CustomFormat = "dd/MM/yyyy";
            this.dateout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateout.Location = new System.Drawing.Point(154, 266);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(100, 26);
            this.dateout.TabIndex = 34;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 383);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.huonetypeCB);
            this.Controls.Add(this.huonenroCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tyhjennaVR);
            this.Controls.Add(this.poistaVR);
            this.Controls.Add(this.paivitaVR);
            this.Controls.Add(this.lisaaVR);
            this.Controls.Add(this.varauksetDG);
            this.Controls.Add(this.asiakasID);
            this.Controls.Add(this.varausID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationForm";
            this.Text = "Varausten hallinta";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tyhjennaVR;
        private System.Windows.Forms.Button poistaVR;
        private System.Windows.Forms.Button paivitaVR;
        private System.Windows.Forms.Button lisaaVR;
        private System.Windows.Forms.DataGridView varauksetDG;
        private System.Windows.Forms.TextBox asiakasID;
        private System.Windows.Forms.TextBox varausID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox huonenroCB;
        private System.Windows.Forms.ComboBox huonetypeCB;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.DateTimePicker dateout;
    }
}