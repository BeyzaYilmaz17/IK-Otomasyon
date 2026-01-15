namespace IKotomasyon.UI
{
    partial class YöneticiIzinform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIzinYönetimi = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.btnReddet = new System.Windows.Forms.Button();
            this.aciklamalabel = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.BasBitislabel = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.Günsayısılabel = new System.Windows.Forms.Label();
            this.IzinTürülabel = new System.Windows.Forms.Label();
            this.Derpartmanlabel = new System.Windows.Forms.Label();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.personellabel = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.seçilifiltrelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIzinler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelIzinYönetimi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(935, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giriş Yapan:";
            // 
            // labelIzinYönetimi
            // 
            this.labelIzinYönetimi.AutoSize = true;
            this.labelIzinYönetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIzinYönetimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelIzinYönetimi.Location = new System.Drawing.Point(12, 32);
            this.labelIzinYönetimi.Name = "labelIzinYönetimi";
            this.labelIzinYönetimi.Size = new System.Drawing.Size(180, 38);
            this.labelIzinYönetimi.TabIndex = 1;
            this.labelIzinYönetimi.Text = "İzin Yönetimi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel4.Controls.Add(this.rtbAciklama);
            this.panel4.Controls.Add(this.txtGunSayisi);
            this.panel4.Controls.Add(this.btnReddet);
            this.panel4.Controls.Add(this.aciklamalabel);
            this.panel4.Controls.Add(this.dtBitis);
            this.panel4.Controls.Add(this.BasBitislabel);
            this.panel4.Controls.Add(this.btnOnayla);
            this.panel4.Controls.Add(this.dtBaslangic);
            this.panel4.Controls.Add(this.Günsayısılabel);
            this.panel4.Controls.Add(this.IzinTürülabel);
            this.panel4.Controls.Add(this.Derpartmanlabel);
            this.panel4.Controls.Add(this.cmbIzinTuru);
            this.panel4.Controls.Add(this.personellabel);
            this.panel4.Controls.Add(this.cmbDepartman);
            this.panel4.Controls.Add(this.txtPersonelAdi);
            this.panel4.Location = new System.Drawing.Point(781, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 688);
            this.panel4.TabIndex = 3;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(47, 489);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.ReadOnly = true;
            this.rtbAciklama.Size = new System.Drawing.Size(255, 96);
            this.rtbAciklama.TabIndex = 22;
            this.rtbAciklama.Text = "";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(47, 414);
            this.txtGunSayisi.Multiline = true;
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.ReadOnly = true;
            this.txtGunSayisi.Size = new System.Drawing.Size(256, 37);
            this.txtGunSayisi.TabIndex = 21;
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReddet.Enabled = false;
            this.btnReddet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReddet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReddet.Location = new System.Drawing.Point(196, 606);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(107, 49);
            this.btnReddet.TabIndex = 20;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.reddetbutton_Click);
            // 
            // aciklamalabel
            // 
            this.aciklamalabel.AutoSize = true;
            this.aciklamalabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamalabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.aciklamalabel.Location = new System.Drawing.Point(7, 462);
            this.aciklamalabel.Name = "aciklamalabel";
            this.aciklamalabel.Size = new System.Drawing.Size(106, 24);
            this.aciklamalabel.TabIndex = 16;
            this.aciklamalabel.Text = "Açıklama:";
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Enabled = false;
            this.dtBitis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(45, 344);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(257, 30);
            this.dtBitis.TabIndex = 18;
            // 
            // BasBitislabel
            // 
            this.BasBitislabel.AutoSize = true;
            this.BasBitislabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasBitislabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BasBitislabel.Location = new System.Drawing.Point(7, 259);
            this.BasBitislabel.Name = "BasBitislabel";
            this.BasBitislabel.Size = new System.Drawing.Size(159, 24);
            this.BasBitislabel.TabIndex = 15;
            this.BasBitislabel.Text = "Başlangıç-Bitiş:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOnayla.Enabled = false;
            this.btnOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOnayla.Location = new System.Drawing.Point(45, 606);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(113, 49);
            this.btnOnayla.TabIndex = 12;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.onaylabutton_Click);
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Enabled = false;
            this.dtBaslangic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(46, 297);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(257, 30);
            this.dtBaslangic.TabIndex = 17;
            // 
            // Günsayısılabel
            // 
            this.Günsayısılabel.AutoSize = true;
            this.Günsayısılabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Günsayısılabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Günsayısılabel.Location = new System.Drawing.Point(7, 387);
            this.Günsayısılabel.Name = "Günsayısılabel";
            this.Günsayısılabel.Size = new System.Drawing.Size(117, 24);
            this.Günsayısılabel.TabIndex = 9;
            this.Günsayısılabel.Text = "Gün Sayısı:";
            // 
            // IzinTürülabel
            // 
            this.IzinTürülabel.AutoSize = true;
            this.IzinTürülabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IzinTürülabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.IzinTürülabel.Location = new System.Drawing.Point(7, 193);
            this.IzinTürülabel.Name = "IzinTürülabel";
            this.IzinTürülabel.Size = new System.Drawing.Size(105, 24);
            this.IzinTürülabel.TabIndex = 7;
            this.IzinTürülabel.Text = "İzin Türü:";
            // 
            // Derpartmanlabel
            // 
            this.Derpartmanlabel.AutoSize = true;
            this.Derpartmanlabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Derpartmanlabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Derpartmanlabel.Location = new System.Drawing.Point(7, 127);
            this.Derpartmanlabel.Name = "Derpartmanlabel";
            this.Derpartmanlabel.Size = new System.Drawing.Size(126, 24);
            this.Derpartmanlabel.TabIndex = 5;
            this.Derpartmanlabel.Text = "Departman:";
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzinTuru.Enabled = false;
            this.cmbIzinTuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Location = new System.Drawing.Point(47, 220);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(256, 36);
            this.cmbIzinTuru.TabIndex = 8;
            // 
            // personellabel
            // 
            this.personellabel.AutoSize = true;
            this.personellabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personellabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.personellabel.Location = new System.Drawing.Point(7, 60);
            this.personellabel.Name = "personellabel";
            this.personellabel.Size = new System.Drawing.Size(137, 24);
            this.personellabel.TabIndex = 2;
            this.personellabel.Text = "Personel Adı:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.Enabled = false;
            this.cmbDepartman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(47, 154);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(255, 36);
            this.cmbDepartman.TabIndex = 6;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(46, 87);
            this.txtPersonelAdi.Multiline = true;
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.ReadOnly = true;
            this.txtPersonelAdi.Size = new System.Drawing.Size(256, 37);
            this.txtPersonelAdi.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.seçilifiltrelabel);
            this.panel5.Location = new System.Drawing.Point(781, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 45);
            this.panel5.TabIndex = 16;
            // 
            // seçilifiltrelabel
            // 
            this.seçilifiltrelabel.AutoSize = true;
            this.seçilifiltrelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seçilifiltrelabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.seçilifiltrelabel.Location = new System.Drawing.Point(5, 7);
            this.seçilifiltrelabel.Name = "seçilifiltrelabel";
            this.seçilifiltrelabel.Size = new System.Drawing.Size(203, 31);
            this.seçilifiltrelabel.TabIndex = 1;
            this.seçilifiltrelabel.Text = "Seçilen İzin Detayı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIzinler);
            this.panel2.Location = new System.Drawing.Point(19, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 681);
            this.panel2.TabIndex = 18;
            // 
            // dgvIzinler
            // 
            this.dgvIzinler.AllowUserToDeleteRows = false;
            this.dgvIzinler.AllowUserToResizeRows = false;
            this.dgvIzinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzinler.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvIzinler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIzinler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIzinler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzinler.EnableHeadersVisualStyles = false;
            this.dgvIzinler.Location = new System.Drawing.Point(0, 0);
            this.dgvIzinler.MultiSelect = false;
            this.dgvIzinler.Name = "dgvIzinler";
            this.dgvIzinler.ReadOnly = true;
            this.dgvIzinler.RowHeadersVisible = false;
            this.dgvIzinler.RowHeadersWidth = 51;
            this.dgvIzinler.RowTemplate.Height = 24;
            this.dgvIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinler.Size = new System.Drawing.Size(692, 681);
            this.dgvIzinler.TabIndex = 18;
            this.dgvIzinler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzinler_CellClick);
            // 
            // YöneticiIzinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1242, 953);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "YöneticiIzinform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YöneticiIzinform";
            this.Load += new System.EventHandler(this.YöneticiIzinform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIzinYönetimi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label Günsayısılabel;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label IzinTürülabel;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label Derpartmanlabel;
        private System.Windows.Forms.Label personellabel;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label seçilifiltrelabel;
        private System.Windows.Forms.Label aciklamalabel;
        private System.Windows.Forms.Label BasBitislabel;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIzinler;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.TextBox txtGunSayisi;
    }
}