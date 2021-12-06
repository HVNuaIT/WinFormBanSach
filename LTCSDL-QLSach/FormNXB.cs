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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
        }

        QLBanSach db = new QLBanSach();

        private void bntThêm_Click(object sender, EventArgs e)
        {
            NXB nxb = new NXB();
            nxb.MaNXB = Convert.ToInt32(txtMa.Text);
            nxb.TenNXB = txtTen.Text;
            nxb.DiaChi = txtDC.Text;
            nxb.SoDienThoai = Convert.ToInt32(txtSDT.Text);
            var dsThem = db.NXBs.Where(s => s.TenNXB.Equals(txtTen.Text)).ToList();
            if (dsThem.Count > 0)
            {
                MessageBox.Show("Đã Tồn Tại Nhà Xuất Bản !!"); return; 
            }
            db.NXBs.Add(nxb);
            db.SaveChanges();
            Loaddata();
            Reset();
            
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        void Loaddata()
        {
            var dsNXB = db.NXBs.ToList();
            dataGridView1.DataSource = dsNXB; 
        }
        void Reset()
        {
            txtMa.Text = String.Empty;
            txtDC.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTen.Text = String.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.NXBs.Where(s => s.MaNXB == ma).First();
            txtDC.Text = obj.DiaChi;
            txtMa.Text = obj.MaNXB.ToString();
            txtSDT.Text = obj.SoDienThoai.ToString();
            txtTen.Text = obj.TenNXB;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
             int ma = Convert.ToInt32(txtMa.Text);
            var objxoa = db.NXBs.Where(s => s.MaNXB == ma).First();

            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa NXB hay Không !!" ,"Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
            if (dt ==DialogResult.No)
            {
                return; 

            }
            db.NXBs.Remove(objxoa);
            db.SaveChanges();
            Loaddata();
            Reset();

        }

        private void bntSửa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtMa.Text);
            var objsua = db.NXBs.Where(s => s.MaNXB == ma).First();
            objsua.MaNXB = Convert.ToInt32(txtMa.Text);
            objsua.TenNXB = txtTen.Text;
            objsua.DiaChi = txtDC.Text;
            objsua.SoDienThoai = Convert.ToInt32(txtSDT.Text);
            db.SaveChanges();
            Loaddata();
            Reset();
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
            dataGridView1.DataSource = db.NXBs.Where(s => s.TenNXB.Contains(str)).ToList();

        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn làm mới ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt == DialogResult.Yes)
            {
                Loaddata();
            }
           
        }
    }
}
