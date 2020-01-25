namespace VeriTabaniBaglantisi
{
    partial class Control_KullaniciSil
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
            this.txt_kullanicisilcontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kullanicisil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kullanicisilcontrol
            // 
            this.txt_kullanicisilcontrol.Location = new System.Drawing.Point(153, 43);
            this.txt_kullanicisilcontrol.Name = "txt_kullanicisilcontrol";
            this.txt_kullanicisilcontrol.Size = new System.Drawing.Size(249, 22);
            this.txt_kullanicisilcontrol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı ID : ";
            // 
            // btn_kullanicisil
            // 
            this.btn_kullanicisil.Location = new System.Drawing.Point(281, 71);
            this.btn_kullanicisil.Name = "btn_kullanicisil";
            this.btn_kullanicisil.Size = new System.Drawing.Size(121, 29);
            this.btn_kullanicisil.TabIndex = 2;
            this.btn_kullanicisil.Text = "Kullanıcıyı Sil";
            this.btn_kullanicisil.UseVisualStyleBackColor = true;
            this.btn_kullanicisil.Click += new System.EventHandler(this.Btn_kullanicisil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 3;
            // 
            // Control_KullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kullanicisil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kullanicisilcontrol);
            this.Name = "Control_KullaniciSil";
            this.Size = new System.Drawing.Size(1377, 740);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_KullaniciSil_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kullanicisilcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kullanicisil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
