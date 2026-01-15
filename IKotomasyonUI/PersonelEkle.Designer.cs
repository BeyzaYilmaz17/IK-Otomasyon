namespace IKotomasyon.UI
{
    partial class PersonelEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personelyönetimilabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtwPersonelTablo = new System.Windows.Forms.DataGridView();
            this.panelpersonelbilgileri = new System.Windows.Forms.Panel();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.Tellbl = new System.Windows.Forms.Label();
            this.epostalbl = new System.Windows.Forms.Label();
            this.picturesil = new System.Windows.Forms.PictureBox();
            this.picturegüncelle = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.adlabel = new System.Windows.Forms.Label();
            this.labelPersonelBilgileri = new System.Windows.Forms.Label();
            this.personelicon = new System.Windows.Forms.PictureBox();
            this.pictureekle = new System.Windows.Forms.PictureBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwPersonelTablo)).BeginInit();
            this.panelpersonelbilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureekle)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1242, 84);
            this.panel1.TabIndex = 0;
            // 
            // personelyönetimilabel
            // 
            this.personelyönetimilabel.AutoSize = true;
            this.personelyönetimilabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelyönetimilabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personelyönetimilabel.Location = new System.Drawing.Point(12, 21);
            this.personelyönetimilabel.Name = "personelyönetimilabel";
            this.personelyönetimilabel.Size = new System.Drawing.Size(243, 38);
            this.personelyönetimilabel.TabIndex = 0;
            this.personelyönetimilabel.Text = "Personel Yönetimi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.dtwPersonelTablo);
            this.panel2.Location = new System.Drawing.Point(444, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 743);
            this.panel2.TabIndex = 1;
            // 
            // dtwPersonelTablo
            // 
            this.dtwPersonelTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwPersonelTablo.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtwPersonelTablo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwPersonelTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtwPersonelTablo.ColumnHeadersHeight = 35;
            this.dtwPersonelTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtwPersonelTablo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtwPersonelTablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtwPersonelTablo.EnableHeadersVisualStyles = false;
            this.dtwPersonelTablo.GridColor = System.Drawing.Color.LightGray;
            this.dtwPersonelTablo.Location = new System.Drawing.Point(0, 0);
            this.dtwPersonelTablo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtwPersonelTablo.MultiSelect = false;
            this.dtwPersonelTablo.Name = "dtwPersonelTablo";
            this.dtwPersonelTablo.ReadOnly = true;
            this.dtwPersonelTablo.RowHeadersWidth = 60;
            this.dtwPersonelTablo.RowTemplate.Height = 24;
            this.dtwPersonelTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtwPersonelTablo.Size = new System.Drawing.Size(775, 743);
            this.dtwPersonelTablo.TabIndex = 0;
            // 
            // panelpersonelbilgileri
            // 
            this.panelpersonelbilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelpersonelbilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpersonelbilgileri.Controls.Add(this.txtTel);
            this.panelpersonelbilgileri.Controls.Add(this.txtPosta);
            this.panelpersonelbilgileri.Controls.Add(this.Tellbl);
            this.panelpersonelbilgileri.Controls.Add(this.epostalbl);
            this.panelpersonelbilgileri.Controls.Add(this.picturesil);
            this.panelpersonelbilgileri.Controls.Add(this.picturegüncelle);
            this.panelpersonelbilgileri.Controls.Add(this.btnGuncelle);
            this.panelpersonelbilgileri.Controls.Add(this.btnSil);
            this.panelpersonelbilgileri.Controls.Add(this.dtBaslangic);
            this.panelpersonelbilgileri.Controls.Add(this.label5);
            this.panelpersonelbilgileri.Controls.Add(this.cmbDurum);
            this.panelpersonelbilgileri.Controls.Add(this.txtPozisyon);
            this.panelpersonelbilgileri.Controls.Add(this.txtSoyad);
            this.panelpersonelbilgileri.Controls.Add(this.cmbDepartman);
            this.panelpersonelbilgileri.Controls.Add(this.txtAd);
            this.panelpersonelbilgileri.Controls.Add(this.label4);
            this.panelpersonelbilgileri.Controls.Add(this.label3);
            this.panelpersonelbilgileri.Controls.Add(this.label2);
            this.panelpersonelbilgileri.Controls.Add(this.soyadlabel);
            this.panelpersonelbilgileri.Controls.Add(this.adlabel);
            this.panelpersonelbilgileri.Controls.Add(this.labelPersonelBilgileri);
            this.panelpersonelbilgileri.Controls.Add(this.personelicon);
            this.panelpersonelbilgileri.Controls.Add(this.pictureekle);
            this.panelpersonelbilgileri.Controls.Add(this.btnekle);
            this.panelpersonelbilgileri.Location = new System.Drawing.Point(19, 104);
            this.panelpersonelbilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelpersonelbilgileri.Name = "panelpersonelbilgileri";
            this.panelpersonelbilgileri.Size = new System.Drawing.Size(405, 743);
            this.panelpersonelbilgileri.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(122, 287);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(267, 44);
            this.txtTel.TabIndex = 29;
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPosta.Location = new System.Drawing.Point(122, 214);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosta.Multiline = true;
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(267, 44);
            this.txtPosta.TabIndex = 28;
            // 
            // Tellbl
            // 
            this.Tellbl.AutoSize = true;
            this.Tellbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tellbl.Location = new System.Drawing.Point(6, 289);
            this.Tellbl.Name = "Tellbl";
            this.Tellbl.Size = new System.Drawing.Size(84, 27);
            this.Tellbl.TabIndex = 27;
            this.Tellbl.Text = "Telefon:";
            // 
            // epostalbl
            // 
            this.epostalbl.AutoSize = true;
            this.epostalbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostalbl.Location = new System.Drawing.Point(7, 216);
            this.epostalbl.Name = "epostalbl";
            this.epostalbl.Size = new System.Drawing.Size(78, 27);
            this.epostalbl.TabIndex = 26;
            this.epostalbl.Text = "Eposta:";
            // 
            // picturesil
            // 
            this.picturesil.BackColor = System.Drawing.Color.LightSlateGray;
            this.picturesil.Image = global::IKotomasyon.UI.Properties.Resources.trash;
            this.picturesil.Location = new System.Drawing.Point(302, 682);
            this.picturesil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturesil.Name = "picturesil";
            this.picturesil.Size = new System.Drawing.Size(38, 29);
            this.picturesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturesil.TabIndex = 25;
            this.picturesil.TabStop = false;
            // 
            // picturegüncelle
            // 
            this.picturegüncelle.BackColor = System.Drawing.Color.LightSlateGray;
            this.picturegüncelle.Image = global::IKotomasyon.UI.Properties.Resources.edit__1_;
            this.picturegüncelle.Location = new System.Drawing.Point(181, 682);
            this.picturegüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturegüncelle.Name = "picturegüncelle";
            this.picturegüncelle.Size = new System.Drawing.Size(38, 29);
            this.picturegüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturegüncelle.TabIndex = 24;
            this.picturegüncelle.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGuncelle.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(147, 646);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 46);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSil.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(274, 646);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 46);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(122, 507);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(267, 34);
            this.dtBaslangic.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Başlangıç:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(122, 579);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(267, 36);
            this.cmbDurum.TabIndex = 15;
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyon.Location = new System.Drawing.Point(122, 434);
            this.txtPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPozisyon.Multiline = true;
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(267, 44);
            this.txtPozisyon.TabIndex = 14;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(122, 141);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(267, 44);
            this.txtSoyad.TabIndex = 13;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(122, 360);
            this.cmbDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(267, 36);
            this.cmbDepartman.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(122, 68);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(267, 44);
            this.txtAd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pozisyon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departman:";
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlabel.Location = new System.Drawing.Point(6, 143);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(70, 27);
            this.soyadlabel.TabIndex = 4;
            this.soyadlabel.Text = "Soyad:";
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adlabel.Location = new System.Drawing.Point(6, 70);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(45, 27);
            this.adlabel.TabIndex = 3;
            this.adlabel.Text = "Ad:";
            // 
            // labelPersonelBilgileri
            // 
            this.labelPersonelBilgileri.AutoSize = true;
            this.labelPersonelBilgileri.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonelBilgileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPersonelBilgileri.Location = new System.Drawing.Point(56, 10);
            this.labelPersonelBilgileri.Name = "labelPersonelBilgileri";
            this.labelPersonelBilgileri.Size = new System.Drawing.Size(197, 31);
            this.labelPersonelBilgileri.TabIndex = 1;
            this.labelPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // personelicon
            // 
            this.personelicon.Image = global::IKotomasyon.UI.Properties.Resources.people;
            this.personelicon.Location = new System.Drawing.Point(14, 10);
            this.personelicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelicon.Name = "personelicon";
            this.personelicon.Size = new System.Drawing.Size(41, 31);
            this.personelicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personelicon.TabIndex = 2;
            this.personelicon.TabStop = false;
            // 
            // pictureekle
            // 
            this.pictureekle.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureekle.Image = global::IKotomasyon.UI.Properties.Resources.plus;
            this.pictureekle.Location = new System.Drawing.Point(63, 682);
            this.pictureekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureekle.Name = "pictureekle";
            this.pictureekle.Size = new System.Drawing.Size(38, 29);
            this.pictureekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureekle.TabIndex = 21;
            this.pictureekle.TabStop = false;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnekle.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.Location = new System.Drawing.Point(36, 646);
            this.btnekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(93, 46);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1242, 913);
            this.Controls.Add(this.panelpersonelbilgileri);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtwPersonelTablo)).EndInit();
            this.panelpersonelbilgileri.ResumeLayout(false);
            this.panelpersonelbilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureekle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label personelyönetimilabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelpersonelbilgileri;
        private System.Windows.Forms.PictureBox personelicon;
        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.Label labelPersonelBilgileri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox picturesil;
        private System.Windows.Forms.PictureBox picturegüncelle;
        private System.Windows.Forms.PictureBox pictureekle;
        private System.Windows.Forms.DataGridView dtwPersonelTablo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.Label Tellbl;
        private System.Windows.Forms.Label epostalbl;
    }
}