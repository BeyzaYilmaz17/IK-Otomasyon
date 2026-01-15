namespace IKotomasyon.UI
{
    partial class Performans
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.performanslbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.labelPersonelBilgileri = new System.Windows.Forms.Label();
            this.personelicon = new System.Windows.Forms.PictureBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbVerimlilik = new System.Windows.Forms.ComboBox();
            this.cmbGelisim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTakim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chartDepartman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.performanslbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 95);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IKotomasyon.UI.Properties.Resources.icons8_performance_64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // performanslbl
            // 
            this.performanslbl.AutoSize = true;
            this.performanslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.performanslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.performanslbl.Location = new System.Drawing.Point(101, 28);
            this.performanslbl.Name = "performanslbl";
            this.performanslbl.Size = new System.Drawing.Size(163, 38);
            this.performanslbl.TabIndex = 1;
            this.performanslbl.Text = "Performans";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cmbPersonel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbDepartman);
            this.panel2.Controls.Add(this.labelPersonelBilgileri);
            this.panel2.Controls.Add(this.personelicon);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(27, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 399);
            this.panel2.TabIndex = 2;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(20, 270);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(264, 33);
            this.cmbPersonel.TabIndex = 10;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Personel Seç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departman Seç:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(20, 148);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(264, 33);
            this.cmbDepartman.TabIndex = 5;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
            // 
            // labelPersonelBilgileri
            // 
            this.labelPersonelBilgileri.AutoSize = true;
            this.labelPersonelBilgileri.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonelBilgileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPersonelBilgileri.Location = new System.Drawing.Point(44, 10);
            this.labelPersonelBilgileri.Name = "labelPersonelBilgileri";
            this.labelPersonelBilgileri.Size = new System.Drawing.Size(197, 31);
            this.labelPersonelBilgileri.TabIndex = 3;
            this.labelPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // personelicon
            // 
            this.personelicon.Image = global::IKotomasyon.UI.Properties.Resources.people;
            this.personelicon.Location = new System.Drawing.Point(5, 10);
            this.personelicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelicon.Name = "personelicon";
            this.personelicon.Size = new System.Drawing.Size(41, 31);
            this.personelicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personelicon.TabIndex = 4;
            this.personelicon.TabStop = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Crimson;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(241, 446);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(112, 53);
            this.btnYenile.TabIndex = 14;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click_1);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOnayla.Location = new System.Drawing.Point(89, 446);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(113, 53);
            this.btnOnayla.TabIndex = 13;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnYenile);
            this.panel3.Controls.Add(this.btnOnayla);
            this.panel3.Controls.Add(this.txtAciklama);
            this.panel3.Controls.Add(this.cmbVerimlilik);
            this.panel3.Controls.Add(this.cmbGelisim);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbTakim);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(368, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 534);
            this.panel3.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(131, 266);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(276, 146);
            this.txtAciklama.TabIndex = 12;
            // 
            // cmbVerimlilik
            // 
            this.cmbVerimlilik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVerimlilik.FormattingEnabled = true;
            this.cmbVerimlilik.Location = new System.Drawing.Point(131, 140);
            this.cmbVerimlilik.Name = "cmbVerimlilik";
            this.cmbVerimlilik.Size = new System.Drawing.Size(276, 36);
            this.cmbVerimlilik.TabIndex = 11;
            // 
            // cmbGelisim
            // 
            this.cmbGelisim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGelisim.FormattingEnabled = true;
            this.cmbGelisim.Location = new System.Drawing.Point(131, 203);
            this.cmbGelisim.Name = "cmbGelisim";
            this.cmbGelisim.Size = new System.Drawing.Size(276, 36);
            this.cmbGelisim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 84);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ek Öneri \r\n    ve\r\nAçıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gelişim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verimlilik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Takım \r\nÇalışması:";
            // 
            // cmbTakim
            // 
            this.cmbTakim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTakim.FormattingEnabled = true;
            this.cmbTakim.Location = new System.Drawing.Point(131, 77);
            this.cmbTakim.Name = "cmbTakim";
            this.cmbTakim.Size = new System.Drawing.Size(276, 36);
            this.cmbTakim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Değerlendir";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.chartDepartman);
            this.panel4.Location = new System.Drawing.Point(824, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 534);
            this.panel4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 62);
            this.label8.TabIndex = 5;
            this.label8.Text = "Departman Genel \r\nPerformans Oranı";
            // 
            // chartDepartman
            // 
            this.chartDepartman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartDepartman.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDepartman.Legends.Add(legend1);
            this.chartDepartman.Location = new System.Drawing.Point(0, 85);
            this.chartDepartman.Name = "chartDepartman";
            this.chartDepartman.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDepartman.Series.Add(series1);
            this.chartDepartman.Size = new System.Drawing.Size(392, 449);
            this.chartDepartman.TabIndex = 4;
            this.chartDepartman.Text = "chart1";
            // 
            // Performans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1242, 813);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Performans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performans";
            this.Load += new System.EventHandler(this.Performans_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label performanslbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPersonelBilgileri;
        private System.Windows.Forms.PictureBox personelicon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbVerimlilik;
        private System.Windows.Forms.ComboBox cmbGelisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTakim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartman;
        private System.Windows.Forms.Label label8;
    }
}