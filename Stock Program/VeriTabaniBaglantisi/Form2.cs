using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniBaglantisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            control_KullaniciEkle1.BringToFront();
        }

        private void Btn_UserAdd_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_UserAdd.Top;
            control_KullaniciEkle1.BringToFront();
        }

        private void Btn_UserDelete_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_UserDelete.Top;
            control_KullaniciSil1.BringToFront();
        }

        private void Btn_MusteriLıstele_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_MusteriLıstele.Top;
            control_MusteriListele1.BringToFront();
        }

        private void Btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_MusteriEkle.Top;
            control_MusteriEkle1.BringToFront();

        }

        private void Btn_MusteriSil_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_MusteriSil.Top;
            control_MusteriSil1.BringToFront();

        }

        private void Btn_UrunEkle_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_UrunEkle.Top;
            control_UrunEkle1.BringToFront();
        }

        private void Btn_UrunSil_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = btn_UrunSil.Top;
            control_UrunSil1.BringToFront();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = Btn_Cikis.Top;
            Application.Exit();
        }
    }
}
