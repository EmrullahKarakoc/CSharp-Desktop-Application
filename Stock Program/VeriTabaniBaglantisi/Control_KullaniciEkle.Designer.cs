namespace VeriTabaniBaglantisi
{
    partial class Control_KullaniciEkle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_KullaniciadiControl = new System.Windows.Forms.TextBox();
            this.txt_kullanicisifrecontrol = new System.Windows.Forms.TextBox();
            this.txt_Kullanicitekrarsifrecontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_KullaniciEkleControl = new System.Windows.Forms.Button();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_Normal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KullaniciadiControl
            // 
            this.txt_KullaniciadiControl.Location = new System.Drawing.Point(153, 43);
            this.txt_KullaniciadiControl.Name = "txt_KullaniciadiControl";
            this.txt_KullaniciadiControl.Size = new System.Drawing.Size(249, 22);
            this.txt_KullaniciadiControl.TabIndex = 0;
            // 
            // txt_kullanicisifrecontrol
            // 
            this.txt_kullanicisifrecontrol.Location = new System.Drawing.Point(153, 71);
            this.txt_kullanicisifrecontrol.Name = "txt_kullanicisifrecontrol";
            this.txt_kullanicisifrecontrol.Size = new System.Drawing.Size(249, 22);
            this.txt_kullanicisifrecontrol.TabIndex = 1;
            // 
            // txt_Kullanicitekrarsifrecontrol
            // 
            this.txt_Kullanicitekrarsifrecontrol.Location = new System.Drawing.Point(153, 99);
            this.txt_Kullanicitekrarsifrecontrol.Name = "txt_Kullanicitekrarsifrecontrol";
            this.txt_Kullanicitekrarsifrecontrol.Size = new System.Drawing.Size(249, 22);
            this.txt_Kullanicitekrarsifrecontrol.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre ( Tekrar ) :";
            // 
            // btn_KullaniciEkleControl
            // 
            this.btn_KullaniciEkleControl.Location = new System.Drawing.Point(251, 189);
            this.btn_KullaniciEkleControl.Name = "btn_KullaniciEkleControl";
            this.btn_KullaniciEkleControl.Size = new System.Drawing.Size(151, 34);
            this.btn_KullaniciEkleControl.TabIndex = 7;
            this.btn_KullaniciEkleControl.Text = "Kullanıcıyı Ekle";
            this.btn_KullaniciEkleControl.UseVisualStyleBackColor = true;
            this.btn_KullaniciEkleControl.Click += new System.EventHandler(this.Btn_KullaniciEkleControl_Click);
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(6, 21);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(68, 21);
            this.rb_Admin.TabIndex = 9;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_Normal
            // 
            this.rb_Normal.AutoSize = true;
            this.rb_Normal.Location = new System.Drawing.Point(105, 21);
            this.rb_Normal.Name = "rb_Normal";
            this.rb_Normal.Size = new System.Drawing.Size(59, 21);
            this.rb_Normal.TabIndex = 10;
            this.rb_Normal.TabStop = true;
            this.rb_Normal.Text = "User";
            this.rb_Normal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Normal);
            this.groupBox1.Controls.Add(this.rb_Admin);
            this.groupBox1.Location = new System.Drawing.Point(232, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 12;
            // 
            // Control_KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_KullaniciEkleControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kullanicitekrarsifrecontrol);
            this.Controls.Add(this.txt_kullanicisifrecontrol);
            this.Controls.Add(this.txt_KullaniciadiControl);
            this.Name = "Control_KullaniciEkle";
            this.Size = new System.Drawing.Size(1377, 740);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_KullaniciEkle_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullaniciadiControl;
        private System.Windows.Forms.TextBox txt_kullanicisifrecontrol;
        private System.Windows.Forms.TextBox txt_Kullanicitekrarsifrecontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_KullaniciEkleControl;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.RadioButton rb_Normal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
