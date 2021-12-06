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

namespace LTCSDL_QLSach.Admin
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
        }
        QLBanSach db = new QLBanSach();
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataSach();
            txtTongTien.Enabled = false;

        }
        void LoadData()
        {
           
            List<TacGia> dsTG = db.TacGias.ToList();
            cbTG.DisplayMember = "TenTG";
            cbTG.ValueMember = "MaTG";
            cbTG.DataSource = dsTG;

            List<Sach> dsSach = db.Saches.ToList();
            cbMaSach.DisplayMember = "TenSach";
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DataSource = dsSach;

            List<NXB> dsNXB = db.NXBs.ToList();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";
            cbNXB.DataSource = dsNXB;
            

        }
        void LoadDataSach()
        {
            dataGridView1.DataSource = null;
            LamMoi();
            List<Sach> dsSach1 = db.Saches.ToList();
            cbTim.DisplayMember = "TenSach";
            cbTim.ValueMember = "MaSach";
            cbTim.DataSource = dsSach1;
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32( cbTim.SelectedValue.ToString());
            var objtim = db.Saches.Where(x => x.MaSach == ma ).Select(t => new
            {
                t.MaSach,
                t.TenSach,
                t.GiaBan,
                t.MoTa,
                t.SoLuongTon,
                t.NgayCapNhat
            }).ToList();
            dataGridView1.DataSource = objtim;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.Saches.Where(s => s.MaSach == ma).First();
            txtGíaSách.Text = obj.GiaBan.ToString();
            txtSL.Text = obj.SoLuongTon.ToString();
            cbMaSach.SelectedValue = obj.MaSach;
            cbTG.SelectedValue = obj.MaTG;
            cbNXB.SelectedValue = obj.MaNXB;
        }

        private void bntQuaylai_Click(object sender, EventArgs e)
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

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            float a =Convert.ToInt32( txtGíaSách.Text);
            int b = Convert.ToInt32(txtSL.Text);
            int ma = Convert.ToInt32(cbMaSach.SelectedValue.ToString());
            var ds = db.Saches.Where(x => x.MaSach == ma).First();
         if (ds.SoLuongTon <= 0)
            {
                MessageBox.Show("Đã Hết Sách");
                return;
            }
            thanhtoan(a, b);
            ds.SoLuongTon -= b;
            db.SaveChanges();
            hienThi();
            MessageBox.Show("Tổng Tiền Thanh Toán Của Khách Là : "+txtTongTien.Text,"Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            Reset();

        }
        void thanhtoan (float a , float b )
        {
            float ketqua = a * b;
            txtTongTien.Text = ketqua.ToString(); 
        }
       
        void hienThi()
        {
            float a = Convert.ToInt32(txtGíaSách.Text);
            int b = Convert.ToInt32(txtSL.Text);
            ThanhToan tt = new ThanhToan();
            tt.IdThanhToan = Convert.ToInt32(txtTT.Text);
            tt.MaNXB = Convert.ToInt32(cbNXB.SelectedValue);
            tt.MaSach = Convert.ToInt32(cbMaSach.SelectedValue);
            tt.MaTG = Convert.ToInt32(cbTG.SelectedValue);
            tt.TenKhach = txtTenKhach.Text;
            tt.GiaSach =  Convert.ToDouble(txtGíaSách.Text);
            tt.SoLuong = Convert.ToInt32(txtSL.Text);
            tt.TongTien = a * b;
            db.ThanhToans.Add(tt);
            db.SaveChanges();
        }
        void Reset()
        {
            txtTongTien.Text = String.Empty;
            txtGíaSách.Text = String.Empty;
            txtSL.Text = String.Empty;
            txtTT.Text= String.Empty;
           txtTenKhach.Text= String.Empty;
            cbMaSach.SelectedValue = String.Empty;
            cbNXB.SelectedValue= String.Empty;
            cbTG.SelectedValue= String.Empty;
        }

        private void bntThoát_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Thóat Khỏi Chương Trình Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void LamMoi()
        {
            dataGridView1.DataSource = db.Saches.Select(t => new
            {
                t.MaSach , 
                t.TenSach,
                t.GiaBan,
                t.MoTa,
                t.SoLuongTon, 
                t.NgayCapNhat
            }).ToList();
        }

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
