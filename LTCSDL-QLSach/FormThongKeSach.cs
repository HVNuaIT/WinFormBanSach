using ClosedXML.Excel;
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
    public partial class FormThongKeSach : Form
    {
        public FormThongKeSach()
        {
            InitializeComponent();
        }

        private void bntExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog() { Filter = "Excel WorkBook|*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.qLBanSachDataSet2.Sach.CopyToDataTable(), "Thông Kê Doanh Thu");
                            workbook.SaveAs(ofd.FileName);
                        }
                        MessageBox.Show("Xuất File Báo Cáo Doanh Thu Thành Công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không Xuất File Thành Công", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bntQuayLại_Click(object sender, EventArgs e)
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

        private void bntThoát_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormThongKeSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanSachDataSet2.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLBanSachDataSet2.Sach);


        }
    }
}
