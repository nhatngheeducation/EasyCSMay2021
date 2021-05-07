using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraNamNhuan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime Ngay = new DateTime(2100, 3, 1).AddDays(-1);
            //MessageBox.Show(Ngay.ToString());

            int Nam, Thang;
            if (!int.TryParse(txtNam.Text, out Nam) || Nam < 1900)
            {
                MessageBox.Show("Năm không hợp lệ");
                txtNam.Focus();
                return;
            }
            if (!int.TryParse(txtThang.Text, out Thang) || Thang < 1 || Thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                txtThang.Focus();
                return;
            }
            bool LaNamNhuan = false;
            if (Nam % 400 == 0)
            {
                LaNamNhuan = true;
            }
            else if(Nam % 4 == 0 && Nam % 100 != 0)
            {
                LaNamNhuan = true;
            }
            int SoNgay = 0;
            switch (Thang)
            {
                case 1: case 3: case 5: case 7:
                case 8: case 10: case 12:
                    SoNgay = 31; break;
                case 2:
                    SoNgay = LaNamNhuan ? 29 : 28;
                    break;
                default:
                    SoNgay = 30; break;
            }
            chkLaNamNhuan.Checked = LaNamNhuan;
            txtKetQua.Text = $"Tháng {Thang}/{Nam} có {SoNgay} ngày.";
        }//end
    }
}
