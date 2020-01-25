namespace VeriTabaniBaglantisi
{
    partial class Control_UrunEkle
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
            this.txt_controlurunkodu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ControlUrunuEkle = new System.Windows.Forms.Button();
            this.txt_controlurunadedi = new System.Windows.Forms.TextBox();
            this.txt_controlurunısmı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_urunkategorisi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_controlurunkodu
            // 
            this.txt_controlurunkodu.Location = new System.Drawing.Point(153, 43);
            this.txt_controlurunkodu.Name = "txt_controlurunkodu";
            this.txt_controlurunkodu.Size = new System.Drawing.Size(249, 22);
            this.txt_controlurunkodu.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_ControlUrunuEkle
            // 
            this.btn_ControlUrunuEkle.Location = new System.Drawing.Point(281, 155);
            this.btn_ControlUrunuEkle.Name = "btn_ControlUrunuEkle";
            this.btn_ControlUrunuEkle.Size = new System.Drawing.Size(121, 29);
            this.btn_ControlUrunuEkle.TabIndex = 2;
            this.btn_ControlUrunuEkle.Text = "Ürünü Ekle";
            this.btn_ControlUrunuEkle.UseVisualStyleBackColor = true;
            this.btn_ControlUrunuEkle.Click += new System.EventHandler(this.Btn_ControlUrunuEkle_Click);
            // 
            // txt_controlurunadedi
            // 
            this.txt_controlurunadedi.Location = new System.Drawing.Point(153, 99);
            this.txt_controlurunadedi.Name = "txt_controlurunadedi";
            this.txt_controlurunadedi.Size = new System.Drawing.Size(249, 22);
            this.txt_controlurunadedi.TabIndex = 3;
            this.txt_controlurunadedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_controlurunadedi_KeyPress);
            // 
            // txt_controlurunısmı
            // 
            this.txt_controlurunısmı.Location = new System.Drawing.Point(153, 71);
            this.txt_controlurunısmı.Name = "txt_controlurunısmı";
            this.txt_controlurunısmı.Size = new System.Drawing.Size(249, 22);
            this.txt_controlurunısmı.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün İsmi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Kategorisi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Adedi : ";
            // 
            // txt_urunkategorisi
            // 
            this.txt_urunkategorisi.Location = new System.Drawing.Point(153, 127);
            this.txt_urunkategorisi.Name = "txt_urunkategorisi";
            this.txt_urunkategorisi.Size = new System.Drawing.Size(249, 22);
            this.txt_urunkategorisi.TabIndex = 9;
            // 
            // Control_UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.txt_urunkategorisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_controlurunısmı);
            this.Controls.Add(this.txt_controlurunadedi);
            this.Controls.Add(this.btn_ControlUrunuEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_controlurunkodu);
            this.Name = "Control_UrunEkle";
            this.Size = new System.Drawing.Size(1377, 740);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_UrunEkle_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_controlurunkodu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ControlUrunuEkle;
        private System.Windows.Forms.TextBox txt_controlurunadedi;
        private System.Windows.Forms.TextBox txt_controlurunısmı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_urunkategorisi;
    }
}
