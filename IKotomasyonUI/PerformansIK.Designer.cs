namespace IKotomasyon.UI
{
    partial class PerformansIK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.performanslbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblDepartmanBilgi = new System.Windows.Forms.Label();
            this.personelicon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartDepartman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvPerformans = new System.Windows.Forms.DataGridView();
            this.colDepartman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTakim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerimlilik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGelisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.performanslbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IKotomasyon.UI.Properties.Resources.icons8_performance_64;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // performanslbl
            // 
            this.performanslbl.AutoSize = true;
            this.performanslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.performanslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.performanslbl.Location = new System.Drawing.Point(92, 34);
            this.performanslbl.Name = "performanslbl";
            this.performanslbl.Size = new System.Drawing.Size(163, 38);
            this.performanslbl.TabIndex = 2;
            this.performanslbl.Text = "Performans";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cmbPersonel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnFiltrele);
            this.panel2.Controls.Add(this.lblPersonel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbDepartman);
            this.panel2.Controls.Add(this.lblDepartmanBilgi);
            this.panel2.Controls.Add(this.personelicon);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(12, 231);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 393);
            this.panel2.TabIndex = 5;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(19, 241);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(264, 33);
            this.cmbPersonel.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox2.Image = global::IKotomasyon.UI.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(51, 318);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrele.Location = new System.Drawing.Point(19, 309);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(264, 54);
            this.btnFiltrele.TabIndex = 31;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Location = new System.Drawing.Point(13, 198);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(95, 28);
            this.lblPersonel.TabIndex = 27;
            this.lblPersonel.Text = "Personel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departman Seç:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(19, 127);
            this.cmbDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(264, 33);
            this.cmbDepartman.TabIndex = 5;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
            // 
            // lblDepartmanBilgi
            // 
            this.lblDepartmanBilgi.AutoSize = true;
            this.lblDepartmanBilgi.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmanBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmanBilgi.Location = new System.Drawing.Point(44, 10);
            this.lblDepartmanBilgi.Name = "lblDepartmanBilgi";
            this.lblDepartmanBilgi.Size = new System.Drawing.Size(225, 31);
            this.lblDepartmanBilgi.TabIndex = 3;
            this.lblDepartmanBilgi.Text = "Departman Bilgileri";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.chartDepartman);
            this.panel4.Location = new System.Drawing.Point(896, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 433);
            this.panel4.TabIndex = 7;
            // 
            // chartDepartman
            // 
            this.chartDepartman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chartDepartman.ChartAreas.Add(chartArea2);
            this.chartDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDepartman.Legends.Add(legend2);
            this.chartDepartman.Location = new System.Drawing.Point(0, 0);
            this.chartDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDepartman.Name = "chartDepartman";
            this.chartDepartman.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDepartman.Series.Add(series2);
            this.chartDepartman.Size = new System.Drawing.Size(373, 433);
            this.chartDepartman.TabIndex = 4;
            this.chartDepartman.Text = "chart1";
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
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvPerformans);
            this.pnlGrid.Location = new System.Drawing.Point(315, 144);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(575, 567);
            this.pnlGrid.TabIndex = 8;
            // 
            // dgvPerformans
            // 
            this.dgvPerformans.AllowUserToAddRows = false;
            this.dgvPerformans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvPerformans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPerformans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerformans.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvPerformans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerformans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPerformans.ColumnHeadersHeight = 55;
            this.dgvPerformans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPerformans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepartman,
            this.colPersonel,
            this.colTakim,
            this.colVerimlilik,
            this.colGelisim,
            this.colTarih,
            this.colOrt});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformans.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPerformans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerformans.Location = new System.Drawing.Point(0, 0);
            this.dgvPerformans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPerformans.MultiSelect = false;
            this.dgvPerformans.Name = "dgvPerformans";
            this.dgvPerformans.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerformans.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPerformans.RowHeadersVisible = false;
            this.dgvPerformans.RowHeadersWidth = 51;
            this.dgvPerformans.RowTemplate.Height = 24;
            this.dgvPerformans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerformans.Size = new System.Drawing.Size(575, 567);
            this.dgvPerformans.TabIndex = 3;
            // 
            // colDepartman
            // 
            this.colDepartman.HeaderText = "Departman";
            this.colDepartman.MinimumWidth = 6;
            this.colDepartman.Name = "colDepartman";
            this.colDepartman.ReadOnly = true;
            // 
            // colPersonel
            // 
            this.colPersonel.HeaderText = "Personel";
            this.colPersonel.MinimumWidth = 6;
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.ReadOnly = true;
            // 
            // colTakim
            // 
            this.colTakim.HeaderText = "Takım Çalışması";
            this.colTakim.MinimumWidth = 6;
            this.colTakim.Name = "colTakim";
            this.colTakim.ReadOnly = true;
            // 
            // colVerimlilik
            // 
            this.colVerimlilik.HeaderText = "Verimlilik";
            this.colVerimlilik.MinimumWidth = 6;
            this.colVerimlilik.Name = "colVerimlilik";
            this.colVerimlilik.ReadOnly = true;
            // 
            // colGelisim
            // 
            this.colGelisim.HeaderText = "Gelişim";
            this.colGelisim.MinimumWidth = 6;
            this.colGelisim.Name = "colGelisim";
            this.colGelisim.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.MinimumWidth = 6;
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colOrt
            // 
            this.colOrt.HeaderText = "Ortalama Puan";
            this.colOrt.MinimumWidth = 6;
            this.colOrt.Name = "colOrt";
            this.colOrt.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(896, 203);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 79);
            this.panel3.TabIndex = 9;
            // 
            // PerformansIK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1283, 814);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PerformansIK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerformansIK";
            this.Load += new System.EventHandler(this.PerformansIK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label performanslbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblDepartmanBilgi;
        private System.Windows.Forms.PictureBox personelicon;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartman;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvPerformans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTakim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerimlilik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGelisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbPersonel;
    }
}