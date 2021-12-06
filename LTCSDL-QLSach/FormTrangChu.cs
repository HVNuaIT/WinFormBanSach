using LTCSDL_QLSach.Admin;
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
    public partial class FormTrangChu : Form
    {
        QLBanSach db = new QLBanSach();
        public FormTrangChu()
        {
            InitializeComponent();

        }
        void Phanquyen()
        {
            if (KiemTra.check == false )
            {
                toolStripMenuItem1.Enabled = false;
                thôngKêNhânViênToolStripMenuItem.Enabled = false;
            }
        }
       
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Phanquyen();
            
           
        }
        private void quanLySachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form x = new FormSach();
            x.Show();
            this.Hide();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormTacGia();
            x.Show();
            this.Hide();
        }

        private void nhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormNXB();
            x.Show();
            this.Hide();
        }

        private void thôngKêTheoNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeSach();
            x.Show();
            this.Hide();
        }

        private void thôngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeNhanVien();
            x.Show();
            this.Hide();
        }

        private void quanLiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormQuanLyNV();
            x.Show();
            this.Hide();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new Login();
            DialogResult dt = MessageBox.Show("Bạn có muốn Thoát trang chủ không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;

            }
            x.Show();
            this.Hide();
        }

        private void thanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThanhToan();
            x.Show();
            this.Hide();
        }

       

        private void thôngKêDoanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form x = new FormThongKeDoanhThu();
            x.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
