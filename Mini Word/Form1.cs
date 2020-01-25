using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.ShowDialog();
            richTextBox.SelectionColor = Renk.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox.SelectionFont = font.Font;
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog ();
            kaydet.ShowDialog();
        
        }
    }
}
