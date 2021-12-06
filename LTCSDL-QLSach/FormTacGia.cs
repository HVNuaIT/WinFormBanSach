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
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
        }

        QLBanSach db = new QLBanSach();

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

        private void bntThemTG_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.MaTG = Convert.ToInt32(txtMaTG.Text);
            tg.TenTG = txtTenTG.Text;
            tg.Tuoi = Convert.ToInt32(txtTuoi.Text);
            tg.SDT = Convert.ToInt32(txtSDT.Text);
            var ObjThem = db.TacGias.Where(x => x.TenTG.Equals(txtTenTG.Text)).ToList();
            if (ObjThem.Count > 0)
            {
                MessageBox.Show("Tác Gỉa Đã Tồn Tại Rồi !!");
                return;
            }
            db.TacGias.Add(tg);
            db.SaveChanges();
            Loaddata();
            Reset();


        }
        void Loaddata()
        {
            var dsTacGia = db.TacGias.ToList();
            dataGridView1.DataSource = dsTacGia;
        }
        void Reset()
        {
            txtMaTG.Text = String.Empty;
            txtTenTG.Text = String.Empty;
            txtTuoi.Text = String.Empty;
            txtSDT.Text = String.Empty; 
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void bntXoaTG_Click(object sender, EventArgs e)
        {
            int maTG = Convert.ToInt32(txtMaTG.Text);
            var objxoa = db.TacGias.Where(x => x.MaTG == maTG).First();
            DialogResult dt = MessageBox.Show("Có Chắc Chắn Muốn Xóa Tác Gỉa Này Không", "Thông BÁO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return; 
            }
            db.TacGias.Remove(objxoa);
            db.SaveChanges();
            Loaddata();
            Reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            int maTG = Convert.ToInt32(txtMaTG.Text);
            var objsua = db.TacGias.Where(x => x.MaTG == maTG).First();
            objsua.MaTG = Convert.ToInt32(txtMaTG.Text);
            objsua.TenTG = txtTenTG.Text;
            objsua.SDT = Convert.ToInt32(txtSDT.Text);
            objsua.Tuoi = Convert.ToInt32(txtTuoi.Text);
            db.SaveChanges();
            Loaddata();
                Reset();
            MessageBox.Show("Cập nhật thành công ", "Thông Báo");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.TacGias.Where(s => s.MaTG == ma).First();
            txtMaTG.Text = obj.MaTG.ToString();
            txtTenTG.Text = obj.TenTG;
            txtSDT.Text = obj.SDT.ToString();
            txtTuoi.Text = obj.Tuoi.ToString();
        }

        

        private void bntTim_Click(object sender, EventArgs e)
        {
            String str = txtTim.Text.Trim();
            dataGridView1.DataSource = db.TacGias.Where(s => s.TenTG.Contains(str)).ToList();

        }

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn làm mới ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt == DialogResult.Yes)
            {
                Loaddata();
            }
        }
    }
}
