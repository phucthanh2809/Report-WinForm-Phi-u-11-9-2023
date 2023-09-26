
namespace Report_WinForm_Phiếu_11_9_2023
{
    partial class GiayCamDoanChapNhanPhauThuat_Chinh
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgrBacSi = new System.Windows.Forms.DataGridView();
            this.IdPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPPTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bienchung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennguoithan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noilamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danhxung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoadieutri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrangbenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.BtnXuat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBacSi)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1473, 734);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trang 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgrBacSi);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 102);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1465, 628);
            this.panel6.TabIndex = 1;
            // 
            // dgrBacSi
            // 
            this.dgrBacSi.AllowUserToAddRows = false;
            this.dgrBacSi.AllowUserToDeleteRows = false;
            this.dgrBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPhieu,
            this.TenBS,
            this.TenKhoaBS,
            this.Chuandoan,
            this.PPPTTT,
            this.Bienchung,
            this.Tennguoithan,
            this.Tuoi,
            this.Gioitinh,
            this.Dantoc,
            this.Quoctich,
            this.Nghenghiep,
            this.Noilamviec,
            this.Diachi,
            this.Danhxung,
            this.Tenbenhnhan,
            this.Khoadieutri,
            this.Tinhtrangbenh,
            this.cSua,
            this.cXoa});
            this.dgrBacSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrBacSi.Location = new System.Drawing.Point(0, 0);
            this.dgrBacSi.Margin = new System.Windows.Forms.Padding(4);
            this.dgrBacSi.MultiSelect = false;
            this.dgrBacSi.Name = "dgrBacSi";
            this.dgrBacSi.ReadOnly = true;
            this.dgrBacSi.RowHeadersWidth = 51;
            this.dgrBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrBacSi.Size = new System.Drawing.Size(1465, 628);
            this.dgrBacSi.TabIndex = 61;
            this.dgrBacSi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBacSi_CellContentClick);
            this.dgrBacSi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBacSi_CellDoubleClick);
            this.dgrBacSi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrBacSi_RowPostPaint);
            // 
            // IdPhieu
            // 
            this.IdPhieu.DataPropertyName = "IdPhieu";
            this.IdPhieu.HeaderText = "Mã Phiếu";
            this.IdPhieu.MinimumWidth = 6;
            this.IdPhieu.Name = "IdPhieu";
            this.IdPhieu.ReadOnly = true;
            this.IdPhieu.Width = 125;
            // 
            // TenBS
            // 
            this.TenBS.DataPropertyName = "TenBS";
            this.TenBS.HeaderText = "Tên Bác Sĩ";
            this.TenBS.MinimumWidth = 6;
            this.TenBS.Name = "TenBS";
            this.TenBS.ReadOnly = true;
            this.TenBS.Width = 125;
            // 
            // TenKhoaBS
            // 
            this.TenKhoaBS.DataPropertyName = "TenKhoaBS";
            this.TenKhoaBS.HeaderText = "Thuộc khoa";
            this.TenKhoaBS.MinimumWidth = 6;
            this.TenKhoaBS.Name = "TenKhoaBS";
            this.TenKhoaBS.ReadOnly = true;
            this.TenKhoaBS.Width = 125;
            // 
            // Chuandoan
            // 
            this.Chuandoan.DataPropertyName = "Chuandoan";
            this.Chuandoan.HeaderText = "Chuẩn đoán";
            this.Chuandoan.MinimumWidth = 6;
            this.Chuandoan.Name = "Chuandoan";
            this.Chuandoan.ReadOnly = true;
            this.Chuandoan.Width = 125;
            // 
            // PPPTTT
            // 
            this.PPPTTT.DataPropertyName = "PPPTTT";
            this.PPPTTT.HeaderText = "Phương pháp phẫu thuật";
            this.PPPTTT.MinimumWidth = 6;
            this.PPPTTT.Name = "PPPTTT";
            this.PPPTTT.ReadOnly = true;
            this.PPPTTT.Width = 125;
            // 
            // Bienchung
            // 
            this.Bienchung.DataPropertyName = "Bienchung";
            this.Bienchung.HeaderText = "Biến chứng";
            this.Bienchung.MinimumWidth = 6;
            this.Bienchung.Name = "Bienchung";
            this.Bienchung.ReadOnly = true;
            this.Bienchung.Width = 125;
            // 
            // Tennguoithan
            // 
            this.Tennguoithan.DataPropertyName = "Tennguoithan";
            this.Tennguoithan.HeaderText = "Tên người thân";
            this.Tennguoithan.MinimumWidth = 6;
            this.Tennguoithan.Name = "Tennguoithan";
            this.Tennguoithan.ReadOnly = true;
            this.Tennguoithan.Width = 125;
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "Tuoi";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.ReadOnly = true;
            this.Tuoi.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            this.Gioitinh.Width = 125;
            // 
            // Dantoc
            // 
            this.Dantoc.DataPropertyName = "Dantoc";
            this.Dantoc.HeaderText = "Dân tộc";
            this.Dantoc.MinimumWidth = 6;
            this.Dantoc.Name = "Dantoc";
            this.Dantoc.ReadOnly = true;
            this.Dantoc.Width = 125;
            // 
            // Quoctich
            // 
            this.Quoctich.DataPropertyName = "Quoctich";
            this.Quoctich.HeaderText = "Quốc tịch";
            this.Quoctich.MinimumWidth = 6;
            this.Quoctich.Name = "Quoctich";
            this.Quoctich.ReadOnly = true;
            this.Quoctich.Width = 125;
            // 
            // Nghenghiep
            // 
            this.Nghenghiep.DataPropertyName = "Nghenghiep";
            this.Nghenghiep.HeaderText = "Nghề nghiệp";
            this.Nghenghiep.MinimumWidth = 6;
            this.Nghenghiep.Name = "Nghenghiep";
            this.Nghenghiep.ReadOnly = true;
            this.Nghenghiep.Width = 125;
            // 
            // Noilamviec
            // 
            this.Noilamviec.DataPropertyName = "Noilamviec";
            this.Noilamviec.HeaderText = "Nơi làm việc";
            this.Noilamviec.MinimumWidth = 6;
            this.Noilamviec.Name = "Noilamviec";
            this.Noilamviec.ReadOnly = true;
            this.Noilamviec.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 125;
            // 
            // Danhxung
            // 
            this.Danhxung.DataPropertyName = "Danhxung";
            this.Danhxung.HeaderText = "Đại diện";
            this.Danhxung.MinimumWidth = 6;
            this.Danhxung.Name = "Danhxung";
            this.Danhxung.ReadOnly = true;
            this.Danhxung.Width = 125;
            // 
            // Tenbenhnhan
            // 
            this.Tenbenhnhan.DataPropertyName = "Tenbenhnhan";
            this.Tenbenhnhan.HeaderText = "Họ tên bệnh nhân";
            this.Tenbenhnhan.MinimumWidth = 6;
            this.Tenbenhnhan.Name = "Tenbenhnhan";
            this.Tenbenhnhan.ReadOnly = true;
            this.Tenbenhnhan.Width = 125;
            // 
            // Khoadieutri
            // 
            this.Khoadieutri.DataPropertyName = "Khoadieutri";
            this.Khoadieutri.HeaderText = "Khoa điều trị";
            this.Khoadieutri.MinimumWidth = 6;
            this.Khoadieutri.Name = "Khoadieutri";
            this.Khoadieutri.ReadOnly = true;
            this.Khoadieutri.Width = 125;
            // 
            // Tinhtrangbenh
            // 
            this.Tinhtrangbenh.DataPropertyName = "Tinhtrangbenh";
            this.Tinhtrangbenh.HeaderText = "Tình trạng bệnh";
            this.Tinhtrangbenh.MinimumWidth = 6;
            this.Tinhtrangbenh.Name = "Tinhtrangbenh";
            this.Tinhtrangbenh.ReadOnly = true;
            this.Tinhtrangbenh.Width = 125;
            // 
            // cSua
            // 
            this.cSua.HeaderText = "Sửa";
            this.cSua.MinimumWidth = 6;
            this.cSua.Name = "cSua";
            this.cSua.ReadOnly = true;
            this.cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cSua.Width = 125;
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.MinimumWidth = 6;
            this.cXoa.Name = "cXoa";
            this.cXoa.ReadOnly = true;
            this.cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cXoa.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.BtnXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 98);
            this.panel2.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(579, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 66);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // BtnXuat
            // 
            this.BtnXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXuat.Location = new System.Drawing.Point(738, 15);
            this.BtnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXuat.Name = "BtnXuat";
            this.BtnXuat.Size = new System.Drawing.Size(151, 66);
            this.BtnXuat.TabIndex = 7;
            this.BtnXuat.Text = "Xuất XML";
            this.BtnXuat.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1481, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // GiayCamDoanChapNhanPhauThuat_Chinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1481, 763);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiayCamDoanChapNhanPhauThuat_Chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giấy cam đoan chấp nhận phẫu thuật thủ thuật";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrBacSi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgrBacSi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button BtnXuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPPTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bienchung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennguoithan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noilamviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danhxung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoadieutri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrangbenh;
        private System.Windows.Forms.DataGridViewImageColumn cSua;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
    }
}