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
    public partial class GiayCamDoanChapNhanGayMeHoiSuc : Form
    {
        private string mconnectstring = Properties.Resources.connectStr;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public GiayCamDoanChapNhanGayMeHoiSuc()
        {
            InitializeComponent();
            LoadData();
        }
        public static string IDPhieuChapNhanGayMe;
        private void LoadData()
        {
            msql = "SELECT * FROM [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuCamDoanGayMe"); // Thực thi lấy bảng dữ liệu
            dgrPhieuCamDoanGayMe.AutoGenerateColumns = false; // Hiển thị dững dữ liệu trên colums, cái nào null sẽ ẩn
            dgrPhieuCamDoanGayMe.DataSource = tb;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaThongtin();
            GiayCamDoanChapNhanGayMeHoiSuc a = new GiayCamDoanChapNhanGayMeHoiSuc();
            a.btnThem.Visible = false;
            a.ShowDialog();
        }
        private void XoaThongtin()
        {
            txtTenBacSi.Text = "";
            txtKhoa.Text = "";
            chkMask.Checked = false;
            chkNoiKhiQuan.Checked = false;
            chkMaskThanhQuan.Checked = false;
            chkNoiPheQuan.Checked = false;
            chkTeTaiCho.Checked = false;
            chkTeKhoangXuongCung.Checked = false;
            chkTeNgoaiMangCung.Checked = false;
            chkTeVung.Checked = false;
            chkDatDongMachXamLan.Checked = false;
            chkDatCatheter.Checked = false;
            txtTenBN.Text = "";
            txtTuoiBN.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
            txtDanToc.Text = "";
            txtQuocTich.Text = "";
            txtNgheNghiep.Text = "";
            txtNoiLamViec.Text = "";
            txtDiaChi.Text = "";
            txtNguoiDaiDien.Text = "";
            txtTenNguoiDaiDien.Text = "";
            txtDieuTriTaiKhoa.Text = "";
            txtTinhTrangBenh.Text = "";
            chkDongYGayMe.Checked = false;
            chkKhongDongY.Checked = false;
            txtGiaDinhTuViet.Text = "";
            txtTenBacSi.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenBacSi.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc]([TenBacSi],[Khoa],[Mask],[NoiKhiQuan],[MaskThanhQuan],[NoiPheQuan],[TeTaiCho]," +
                    "[TeKhoangXuongCung],[TeNgoaiMangCung],[TeVung],[DatDongMachXamLan],[DatCatheterTinhMach],[TenBenhNhan],[TuoiBenhNhan],[GioiTinhNam]," +
                    "[GioiTinhNu],[DanToc],[QuocTich],[NgheNghiep],[NoiLamViec],[DiaChi],[NguoiDaiDien],[TenNguoiDaiDien],[DieuTriTaiKhoa],[TinhTrangBenh]," +
                    "[DongYGayMe],[KhongDongYGayMe],[GiaDinhTuViet])" +
                    "VALUES" +
                    "(N'" + txtTenBacSi.Text + "', N'" + txtKhoa.Text + "', '" + chkMask.Checked + "', '" + chkNoiKhiQuan.Checked + "', '" + chkMaskThanhQuan.Checked + "'," +
                    " '" + chkNoiPheQuan.Checked + "', '" + chkTeTaiCho.Checked + "','" + chkTeKhoangXuongCung.Checked + "', '" + chkTeNgoaiMangCung.Checked + "'," +
                    " '" + chkTeVung.Checked + "', '" + chkDatDongMachXamLan.Checked + "', '" + chkDatCatheter.Checked + "', N'" + txtTenBN.Text + "', N'" + txtTuoiBN.Text + "'," +
                    " '" + chkNam.Checked + "', '" + chkNu.Checked + "', N'" + txtDanToc.Text + "', N'" + txtQuocTich.Text + "', N'" + txtNgheNghiep.Text + "'," +
                    " N'" + txtNoiLamViec.Text + "',N'" + txtDiaChi.Text + "', N'" + txtNguoiDaiDien.Text + "', N'" + txtTenNguoiDaiDien.Text + "', N'" + txtDieuTriTaiKhoa.Text + "'," +
                    " N'" + txtTinhTrangBenh.Text + "', '" + chkDongYGayMe.Checked + "', '" + chkKhongDongY.Checked + "', N'" + txtGiaDinhTuViet.Text + "')";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Đã Lưu thông tin thành công");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtTenBacSi.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhieu();
        }
        private void XoaPhieu()
        {
            msql = "DELETE FROM [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] WHERE IDPhieuChapNhanGayMe = '" + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Đã Xóa thông tin thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaPhieu();
        }

        private void SuaPhieu()
        {
            msql = "UPDATE [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] SET [TenBacSi]=N'" + txtTenBacSi.Text + "',[Khoa]=N'" + txtKhoa.Text + "',[Mask]=N'" + chkMask.Checked + "',[NoiKhiQuan]=N'" + chkNoiKhiQuan.Checked + "',[MaskThanhQuan]=N'" + chkMaskThanhQuan.Checked + "'," +
                "[NoiPheQuan]=N'" + chkNoiPheQuan.Checked + "',[TeTaiCho]=N'" + chkTeTaiCho.Checked + "',[TeKhoangXuongCung]= N'" + chkTeKhoangXuongCung.Checked + "',[TeNgoaiMangCung]= N'" + chkTeNgoaiMangCung.Checked + "',[TeVung]= N'" + chkTeVung.Checked + "',[DatDongMachXamLan]= N'" + chkDatDongMachXamLan.Checked + "'," +
                "[DatCatheterTinhMach]= N'" + chkDatCatheter.Checked + "',[TenBenhNhan]= N'" + txtTenBN.Text + "',[TuoiBenhNhan]= N'" + txtTuoiBN.Text + "',[GioiTinhNam]= N'" + chkNam.Checked + "',[GioiTinhNu]= N'" + chkNu.Checked + "',[DanToc]= N'" + txtDanToc.Text + "',[QuocTich]= N'" + txtQuocTich.Text + "'," +
                "[NgheNghiep]= N'" + txtNgheNghiep.Text + "',[NoiLamViec]= N'" + txtNoiLamViec.Text + "',[DiaChi]= N'" + txtDiaChi.Text + "',[NguoiDaiDien]= N'" + txtNguoiDaiDien.Text + "',[TenNguoiDaiDien]= N'" + txtTenNguoiDaiDien.Text + "',[DieuTriTaiKhoa]= N'" + txtDieuTriTaiKhoa.Text + "',[TinhTrangBenh]= N'" + txtTinhTrangBenh.Text + "'," +
                "[DongYGayMe]= N'" + chkDongYGayMe.Checked + "',[KhongDongYGayMe]= N'" + chkKhongDongY.Checked + "',[GiaDinhTuViet]= N'" + txtGiaDinhTuViet.Text + "' " +
                "WHERE IDPhieuChapNhanGayMe = '" + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Đã Sửa thông tin thành công");
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
             //IDPhieuChapNhanGayMe = dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString();
            In_PhieuCamDoanChapNhanGayMeHoiSuc rp = new In_PhieuCamDoanChapNhanGayMeHoiSuc();
            rp.ShowDialog();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //Load checkbox (lấy dữ liệu hiển thị lên checkbox)
        private void LoadCheckbox()
        {
            chkMask.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMask"].Value.ToString());
            chkNoiKhiQuan.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cNoiKhiQuan"].Value.ToString());
            chkTeTaiCho.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeTaiCho"].Value.ToString());
            chkTeKhoangXuongCung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeKhoangXuongCung"].Value.ToString());
            chkTeNgoaiMangCung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeNgoaiMangCung"].Value.ToString());
            chkTeVung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeVung"].Value.ToString());
            chkDatDongMachXamLan.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDatDongMachXamLan"].Value.ToString());
            chkDatCatheter.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDatCatheterTinhMach"].Value.ToString());
            chkNam.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cGioiTinhNam"].Value.ToString());
            chkNu.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cGioiTinhNu"].Value.ToString());
            chkDongYGayMe.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDongYGayMe"].Value.ToString());
            chkKhongDongY.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cKhongDongYGayMe"].Value.ToString());
        }
        private void dgrPhieuCamDoanGayMe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //lấy dữ liệu hiển thị lên checkbox khi click vào
            LoadCheckbox();
            if (dgrPhieuCamDoanGayMe["cXoa", e.RowIndex] == dgrPhieuCamDoanGayMe.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn Xóa " + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + " này không ?"))
                {
                    XoaPhieu();
                }
            }

            if (dgrPhieuCamDoanGayMe["cSua", e.RowIndex] == dgrPhieuCamDoanGayMe.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn Sửa " + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + " này không ?"))
                {
                    
                    SuaPhieu();
                }
            }
        }

        private void txtTenBacSi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenBacSi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenBacSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKhoa);
        }

        private void txtKhoa_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKhoa_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenBN);
        }

        private void txtTenBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTuoiBN);
        }

        private void txtTuoiBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTuoiBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTuoiBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDanToc);
        }

        private void txtDanToc_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDanToc_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtQuocTich);
        }

        private void txtQuocTich_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtQuocTich_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNgheNghiep);
        }

        private void txtNgheNghiep_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNgheNghiep_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNgheNghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiLamViec);
        }

        private void txtNoiLamViec_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiLamViec_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDiaChi);
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNguoiDaiDien);
        }

        private void txtNguoiDaiDien_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiDaiDien_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiDaiDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenNguoiDaiDien);
        }

        private void txtTenNguoiDaiDien_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenNguoiDaiDien_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenNguoiDaiDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDieuTriTaiKhoa);
        }

        private void txtDieuTriTaiKhoa_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDieuTriTaiKhoa_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDieuTriTaiKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTinhTrangBenh);
        }

        private void txtTinhTrangBenh_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTinhTrangBenh_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTinhTrangBenh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaDinhTuViet);
        }

        private void txtGiaDinhTuViet_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaDinhTuViet_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaDinhTuViet_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
        }
    }
}
