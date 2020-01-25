namespace VeriTabaniBaglantisi
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UserAdd = new System.Windows.Forms.Button();
            this.btn_UserDelete = new System.Windows.Forms.Button();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.btn_MusteriLıstele = new System.Windows.Forms.Button();
            this.btn_MusteriSil = new System.Windows.Forms.Button();
            this.btn_UrunSil = new System.Windows.Forms.Button();
            this.btn_MusteriEkle = new System.Windows.Forms.Button();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.control_UrunSil1 = new VeriTabaniBaglantisi.Control_UrunSil();
            this.control_UrunEkle1 = new VeriTabaniBaglantisi.Control_UrunEkle();
            this.control_MusteriSil1 = new VeriTabaniBaglantisi.Control_MusteriSil();
            this.control_MusteriListele1 = new VeriTabaniBaglantisi.Control_MusteriListele();
            this.control_MusteriEkle1 = new VeriTabaniBaglantisi.Control_MusteriEkle();
            this.control_KullaniciSil1 = new VeriTabaniBaglantisi.Control_KullaniciSil();
            this.control_KullaniciEkle1 = new VeriTabaniBaglantisi.Control_KullaniciEkle();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 21);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_UserAdd);
            this.panel2.Controls.Add(this.btn_UserDelete);
            this.panel2.Controls.Add(this.ActivePanel);
            this.panel2.Controls.Add(this.Btn_Cikis);
            this.panel2.Controls.Add(this.btn_MusteriLıstele);
            this.panel2.Controls.Add(this.btn_MusteriSil);
            this.panel2.Controls.Add(this.btn_UrunSil);
            this.panel2.Controls.Add(this.btn_MusteriEkle);
            this.panel2.Controls.Add(this.btn_UrunEkle);
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 740);
            this.panel2.TabIndex = 2;
            // 
            // btn_UserAdd
            // 
            this.btn_UserAdd.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserAdd.Location = new System.Drawing.Point(13, 17);
            this.btn_UserAdd.Name = "btn_UserAdd";
            this.btn_UserAdd.Size = new System.Drawing.Size(166, 81);
            this.btn_UserAdd.TabIndex = 4;
            this.btn_UserAdd.Text = "Kullanıcı Ekle";
            this.btn_UserAdd.UseVisualStyleBackColor = true;
            this.btn_UserAdd.Click += new System.EventHandler(this.Btn_UserAdd_Click);
            // 
            // btn_UserDelete
            // 
            this.btn_UserDelete.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserDelete.Location = new System.Drawing.Point(13, 104);
            this.btn_UserDelete.Name = "btn_UserDelete";
            this.btn_UserDelete.Size = new System.Drawing.Size(166, 81);
            this.btn_UserDelete.TabIndex = 4;
            this.btn_UserDelete.Text = "Kullanıcı Sil";
            this.btn_UserDelete.UseVisualStyleBackColor = true;
            this.btn_UserDelete.Click += new System.EventHandler(this.Btn_UserDelete_Click);
            // 
            // ActivePanel
            // 
            this.ActivePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ActivePanel.Location = new System.Drawing.Point(3, 17);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(10, 81);
            this.ActivePanel.TabIndex = 3;
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cikis.Location = new System.Drawing.Point(10, 626);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(166, 81);
            this.Btn_Cikis.TabIndex = 5;
            this.Btn_Cikis.Text = "Çıkış Yap";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_MusteriLıstele
            // 
            this.btn_MusteriLıstele.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MusteriLıstele.Location = new System.Drawing.Point(10, 539);
            this.btn_MusteriLıstele.Name = "btn_MusteriLıstele";
            this.btn_MusteriLıstele.Size = new System.Drawing.Size(166, 81);
            this.btn_MusteriLıstele.TabIndex = 3;
            this.btn_MusteriLıstele.Text = "Sepet İşlemleri";
            this.btn_MusteriLıstele.UseVisualStyleBackColor = true;
            this.btn_MusteriLıstele.Click += new System.EventHandler(this.Btn_MusteriLıstele_Click);
            // 
            // btn_MusteriSil
            // 
            this.btn_MusteriSil.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MusteriSil.Location = new System.Drawing.Point(13, 278);
            this.btn_MusteriSil.Name = "btn_MusteriSil";
            this.btn_MusteriSil.Size = new System.Drawing.Size(166, 81);
            this.btn_MusteriSil.TabIndex = 6;
            this.btn_MusteriSil.Text = "Müşteri Sil";
            this.btn_MusteriSil.UseVisualStyleBackColor = true;
            this.btn_MusteriSil.Click += new System.EventHandler(this.Btn_MusteriSil_Click);
            // 
            // btn_UrunSil
            // 
            this.btn_UrunSil.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UrunSil.Location = new System.Drawing.Point(13, 452);
            this.btn_UrunSil.Name = "btn_UrunSil";
            this.btn_UrunSil.Size = new System.Drawing.Size(166, 81);
            this.btn_UrunSil.TabIndex = 4;
            this.btn_UrunSil.Text = "Ürün Sil";
            this.btn_UrunSil.UseVisualStyleBackColor = true;
            this.btn_UrunSil.Click += new System.EventHandler(this.Btn_UrunSil_Click);
            // 
            // btn_MusteriEkle
            // 
            this.btn_MusteriEkle.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MusteriEkle.Location = new System.Drawing.Point(13, 191);
            this.btn_MusteriEkle.Name = "btn_MusteriEkle";
            this.btn_MusteriEkle.Size = new System.Drawing.Size(166, 81);
            this.btn_MusteriEkle.TabIndex = 4;
            this.btn_MusteriEkle.Text = "Müşteri Ekle";
            this.btn_MusteriEkle.UseVisualStyleBackColor = true;
            this.btn_MusteriEkle.Click += new System.EventHandler(this.Btn_MusteriEkle_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UrunEkle.Location = new System.Drawing.Point(13, 365);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(166, 81);
            this.btn_UrunEkle.TabIndex = 5;
            this.btn_UrunEkle.Text = "Ürün Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = true;
            this.btn_UrunEkle.Click += new System.EventHandler(this.Btn_UrunEkle_Click);
            // 
            // control_UrunSil1
            // 
            this.control_UrunSil1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_UrunSil1.Location = new System.Drawing.Point(176, 20);
            this.control_UrunSil1.Name = "control_UrunSil1";
            this.control_UrunSil1.Size = new System.Drawing.Size(1377, 740);
            this.control_UrunSil1.TabIndex = 9;
            // 
            // control_UrunEkle1
            // 
            this.control_UrunEkle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_UrunEkle1.Location = new System.Drawing.Point(178, 20);
            this.control_UrunEkle1.Name = "control_UrunEkle1";
            this.control_UrunEkle1.Size = new System.Drawing.Size(1377, 740);
            this.control_UrunEkle1.TabIndex = 8;
            // 
            // control_MusteriSil1
            // 
            this.control_MusteriSil1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_MusteriSil1.Location = new System.Drawing.Point(176, 20);
            this.control_MusteriSil1.Name = "control_MusteriSil1";
            this.control_MusteriSil1.Size = new System.Drawing.Size(1377, 740);
            this.control_MusteriSil1.TabIndex = 7;
            // 
            // control_MusteriListele1
            // 
            this.control_MusteriListele1.Location = new System.Drawing.Point(176, 20);
            this.control_MusteriListele1.Name = "control_MusteriListele1";
            this.control_MusteriListele1.Size = new System.Drawing.Size(1377, 740);
            this.control_MusteriListele1.TabIndex = 6;
            // 
            // control_MusteriEkle1
            // 
            this.control_MusteriEkle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_MusteriEkle1.Location = new System.Drawing.Point(176, 20);
            this.control_MusteriEkle1.Name = "control_MusteriEkle1";
            this.control_MusteriEkle1.Size = new System.Drawing.Size(1377, 740);
            this.control_MusteriEkle1.TabIndex = 5;
            // 
            // control_KullaniciSil1
            // 
            this.control_KullaniciSil1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_KullaniciSil1.Location = new System.Drawing.Point(178, 20);
            this.control_KullaniciSil1.Name = "control_KullaniciSil1";
            this.control_KullaniciSil1.Size = new System.Drawing.Size(1375, 740);
            this.control_KullaniciSil1.TabIndex = 4;
            // 
            // control_KullaniciEkle1
            // 
            this.control_KullaniciEkle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_KullaniciEkle1.Location = new System.Drawing.Point(178, 20);
            this.control_KullaniciEkle1.Name = "control_KullaniciEkle1";
            this.control_KullaniciEkle1.Size = new System.Drawing.Size(1375, 740);
            this.control_KullaniciEkle1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 760);
            this.Controls.Add(this.control_UrunSil1);
            this.Controls.Add(this.control_UrunEkle1);
            this.Controls.Add(this.control_MusteriSil1);
            this.Controls.Add(this.control_MusteriListele1);
            this.Controls.Add(this.control_MusteriEkle1);
            this.Controls.Add(this.control_KullaniciSil1);
            this.Controls.Add(this.control_KullaniciEkle1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Program";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_MusteriSil;
        private System.Windows.Forms.Button btn_UrunSil;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.Button btn_MusteriEkle;
        private System.Windows.Forms.Button btn_MusteriLıstele;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Button btn_UserAdd;
        private System.Windows.Forms.Button btn_UserDelete;
        private Control_KullaniciEkle control_KullaniciEkle1;
        private Control_KullaniciSil control_KullaniciSil1;
        private Control_MusteriEkle control_MusteriEkle1;
        private Control_MusteriListele control_MusteriListele1;
        private Control_MusteriSil control_MusteriSil1;
        private Control_UrunEkle control_UrunEkle1;
        private Control_UrunSil control_UrunSil1;
    }
}