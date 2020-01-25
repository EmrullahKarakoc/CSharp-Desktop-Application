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
    public partial class Control_KullaniciEkle : UserControl
    {
        public Control_KullaniciEkle()
        {
            InitializeComponent();
            GridYukle();
        }

        private void Btn_KullaniciEkleControl_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciadiControl.Text != "" && txt_kullanicisifrecontrol.Text != "" && txt_Kullanicitekrarsifrecontrol.Text != "" && (rb_Admin.Checked || rb_Normal.Checked))
            {
                if(txt_kullanicisifrecontrol.Text == txt_Kullanicitekrarsifrecontrol.Text)
                {

                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = connection;

                        if (rb_Admin.Checked)
                        {
                            komut.CommandText = "INSERT INTO UsersTable (UserName, Password, Role) VALUES ('" + txt_KullaniciadiControl.Text + "','" + txt_kullanicisifrecontrol.Text + "','1');";

                        }
                        else if (rb_Normal.Checked)
                        {
                            komut.CommandText = "INSERT INTO UsersTable (UserName, Password, Role) VALUES ('" + txt_KullaniciadiControl.Text + "','" + txt_kullanicisifrecontrol.Text + "','2')";
                        }
                        komut.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(txt_KullaniciadiControl.Text + " Kullanıcısı Başarılı Bir Şekilde Sisteme Eklenmiştir ..");
                        {
                            txt_KullaniciadiControl.Text = "";
                            txt_kullanicisifrecontrol.Text = "";
                            txt_Kullanicitekrarsifrecontrol.Text = "";
                            rb_Admin.Checked = false;
                            rb_Normal.Checked = false;
                            GridYukle();
                        }


                }
                else
                MessageBox.Show("Şifreler Eşleşmiyor. Lütfen Aynı Şifreyi Giriniz ... !");

            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");

        }

        public void GridYukle()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UsersTable", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Id";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Şifresi";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı Rolü";
        }

        private void Control_KullaniciEkle_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }
    }
}
