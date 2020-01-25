using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B171210002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            
            Form2 bilgialma = new Form2();
            bilgialma.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Form3 bilgiyazma = new Form3();
            bilgiyazma.Show();
            this.Hide();

        }
    }
}
