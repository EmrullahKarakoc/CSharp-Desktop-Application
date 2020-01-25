using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace VeriTabaniBaglantisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            DataTable datatable = new DataTable();
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT * FROM UsersTable WHERE UserName='"+txt_Username.Text +"' AND Password='"+txt_Password.Text+"'",connection);
            dataadapter.Fill(datatable);

            if(datatable.Rows.Count ==1)
            {
                Form2 normalpanel = new Form2();
                this.Hide();
                normalpanel.Show();
            }
            else
            {
                txt_Username.Text = "";
                txt_Password.Text = "";
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz.Tekrar Deneyin !");
            }
            connection.Close();
        }


        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
