
namespace LTCSDL_QLSach.Admin
{
    partial class FormThongKeSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntThoát = new System.Windows.Forms.Button();
            this.bntQuayLại = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExcel = new System.Windows.Forms.Button();
            this.qLBanSachDataSet2 = new LTCSDL_QLSach.QLBanSachDataSet2();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new LTCSDL_QLSach.QLBanSachDataSet2TableAdapters.SachTableAdapter();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // bntThoát
            // 
            this.bntThoát.Location = new System.Drawing.Point(548, 365);
            this.bntThoát.Name = "bntThoát";
            this.bntThoát.Size = new System.Drawing.Size(75, 23);
            this.bntThoát.TabIndex = 19;
            this.bntThoát.Text = "Thoát";
            this.bntThoát.UseVisualStyleBackColor = true;
            this.bntThoát.Click += new System.EventHandler(this.bntThoát_Click);
            // 
            // bntQuayLại
            // 
            this.bntQuayLại.Location = new System.Drawing.Point(381, 365);
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
            this.label1.Location = new System.Drawing.Point(315, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thống Kê  Số Lượng Sách";
            // 
            // bntExcel
            // 
            this.bntExcel.Location = new System.Drawing.Point(216, 365);
            this.bntExcel.Name = "bntExcel";
            this.bntExcel.Size = new System.Drawing.Size(75, 23);
            this.bntExcel.TabIndex = 16;
            this.bntExcel.Text = "&Excel";
            this.bntExcel.UseVisualStyleBackColor = true;
            this.bntExcel.Click += new System.EventHandler(this.bntExcel_Click);
            // 
            // qLBanSachDataSet2
            // 
            this.qLBanSachDataSet2.DataSetName = "QLBanSachDataSet2";
            this.qLBanSachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLBanSachDataSet2;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            // 
            // FormThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntThoát);
            this.Controls.Add(this.bntQuayLại);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntExcel);
            this.Name = "FormThongKeSach";
            this.Text = "FormThongKeSach";
            this.Load += new System.EventHandler(this.FormThongKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntThoát;
        private System.Windows.Forms.Button bntQuayLại;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExcel;
        private QLBanSachDataSet2 qLBanSachDataSet2;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLBanSachDataSet2TableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
    }
}