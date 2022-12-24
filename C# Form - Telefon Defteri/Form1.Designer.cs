
namespace Week6_P5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kayit_listeleme = new System.Windows.Forms.Button();
            this.btn_kayit_arama = new System.Windows.Forms.Button();
            this.btn_kayit_silme = new System.Windows.Forms.Button();
            this.btn_kayit_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ekle = new System.Windows.Forms.Panel();
            this.btn_kapat1 = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Kn = new System.Windows.Forms.TextBox();
            this.panel_ara = new System.Windows.Forms.Panel();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_kapat3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel_sil = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_sil = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kapat4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kapat2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel_liste = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ekle.SuspendLayout();
            this.panel_ara.SuspendLayout();
            this.panel_sil.SuspendLayout();
            this.panel_liste.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kayit_listeleme);
            this.groupBox1.Controls.Add(this.btn_kayit_arama);
            this.groupBox1.Controls.Add(this.btn_kayit_silme);
            this.groupBox1.Controls.Add(this.btn_kayit_giris);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenek";
            // 
            // btn_kayit_listeleme
            // 
            this.btn_kayit_listeleme.Location = new System.Drawing.Point(21, 157);
            this.btn_kayit_listeleme.Name = "btn_kayit_listeleme";
            this.btn_kayit_listeleme.Size = new System.Drawing.Size(200, 23);
            this.btn_kayit_listeleme.TabIndex = 3;
            this.btn_kayit_listeleme.Text = "Listeleme";
            this.btn_kayit_listeleme.UseVisualStyleBackColor = true;
            this.btn_kayit_listeleme.Click += new System.EventHandler(this.btn_kayit_listeleme_Click);
            // 
            // btn_kayit_arama
            // 
            this.btn_kayit_arama.Location = new System.Drawing.Point(21, 67);
            this.btn_kayit_arama.Name = "btn_kayit_arama";
            this.btn_kayit_arama.Size = new System.Drawing.Size(200, 23);
            this.btn_kayit_arama.TabIndex = 2;
            this.btn_kayit_arama.Text = "Kayıt Arama";
            this.btn_kayit_arama.UseVisualStyleBackColor = true;
            this.btn_kayit_arama.Click += new System.EventHandler(this.btn_kayit_arama_Click);
            // 
            // btn_kayit_silme
            // 
            this.btn_kayit_silme.Location = new System.Drawing.Point(21, 110);
            this.btn_kayit_silme.Name = "btn_kayit_silme";
            this.btn_kayit_silme.Size = new System.Drawing.Size(200, 23);
            this.btn_kayit_silme.TabIndex = 1;
            this.btn_kayit_silme.Text = "Kayıt Silme";
            this.btn_kayit_silme.UseVisualStyleBackColor = true;
            this.btn_kayit_silme.Click += new System.EventHandler(this.btn_kayit_silme_Click);
            // 
            // btn_kayit_giris
            // 
            this.btn_kayit_giris.Location = new System.Drawing.Point(21, 22);
            this.btn_kayit_giris.Name = "btn_kayit_giris";
            this.btn_kayit_giris.Size = new System.Drawing.Size(200, 23);
            this.btn_kayit_giris.TabIndex = 0;
            this.btn_kayit_giris.Text = "Kayıt Girişi";
            this.btn_kayit_giris.UseVisualStyleBackColor = true;
            this.btn_kayit_giris.Click += new System.EventHandler(this.btn_kayit_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefon Defteri - 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baloo 2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasarım - Begüm İbrişim";
            // 
            // panel_ekle
            // 
            this.panel_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_ekle.Controls.Add(this.btn_kapat1);
            this.panel_ekle.Controls.Add(this.btn_ekle);
            this.panel_ekle.Controls.Add(this.textBox_telefon);
            this.panel_ekle.Controls.Add(this.textBox_soyad);
            this.panel_ekle.Controls.Add(this.textBox_ad);
            this.panel_ekle.Controls.Add(this.label6);
            this.panel_ekle.Controls.Add(this.label5);
            this.panel_ekle.Controls.Add(this.label4);
            this.panel_ekle.Controls.Add(this.label3);
            this.panel_ekle.Controls.Add(this.textBox_Kn);
            this.panel_ekle.Location = new System.Drawing.Point(281, 12);
            this.panel_ekle.Name = "panel_ekle";
            this.panel_ekle.Size = new System.Drawing.Size(466, 223);
            this.panel_ekle.TabIndex = 4;
            this.panel_ekle.Visible = false;
            // 
            // btn_kapat1
            // 
            this.btn_kapat1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kapat1.Location = new System.Drawing.Point(377, 191);
            this.btn_kapat1.Name = "btn_kapat1";
            this.btn_kapat1.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat1.TabIndex = 12;
            this.btn_kapat1.Text = "Kapat";
            this.btn_kapat1.UseVisualStyleBackColor = true;
            this.btn_kapat1.Click += new System.EventHandler(this.btn_kapat1_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ekle.Location = new System.Drawing.Point(254, 169);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(188, 140);
            this.textBox_telefon.MaxLength = 11;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(141, 23);
            this.textBox_telefon.TabIndex = 9;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(188, 103);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(141, 23);
            this.textBox_soyad.TabIndex = 8;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(188, 66);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(141, 23);
            this.textBox_ad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(115, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(125, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kayıt No";
            // 
            // textBox_Kn
            // 
            this.textBox_Kn.Location = new System.Drawing.Point(188, 28);
            this.textBox_Kn.Name = "textBox_Kn";
            this.textBox_Kn.ReadOnly = true;
            this.textBox_Kn.Size = new System.Drawing.Size(141, 23);
            this.textBox_Kn.TabIndex = 0;
            // 
            // panel_ara
            // 
            this.panel_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_ara.Controls.Add(this.textBox_ara);
            this.panel_ara.Controls.Add(this.label19);
            this.panel_ara.Controls.Add(this.btn_ara);
            this.panel_ara.Controls.Add(this.listBox2);
            this.panel_ara.Controls.Add(this.btn_kapat3);
            this.panel_ara.Controls.Add(this.label11);
            this.panel_ara.Controls.Add(this.label12);
            this.panel_ara.Controls.Add(this.label13);
            this.panel_ara.Controls.Add(this.label14);
            this.panel_ara.Location = new System.Drawing.Point(763, 12);
            this.panel_ara.Name = "panel_ara";
            this.panel_ara.Size = new System.Drawing.Size(466, 223);
            this.panel_ara.TabIndex = 12;
            this.panel_ara.Visible = false;
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(187, 151);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(142, 23);
            this.textBox_ara.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(30, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 21);
            this.label19.TabIndex = 12;
            this.label19.Text = "Aranacak Kayıt No";
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ara.Location = new System.Drawing.Point(336, 151);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(77, 23);
            this.btn_ara.TabIndex = 12;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(11, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(441, 79);
            this.listBox2.TabIndex = 11;
            // 
            // btn_kapat3
            // 
            this.btn_kapat3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kapat3.Location = new System.Drawing.Point(377, 191);
            this.btn_kapat3.Name = "btn_kapat3";
            this.btn_kapat3.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat3.TabIndex = 10;
            this.btn_kapat3.Text = "Kapat";
            this.btn_kapat3.UseVisualStyleBackColor = true;
            this.btn_kapat3.Click += new System.EventHandler(this.btn_kapat3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(317, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Telefonu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(211, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Soyadı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(116, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Adı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(11, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "K. No";
            // 
            // panel_sil
            // 
            this.panel_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_sil.Controls.Add(this.label15);
            this.panel_sil.Controls.Add(this.textBox_sil);
            this.panel_sil.Controls.Add(this.btn_sil);
            this.panel_sil.Controls.Add(this.btn_kapat4);
            this.panel_sil.Location = new System.Drawing.Point(763, 253);
            this.panel_sil.Name = "panel_sil";
            this.panel_sil.Size = new System.Drawing.Size(466, 223);
            this.panel_sil.TabIndex = 14;
            this.panel_sil.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(30, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Silinecek Kayıt No";
            // 
            // textBox_sil
            // 
            this.textBox_sil.Location = new System.Drawing.Point(187, 102);
            this.textBox_sil.Name = "textBox_sil";
            this.textBox_sil.Size = new System.Drawing.Size(142, 23);
            this.textBox_sil.TabIndex = 16;
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sil.Location = new System.Drawing.Point(336, 102);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(77, 23);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kapat4
            // 
            this.btn_kapat4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kapat4.Location = new System.Drawing.Point(377, 191);
            this.btn_kapat4.Name = "btn_kapat4";
            this.btn_kapat4.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat4.TabIndex = 10;
            this.btn_kapat4.Text = "Kapat";
            this.btn_kapat4.UseVisualStyleBackColor = true;
            this.btn_kapat4.Click += new System.EventHandler(this.btn_kapat4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "K. No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(125, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(227, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(358, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefonu";
            // 
            // btn_kapat2
            // 
            this.btn_kapat2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kapat2.Location = new System.Drawing.Point(377, 191);
            this.btn_kapat2.Name = "btn_kapat2";
            this.btn_kapat2.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat2.TabIndex = 10;
            this.btn_kapat2.Text = "Kapat";
            this.btn_kapat2.UseVisualStyleBackColor = true;
            this.btn_kapat2.Click += new System.EventHandler(this.btn_kapat2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(11, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 139);
            this.listBox1.TabIndex = 11;
            // 
            // panel_liste
            // 
            this.panel_liste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_liste.Controls.Add(this.listBox1);
            this.panel_liste.Controls.Add(this.btn_kapat2);
            this.panel_liste.Controls.Add(this.label7);
            this.panel_liste.Controls.Add(this.label8);
            this.panel_liste.Controls.Add(this.label9);
            this.panel_liste.Controls.Add(this.label10);
            this.panel_liste.Location = new System.Drawing.Point(281, 253);
            this.panel_liste.Name = "panel_liste";
            this.panel_liste.Size = new System.Drawing.Size(466, 223);
            this.panel_liste.TabIndex = 13;
            this.panel_liste.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 497);
            this.Controls.Add(this.panel_liste);
            this.Controls.Add(this.panel_sil);
            this.Controls.Add(this.panel_ara);
            this.Controls.Add(this.panel_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Telefon Defteri";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ekle.ResumeLayout(false);
            this.panel_ekle.PerformLayout();
            this.panel_ara.ResumeLayout(false);
            this.panel_ara.PerformLayout();
            this.panel_sil.ResumeLayout(false);
            this.panel_sil.PerformLayout();
            this.panel_liste.ResumeLayout(false);
            this.panel_liste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kayit_listeleme;
        private System.Windows.Forms.Button btn_kayit_arama;
        private System.Windows.Forms.Button btn_kayit_silme;
        private System.Windows.Forms.Button btn_kayit_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_ekle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Kn;
        private System.Windows.Forms.Panel panel_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_kapat3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel_sil;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_kapat4;
        private System.Windows.Forms.Button btn_kapat1;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_sil;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kapat2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel_liste;
    }
}

