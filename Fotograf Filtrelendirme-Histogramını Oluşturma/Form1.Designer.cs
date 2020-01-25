namespace B171210002_1.odev
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbGri = new Emgu.CV.UI.ImageBox();
            this.pbRenkli = new Emgu.CV.UI.ImageBox();
            this.pbBinary = new Emgu.CV.UI.ImageBox();
            this.hbHistogram = new Emgu.CV.UI.HistogramBox();
            this.btnekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenkli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinary)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGri
            // 
            this.pbGri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbGri.Location = new System.Drawing.Point(529, 12);
            this.pbGri.Name = "pbGri";
            this.pbGri.Size = new System.Drawing.Size(509, 312);
            this.pbGri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGri.TabIndex = 2;
            this.pbGri.TabStop = false;
            // 
            // pbRenkli
            // 
            this.pbRenkli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbRenkli.Location = new System.Drawing.Point(12, 12);
            this.pbRenkli.Name = "pbRenkli";
            this.pbRenkli.Size = new System.Drawing.Size(511, 312);
            this.pbRenkli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRenkli.TabIndex = 3;
            this.pbRenkli.TabStop = false;
            // 
            // pbBinary
            // 
            this.pbBinary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbBinary.Location = new System.Drawing.Point(529, 373);
            this.pbBinary.Name = "pbBinary";
            this.pbBinary.Size = new System.Drawing.Size(509, 312);
            this.pbBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBinary.TabIndex = 4;
            this.pbBinary.TabStop = false;
            // 
            // hbHistogram
            // 
            this.hbHistogram.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hbHistogram.Location = new System.Drawing.Point(12, 373);
            this.hbHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hbHistogram.Name = "hbHistogram";
            this.hbHistogram.Size = new System.Drawing.Size(510, 312);
            this.hbHistogram.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Gold;
            this.btnekle.Location = new System.Drawing.Point(12, 330);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(127, 36);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "Resim Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 725);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.hbHistogram);
            this.Controls.Add(this.pbBinary);
            this.Controls.Add(this.pbRenkli);
            this.Controls.Add(this.pbGri);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenkli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox pbGri;
        private Emgu.CV.UI.ImageBox pbRenkli;
        private Emgu.CV.UI.ImageBox pbBinary;
        private Emgu.CV.UI.HistogramBox hbHistogram;
        private System.Windows.Forms.Button btnekle;
    }
}

