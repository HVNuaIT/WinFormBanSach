
namespace LTCSDL_QLSach
{
    partial class FormThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bntThoát = new System.Windows.Forms.Button();
            this.bntQuayLại = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLBanSachDataSet = new LTCSDL_QLSach.QLBanSachDataSet();
            this.thanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhToanTableAdapter = new LTCSDL_QLSach.QLBanSachDataSetTableAdapters.ThanhToanTableAdapter();
            this.idThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoát
            // 
            this.bntThoát.Location = new System.Drawing.Point(527, 365);
            this.bntThoát.Name = "bntThoát";
            this.bntThoát.Size = new System.Drawing.Size(75, 23);
            this.bntThoát.TabIndex = 19;
            this.bntThoát.Text = "Thoát";
            this.bntThoát.UseVisualStyleBackColor = true;
            this.bntThoát.Click += new System.EventHandler(this.bntThoát_Click);
            // 
            // bntQuayLại
            // 
            this.bntQuayLại.Location = new System.Drawing.Point(360, 365);
            this.bntQuayLại.Name = "bntQuayLại";
            this.bntQuayLại.Size = new System.Drawing.Size(75, 23);
            this.bntQuayLại.TabIndex = 18;
            this.bntQuayLại.Text = "Quay Lại";
            this.bntQuayLại.UseVisualStyleBackColor = true;
            this.bntQuayLại.Click += new System.EventHandler(this.bntQuayLại_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // bntExcel
            // 
            this.bntExcel.Location = new System.Drawing.Point(195, 365);
            this.bntExcel.Name = "bntExcel";
            this.bntExcel.Size = new System.Drawing.Size(75, 23);
            this.bntExcel.TabIndex = 16;
            this.bntExcel.Text = "&Excel";
            this.bntExcel.UseVisualStyleBackColor = true;
            this.bntExcel.Click += new System.EventHandler(this.bntExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idThanhToanDataGridViewTextBoxColumn,
            this.tenKhachDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.maTGDataGridViewTextBoxColumn,
            this.maNXBDataGridViewTextBoxColumn,
            this.giaSachDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thanhToanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 193);
            this.dataGridView1.TabIndex = 15;
            // 
            // qLBanSachDataSet
            // 
            this.qLBanSachDataSet.DataSetName = "QLBanSachDataSet";
            this.qLBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhToanBindingSource
            // 
            this.thanhToanBindingSource.DataMember = "ThanhToan";
            this.thanhToanBindingSource.DataSource = this.qLBanSachDataSet;
            // 
            // thanhToanTableAdapter
            // 
            this.thanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // idThanhToanDataGridViewTextBoxColumn
            // 
            this.idThanhToanDataGridViewTextBoxColumn.DataPropertyName = "IdThanhToan";
            this.idThanhToanDataGridViewTextBoxColumn.HeaderText = "IdThanhToan";
            this.idThanhToanDataGridViewTextBoxColumn.Name = "idThanhToanDataGridViewTextBoxColumn";
            this.idThanhToanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhachDataGridViewTextBoxColumn
            // 
            this.tenKhachDataGridViewTextBoxColumn.DataPropertyName = "TenKhach";
            this.tenKhachDataGridViewTextBoxColumn.HeaderText = "TenKhach";
            this.tenKhachDataGridViewTextBoxColumn.Name = "tenKhachDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            // 
            // maTGDataGridViewTextBoxColumn
            // 
            this.maTGDataGridViewTextBoxColumn.DataPropertyName = "MaTG";
            this.maTGDataGridViewTextBoxColumn.HeaderText = "MaTG";
            this.maTGDataGridViewTextBoxColumn.Name = "maTGDataGridViewTextBoxColumn";
            // 
            // maNXBDataGridViewTextBoxColumn
            // 
            this.maNXBDataGridViewTextBoxColumn.DataPropertyName = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.HeaderText = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.Name = "maNXBDataGridViewTextBoxColumn";
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntThoát);
            this.Controls.Add(this.bntQuayLại);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntExcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoát;
        private System.Windows.Forms.Button bntQuayLại;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLBanSachDataSet qLBanSachDataSet;
        private System.Windows.Forms.BindingSource thanhToanBindingSource;
        private QLBanSachDataSetTableAdapters.ThanhToanTableAdapter thanhToanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
    }
}