
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

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class GiayCamDoanChapNhanPhauThuatThuThuat : Form
    {
        public static string mconnectstring = "server=.; database=PhauThuat;uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public GiayCamDoanChapNhanPhauThuatThuThuat()
        {
            InitializeComponent();
            LoadData();
            
        }


        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChuanDoan_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e); ev.Qtxt_Enter(sender, e);
        }

        private void txtPhuongPhap_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtBienChung_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHoTenBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDanToc_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTuoi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiLamViec_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void HoTenThanNhan_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txt_Khoa_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChuanDoan_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtPhuongPhap_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtBienChung_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHoTenBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTuoi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDanToc_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiLamViec_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void HoTenThanNhan_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txt_Khoa_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, linktxtChuanDoan);
        }

        private void txtChuanDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhuongPhap);
        }

        private void txtPhuongPhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtBienChung);
        }

        private void txtBienChung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHoTenBN);
        }

        private void txtHoTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTuoi);
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDanToc);
        }

        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiLamViec);
        }

        private void txtNoiLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDiaChi);
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHoTenDanhXung);
        }

        private void HoTenThanNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuu);
        }

        
        private void LoadData()
        {
            // cbo Khoa
            msql = "SELECT * FROM [dbo].[Khoa]";
            DataTable k = comm.GetDataTable(mconnectstring, msql, "khoa");
            cboKhoa.DataSource = k.Copy();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.CustomAlignment = new string[] { "l", "l" };
            cboKhoa.CustomColumnStyle = new string[] { "t", "t" };
            cbo_Khoa.DataSource = k.Copy();
            cbo_Khoa.DisplayMember = "TenKhoa";
            cbo_Khoa.ValueMember = "MaKhoa";
            cbo_Khoa.CustomAlignment = new string[] { "l", "l" };
            cbo_Khoa.CustomColumnStyle = new string[] { "t", "t" };

            // cbo Tên BS
            msql = "SELECT * FROM [dbo].[BacSi]";
            DataTable bs = comm.GetDataTable(mconnectstring, msql, "BacSi");
            cboHoTenBS.DataSource = bs.Copy();
            cboHoTenBS.DisplayMember = "TenBS";
            cboHoTenBS.ValueMember = "MaBS";
            cboHoTenBS.CustomAlignment = new string[] { "l", "l" };
            cboHoTenBS.CustomColumnStyle = new string[] { "t", "t" };
            // cbo Chuẩn Đoán
            msql = "SELECT * FROM [dbo].[ChuanDoan]";
            DataTable cd = comm.GetDataTable(mconnectstring, msql, "ChuanDoan");
            cboChuanDoan.DataSource = cd.Copy();
            cboChuanDoan.DisplayMember = "TenChuanDoan";
            cboChuanDoan.ValueMember = "MaChuanDoan";
            cboChuanDoan.CustomAlignment = new string[] { "l", "l" };
            cboChuanDoan.CustomColumnStyle = new string[] { "t", "t" };
            cboChuanDoan.sf = setfocusTensearch;
            // cbo Quốc tịch
            msql = "SELECT * FROM [dbo].[QuocTich]";
            DataTable qt = comm.GetDataTable(mconnectstring, msql, "ChuanDoan");
            cboQuocTich.DataSource = qt.Copy();
            cboQuocTich.DisplayMember = "TenQuocTich";
            cboQuocTich.ValueMember = "MaQuocTich";
            cboQuocTich.CustomAlignment = new string[] { "l", "l" };
            cboQuocTich.CustomColumnStyle = new string[] { "t", "t" };
            //cbo Danh Xưng GD
            msql = "SELECT * FROM [dbo].[DanhXungGD]";
            DataTable dx = comm.GetDataTable(mconnectstring, msql, "DanhXungGD");
            cboDanhXungGD.DataSource = dx.Copy();
            cboDanhXungGD.DisplayMember = "TenDanhXung";
            cboDanhXungGD.ValueMember = "MaDanhXung";
            cboDanhXungGD.CustomAlignment = new string[] { "l", "l" };
            cboDanhXungGD.CustomColumnStyle = new string[] { "t", "t" };
            // cbo Trạng Thái
            msql = "SELECT * FROM [dbo].[TrangThaiBN]";
            DataTable tt = comm.GetDataTable(mconnectstring, msql, "TrangThaiBN");
            cboTrangThai.DataSource = tt.Copy();
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "MaTrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };
            // cbo Nghề Nghiệp
            msql = "SELECT * FROM [dbo].[NgheNghiep]";
            DataTable nn = comm.GetDataTable(mconnectstring, msql, "NgheNghiep");
            cboNgheNghiep.DataSource = nn.Copy();
            cboNgheNghiep.DisplayMember = "TenNgheNghiep";
            cboNgheNghiep.ValueMember = "MaNgheNghiep";
            cboNgheNghiep.CustomAlignment = new string[] { "l", "l" };
            cboNgheNghiep.CustomColumnStyle = new string[] { "t", "t" };
        }
        private int setfocusTensearch()
        {
            linktxtChuanDoan.Focus();
            return 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void LoadLuuBacSiThucHien()
        {
            //msql = "SELECT * FROM dbo.BacSi INNER JOIN dbo.BacSiThucHien ON dbo.BacSi.MaBS = dbo.BacSiThucHien.HoTenBS INNER JOINdbo.ChuanDoan ON dbo.BacSiThucHien.ChuanDoan = dbo.ChuanDoan.MaChuanDoan INNER JOINdbo.Khoa ON dbo.BacSiThucHien.TenKhoa = dbo.Khoa.MaKhoa";
            msql = "INSERT INTO [dbo].[BacSiThucHien]([HoTenBS],[TenKhoa],[ChuanDoan],[PhuongPhap],[BienChung])" +
                    "VALUES(N'" + cboHoTenBS.SelectedValue + "',N'" + cboKhoa.SelectedValue + "',N'" + cboChuanDoan.SelectedValue + "',N'" + txtPhuongPhap.Text + "',N'" + txtBienChung.Text + "')";
            comm.RunSQL(mconnectstring, msql);

        }

        private void LoadLuuBenhNhan()
        {
            msql = "INSERT INTO [dbo].[BenhNhanKhamBenh]([TenBN],[Tuoi],[DanToc],[QuocTich],[TenNgheNghiep],[NoiLamViec],[DiaChi],[TenDanhXung],[HoTenDanhXung],[KhoaDieuTri],[TrangThai],[GioiTinh_Nam],[GioiTinh_Nu],[DongYPhauThuat],[KhongDongYPhauThuat])" +
                "VALUES(N'" + txtHoTenBN.Text + "',N'" + txtTuoi.Text + "',N'" + txtDanToc.Text + "',N'" + cboQuocTich.SelectedValue + "',N'" + cboNgheNghiep.SelectedValue + "',N'" + txtNoiLamViec.Text + "',N'" + txtDiaChi.Text + "',N'" + cboDanhXungGD.SelectedValue + "',N'" + txtHoTenDanhXung.Text + "',N'" + cbo_Khoa.SelectedValue + "',N'" + cboTrangThai.SelectedValue + "',N'" + chkNam.Checked + "',N'" + chkNu.Checked + "',N'" + chkDongY.Checked + "',N'" + chkKhongDongY.Checked + "')";
            comm.RunSQL(mconnectstring, msql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (linktxtChuanDoan.Text.Trim() != "" && txtPhuongPhap.Text.Trim() != "" && txtBienChung.Text.Trim() != "" )
            {
                LoadLuuBacSiThucHien();
                LoadLuuBenhNhan();
                ev.QFrmThongBao("Đã nhập thành công !!");
                //msql = "INSERT INTO [dbo].[BacSiThucHien]([HoTenBS],[TenKhoa],[ChuanDoan],[PhuongPhap],[BienChung])" +
                //    "VALUES(N'" + cboHoTenBS.SelectedValue + "',N'" + cboKhoa.SelectedValue + "',N'" + cboChuanDoan.SelectedValue + "',N'" + txtPhuongPhap.Text + "',N'" + txtBienChung.Text + "')";
                //comm.RunSQL(mconnectstring, msql);
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }    
            
        }


    }
}
