namespace VeriTabaniBaglantisi
{
    partial class Control_MusteriSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ControlSilinecekTc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ControlMusteriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Müşteri TC :";
            // 
            // txt_ControlSilinecekTc
            // 
            this.txt_ControlSilinecekTc.Location = new System.Drawing.Point(198, 43);
            this.txt_ControlSilinecekTc.Name = "txt_ControlSilinecekTc";
            this.txt_ControlSilinecekTc.Size = new System.Drawing.Size(207, 22);
            this.txt_ControlSilinecekTc.TabIndex = 1;
            this.txt_ControlSilinecekTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ControlSilinecekTc_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 740);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_ControlMusteriSil
            // 
            this.btn_ControlMusteriSil.Location = new System.Drawing.Point(284, 71);
            this.btn_ControlMusteriSil.Name = "btn_ControlMusteriSil";
            this.btn_ControlMusteriSil.Size = new System.Drawing.Size(121, 29);
            this.btn_ControlMusteriSil.TabIndex = 5;
            this.btn_ControlMusteriSil.Text = "Müşteriyi Sil";
            this.btn_ControlMusteriSil.UseVisualStyleBackColor = true;
            this.btn_ControlMusteriSil.Click += new System.EventHandler(this.Btn_ControlMusteriSil_Click);
            // 
            // Control_MusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btn_ControlMusteriSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_ControlSilinecekTc);
            this.Controls.Add(this.label1);
            this.Name = "Control_MusteriSil";
            this.Size = new System.Drawing.Size(1377, 740);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MusteriSil_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ControlSilinecekTc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ControlMusteriSil;
    }
}
