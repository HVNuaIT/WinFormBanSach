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

namespace LTCSDL_QLSach
{
    public partial class FormQuanLyNV : Form
    {
        public FormQuanLyNV()
        {
            InitializeComponent();
        }
        QLBanSach db = new QLBanSach();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.Users.Where(s => s.IdUser == ma).First();
            txtid.Text = obj.IdUser.ToString();
            txtDC.Text = obj.DiaChi;
            txtGT.Text = obj.GioiTinh;
            txtMK.Text = obj.MatKhau;
            txtSDT.Text = obj.SDT.ToString();
            txtTenND.Text = obj.TenNguoiDung;
            txtTK.Text = obj.TaiKhoan;
            cbChucVu.SelectedValue = obj.idChucVu;
        }

        
        void Loaddata()
        {
            dataGridView1.DataSource = db.Users.ToList();
            List<ChucVu> dsChucVu = db.ChucVus.ToList();
            cbChucVu.DisplayMember = "ChucVu1";
            cbChucVu.ValueMember = "IdChucVu";
            cbChucVu.DataSource = dsChucVu;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            User s = new User();
            s.TaiKhoan = txtTK.Text;
            s.MatKhau = txtMK.Text;
            s.SDT =Convert.ToInt32 (txtSDT.Text);
            s.TenNguoiDung = txtTenND.Text;
            s.DiaChi = txtDC.Text;
            s.GioiTinh = txtGT.Text;
            s.idChucVu = Convert.ToInt32(cbChucVu.SelectedValue.ToString());
            s.IdUser = Convert.ToInt32(txtid.Text);
            var ds = db.Users.Where(a => a.TenNguoiDung.Contains(txtTenND.Text)).ToList();
            if (ds.Count > 0)
            {
                MessageBox.Show("Người Dùng đã Tồn Tại Rồi "); return; 
            }
            db.Users.Add(s);
            db.SaveChanges();
            Loaddata();
            reset();
        }

        private void FormQuanLyNV_Load_1(object sender, EventArgs e)
        {
            Loaddata();
        }
        void reset()
        {
            txtid.Text = String.Empty;
            txtGT.Text = String.Empty;
            txtDC.Text = String.Empty;
            txtMK.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTenND.Text = String.Empty;
            txtTK.Text = String.Empty;
            cbChucVu.Text = String.Empty;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtid.Text);
            var ds = db.Users.Where(s => s.IdUser == ma).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.SaveChanges();
            Loaddata();
            reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {   int ma = Convert.ToInt32(txtid.Text);
            var ds = db.Users.Where(s => s.IdUser == ma).First();
            ds.TaiKhoan = txtTK.Text;
            ds.MatKhau = txtMK.Text;
            ds.SDT = Convert.ToInt32(txtSDT.Text);
            ds.TenNguoiDung = txtTenND.Text;
            ds.DiaChi = txtDC.Text;
            ds.GioiTinh = txtGT.Text;
            ds.idChucVu = Convert.ToInt32(cbChucVu.SelectedValue.ToString());
            ds.IdUser = Convert.ToInt32(txtid.Text);
            db.SaveChanges();
            Loaddata();
            reset();
            MessageBox.Show("Cập nhật thành công ", "Thông Báo");
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            Form x = new FormTrangChu();
            DialogResult dt = MessageBox.Show("Bạn có muốn quay lại trang chủ không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;

            }
            x.Show();
            this.Hide();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String str = txtTim.Text.Trim();
            dataGridView1.DataSource = db.Users.Where(x => x.TenNguoiDung.Contains(str) ||x.GioiTinh.Contains(str)).Select(t => new

            {
                t.IdUser,
                t.TenNguoiDung,
                t.SDT,
                t.TaiKhoan,
                t.MatKhau,
                t.GioiTinh,
                t.DiaChi
            }).ToList();
            
           
           
           
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
