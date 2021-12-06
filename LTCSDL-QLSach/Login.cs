using LTCSDL_QLSach.DataBase;
using LTCSDL_QLSach.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LTCSDL_QLSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        QLBanSach db = new QLBanSach();


        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = db.Users.Where(x => x.TaiKhoan == txtTK.Text).First();


                if (ds.TaiKhoan == txtTK.Text && ds.MatKhau == txtMK.Text)
                {
                    if (ds.idChucVu == 1)
                    {
                        MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Với Quyền Admin !!");
                        Form admin = new FormTrangChu();
                        admin.Show();
                        KiemTra.check = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Quyền User !!");
                        Form nv = new FormTrangChu();
                        KiemTra.check = false;
                        nv.Show();
                        this.Hide();
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Đăng Nhập Thất Bại Rồi !!");
            }
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form f = new FormDK();
            f.Show();
            this.Hide();
        }
    }
    public class KiemTra
    {
        public static bool check { get; set; } = true;
    }
    
}

