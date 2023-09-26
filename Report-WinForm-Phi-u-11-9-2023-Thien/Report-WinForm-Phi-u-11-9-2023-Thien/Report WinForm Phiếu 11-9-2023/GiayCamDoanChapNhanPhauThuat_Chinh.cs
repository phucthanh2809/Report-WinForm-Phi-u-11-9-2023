using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using Report_WinForm_Phiếu_11_9_2023.Model;

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class GiayCamDoanChapNhanPhauThuat_Chinh : DevExpress.XtraEditors.XtraForm
    {
        public static string mconnectstring = Properties.Resources.connectStr;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public GiayCamDoanChapNhanPhauThuat_Chinh()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            List<PhieuCamDoanChapNhanPTTT> listphieu = new List<PhieuCamDoanChapNhanPTTT>();
            //dgr Bac Si Thực Hiện
            msql = "SELECT * FROM [GiayCamDoanChapNhanPhauThuatThuThuat]";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "GiayCamDoan");
            foreach (DataRow row in ncc.Rows)
            {
                PhieuCamDoanChapNhanPTTT model = new PhieuCamDoanChapNhanPTTT();
                model.IdPhieu = Int32.Parse(row["PhieuID"].ToString());
                model.MaBS = row["BS"].ToString();
                model.MaKhoa = row["Khoa"].ToString();
                model.MaChuanDoan = row["ChuanDoan"].ToString();
                model.MaPPTT = row["PPPT"].ToString();
                model.Bienchung = row["BienChung"].ToString();
                model.Tennguoithan = row["TenNguoiThan"].ToString();
                model.Tuoi = Int32.Parse(row["Tuoi"].ToString());
                model.Gioitinhso = Int32.Parse(row["GioiTinh"].ToString());
                model.Dantoc = row["DanToc"].ToString();
                model.MaQuocTich = row["QuocTich"].ToString();
                model.Nghenghiep = row["NgheNghiep"].ToString();
                model.Noilamviec = row["NoiLamViec"].ToString();
                model.Diachi = row["DiaChi"].ToString();
                model.Danhxung = row["DaiDien"].ToString();
                model.Tenbenhnhan = row["HoTenBN"].ToString();
                model.MaKhoaDieuTri = row["KhoaDieuTri"].ToString();
                model.Tinhtrangbenh = row["TinhTrangBenh"].ToString();
                listphieu.Add(model);
            }
            
            dgrBacSi.AutoGenerateColumns = false;
            dgrBacSi.DataSource = listphieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiayCamDoanChapNhanGayMeHoiSuc phieu = new GiayCamDoanChapNhanGayMeHoiSuc();
            this.Hide();
            phieu.ShowDialog();
            this.Show();
            LoadData();
        }

        private void dgrBacSi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrBacSi);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            GiayCamDoanChapNhanPhauThuatThuThuat phieu = new GiayCamDoanChapNhanPhauThuatThuThuat(0);
            this.Hide();
            phieu.ShowDialog();
            this.Show();
            LoadData();
        }

        private void XoaPhieu(int iid)
        {
            try
            {
                msql = $"execute del_GiayCamDoanPTTT '{iid}'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Đã Xóa thông tin thành công");
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Lỗi cơ sở dữ liệu, vui lòng kiểm tra và thử lại!");
            }
            LoadData();
        }

        private void SuaPhieu(int iid)
        {
            
            GiayCamDoanChapNhanPhauThuatThuThuat phieu = new GiayCamDoanChapNhanPhauThuatThuThuat(iid);
            this.Hide();
            phieu.ShowDialog();
            this.Show();
            LoadData();
        }
        private void dgrBacSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = (int)dgrBacSi.CurrentRow.Cells["IdPhieu"].Value;
            //lấy dữ liệu hiển thị lên checkbox khi click vào
            if (dgrBacSi["cXoa", e.RowIndex] == dgrBacSi.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn Xóa phiếu này không ?"))
                {
                    XoaPhieu(iid);
                }
            }

            if (dgrBacSi["cSua", e.RowIndex] == dgrBacSi.CurrentCell)
            {
                SuaPhieu(iid);
            }
        }

        private void dgrBacSi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = (int)dgrBacSi.CurrentRow.Cells["IdPhieu"].Value;
            SuaPhieu(iid);
        }
    }
}

