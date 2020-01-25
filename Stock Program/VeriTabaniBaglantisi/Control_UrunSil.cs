using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniBaglantisi
{
    public partial class Control_UrunSil : UserControl
    {
        public Control_UrunSil()
        {
            InitializeComponent();
            GridYukle();
        }

        private void Txt_ControlUrunAdedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_ControlUrunuSil_Click(object sender, EventArgs e)
        {
            if(txt_ControlUrunKodu.Text != "" && txt_ControlUrunAdedi.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                komut.Connection = connection;
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = connection;
                connection.Open();
                komut.CommandText = "DELETE FROM Urunler WHERE UrunAdedi <= 0";
                komut2.CommandText = "UPDATE Urunler SET UrunAdedi -=  " + txt_ControlUrunAdedi.Text + " WHERE UrunKodu = '" + txt_ControlUrunKodu.Text + "'";
                int kosul = (int)komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                if (kosul == 1)
                 {

                    MessageBox.Show(txt_ControlUrunKodu.Text + " Kodlu Ürün Sistemden Başarıla Silinmiştir...");
                    txt_ControlUrunKodu.Text = "";
                    txt_ControlUrunAdedi.Text = "";

                 }
                 else
                     MessageBox.Show(txt_ControlUrunKodu.Text + " Kodlu Ürün Sistemde Bulunamamıştır...");
                connection.Close();
                GridYukle();
            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");
        }

        public void GridYukle()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Urunler", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Ürün Kodu";
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[2].HeaderText = "Ürün Adedi";
            dataGridView1.Columns[3].HeaderText = "Ürün Kategorisi";
        }

        private void Control_UrunSil_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }
    }
}
