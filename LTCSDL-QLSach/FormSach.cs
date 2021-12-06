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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }
        QLBanSach db = new QLBanSach();
        

        private void FormSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = null;
            LamMoi();
            List<TacGia> dsTG = db.TacGias.ToList();
            cbTacGia.DisplayMember = "TenTG";
            cbTacGia.ValueMember = "MaTG";
            cbTacGia.DataSource = dsTG;
            List<NXB> dsNXB = db.NXBs.ToList();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";
            cbNXB.DataSource = dsNXB;
            
        }
        

        private void bntThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = Convert.ToInt32( txtMaSach.Text);
            sach.GiaBan = Convert.ToInt32(txtGiaBan.Text);
            sach.MaNXB = Convert.ToInt32(cbNXB.SelectedValue.ToString());
            sach.MaTG = Convert.ToInt32(cbTacGia.SelectedValue.ToString());
            sach.MoTa = txtMoTa.Text;
            sach.NgayCapNhat = dateCN.Value;
            sach.SoLuongTon =  Convert.ToInt32( txtSoLuong.Text);
            sach.TenSach = txtTenSach.Text;
           var ds =  db.Saches.Where(s => s.TenSach.Equals(txtTenSach.Text)).ToList();
            if (ds.Count >0)
            {
                MessageBox.Show("Đã Tồn Tại Sách này Trong Danh Sách Rồi !"); return; 

            }
            db.Saches.Add(sach);
            db.SaveChanges();
            LoadData();
            Reset();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtMaSach.Text);
            var ojbsach = db.Saches.Where(s => s.MaSach == ma).First();
            DialogResult dt = MessageBox.Show("Có Muốn Xóa Không !!", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt== DialogResult.No)
            {
                return ;
            }
            db.Saches.Remove(ojbsach);
            db.SaveChanges();
            LoadData();
            Reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtMaSach.Text);
            var ojbsach = db.Saches.Where(s => s.MaSach == ma).First();
            ojbsach.MaTG = Convert.ToInt32(cbTacGia.SelectedValue);
            ojbsach.MaNXB = Convert.ToInt32(cbNXB.SelectedValue);
            ojbsach.MaSach = Convert.ToInt32(txtMaSach.Text);
            ojbsach.TenSach = txtTenSach.Text;
            ojbsach.MoTa = txtMoTa.Text;
            ojbsach.GiaBan = Convert.ToDouble(txtGiaBan.Text);
            ojbsach.NgayCapNhat = dateCN.Value;
            ojbsach.SoLuongTon =Convert.ToInt32( txtSoLuong.Text);
            db.SaveChanges();
            LoadData();
            Reset();
            MessageBox.Show("Cập nhật thành công ", "Thông Báo");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.Saches.Where(s => s.MaSach == ma).First();
            txtMaSach.Text = obj.MaSach.ToString();
            txtMoTa.Text = obj.MoTa;
            txtSoLuong.Text = obj.SoLuongTon.ToString();
            txtTenSach.Text = obj.TenSach;
            txtGiaBan.Text = obj.GiaBan.ToString();
            cbNXB.SelectedValue = obj.MaNXB;
            cbTacGia.SelectedValue = obj.MaTG;
        }
        public void Reset()
        {
            txtMaSach.Text =String.Empty; 
            txtGiaBan.Text = String.Empty;
            txtMoTa.Text = String.Empty;
           txtSoLuong.Text = String.Empty;
            txtTenSach.Text = String.Empty;
            cbTacGia.Text  = String.Empty;
            cbNXB.Text = String.Empty;
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
        void LamMoi()
        {
            dataGridView1.DataSource = db.Saches.Select(t => new
            {
                t.MaSach,
                t.TenSach,
                t.GiaBan,
                t.MoTa,
                t.SoLuongTon,
                t.NgayCapNhat
            }).ToList();
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String str = txtTim.Text.Trim();
            dataGridView1.DataSource = db.Saches.Where(s => s.TenSach.Contains(str)).ToList();

           
        }
    }
}
