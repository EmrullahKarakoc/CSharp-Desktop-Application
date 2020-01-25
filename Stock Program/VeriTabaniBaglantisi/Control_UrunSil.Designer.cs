namespace VeriTabaniBaglantisi
{
    partial class Control_UrunSil
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ControlUrunKodu = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_ControlUrunAdedi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ControlUrunuSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = " Ürün Adedi : ";
            // 
            // txt_ControlUrunKodu
            // 
            this.txt_ControlUrunKodu.Location = new System.Drawing.Point(153, 43);
            this.txt_ControlUrunKodu.Name = "txt_ControlUrunKodu";
            this.txt_ControlUrunKodu.Size = new System.Drawing.Size(249, 22);
            this.txt_ControlUrunKodu.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_ControlUrunAdedi
            // 
            this.txt_ControlUrunAdedi.Location = new System.Drawing.Point(153, 71);
            this.txt_ControlUrunAdedi.Name = "txt_ControlUrunAdedi";
            this.txt_ControlUrunAdedi.Size = new System.Drawing.Size(249, 22);
            this.txt_ControlUrunAdedi.TabIndex = 10;
            this.txt_ControlUrunAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ControlUrunAdedi_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_ControlUrunuSil
            // 
            this.btn_ControlUrunuSil.Location = new System.Drawing.Point(284, 99);
            this.btn_ControlUrunuSil.Name = "btn_ControlUrunuSil";
            this.btn_ControlUrunuSil.Size = new System.Drawing.Size(121, 29);
            this.btn_ControlUrunuSil.TabIndex = 12;
            this.btn_ControlUrunuSil.Text = "Ürünü Sil";
            this.btn_ControlUrunuSil.UseVisualStyleBackColor = true;
            this.btn_ControlUrunuSil.Click += new System.EventHandler(this.Btn_ControlUrunuSil_Click);
            // 
            // Control_UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btn_ControlUrunuSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_ControlUrunAdedi);
            this.Controls.Add(this.txt_ControlUrunKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Control_UrunSil";
            this.Size = new System.Drawing.Size(1377, 740);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_UrunSil_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ControlUrunKodu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_ControlUrunAdedi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ControlUrunuSil;
    }
}
