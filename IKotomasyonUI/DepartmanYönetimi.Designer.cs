namespace IKotomasyon.UI
{
    partial class DepartmanYönetimi
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
            this.labelDepartmanYönetimi = new System.Windows.Forms.Label();
            this.paneldepartmanbilgileri = new System.Windows.Forms.Panel();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.Güncellebutton = new System.Windows.Forms.Button();
            this.Silbutton = new System.Windows.Forms.Button();
            this.eklebutton = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.açıklamalabel = new System.Windows.Forms.Label();
            this.departmanlabel = new System.Windows.Forms.Label();
            this.labelPersonelBilgileri = new System.Windows.Forms.Label();
            this.lstDepartmanlar = new System.Windows.Forms.ListBox();
            this.picturesil = new System.Windows.Forms.PictureBox();
            this.picturegüncelle = new System.Windows.Forms.PictureBox();
            this.pictureekle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.paneldepartmanbilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelDepartmanYönetimi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelDepartmanYönetimi
            // 
            this.labelDepartmanYönetimi.AutoSize = true;
            this.labelDepartmanYönetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDepartmanYönetimi.Location = new System.Drawing.Point(12, 33);
            this.labelDepartmanYönetimi.Name = "labelDepartmanYönetimi";
            this.labelDepartmanYönetimi.Size = new System.Drawing.Size(280, 38);
            this.labelDepartmanYönetimi.TabIndex = 0;
            this.labelDepartmanYönetimi.Text = "Departman Yönetimi";
            // 
            // paneldepartmanbilgileri
            // 
            this.paneldepartmanbilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneldepartmanbilgileri.Controls.Add(this.txtDepartman);
            this.paneldepartmanbilgileri.Controls.Add(this.picturesil);
            this.paneldepartmanbilgileri.Controls.Add(this.picturegüncelle);
            this.paneldepartmanbilgileri.Controls.Add(this.Güncellebutton);
            this.paneldepartmanbilgileri.Controls.Add(this.Silbutton);
            this.paneldepartmanbilgileri.Controls.Add(this.pictureekle);
            this.paneldepartmanbilgileri.Controls.Add(this.eklebutton);
            this.paneldepartmanbilgileri.Controls.Add(this.txtAciklama);
            this.paneldepartmanbilgileri.Controls.Add(this.açıklamalabel);
            this.paneldepartmanbilgileri.Controls.Add(this.departmanlabel);
            this.paneldepartmanbilgileri.Controls.Add(this.pictureBox1);
            this.paneldepartmanbilgileri.Controls.Add(this.labelPersonelBilgileri);
            this.paneldepartmanbilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paneldepartmanbilgileri.Location = new System.Drawing.Point(19, 157);
            this.paneldepartmanbilgileri.Name = "paneldepartmanbilgileri";
            this.paneldepartmanbilgileri.Size = new System.Drawing.Size(669, 484);
            this.paneldepartmanbilgileri.TabIndex = 3;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartman.Location = new System.Drawing.Point(142, 100);
            this.txtDepartman.Multiline = true;
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(428, 52);
            this.txtDepartman.TabIndex = 32;
            // 
            // Güncellebutton
            // 
            this.Güncellebutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.Güncellebutton.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Güncellebutton.Location = new System.Drawing.Point(277, 353);
            this.Güncellebutton.Name = "Güncellebutton";
            this.Güncellebutton.Size = new System.Drawing.Size(153, 63);
            this.Güncellebutton.TabIndex = 29;
            this.Güncellebutton.Text = "Güncelle";
            this.Güncellebutton.UseVisualStyleBackColor = false;
            this.Güncellebutton.Click += new System.EventHandler(this.Güncellebutton_Click);
            // 
            // Silbutton
            // 
            this.Silbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.Silbutton.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silbutton.Location = new System.Drawing.Point(452, 353);
            this.Silbutton.Name = "Silbutton";
            this.Silbutton.Size = new System.Drawing.Size(91, 63);
            this.Silbutton.TabIndex = 28;
            this.Silbutton.Text = "Sil";
            this.Silbutton.UseVisualStyleBackColor = false;
            this.Silbutton.Click += new System.EventHandler(this.Silbutton_Click);
            // 
            // eklebutton
            // 
            this.eklebutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.eklebutton.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebutton.Location = new System.Drawing.Point(166, 353);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Size = new System.Drawing.Size(91, 63);
            this.eklebutton.TabIndex = 26;
            this.eklebutton.Text = "Ekle";
            this.eklebutton.UseVisualStyleBackColor = false;
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(142, 188);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(428, 130);
            this.txtAciklama.TabIndex = 17;
            // 
            // açıklamalabel
            // 
            this.açıklamalabel.AutoSize = true;
            this.açıklamalabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.açıklamalabel.Location = new System.Drawing.Point(11, 240);
            this.açıklamalabel.Name = "açıklamalabel";
            this.açıklamalabel.Size = new System.Drawing.Size(103, 27);
            this.açıklamalabel.TabIndex = 15;
            this.açıklamalabel.Text = "Açıklama:";
            // 
            // departmanlabel
            // 
            this.departmanlabel.AutoSize = true;
            this.departmanlabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanlabel.Location = new System.Drawing.Point(11, 112);
            this.departmanlabel.Name = "departmanlabel";
            this.departmanlabel.Size = new System.Drawing.Size(120, 27);
            this.departmanlabel.TabIndex = 14;
            this.departmanlabel.Text = "Departman:";
            // 
            // labelPersonelBilgileri
            // 
            this.labelPersonelBilgileri.AutoSize = true;
            this.labelPersonelBilgileri.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonelBilgileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPersonelBilgileri.Location = new System.Drawing.Point(73, 17);
            this.labelPersonelBilgileri.Name = "labelPersonelBilgileri";
            this.labelPersonelBilgileri.Size = new System.Drawing.Size(225, 31);
            this.labelPersonelBilgileri.TabIndex = 2;
            this.labelPersonelBilgileri.Text = "Departman Bilgileri";
            // 
            // lstDepartmanlar
            // 
            this.lstDepartmanlar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstDepartmanlar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDepartmanlar.FormattingEnabled = true;
            this.lstDepartmanlar.ItemHeight = 24;
            this.lstDepartmanlar.Location = new System.Drawing.Point(798, 157);
            this.lstDepartmanlar.Name = "lstDepartmanlar";
            this.lstDepartmanlar.Size = new System.Drawing.Size(337, 484);
            this.lstDepartmanlar.TabIndex = 4;
            // 
            // picturesil
            // 
            this.picturesil.BackColor = System.Drawing.Color.LightSlateGray;
            this.picturesil.Image = global::IKotomasyon.UI.Properties.Resources.trash;
            this.picturesil.Location = new System.Drawing.Point(480, 406);
            this.picturesil.Name = "picturesil";
            this.picturesil.Size = new System.Drawing.Size(38, 28);
            this.picturesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturesil.TabIndex = 31;
            this.picturesil.TabStop = false;
            // 
            // picturegüncelle
            // 
            this.picturegüncelle.BackColor = System.Drawing.Color.LightSlateGray;
            this.picturegüncelle.Image = global::IKotomasyon.UI.Properties.Resources.edit__1_;
            this.picturegüncelle.Location = new System.Drawing.Point(311, 406);
            this.picturegüncelle.Name = "picturegüncelle";
            this.picturegüncelle.Size = new System.Drawing.Size(87, 28);
            this.picturegüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturegüncelle.TabIndex = 30;
            this.picturegüncelle.TabStop = false;
            // 
            // pictureekle
            // 
            this.pictureekle.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureekle.Image = global::IKotomasyon.UI.Properties.Resources.plus;
            this.pictureekle.Location = new System.Drawing.Point(193, 406);
            this.pictureekle.Name = "pictureekle";
            this.pictureekle.Size = new System.Drawing.Size(38, 28);
            this.pictureekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureekle.TabIndex = 27;
            this.pictureekle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IKotomasyon.UI.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DepartmanYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lstDepartmanlar);
            this.Controls.Add(this.paneldepartmanbilgileri);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmanYönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmanYönetimi";
            this.Load += new System.EventHandler(this.DepartmanYönetimi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldepartmanbilgileri.ResumeLayout(false);
            this.paneldepartmanbilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDepartmanYönetimi;
        private System.Windows.Forms.Panel paneldepartmanbilgileri;
        private System.Windows.Forms.Label labelPersonelBilgileri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label açıklamalabel;
        private System.Windows.Forms.Label departmanlabel;
        private System.Windows.Forms.PictureBox picturesil;
        private System.Windows.Forms.PictureBox picturegüncelle;
        private System.Windows.Forms.Button Güncellebutton;
        private System.Windows.Forms.Button Silbutton;
        private System.Windows.Forms.PictureBox pictureekle;
        private System.Windows.Forms.Button eklebutton;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.ListBox lstDepartmanlar;
    }
}