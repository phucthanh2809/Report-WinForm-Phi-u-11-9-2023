using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class PhieuKhamTienMe : Form
    {
        private string mconnectstring = "server=.;database = ITTT; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public PhieuKhamTienMe()
        {
            InitializeComponent();
            LoadCbo();
            
        }
        public static string a;
        public static string b;
        private void LoadCbo()
        {
            //cboChuẩn đoán
            msql = "SELECT * FROM [dbo].[tabCDSPK]";
            DataTable ChuanDoan = comm.GetDataTable(mconnectstring, msql, "tabCDSPK");
            cboChuanDoan.DataSource = ChuanDoan.Copy();
            cboChuanDoan.DisplayMember = "TenChanDoan";
            cboChuanDoan.ValueMember = "MaChanDoan";
            cboChuanDoan.CustomAlignment = new string[] { "l", "l" };
            cboChuanDoan.CustomColumnStyle = new string[] { "t", "t" };
            //cboPPPT
            msql = "SELECT * FROM [dbo].[tabPhuongPhapPhauThuat]";
            DataTable PhuongPhaPhauThuat = comm.GetDataTable(mconnectstring, msql, "tabPhuongPhapPhauThuat");
            cboPPPT.DataSource = PhuongPhaPhauThuat.Copy();
            cboPPPT.DisplayMember = "TenPhuongPhapPhauThuat";
            cboPPPT.ValueMember = "TenTat";
            cboPPPT.CustomAlignment = new string[] { "l", "l" };
            cboPPPT.CustomColumnStyle = new string[] { "t", "t" };
            //cboKhoa
            msql = "SELECT * FROM [dbo].[tabMACHUYENKHOA]";
            DataTable Khoa = comm.GetDataTable(mconnectstring, msql, "tabMACHUYENKHOA");
            cboKhoa.DataSource = Khoa.Copy();
            cboKhoa.DisplayMember = "TENCHUYENKHOA";
            cboKhoa.ValueMember = "TENTAT";
            cboKhoa.CustomAlignment = new string[] { "l", "l" };
            cboKhoa.CustomColumnStyle = new string[] { "t", "t" };
            //cboGioiTinh
            msql = "SELECT * FROM [dbo].[tabGioiTinh]";
            DataTable GioiTinh = comm.GetDataTable(mconnectstring, msql, "tabGioiTinh");
            cboGioiTinh.DataSource = GioiTinh.Copy();
            cboGioiTinh.DisplayMember = "TenGioiTinh";
            cboGioiTinh.ValueMember = "IDGioiTinh";
            cboGioiTinh.CustomAlignment = new string[] { "l", "l" };
            cboGioiTinh.CustomColumnStyle = new string[] { "t", "t" };
            //cboBenhDangDieuTri
            msql = "SELECT * FROM [dbo].[tabMABENH]";
            DataTable BenhDangDieuTri = comm.GetDataTable(mconnectstring, msql, "tabMABENH");
            cboBenhDangDieuTri.DataSource = BenhDangDieuTri.Copy();
            cboBenhDangDieuTri.DisplayMember = "TenBenh";
            cboBenhDangDieuTri.ValueMember = "MaBenh";
            cboBenhDangDieuTri.CustomAlignment = new string[] { "l", "l" };
            cboBenhDangDieuTri.CustomColumnStyle = new string[] { "t", "t" };
            ////cboThuocDangSuDung
            //msql = "SELECT * FROM [dbo].[tabDanhMucThuoc]";
            //DataTable Thuoc = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            //cboThuocDangSuDung.DataSource = Thuoc.Copy();
            //cboThuocDangSuDung.DisplayMember = "TenThuoc";
            //cboThuocDangSuDung.ValueMember = "MaThuoc";
            //cboThuocDangSuDung.CustomAlignment = new string[] { "l", "l" };
            //cboThuocDangSuDung.CustomColumnStyle = new string[] { "t", "t" };
            //cboXNDeNghi
            msql = "SELECT * FROM [dbo].[XN_tabKieuXN]";
            DataTable XN = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            cboXNDeNghi.DataSource = XN.Copy();
            cboXNDeNghi.DisplayMember = "TypeName";
            cboXNDeNghi.ValueMember = "Type";
            cboXNDeNghi.CustomAlignment = new string[] { "l", "l" };
            cboXNDeNghi.CustomColumnStyle = new string[] { "t", "t" };
            //cboDichTruyen
            msql = "SELECT * FROM [dbo].[tabDichTruyen]";
            DataTable DichTruyen = comm.GetDataTable(mconnectstring, msql, "tabDichTruyen");
            cboDichTruyen.DataSource = DichTruyen.Copy();
            cboDichTruyen.DisplayMember = "TenDichTruyen";
            cboDichTruyen.ValueMember = "MaDichTruyen";
            cboDichTruyen.CustomAlignment = new string[] { "l", "l" };
            cboDichTruyen.CustomColumnStyle = new string[] { "t", "t" };
            //cboThuocTienMe
            msql = "SELECT * FROM [dbo].[tabDanhMucThuoc]";
            DataTable Thuoc = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            cboThuocTienMe.DataSource = Thuoc.Copy();
            cboThuocTienMe.DisplayMember = "TenThuoc";
            cboThuocTienMe.ValueMember = "MaThuoc";
            cboThuocTienMe.CustomAlignment = new string[] { "l", "l" };
            cboThuocTienMe.CustomColumnStyle = new string[] { "t", "t" };
            //cboBSKhamTienMe
            msql = "SELECT * FROM [dbo].[tabMaBS]";
            DataTable BS = comm.GetDataTable(mconnectstring, msql, "tabMaBS");
            cboBSKhamTienMe.DataSource = BS.Copy();
            cboBSKhamTienMe.DisplayMember = "TENBACSI";
            cboBSKhamTienMe.ValueMember = "MABACSI";
            cboBSKhamTienMe.CustomAlignment = new string[] { "l", "l" };
            cboBSKhamTienMe.CustomColumnStyle = new string[] { "t", "t" };
            //cboNhomMau 
            msql = "SELECT * FROM [dbo].[tabNhomMau]";
            DataTable Mau = comm.GetDataTable(mconnectstring, msql, "tabNhomMau");
            cboNhomMau.DataSource = Mau.Copy();
            cboNhomMau.DisplayMember = "TenNhomMau";
            cboNhomMau.ValueMember = "MaNhomMau";
            cboNhomMau.CustomAlignment = new string[] { "l", "l" };
            cboNhomMau.CustomColumnStyle = new string[] { "t", "t" };

        }
        private void ResetForm()
        {
            // Clear textboxes
            txtHoTen.Text = string.Empty;
            txtSoVaoVien.Text = string.Empty;
            txtSoHoSo.Text = string.Empty;
            txtYLenhKhac.Text = string.Empty;
            txtHCL.Text = string.Empty;
            txtKhac.Text = string.Empty;
            txtXNCanLuuY.Text = string.Empty;
            txtMach.Text = string.Empty;
            txtHA.Text = string.Empty;
            txtT.Text = string.Empty;
            txtCao.Text = string.Empty;
            txtCanNang.Text = string.Empty;
            txtTimMachBatThuong.Text = string.Empty;
            txtXNCanLuuY.Text = string.Empty;
            txtGiaDinh.Text = string.Empty;
            txtSanKhoa.Text = string.Empty;
            txtDiUng.Text = string.Empty;
            txtTaiBien.Text = string.Empty;

            // Uncheck checkboxes
            chkDiUng.Checked = false;
            chkHenSuyen.Checked = false;
            chkBenhLyDongCamMau.Checked = false;
            chkPhauThuat.Checked = false;
            chkMe.Checked = false;
            chkTe.Checked = false;
            chkTaiBien.Checked = false;
            chkMiengHaNho.Checked = false;
            chkCamLem.Checked = false;
            chkCoNgan.Checked = false;
            chkNguaCoKho.Checked = false;
            chkGayXuongHamNiengHam.Checked = false;
            chkRangLungLay.Checked = false;
            chkMallaI.Checked = false;
            chkMallaII.Checked = false;
            chkMallaIII.Checked = false;
            chkMallaIV.Checked = false;
            chkTimMachBT.Checked = false;
            chkTimMachBatThuong.Checked = false;
            chkHoHapBT.Checked = false;
            chkThanKinhBT.Checked = false;
            chkNoiTietBT.Checked = false;
            chkCoXuongKhopBT.Checked = false;
            chkCapCuu.Checked = false;
            chkBanKhan.Checked = false;
            chkASAI.Checked = false;
            chkASAII.Checked = false;
            chkASAIII.Checked = false;
            chkASAIV.Checked = false;
            chkKhaNangTruyenMau.Checked = false;
            chkMeNKQ.Checked = false;
            chkMeNMC.Checked = false;
            chkDatCVP.Checked = false; 
            chkMeNoiPQ.Checked = false;
            chkTeXuongCung.Checked = false;
            chkDoHADMXL.Checked = false;
            chkMeMaskTQ.Checked = false;
            chkTeTKVung.Checked = false;
            chkCEC.Checked = false;
            chkMeMask.Checked = false;
            chkTeTaiCho.Checked = false;
            chkTMHH.Checked = false;
            chkTeTM.Checked = false;
            chkNSHH.Checked = false;
            chkBis.Checked = false;
            chkTienMe.Checked = false;
            chkSieuAmTQ.Checked = false;
            chkDienNao.Checked = false;
            chkChuongTrinh.Checked = false;


            // Reset NumericUpDown control to its minimum value (if applicable)
            nmNhinSuaTu.Value = nmNhinSuaTu.Minimum;
            nmUongNuocDuongDen.Value = nmUongNuocDuongDen.Minimum;

            // You can reset other controls as needed
        }

        //Nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé! ^-^"))
                {
                    if (dtNgaySinh.Value < dtNgayNhapVien.Value)
                    {
                        ThemThongTinBN();
                        ThemThongTinKhamLamSang();
                        ThemThongTinKhamTienMe();
                        ev.QFrmThongBao("Đã lưu thành công");
                        ResetForm();
                    }
                    else
                        ev.QFrmThongBaoError("Vui lòng chọn lại Ngày sinh hoặc Ngày nhập viện. Ngày sinh không thể lớn hơn Ngày nhập viện và ngược lại!");
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ^-^");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập đầy đủ thông tin");
            txtHoTen.Focus();

        }
        //Lưu thông tin BN
        private void ThemThongTinBN()
        {
            msql = "INSERT INTO [dbo].[tabThongTinBenhNhan]" +
                "([SoVaoVien],[HoTen],[NgaySinh],[NgayNhapVien],[Khoa],[MaHoSo],[GioiTinh],[ChuanDoan],[PhuongPhapPhauThuat],[GiaDinh],[SanKhoa],[DiUng],[TenDiUng],[HenSuyen],[BenhLyDongCamMau],[PhauThuat],[Me],[Te],[TaiBien],[TenTaiBien],[BenhDangDieuTri],[ThuocDangSuDung])" +
                "VALUES (N'" + txtSoVaoVien.Text + "',N'" + txtHoTen.Text + "','" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayNhapVien.Value).ToString("yyyy-MM-dd") + "',N'" + cboKhoa.SelectedValue + "',N'" + txtSoHoSo.Text + "',N'" + cboGioiTinh.SelectedValue + "',N'" + cboChuanDoan.SelectedValue + "',N'" + cboPPPT.SelectedValue + "',N'" + txtGiaDinh.Text + "',N'" + txtSanKhoa.Text + "','" + chkDiUng.Checked + "',N'" + txtDiUng.Text + "','" + chkHenSuyen.Checked + "','" + chkBenhLyDongCamMau.Checked + "','" + chkPhauThuat.Checked + "','" + chkMe.Checked + "','" + chkTe.Checked + "','" + chkTaiBien.Checked + "',N'" + txtTaiBien.Text + "',N'" + cboBenhDangDieuTri.SelectedValue + "',N'" + txtThuocDangSuDung.Text + "')";
            comm.RunSQL(mconnectstring, msql);
        }

        //Lưu thông tin Khám Lâm Sàng
        private void ThemThongTinKhamLamSang()
        {
            msql = "INSERT INTO [dbo].[tabKhamLamSang]" +
                "([SoVaoVien],[Mach],[HA],[T],[Cao],[CanNang],[DTMiengHaNho],[DTCamLem],[DTCoNgan],[DTNguaCoKho],[DTGayXuongHamNiengHam],[DTRangLungLay],[MallaI],[MallaII],[MallaIII],[MallaIV],[TimMachBT],[TimMachBatThuong],[TimMachBatThuongLiDo],[HoHapBT],[ThanKinhBT],[NoiTietBT],[CoXuongKhopBT],[XNCanLuuY],[XNDeNghi],[ASAI],[ASAII],[ASAIII],[ASAIV],[ChuongTrinh],[CapCuu],[BanKhan])" +
                "VALUES(N'" + txtSoVaoVien.Text + "',N'" + txtMach.Text + "','" + txtHA.Text + "','" + txtT.Text + "','" + txtCao.Text + "','" + txtCanNang.Text + "','"+chkMiengHaNho.Checked+ "','" + chkCamLem.Checked + "','" + chkCoNgan.Checked + "','" + chkNguaCoKho.Checked + "','" + chkGayXuongHamNiengHam.Checked + "','" + chkRangLungLay.Checked + "','" + chkMallaI.Checked + "','" + chkMallaII.Checked + "','" + chkMallaIII.Checked + "','" + chkMallaIV.Checked + "','" + chkTimMachBT.Checked + "','" + chkTimMachBatThuong.Checked + "',N'" + txtTimMachBatThuong.Text + "','" + chkHoHapBT.Checked + "','" + chkThanKinhBT.Checked + "','" + chkNoiTietBT.Checked + "','" + chkCoXuongKhopBT.Checked + "',N'" + txtXNCanLuuY.Text + "',N'" + cboXNDeNghi.SelectedValue + "','" + chkASAI.Checked + "','" + chkASAII.Checked + "','" + chkASAIII.Checked + "','" + chkASAIV.Checked + "','" + chkChuongTrinh.Checked + "','" + chkCapCuu.Checked + "','" + chkBanKhan.Checked + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        //Thêm thông tin khám tiền mê
        private void ThemThongTinKhamTienMe()
        {
            msql = "INSERT INTO [dbo].[tabPhieuKhamTienMe]" +
                   "([SoVaoVien],[PPVCDNMeNKQ],[PPVCDNMeNMC],[PPVCDNDatCVP],[PPVCDNMeNoiPQ],[PPVCDNTeXuongCung],[PPVCDNDoHADMXL],[PPVCDNMeMaskTQ],[PPVCDNTeTKVung],[PPVCDNCEC],[PPVCDNMeMask],[PPVCDNTeTaiCho],[PPVCDNTMHH],[PPVCDNTeTM],[PPVCDNNSHH],[PPVCDNBisEntropy],[PPVCDNTienMe],[PPVCDNSieuAmTQ],[PPVCDNDienNao],[DichTruyen],[ThuocTienMe],[YLenhKhac],[NhinSuaTu],[UongNuocDuongDen],[KhaNangTruyenMau],[NhomMau],[HCL],[Khac],[NgayThangNam],[BSKhamTienMe])" +
                   " VALUES('" + txtSoVaoVien.Text + "','" + chkMeNKQ.Checked + "','" + chkMeNMC.Checked + "','" + chkDatCVP.Checked + "','" + chkMeNoiPQ.Checked + "','" + chkTeXuongCung.Checked + "','" + chkDoHADMXL.Checked + "','" + chkMeMaskTQ.Checked + "','" + chkTeTKVung.Checked + "','" + chkCEC.Checked + "','" + chkMeMask.Checked + "','" + chkTeTaiCho.Checked + "','" + chkTMHH.Checked + "','" + chkTeTM.Checked + "','" + chkNSHH.Checked + "','" + chkBis.Checked + "','" + chkTienMe.Checked + "','" + chkSieuAmTQ.Checked + "','" + chkDienNao.Checked + "',N'" + cboDichTruyen.SelectedValue + "',N'" + cboThuocTienMe.SelectedValue + "',N'" + txtYLenhKhac.Text + "',N'" + nmNhinSuaTu.Value + "',N'" + nmUongNuocDuongDen.Value + "','" + chkKhaNangTruyenMau.Checked + "',N'" + cboNhomMau.SelectedValue + "',N'" + txtHCL.Text + "',N'" + txtKhac.Text + "','" + Convert.ToDateTime(dtChonNgay.Value).ToString("yyyy-MM-dd") + "',N'" + cboBSKhamTienMe.SelectedValue + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        //Nút xóa 
        
        //Xóa phiếu khám tiền mê
        private void XoaPhieuKhamTienMe()
        {
            msql = "DELETE FROM [dbo].[tabPhieuKhamTienMe] WHERE SoVaoVien = '" + txtSoVaoVien.Text + "' ";
            comm.RunSQL(mconnectstring, msql);
        }
        //Xóa phiếu khám lâm sàng
        private void XoaPhieuKhamLamSang()
        {
            msql = "DELETE FROM [dbo].[tabKhamLamSang] WHERE SoVaoVien = '" + txtSoVaoVien.Text + "' ";
            comm.RunSQL(mconnectstring, msql);
        }
        //Nút sửa
        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi sửa nhé! ^-^"))
            {
                SuaThongTinBN();
                SuaThongTinKhamLamSang();
                SuaThongTinKhamTienMe();
                ev.QFrmThongBao("Đã sửa phiếu thành công");
                btnThem.Visible = true;
            }
        }
        //Sửa Thông tin BN 
        private void SuaThongTinBN()
        {
            msql = "UPDATE[dbo].[tabThongTinBenhNhan]" +
                   "SET [HoTen] = '" + txtHoTen.Text + "',[NgaySinh] = '" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "' ,[NgayNhapVien] = '" + Convert.ToDateTime(dtNgayNhapVien.Value).ToString("yyyy-MM-dd") + "',[Khoa] = N'" + cboKhoa.SelectedValue + "',[MaHoSo] = N'" + txtSoHoSo.Text + "',[GioiTinh] = N'" + cboGioiTinh.SelectedValue + "',[ChuanDoan] = N'" + cboChuanDoan.SelectedValue + "',[PhuongPhapPhauThuat] = N'" + cboPPPT.SelectedValue + "',[GiaDinh] = N'" + txtGiaDinh.Text + "',[SanKhoa] = N'" + txtSanKhoa.Text + "',[DiUng] = '" + chkDiUng.Checked + "',[TenDiUng] = N'" + txtDiUng.Text + "',[HenSuyen] = '" + chkHenSuyen.Checked + "'" +
                   ",[BenhLyDongCamMau] = '" + chkBenhLyDongCamMau.Checked + "',[PhauThuat] = '" + chkPhauThuat.Checked + "',[Me] = '" + chkMe.Checked + "',[Te] = '" + chkTe.Checked + "',[TaiBien] = '" + chkTaiBien.Checked + "',[TenTaiBien] = N'" + txtTaiBien.Text + "',[BenhDangDieuTri] = N'" + cboBenhDangDieuTri.SelectedValue + "',[ThuocDangSuDung] = N'" + txtThuocDangSuDung.Text + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Sửa Khám Lâm Sàng 
        private void SuaThongTinKhamLamSang()
        {
            msql = "UPDATE [dbo].[tabKhamLamSang]" +
                   "SET [Mach] = N'" + txtMach.Text + "',[HA] = '" + txtHA.Text + "',[T] = '" + txtT.Text + "',[Cao] = '" + txtCao.Text + "',[CanNang] = '" + txtCanNang.Text + "',[DTMiengHaNho] = '"+chkMiengHaNho.Checked+ "',[DTCamLem] = '" + chkCamLem.Checked + "',[DTCoNgan] = '" + chkCoNgan.Checked + "',[DTNguaCoKho] = '" + chkNguaCoKho.Checked + "',[DTGayXuongHamNiengHam] = '" + chkGayXuongHamNiengHam.Checked + "',[DTRangLungLay] = '" + chkRangLungLay.Checked + "',[MallaI] = '" + chkMallaI.Checked + "',[MallaII] = '" + chkMallaII.Checked + "',[MallaIII] = '" + chkMallaIII.Checked + "'" +
                   ",[MallaIV] = '" + chkMallaIV.Checked + "',[TimMachBT] = '" + chkTimMachBT.Checked + "',[TimMachBatThuong] = '" + chkTimMachBatThuong.Checked + "',[TimMachBatThuongLiDo] = N'" + txtTimMachBatThuong.Text + "',[HoHapBT] = '" + chkHoHapBT.Checked + "',[ThanKinhBT] = '" + chkThanKinhBT.Checked + "',[NoiTietBT] = '" + chkNoiTietBT.Checked + "',[CoXuongKhopBT] = '" + chkCoXuongKhopBT.Checked + "',[XNCanLuuY] = N'" + txtXNCanLuuY.Text + "',[XNDeNghi] = N'" + cboXNDeNghi.SelectedValue + "',[ASAI] = '" + chkASAI.Checked + "',[ASAII] = '" + chkASAII.Checked + "'" +
                   ",[ASAIII] = '" + chkASAIII.Checked + "',[ASAIV] = '" + chkASAIV.Checked + "',[ChuongTrinh] = '" + chkChuongTrinh.Checked + "',[CapCuu] = '" + chkCapCuu.Checked + "',[BanKhan] = '" + chkBanKhan.Checked + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Sửa Thông tin Khám Tiền Mê
        private void SuaThongTinKhamTienMe()
        {
            msql = "UPDATE [dbo].[tabPhieuKhamTienMe]" +
                   "SET [PPVCDNMeNKQ] = '" + chkMeNKQ.Checked + "',[PPVCDNMeNMC] = '" + chkMeNMC.Checked + "',[PPVCDNDatCVP] = '" + chkDatCVP.Checked + "',[PPVCDNMeNoiPQ] = '" + chkMeNoiPQ.Checked + "',[PPVCDNTeXuongCung] = '" + chkTeXuongCung.Checked + "',[PPVCDNDoHADMXL] = '" + chkDoHADMXL.Checked + "',[PPVCDNMeMaskTQ] = '" + chkMeMaskTQ.Checked + "',[PPVCDNTeTKVung] = '" + chkTeTKVung.Checked + "',[PPVCDNCEC] = '" + chkCEC.Checked + "',[PPVCDNMeMask] = '" + chkMeMask.Checked + "',[PPVCDNTeTaiCho] = '" + chkTeTaiCho.Checked + "',[PPVCDNTMHH] = '" + chkTMHH.Checked + "'" +
                   ",[PPVCDNTeTM] = '" + chkTeTM.Checked + "',[PPVCDNNSHH] = '" + chkNSHH.Checked + "',[PPVCDNBisEntropy] = '" + chkBis.Checked + "',[PPVCDNTienMe] = '" + chkTienMe.Checked + "',[PPVCDNSieuAmTQ] = '" + chkSieuAmTQ.Checked + "',[PPVCDNDienNao] = '" + chkDienNao.Checked + "',[DichTruyen] = N'" + cboDichTruyen.SelectedValue + "', [ThuocTienMe] = N'" + cboThuocTienMe.SelectedValue + "', [YLenhKhac] = N'" + txtYLenhKhac.Text + "', [NhinSuaTu] = N'" + nmNhinSuaTu.Value + "', [UongNuocDuongDen] = N'" + nmUongNuocDuongDen.Value + "', [KhaNangTruyenMau] = '" + chkKhaNangTruyenMau.Checked + "'" +
                   ",[NhomMau] = N'" + cboNhomMau.SelectedValue + "', [HCL] = N'" + txtHCL.Text + "', [Khac] = N'" + txtKhac.Text + "', [NgayThangNam] = '" + Convert.ToDateTime(dtChonNgay.Value).ToString("yyyy-MM-dd") + "',[BSKhamTienMe] = N'" + cboBSKhamTienMe.SelectedValue + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Ghi XML
        //private void btnGhiXML_Click(object sender, EventArgs e)
        //{
        //    msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabKhamLamSang] as B,[dbo].[tabPhieuKhamTienMe] as C,[dbo].[tabMaBS] as BS,[dbo].[tabMACHUYENKHOA] AS KHOA,[dbo].[tabCDSPK] AS CHUANDOAN, [dbo].[tabPhuongPhapPhauThuat] AS PHAUTHUAT, [dbo].[tabMABENH] AS BENH, [dbo].[tabDanhMucThuoc] AS THUOC,[dbo].[tabGioiTinh] AS GIOITINH,[dbo].[XN_tabKieuXN] AS XN, [dbo].[tabDichTruyen] AS DICHTRUYEN,[dbo].[tabNhomMau] AS MAU WHERE A.SoVaoVien = B.SoVaoVien AND A.SoVaoVien = C.SoVaoVien AND C.BSKhamTienMe = BS.MABACSI AND A.Khoa = KHOA.TENTAT AND A.ChuanDoan = CHUANDOAN.MaChanDoan AND A.PhuongPhapPhauThuat = PHAUTHUAT.TenTat AND A.BenhDangDieuTri = BENH.MaBenh AND A.ThuocDangSuDung = THUOC.MaThuoc AND A.GioiTinh = GIOITINH.IDGioiTinh AND B.XNDeNghi = XN.Type AND C.DichTruyen = DICHTRUYEN.MaDichTruyen AND C.ThuocTienMe = THUOC.MaThuoc AND c.NhomMau = mau.MaNhomMau ";
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuKhamTienMe");
        //    tb.WriteXmlSchema(@"D:\PhieuKhamTienMe.xsd", true);
        //    ev.QFrmThongBao("Đã ghi thành công");
        //}

        //Load
        private void LoadGridViewThongTinBN()
        {
            msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabGioiTinh] as B,[dbo].[tabMACHUYENKHOA] as C,[dbo].[tabCDSPK] as D,[dbo].[tabPhuongPhapPhauThuat] as E  where A.GioiTinh = B.IDGioiTinh AND A.Khoa=C.TENTAT AND A.ChuanDoan = D.MaChanDoan AND A.PhuongPhapPhauThuat = E.TenTat";
            DataTable thongtinbn = comm.GetDataTable(mconnectstring, msql, "thongtinbn");
            dgrThongTinBN.AutoGenerateColumns = false;
            dgrThongTinBN.DataSource = thongtinbn;

            //txtHoTen.Text = dgrThongTinBN.CurrentRow.Cells["cTenBN"].Value.ToString();
            //txtSoVaoVien.Text = dgrThongTinBN.CurrentRow.Cells["cSoVaoVien"].Value.ToString();
            //dtNgaySinh.Text = dgrThongTinBN.CurrentRow.Cells["cNgaySinh"].Value.ToString();
            //dtNgayNhapVien.Text = dgrThongTinBN.CurrentRow.Cells["cNgayNhapVien"].Value.ToString();
            //txtSoHoSo.Text = dgrThongTinBN.CurrentRow.Cells["cMaHoSo"].Value.ToString();
            //cboKhoa.Text = String.Empty;
            //cboKhoa.SelectedText = dgrThongTinBN.CurrentRow.Cells["cKhoa"].Value.ToString();
            //cboGioiTinh.Text = String.Empty;
            //cboGioiTinh.SelectedText = dgrThongTinBN.CurrentRow.Cells["cGioiTinh"].Value.ToString();
            //cboChuanDoan.Text = String.Empty;
            //cboChuanDoan.SelectedText = dgrThongTinBN.CurrentRow.Cells["cChuanDoan"].Value.ToString();
            //cboPPPT.Text = String.Empty;
            //cboPPPT.SelectedText = dgrThongTinBN.CurrentRow.Cells["cPPPT"].Value.ToString();
        }
        private void LoadGridViewThongTinPhieuKham()
        {
            msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabKhamLamSang] as B,[dbo].[tabPhieuKhamTienMe] as C,[dbo].[tabMaBS] as BS,[dbo].[tabMACHUYENKHOA] AS KHOA,[dbo].[tabCDSPK] AS CHUANDOAN, [dbo].[tabPhuongPhapPhauThuat] AS PHAUTHUAT, [dbo].[tabMABENH] AS BENH, [dbo].[tabDanhMucThuoc] AS THUOC,[dbo].[tabGioiTinh] AS GIOITINH,[dbo].[XN_tabKieuXN] AS XN, [dbo].[tabDichTruyen] AS DICHTRUYEN,[dbo].[tabNhomMau] AS MAU WHERE A.SoVaoVien = '"+txtTimBN.Text+"' AND A.SoVaoVien = B.SoVaoVien AND A.SoVaoVien = C.SoVaoVien AND C.BSKhamTienMe = BS.MABACSI AND A.Khoa = KHOA.TENTAT AND A.ChuanDoan = CHUANDOAN.MaChanDoan AND A.PhuongPhapPhauThuat = PHAUTHUAT.TenTat AND A.BenhDangDieuTri = BENH.MaBenh AND A.GioiTinh = GIOITINH.IDGioiTinh AND B.XNDeNghi = XN.Type AND C.DichTruyen = DICHTRUYEN.MaDichTruyen AND C.ThuocTienMe = THUOC.MaThuoc AND c.NhomMau = mau.MaNhomMau";
            DataTable thongtinphieukham = comm.GetDataTable(mconnectstring, msql, "thongtinphieukham");
            dgrPhieuKham.AutoGenerateColumns = false;
            dgrPhieuKham.DataSource = thongtinphieukham;

            txtHoTen.Text = dgrPhieuKham.CurrentRow.Cells["cHoTen1"].Value.ToString();
            txtSoVaoVien.Text = dgrPhieuKham.CurrentRow.Cells["cSoVaoVien1"].Value.ToString();
            dtNgaySinh.Text = dgrPhieuKham.CurrentRow.Cells["cNgaySinh1"].Value.ToString();
            dtNgayNhapVien.Text = dgrPhieuKham.CurrentRow.Cells["cNgayNhapVien1"].Value.ToString();
            txtSoHoSo.Text = dgrPhieuKham.CurrentRow.Cells["cSoHoSo"].Value.ToString();

            cboKhoa.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cKhoa1"].Value.ToString();

            cboGioiTinh.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cGioiTinh1"].Value.ToString();
            cboChuanDoan.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cChuanDoan1"].Value.ToString();

            cboPPPT.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cPPPT1"].Value.ToString();

            txtGiaDinh.Text = dgrPhieuKham.CurrentRow.Cells["cGiaDinh"].Value.ToString();
            txtSanKhoa.Text = dgrPhieuKham.CurrentRow.Cells["cSanKhoa"].Value.ToString();
            txtDiUng.Text = dgrPhieuKham.CurrentRow.Cells["cDiUngTen"].Value.ToString();
            chkDiUng.Checked= bool.Parse(dgrPhieuKham.CurrentRow.Cells["cDiUng"].Value.ToString());
            chkHenSuyen.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cHen"].Value.ToString());
            chkBenhLyDongCamMau.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cBenhLyDongCamMau"].Value.ToString());
            chkPhauThuat.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cPhauThuat"].Value.ToString());
            chkMe.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMe"].Value.ToString());
            chkTe.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTe"].Value.ToString());
            chkTaiBien.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTaiBien"].Value.ToString());
            txtTaiBien.Text = dgrPhieuKham.CurrentRow.Cells["cTaiBienTen"].Value.ToString();

            cboBenhDangDieuTri.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cBenhDangDieuTri"].Value.ToString();
            //cboThuocDangSuDung.Text = String.Empty;
            //cboThuocDangSuDung.SelectedText = dgrPhieuKham.CurrentRow.Cells["cThuocDangSuDung"].Value.ToString();
            txtThuocDangSuDung.Text = dgrPhieuKham.CurrentRow.Cells["cThuocDangSuDung"].Value.ToString();
            txtMach.Text = dgrPhieuKham.CurrentRow.Cells["cMach"].Value.ToString();
            txtHA.Text = dgrPhieuKham.CurrentRow.Cells["cHa"].Value.ToString();
            txtT.Text = dgrPhieuKham.CurrentRow.Cells["cT"].Value.ToString();
            txtCao.Text = dgrPhieuKham.CurrentRow.Cells["cCao"].Value.ToString();
            txtCanNang.Text = dgrPhieuKham.CurrentRow.Cells["cCanNang"].Value.ToString();
            chkMiengHaNho.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMiengHaNho"].Value.ToString());
            chkCoNgan.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cCoNgan"].Value.ToString());
            chkGayXuongHamNiengHam.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cGayXuongHam"].Value.ToString());
            chkCamLem.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cCamLem"].Value.ToString());
            chkNguaCoKho.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cNguaCoKho"].Value.ToString());
            chkRangLungLay.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cRangLungLay"].Value.ToString());
            chkMallaI.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMallaI"].Value.ToString());
            chkMallaII.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMallaII"].Value.ToString());
            chkMallaIII.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMallaIII"].Value.ToString());
            chkMallaIV.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMallaIV"].Value.ToString());
            chkTimMachBT.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTimMachBinhThuong"].Value.ToString());
            chkTimMachBatThuong.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTimMachBatThuong"].Value.ToString());
            txtTimMachBatThuong.Text = dgrPhieuKham.CurrentRow.Cells["cTimMachBatThuongLiDo"].Value.ToString();
            chkHoHapBT.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cHoHapBinhThuong"].Value.ToString());
            chkThanKinhBT.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cThanKinhBinhThuong"].Value.ToString());
            chkNoiTietBT.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cNoiTiet"].Value.ToString());
            chkCoXuongKhopBT.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cCoXuongKhop"].Value.ToString());
            txtXNCanLuuY.Text = dgrPhieuKham.CurrentRow.Cells["cXNLuuY"].Value.ToString();
            cboXNDeNghi.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cXNDeNghi"].Value.ToString();
            chkASAI.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cASAI"].Value.ToString());
            chkASAII.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cASAII"].Value.ToString());
            chkASAIII.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cASAIII"].Value.ToString());
            chkASAIV.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cASAIV"].Value.ToString());
            chkChuongTrinh.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cChuongTrinh"].Value.ToString());
            chkCapCuu.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cCapCuu"].Value.ToString());
            chkBanKhan.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cBanKhan"].Value.ToString());
            chkMeNKQ.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMeNKQ"].Value.ToString());
            chkMeNMC.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMeNMC"].Value.ToString());
            chkDatCVP.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cDatCVP"].Value.ToString());
            chkMeNoiPQ.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMeNoiPQ"].Value.ToString());
            chkTeXuongCung.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["CTeXuongCung"].Value.ToString());
            chkDoHADMXL.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cDoHADMXL"].Value.ToString());
            chkMeMaskTQ.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMeMaskTQ"].Value.ToString());
            chkTeTKVung.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTeTKVung"].Value.ToString());
            chkCEC.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cCEC"].Value.ToString());
            chkMeMask.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cMeMask"].Value.ToString());
            chkTeTaiCho.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTeTaiCHo"].Value.ToString());
            chkTMHH.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTMHH"].Value.ToString());
            chkTeTM.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTeTM"].Value.ToString());
            chkNSHH.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cNSHH"].Value.ToString());
            chkBis.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cBis"].Value.ToString());
            chkTienMe.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cTienMe"].Value.ToString());
            chkSieuAmTQ.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cSieuAmTQ"].Value.ToString());
            chkDienNao.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cDienNao"].Value.ToString());
            cboDichTruyen.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cDichTruyen"].Value.ToString();
            cboThuocTienMe.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cThuocTienMe"].Value.ToString();
            txtYLenhKhac.Text = dgrPhieuKham.CurrentRow.Cells["cYLenhKhac"].Value.ToString();
            nmNhinSuaTu.Text = dgrPhieuKham.CurrentRow.Cells["cNhinSuaTu"].Value.ToString();
            nmUongNuocDuongDen.Text = dgrPhieuKham.CurrentRow.Cells["cUongNuocDuongDen"].Value.ToString();
            chkKhaNangTruyenMau.Checked = bool.Parse(dgrPhieuKham.CurrentRow.Cells["cKhaNangTruyenMau"].Value.ToString());
            cboNhomMau.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cNhomMau"].Value.ToString();
            txtHCL.Text = dgrPhieuKham.CurrentRow.Cells["cHCL"].Value.ToString();
            txtKhac.Text = dgrPhieuKham.CurrentRow.Cells["cKHac"].Value.ToString();
            cboBSKhamTienMe.SelectedValue = dgrPhieuKham.CurrentRow.Cells["cBSTienMe"].Value.ToString();
        }
        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            txtHoTen.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            txtHoTen.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtSoVaoVien_Enter_1(object sender, EventArgs e)
        {
            txtSoVaoVien.xActive = true;
            ev.Qtxt_Enter(sender, e);
            
        }
        private void txtSoVaoVien_Leave_1(object sender, EventArgs e)
        {
            txtSoVaoVien.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtSoVaoVien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            loadSoHoSo();
        }
        private void loadSoHoSo()
        {

        }
        private void txtSoHoSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadSoHoSo();
        }

        private void txtSoHoSo_Enter(object sender, EventArgs e)
        {
            txtSoHoSo.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoHoSo_Leave(object sender, EventArgs e)
        {
            txtSoHoSo.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void cboChuanDoan_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }
        private void cboChuanDoan_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboPPPT_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboPPPT_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void txtGiaDinh_Enter(object sender, EventArgs e)
        {
            txtGiaDinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender,e,txtSanKhoa);
        }

        private void txtGiaDinh_Leave(object sender, EventArgs e)
        {
            txtGiaDinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSanKhoa_Enter(object sender, EventArgs e)
        {
            txtSanKhoa.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSanKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDiUng);
        }

        private void txtSanKhoa_Leave(object sender, EventArgs e)
        {
            txtSanKhoa.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDiUng_Enter(object sender, EventArgs e)
        {
            txtDiUng.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDiUng_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTaiBien);
        }

        private void txtDiUng_Leave(object sender, EventArgs e)
        {
            txtDiUng.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTaiBien_Enter(object sender, EventArgs e)
        {
            txtTaiBien.xActive = true;
            ev.Qtxt_Enter(sender, e);

        }

        private void txtTaiBien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboBenhDangDieuTri);
        }

        private void txtTaiBien_Leave(object sender, EventArgs e)
        {
            txtTaiBien.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboBenhDangDieuTri_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboThuocDangSuDung_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboThuocDangSuDung_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void txtMach_Enter(object sender, EventArgs e)
        {
            txtMach.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMach_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHA);
        }

        private void txtMach_Leave(object sender, EventArgs e)
        {
            txtMach.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHA_Enter(object sender, EventArgs e)
        {
            txtHA.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtT);
        }

        private void txtHA_Leave(object sender, EventArgs e)
        {
            txtHA.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtT_Enter(object sender, EventArgs e)
        {
            txtT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtCao);
        }

        private void txtT_Leave(object sender, EventArgs e)
        {   
            txtT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtCao_Enter(object sender, EventArgs e)
        {
            txtCao.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtCao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtCanNang);
        }

        private void txtCao_Leave(object sender, EventArgs e)
        {
            txtCao.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtCanNang_Enter(object sender, EventArgs e)
        {
            txtCanNang.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTimMachBatThuong);
        }

        private void txtCanNang_Leave(object sender, EventArgs e)
        {
            txtCanNang.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTimMachBatThuong_Enter(object sender, EventArgs e)
        {
            txtTimMachBatThuong.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTimMachBatThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtXNCanLuuY);
        }

        private void txtTimMachBatThuong_Leave(object sender, EventArgs e)
        {
            txtTimMachBatThuong.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void cboXNDeNghi_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboXNDeNghi_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboDichTruyen_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboDichTruyen_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboThuocTienMe_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboThuocTienMe_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void txtYLenhKhac_Enter(object sender, EventArgs e)
        {
            txtYLenhKhac.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtYLenhKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboNhomMau);
        }

        private void txtYLenhKhac_Leave(object sender, EventArgs e)
        {
            txtYLenhKhac.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtHCL_Enter(object sender, EventArgs e)
        {
            txtHCL.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKhac);
        }

        private void txtHCL_Leave(object sender, EventArgs e)
        {
            txtHCL.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtKhac_Enter(object sender, EventArgs e)
        {
            txtKhac.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboBSKhamTienMe);
        }

        private void txtKhac_Leave(object sender, EventArgs e)
        {
            txtKhac.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboBSKhamTienMe_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboBSKhamTienMe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cboBSKhamTienMe_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboKhoa_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboKhoa_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtIn_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void Print()
        {
            a = txtSoVaoVien.Text;
            RpPhieuKhamTienMe RPPhieuKhamTienMe = new RpPhieuKhamTienMe();
            RPPhieuKhamTienMe.ShowDialog();
        }

        private void txtXNCanLuuY_Enter(object sender, EventArgs e)
        {
            txtXNCanLuuY.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtXNCanLuuY_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboXNDeNghi);
        }

        private void txtXNCanLuuY_Leave(object sender, EventArgs e)
        {
            txtXNCanLuuY.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void DanhSachBN_Click(object sender, EventArgs e)
        {
            LoadGridViewThongTinBN();
            dgrThongTinBN.Visible = true;
        }

        private void dgrThongTinBN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtHoTen.Text = dgrThongTinBN.CurrentRow.Cells["cTenBN"].Value.ToString();
            txtSoVaoVien.Text = dgrThongTinBN.CurrentRow.Cells["cSoVaoVien"].Value.ToString();
            dtNgaySinh.Text = dgrThongTinBN.CurrentRow.Cells["cNgaySinh"].Value.ToString();
            dtNgayNhapVien.Text = dgrThongTinBN.CurrentRow.Cells["cNgayNhapVien"].Value.ToString();
            txtSoHoSo.Text = dgrThongTinBN.CurrentRow.Cells["cMaHoSo"].Value.ToString();

            cboKhoa.SelectedValue = dgrThongTinBN.CurrentRow.Cells["cKhoa"].Value.ToString();
            cboGioiTinh.SelectedValue = dgrThongTinBN.CurrentRow.Cells["cGioiTinh"].Value.ToString();
            cboChuanDoan.SelectedValue = dgrThongTinBN.CurrentRow.Cells["cChuanDoan"].Value.ToString();
            cboPPPT.SelectedValue = dgrThongTinBN.CurrentRow.Cells["cPPPT"].Value.ToString();
            if (dgrThongTinBN["cSua", e.RowIndex] == dgrThongTinBN.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa thông tin phiếu khám của Bệnh Nhân " + dgrThongTinBN.CurrentRow.Cells["cTenBN"].Value.ToString() + " này không ?"))
                {
                    btnLuuSua.Visible = true;
                    btnThem.Visible = false;
                }
            }
            if (dgrThongTinBN["cxoa", e.RowIndex] == dgrThongTinBN.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa thông tin phiếu khám của Bệnh Nhân " + dgrThongTinBN.CurrentRow.Cells["cTenBN"].Value.ToString() + " này không ?"))
                {
                    XoaPhieuKhamLamSang();
                    XoaPhieuKhamTienMe();
                    ev.QFrmThongBao("Đã xóa phiếu khám thành công!");
                    dgrThongTinBN.Visible = false;  
                }
            }
            if (dgrThongTinBN["cPrint", e.RowIndex] == dgrThongTinBN.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn in phiếu khám của Bệnh Nhân " + dgrThongTinBN.CurrentRow.Cells["cTenBN"].Value.ToString() + " này không ?"))
                {
                    
                    Print();
                }
            }
            else
            dgrThongTinBN.Visible = false;
        }

        private void dgrThongTinBN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrThongTinBN);
        }

        private void dgrThongTinBN_MouseLeave(object sender, EventArgs e)
        {
            dgrThongTinBN.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn Reset Phiếu lại không? "))
            {
                ResetForm();
            }
            else
                txtHoTen.Focus();
        }
        private void txtTimBN_Leave_1(object sender, EventArgs e)
        {
            //if (txtHoTen.Text == "")
            //{
                
            //    ev.QFrmThongBao("Không tìm thấy Bệnh Nhân");
            //}
            //else
                LoadGridViewThongTinPhieuKham();
        }

        private void txtGhiXML_Click(object sender, EventArgs e)
        {
            msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabKhamLamSang] as B,[dbo].[tabPhieuKhamTienMe] as C,[dbo].[tabMaBS] as BS,[dbo].[tabMACHUYENKHOA] AS KHOA,[dbo].[tabCDSPK] AS CHUANDOAN, [dbo].[tabPhuongPhapPhauThuat] AS PHAUTHUAT, [dbo].[tabMABENH] AS BENH, [dbo].[tabDanhMucThuoc] AS THUOC,[dbo].[tabGioiTinh] AS GIOITINH,[dbo].[XN_tabKieuXN] AS XN, [dbo].[tabDichTruyen] AS DICHTRUYEN,[dbo].[tabNhomMau] AS MAU WHERE A.SoVaoVien = B.SoVaoVien AND A.SoVaoVien = C.SoVaoVien AND C.BSKhamTienMe = BS.MABACSI AND A.Khoa = KHOA.TENTAT AND A.ChuanDoan = CHUANDOAN.MaChanDoan AND A.PhuongPhapPhauThuat = PHAUTHUAT.TenTat AND A.BenhDangDieuTri = BENH.MaBenh AND A.ThuocDangSuDung = THUOC.MaThuoc AND A.GioiTinh = GIOITINH.IDGioiTinh AND B.XNDeNghi = XN.Type AND C.DichTruyen = DICHTRUYEN.MaDichTruyen AND C.ThuocTienMe = THUOC.MaThuoc AND c.NhomMau = mau.MaNhomMau ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuKhamTienMe");
            tb.WriteXmlSchema(@"D:\PhieuKhamTienMe.xsd", true);
            ev.QFrmThongBao("Đã ghi thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi sửa nhé! ^-^"))
            {
                SuaThongTinBN();
                SuaThongTinKhamLamSang();
                SuaThongTinKhamTienMe();
                ev.QFrmThongBao("Đã sửa phiếu thành công");
                LoadGridViewThongTinPhieuKham();
            }
        }
    }
}
