using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double BanKinh = double.Parse(txtBanKinh.Text);
                double ChuVi = 2 * Math.PI * BanKinh;
                double DienTich = Math.PI * Math.Pow(BanKinh, 2);
                txtChuVi.Text = ChuVi.ToString();
                txtDienTich.Text = DienTich.ToString();
            }
            catch
            {
                MessageBox.Show("Nhập số thực");
            }

        }
    }
}
