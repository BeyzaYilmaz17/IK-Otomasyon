namespace IKotomasyon.UI
{
    partial class Duyuru
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtSaat = new System.Windows.Forms.DateTimePicker();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Basliklbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duyurulbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDuyurular = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblBaslik.Location = new System.Drawing.Point(33, 33);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(199, 35);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "📢 DUYURULAR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.dtSaat);
            this.panel2.Controls.Add(this.dtTarih);
            this.panel2.Controls.Add(this.txtBaslik);
            this.panel2.Controls.Add(this.txtIcerik);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Basliklbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(17, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 606);
            this.panel2.TabIndex = 1;
            // 
            // dtSaat
            // 
            this.dtSaat.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtSaat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSaat.Location = new System.Drawing.Point(104, 444);
            this.dtSaat.Name = "dtSaat";
            this.dtSaat.Size = new System.Drawing.Size(247, 30);
            this.dtSaat.TabIndex = 27;
            // 
            // dtTarih
            // 
            this.dtTarih.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtTarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(104, 375);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(247, 29);
            this.dtTarih.TabIndex = 26;
            // 
            // txtBaslik
            // 
            this.txtBaslik.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(104, 49);
            this.txtBaslik.Multiline = true;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(247, 52);
            this.txtBaslik.TabIndex = 24;
            // 
            // txtIcerik
            // 
            this.txtIcerik.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIcerik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.Location = new System.Drawing.Point(104, 141);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(247, 194);
            this.txtIcerik.TabIndex = 23;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEkle.Location = new System.Drawing.Point(81, 539);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(185, 52);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 56);
            this.label2.TabIndex = 17;
            this.label2.Text = "Duyuru\r\nAçıklama:";
            // 
            // Basliklbl
            // 
            this.Basliklbl.AutoSize = true;
            this.Basliklbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Basliklbl.Location = new System.Drawing.Point(3, 58);
            this.Basliklbl.Name = "Basliklbl";
            this.Basliklbl.Size = new System.Drawing.Size(65, 28);
            this.Basliklbl.TabIndex = 20;
            this.Basliklbl.Text = "Başlık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tarih:";
            // 
            // duyurulbl
            // 
            this.duyurulbl.AutoSize = true;
            this.duyurulbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.duyurulbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyurulbl.Location = new System.Drawing.Point(134, 140);
            this.duyurulbl.Name = "duyurulbl";
            this.duyurulbl.Size = new System.Drawing.Size(149, 31);
            this.duyurulbl.TabIndex = 15;
            this.duyurulbl.Text = "Duyuru Gir:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDuyurular);
            this.panel3.Location = new System.Drawing.Point(411, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 606);
            this.panel3.TabIndex = 16;
            // 
            // dgvDuyurular
            // 
            this.dgvDuyurular.AllowUserToAddRows = false;
            this.dgvDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuyurular.Location = new System.Drawing.Point(0, 0);
            this.dgvDuyurular.Name = "dgvDuyurular";
            this.dgvDuyurular.ReadOnly = true;
            this.dgvDuyurular.RowHeadersVisible = false;
            this.dgvDuyurular.RowHeadersWidth = 51;
            this.dgvDuyurular.RowTemplate.Height = 24;
            this.dgvDuyurular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuyurular.Size = new System.Drawing.Size(619, 606);
            this.dgvDuyurular.TabIndex = 3;
            // 
            // Duyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 813);
            this.Controls.Add(this.duyurulbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Duyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label duyurulbl;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Basliklbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.DateTimePicker dtSaat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDuyurular;
    }
}