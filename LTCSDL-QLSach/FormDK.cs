using LTCSDL_QLSach.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCSDL_QLSach.Properties
{
    public partial class FormDK : Form
    {
        public FormDK()
        {
            InitializeComponent();
        }
        QLBanSach db = new QLBanSach();
        private void bntDK_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.TenNguoiDung = txtNguoiDung.Text;
            user.TaiKhoan = txtTKDK.Text;
            user.MatKhau = txtTKDK.Text; 
            if (txtNhapLạiMK.Text!=txtMKDK.Text)
            {
                DialogResult dt = MessageBox.Show("Mật Khẩu Không đúng Mời !");
                return; 
            }
            user.SDT = Convert.ToInt32(txtSDT.Text);
            user.DiaChi = txtDC.Text;
            user.GioiTinh = txtGT.Text;
            MessageBox.Show(" Chúc Mừng Bạn Đã Đăng Kí Tài Khoản Thành Công !!");
            db.Users.Add(user);
            db.SaveChanges();
            Reset();


        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            Form f = new Login();
            DialogResult dt = MessageBox.Show("Bạn có muốn quay lại Đăng nhập không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;

            }
            f.Show();
            this.Hide();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void Reset()
        {
            txtNguoiDung.Text = " ";
            txtTKDK.Text = " ";
            txtMKDK.Text = " ";
            txtNhapLạiMK.Text= " "; 
            txtSDT.Text = " ";
            txtDC.Text = " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMKDK.PasswordChar = '\0';
                txtNhapLạiMK.PasswordChar = '\0';
            }else
            {
                txtMKDK.PasswordChar = '*';
                txtNhapLạiMK.PasswordChar ='*';
            }
        }
    }
}
