namespace IKotomasyon.UI
{
    partial class PersonelListe
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
            this.personelyönetimilabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.PerformanSeviyelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblDepartmanBilgi = new System.Windows.Forms.Label();
            this.personelicon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.personelyönetimilabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 99);
            this.panel1.TabIndex = 1;
            // 
            // personelyönetimilabel
            // 
            this.personelyönetimilabel.AutoSize = true;
            this.personelyönetimilabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelyönetimilabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personelyönetimilabel.Location = new System.Drawing.Point(12, 30);
            this.personelyönetimilabel.Name = "personelyönetimilabel";
            this.personelyönetimilabel.Size = new System.Drawing.Size(190, 38);
            this.personelyönetimilabel.TabIndex = 0;
            this.personelyönetimilabel.Text = "Personel Liste";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.cmbDurum);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnFiltrele);
            this.panel3.Controls.Add(this.PerformanSeviyelbl);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbDepartman);
            this.panel3.Controls.Add(this.lblDepartmanBilgi);
            this.panel3.Controls.Add(this.personelicon);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(34, 248);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 465);
            this.panel3.TabIndex = 6;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(21, 219);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(293, 45);
            this.cmbDurum.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox2.Image = global::IKotomasyon.UI.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(48, 318);
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
            this.btnFiltrele.Location = new System.Drawing.Point(34, 306);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(264, 54);
            this.btnFiltrele.TabIndex = 31;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // PerformanSeviyelbl
            // 
            this.PerformanSeviyelbl.AutoSize = true;
            this.PerformanSeviyelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PerformanSeviyelbl.Location = new System.Drawing.Point(16, 189);
            this.PerformanSeviyelbl.Name = "PerformanSeviyelbl";
            this.PerformanSeviyelbl.Size = new System.Drawing.Size(80, 28);
            this.PerformanSeviyelbl.TabIndex = 29;
            this.PerformanSeviyelbl.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departman Seç:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(21, 111);
            this.cmbDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(293, 45);
            this.cmbDepartman.TabIndex = 5;
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
            this.personelicon.Location = new System.Drawing.Point(3, 10);
            this.personelicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelicon.Name = "personelicon";
            this.personelicon.Size = new System.Drawing.Size(41, 31);
            this.personelicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personelicon.TabIndex = 4;
            this.personelicon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dgvPersoneller);
            this.panel2.Location = new System.Drawing.Point(407, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 556);
            this.panel2.TabIndex = 2;
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.AllowUserToAddRows = false;
            this.dgvPersoneller.AllowUserToDeleteRows = false;
            this.dgvPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersoneller.Location = new System.Drawing.Point(0, 0);
            this.dgvPersoneller.MultiSelect = false;
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.ReadOnly = true;
            this.dgvPersoneller.RowHeadersWidth = 51;
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(790, 556);
            this.dgvPersoneller.TabIndex = 0;
            // 
            // PersonelListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1242, 913);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelListe";
            this.Text = "PersonelListe";
            this.Load += new System.EventHandler(this.PersonelListe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label personelyönetimilabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label PerformanSeviyelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblDepartmanBilgi;
        private System.Windows.Forms.PictureBox personelicon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DataGridView dgvPersoneller;
    }
}