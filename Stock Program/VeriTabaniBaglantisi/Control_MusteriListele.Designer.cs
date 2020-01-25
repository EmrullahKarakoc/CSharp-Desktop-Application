namespace VeriTabaniBaglantisi
{
    partial class Control_MusteriListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_SepetekleMusterııd = new System.Windows.Forms.TextBox();
            this.txt_sepetekleurunkodu = new System.Windows.Forms.TextBox();
            this.txt_sepetekleurunadeti = new System.Windows.Forms.TextBox();
            this.txt_sepetgörüntülemusteriıd = new System.Windows.Forms.TextBox();
            this.btn_sepeteekle = new System.Windows.Forms.Button();
            this.btn_sepetgetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_SepetekleMusterııd
            // 
            this.txt_SepetekleMusterııd.Location = new System.Drawing.Point(198, 43);
            this.txt_SepetekleMusterııd.Name = "txt_SepetekleMusterııd";
            this.txt_SepetekleMusterııd.Size = new System.Drawing.Size(207, 22);
            this.txt_SepetekleMusterııd.TabIndex = 1;
            // 
            // txt_sepetekleurunkodu
            // 
            this.txt_sepetekleurunkodu.Location = new System.Drawing.Point(198, 71);
            this.txt_sepetekleurunkodu.Name = "txt_sepetekleurunkodu";
            this.txt_sepetekleurunkodu.Size = new System.Drawing.Size(207, 22);
            this.txt_sepetekleurunkodu.TabIndex = 2;
            // 
            // txt_sepetekleurunadeti
            // 
            this.txt_sepetekleurunadeti.Location = new System.Drawing.Point(198, 99);
            this.txt_sepetekleurunadeti.Name = "txt_sepetekleurunadeti";
            this.txt_sepetekleurunadeti.Size = new System.Drawing.Size(207, 22);
            this.txt_sepetekleurunadeti.TabIndex = 3;
            // 
            // txt_sepetgörüntülemusteriıd
            // 
            this.txt_sepetgörüntülemusteriıd.Location = new System.Drawing.Point(198, 237);
            this.txt_sepetgörüntülemusteriıd.Name = "txt_sepetgörüntülemusteriıd";
            this.txt_sepetgörüntülemusteriıd.Size = new System.Drawing.Size(207, 22);
            this.txt_sepetgörüntülemusteriıd.TabIndex = 4;
            // 
            // btn_sepeteekle
            // 
            this.btn_sepeteekle.Location = new System.Drawing.Point(271, 127);
            this.btn_sepeteekle.Name = "btn_sepeteekle";
            this.btn_sepeteekle.Size = new System.Drawing.Size(134, 29);
            this.btn_sepeteekle.TabIndex = 5;
            this.btn_sepeteekle.Text = "Sepete Ekle";
            this.btn_sepeteekle.UseVisualStyleBackColor = true;
            this.btn_sepeteekle.Click += new System.EventHandler(this.Btn_sepeteekle_Click);
            // 
            // btn_sepetgetir
            // 
            this.btn_sepetgetir.Location = new System.Drawing.Point(271, 265);
            this.btn_sepetgetir.Name = "btn_sepetgetir";
            this.btn_sepetgetir.Size = new System.Drawing.Size(134, 29);
            this.btn_sepetgetir.TabIndex = 6;
            this.btn_sepetgetir.Text = "Sepeti Görüntüle";
            this.btn_sepetgetir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri ID :";
            // 
            // Control_MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sepetgetir);
            this.Controls.Add(this.btn_sepeteekle);
            this.Controls.Add(this.txt_sepetgörüntülemusteriıd);
            this.Controls.Add(this.txt_sepetekleurunadeti);
            this.Controls.Add(this.txt_sepetekleurunkodu);
            this.Controls.Add(this.txt_SepetekleMusterııd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Control_MusteriListele";
            this.Size = new System.Drawing.Size(1377, 740);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_SepetekleMusterııd;
        private System.Windows.Forms.TextBox txt_sepetekleurunkodu;
        private System.Windows.Forms.TextBox txt_sepetekleurunadeti;
        private System.Windows.Forms.TextBox txt_sepetgörüntülemusteriıd;
        private System.Windows.Forms.Button btn_sepeteekle;
        private System.Windows.Forms.Button btn_sepetgetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
