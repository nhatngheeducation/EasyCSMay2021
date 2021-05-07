using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy giá trị từ các textbox
                //double Toan = double.Parse(txtToan.Text);
                double Toan;
                if (double.TryParse(txtToan.Text, out  Toan) == false || Toan < 0 || Toan > 10)
                {
                    MessageBox.Show("Điểm Toán không hợp lệ");
                    txtToan.Focus();
                    return;//ép kết thúc hàm tại đây
                }

                double Ly;
                if (double.TryParse(txtLy.Text, out Ly) == false || Ly < 0 || Ly > 10)
                {
                    MessageBox.Show("Điểm Lý không hợp lệ");
                    txtLy.Focus();
                    return;//ép kết thúc hàm tại đây
                }

                double Hoa;
                if (double.TryParse(txtHoa.Text, out Hoa) == false || Hoa < 0 || Hoa > 10)
                {
                    MessageBox.Show("Điểm Hóa không hợp lệ");
                    txtHoa.Focus();
                    return;//ép kết thúc hàm tại đây
                }

                double DiemTrungBinh = (Toan + Ly + Hoa) / 3;
                string XepLoai = string.Empty;
                if (DiemTrungBinh < 5)
                {
                    XepLoai = "Yếu";
                }
                //else if(DiemTrungBinh >= 5 && DiemTrungBinh < 7)
                else if (DiemTrungBinh < 7)
                {
                    XepLoai = "Trung bình";
                }
                else if (DiemTrungBinh < 8)
                {
                    XepLoai = "Khá";
                }
                else if (DiemTrungBinh < 9)
                {
                    XepLoai = "Giỏi";
                }
                else
                {
                    XepLoai = "Xuất sắc";
                }

                txtDTB.Text = DiemTrungBinh.ToString();
                txtXepLoai.Text = XepLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }



        }// end sự kiện click


    }
}
