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
            Loadcbo();
            //LoadButton();
        }
        public static string IDPhieuChapNhanGayMe;
        private void LoadData()
        {
            msql = "select * from [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] as A , tabMaBS as B, tabMACHUYENKHOA as C, tabQuocGia as D where A.MaBacSi = B.MABACSI and A.QuocTich = D.TenTat and A.Khoa= C.TENTAT";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuCamDoanGayMe"); // Thực thi lấy bảng dữ liệu
            dgrPhieuCamDoanGayMe.AutoGenerateColumns = false; // Hiển thị dững dữ liệu trên colums, cái nào null sẽ ẩn
            dgrPhieuCamDoanGayMe.DataSource = tb;
        }

        private void Loadcbo()
        {
            msql = "SELECT * FROM [tabMACHUYENKHOA]";
            DataTable cbo = comm.GetDataTable(mconnectstring, msql, "tabMACHUYENKHOA");

            //cbo Khoa
            cboKhoa.DataSource = cbo.Copy();
            cboKhoa.DisplayMember = "TENCHUYENKHOA";
            cboKhoa.ValueMember = "TENTAT";
            cboKhoa.CustomAlignment = new string[] { "l", "l" };
            cboKhoa.CustomColumnStyle = new string[] { "t", "t" };


            //cbo điều trị tại Khoa
            cboDieuTriTaiKhoa.DataSource = cbo.Copy();
            cboDieuTriTaiKhoa.DisplayMember = "TENCHUYENKHOA";
            cboDieuTriTaiKhoa.ValueMember = "TENTAT";
            cboDieuTriTaiKhoa.CustomAlignment = new string[] { "l", "l" };
            cboDieuTriTaiKhoa.CustomColumnStyle = new string[] { "t", "t" };
        

            msql = "SELECT * FROM [tabQuocGia]";
            DataTable cbo1 = comm.GetDataTable(mconnectstring, msql, "tabQuocGia");

            //cbo Nơi gửi phiếu lĩnh nội bộ chưa xử lý
            cboQuocTich.DataSource = cbo1.Copy();
            cboQuocTich.DisplayMember = "TenQuoctich";
            cboQuocTich.ValueMember = "TenTat";
            cboQuocTich.CustomAlignment = new string[] { "l", "l" };
            cboQuocTich.CustomColumnStyle = new string[] { "t", "t" };
        

            msql = "SELECT * FROM [dbo].[tabMaBS]";
            DataTable cbo2 = comm.GetDataTable(mconnectstring, msql, "tabMaBS");

            //cbo Nơi gửi phiếu lĩnh nội bộ chưa xử lý
            cboTenBacSi.DataSource = cbo2.Copy();
            cboTenBacSi.DisplayMember = "TENBACSI";
            cboTenBacSi.ValueMember = "MABACSI";
            cboTenBacSi.CustomAlignment = new string[] { "l", "l" };
            cboTenBacSi.CustomColumnStyle = new string[] { "t", "t" };
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
            this.Hide();
            XoaThongtin();
            GiayCamDoanChapNhanGayMeHoiSuc a = new GiayCamDoanChapNhanGayMeHoiSuc();
            a.btnThem.Visible = false;
            a.ShowDialog();
            this.Show();
        }
        private void XoaThongtin()
        {
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
            txtNgheNghiep.Text = "";
            txtNoiLamViec.Text = "";
            txtDiaChi.Text = "";
            txtNguoiDaiDien.Text = "";
            txtTenNguoiDaiDien.Text = "";
            txtTinhTrangBenh.Text = "";
            chkDongYGayMe.Checked = false;
            chkKhongDongY.Checked = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenBN.Text.Trim() != "" & txtTuoiBN.Text.Trim() != "" & txtNguoiDaiDien.Text.Trim() != "" & txtTenNguoiDaiDien.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé! "))
                {
                    msql = "INSERT INTO [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc]([MaBacSi],[Khoa],[Mask],[NoiKhiQuan],[MaskThanhQuan],[NoiPheQuan],[TeTaiCho]," +
                    "[TeKhoangXuongCung],[TeNgoaiMangCung],[TeVung],[DatDongMachXamLan],[DatCatheterTinhMach],[TenBenhNhan],[TuoiBenhNhan],[GioiTinh]," +
                    "[DanToc],[QuocTich],[NgheNghiep],[NoiLamViec],[DiaChi],[NguoiDaiDien],[TenNguoiDaiDien],[DieuTriTaiKhoa],[TinhTrangBenh]," +
                    "[DongYGayMe])" +
                    "VALUES" +
                    "(N'" + cboTenBacSi.SelectedValue + "', N'" + cboKhoa.SelectedValue + "', '" + chkMask.Checked + "', '" + chkNoiKhiQuan.Checked + "', '" + chkMaskThanhQuan.Checked + "'," +
                    " '" + chkNoiPheQuan.Checked + "', '" + chkTeTaiCho.Checked + "','" + chkTeKhoangXuongCung.Checked + "', '" + chkTeNgoaiMangCung.Checked + "'," +
                    " '" + chkTeVung.Checked + "', '" + chkDatDongMachXamLan.Checked + "', '" + chkDatCatheter.Checked + "', N'" + txtTenBN.Text + "', N'" + txtTuoiBN.Text + "'," +
                    " '" + LaygioiTinh() + "', N'" + txtDanToc.Text + "', N'" + cboQuocTich.SelectedValue + "', N'" + txtNgheNghiep.Text + "'," +
                    " N'" + txtNoiLamViec.Text + "',N'" + txtDiaChi.Text + "', N'" + txtNguoiDaiDien.Text + "', N'" + txtTenNguoiDaiDien.Text + "', N'" + cboDieuTriTaiKhoa.SelectedValue + "'," +
                    " N'" + txtTinhTrangBenh.Text + "', '" + LayDongY() + "')";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Đã Lưu thông tin thành công");
                    LoadData();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ");  
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhieu();
        }
        private void XoaPhieu()
        {
            
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi XÓA nhé! "))
                {
                    msql = "DELETE FROM [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] WHERE IDPhieuChapNhanGayMe = '" + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + "'";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Đã Xóa thông tin thành công");
                    LoadData();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaPhieu();
        }

        int LaygioiTinh()
        {
            if(chkNam.Checked == true)
            {
                return 1;
            }
            return 2;
        }
        bool LayDongY()
        {
            if(chkDongYGayMe.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SuaPhieu()
        {
            if (txtTenBN.Text.Trim() != "" & txtTuoiBN.Text.Trim() != "" & txtNguoiDaiDien.Text.Trim() != "" & txtTenNguoiDaiDien.Text.Trim() != "" )
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi SỬA nhé! "))
                {
                    msql = "UPDATE [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] SET [MaBacSi]=N'" + cboTenBacSi.SelectedValue + "',[Khoa]=N'" + cboKhoa.SelectedValue + "',[Mask]=N'" + chkMask.Checked + "',[NoiKhiQuan]=N'" + chkNoiKhiQuan.Checked + "',[MaskThanhQuan]=N'" + chkMaskThanhQuan.Checked + "'," +
                "[NoiPheQuan]=N'" + chkNoiPheQuan.Checked + "',[TeTaiCho]=N'" + chkTeTaiCho.Checked + "',[TeKhoangXuongCung]= N'" + chkTeKhoangXuongCung.Checked + "',[TeNgoaiMangCung]= N'" + chkTeNgoaiMangCung.Checked + "',[TeVung]= N'" + chkTeVung.Checked + "',[DatDongMachXamLan]= N'" + chkDatDongMachXamLan.Checked + "'," +
                "[DatCatheterTinhMach]= N'" + chkDatCatheter.Checked + "',[TenBenhNhan]= N'" + txtTenBN.Text + "',[TuoiBenhNhan]= N'" + txtTuoiBN.Text + "',[GioiTinh]= '" + LaygioiTinh() + "',[DanToc]= N'" + txtDanToc.Text + "',[QuocTich]= N'" + cboQuocTich.SelectedValue + "'," +
                "[NgheNghiep]= N'" + txtNgheNghiep.Text + "',[NoiLamViec]= N'" + txtNoiLamViec.Text + "',[DiaChi]= N'" + txtDiaChi.Text + "',[NguoiDaiDien]= N'" + txtNguoiDaiDien.Text + "',[TenNguoiDaiDien]= N'" + txtTenNguoiDaiDien.Text + "',[DieuTriTaiKhoa]= N'" + cboDieuTriTaiKhoa.SelectedValue + "',[TinhTrangBenh]= N'" + txtTinhTrangBenh.Text + "'," +
                "[DongYGayMe]= N'" + LayDongY()  +
                "' WHERE IDPhieuChapNhanGayMe = '" + dgrPhieuCamDoanGayMe.CurrentRow.Cells["cIDPhieuChapNhanGayMe"].Value.ToString() + "'";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Đã Sửa thông tin thành công");
                    LoadData();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin cần SỬA ");
            cboTenBacSi.Focus();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            PhieuCamDoanChapNhanGMHS model = new PhieuCamDoanChapNhanGMHS();
            model.MaBacSi = cboTenBacSi.SelectedValue.ToString();
            model.MaKhoa = cboKhoa.SelectedValue.ToString();
            model.Mask = chkMask.Checked;
            model.NoiKhiQuan = chkNoiKhiQuan.Checked;
            model.MaskThanhQuan = chkMaskThanhQuan.Checked;
            model.NoiPheQuan = chkNoiPheQuan.Checked;
            model.TeTaiCho = chkTeTaiCho.Checked;
            model.TeKhoangXuongCung = chkTeTaiCho.Checked;
            model.TeNgoaiMangCung = chkTeNgoaiMangCung.Checked;
            model.TeVung = chkTeVung.Checked;
            model.DatDongMachXamLan = chkDatDongMachXamLan.Checked;
            model.DatCatheter = chkDatCatheter.Checked;
            model.TenBenhNhan = txtTenBN.Text;
            model.Tuoi = txtTuoiBN.Text;
            model.DanToc = txtDanToc.Text;
            model.MaQuoctich = cboQuocTich.SelectedValue.ToString();
            model.NgheNghiep = txtNgheNghiep.Text;
            model.NoiLamViec = txtNoiLamViec.Text;
            model.DiaChi = txtDiaChi.Text;
            model.NguoiDaiDien = txtNguoiDaiDien.Text;
            model.TenNguoiDaiDien = txtTenNguoiDaiDien.Text;
            model.MaDieuTritaiKhoa = cboDieuTriTaiKhoa.SelectedValue.ToString();
            model.TinhTrangBenh = txtTinhTrangBenh.Text;
            model.DongYGayMe = LayDongY();
            model.GioiTinh = LaygioiTinh();
            In_PhieuCamDoanChapNhanGayMeHoiSuc rp = new In_PhieuCamDoanChapNhanGayMeHoiSuc(model);
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
            chkMaskThanhQuan.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMaskThanhQuan"].Value.ToString());
            chkNoiPheQuan.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cNoiPheQuan"].Value.ToString());
            chkTeTaiCho.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeTaiCho"].Value.ToString());
            chkTeKhoangXuongCung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeKhoangXuongCung"].Value.ToString());
            chkTeNgoaiMangCung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeNgoaiMangCung"].Value.ToString());
            chkTeVung.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cTeVung"].Value.ToString());
            chkDatDongMachXamLan.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDatDongMachXamLan"].Value.ToString());
            chkDatCatheter.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDatCatheterTinhMach"].Value.ToString());
            // ÉP KIỂU LOAD GIỚI TÍNH, NẾU cột cGioiTinh == 1 thì chk Nam đúng, ngược lại thì Nữ đúng 
            if (Convert.ToInt32(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cGioiTinh"].Value.ToString()) == 1)
            {
                chkNam.Checked = true;
            }
            else
            {
                chkNu.Checked = true;

            }
            chkDongYGayMe.Checked = bool.Parse(dgrPhieuCamDoanGayMe.CurrentRow.Cells["cDongYGayMe"].Value.ToString());
        }
        //Load combobox (lấy dữ liệu hiển thị lên combobox)
        private void LoadCombobox()
        {
            cboTenBacSi.SelectedValue = dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMaBacSi"].Value.ToString();
            cboKhoa.SelectedValue = dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMaKhoa"].Value.ToString();
            cboQuocTich.SelectedValue = dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMaQuocTich"].Value.ToString();
            cboDieuTriTaiKhoa.SelectedValue = dgrPhieuCamDoanGayMe.CurrentRow.Cells["cMaDieuTriTaiKhoa"].Value.ToString();
        }


        private void dgrPhieuCamDoanGayMe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //lấy dữ liệu hiển thị lên checkbox & combobox khi click vào
            LoadCheckbox();
            LoadCombobox();
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

        private void cboTenBacSi_Enter(object sender, EventArgs e)
        {
            cboTenBacSi.DroppedDown = true;
        }

        private void cboKhoa_Enter(object sender, EventArgs e)
        {
            cboKhoa.DroppedDown = true;
        }


        private void txtTenBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboQuocTich);
        }

        private void cboQuocTich_Enter(object sender, EventArgs e)
        {
            cboQuocTich.DroppedDown = true;
        }

        private void txtNgheNghiep_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNgheNghiep_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenNguoiDaiDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboDieuTriTaiKhoa);
        }

        private void cboDieuTriTaiKhoa_Enter(object sender, EventArgs e)
        {
            cboDieuTriTaiKhoa.DroppedDown = true;
        }

        private void txtTinhTrangBenh_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTinhTrangBenh_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTinhTrangBenh_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
