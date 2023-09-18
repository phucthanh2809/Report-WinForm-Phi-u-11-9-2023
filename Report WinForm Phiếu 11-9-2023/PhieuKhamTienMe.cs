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
            //cboThuocDangSuDung
            msql = "SELECT * FROM [dbo].[tabDanhMucThuoc]";
            DataTable Thuoc = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            cboThuocDangSuDung.DataSource = Thuoc.Copy();
            cboThuocDangSuDung.DisplayMember = "TenThuoc";
            cboThuocDangSuDung.ValueMember = "MaThuoc";
            cboThuocDangSuDung.CustomAlignment = new string[] { "l", "l" };
            cboThuocDangSuDung.CustomColumnStyle = new string[] { "t", "t" };
            //cboXNCanLuuY
            msql = "SELECT * FROM [dbo].[XN_tabKieuXN]";
            DataTable XN = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            cboXNCanLuuY.DataSource = XN.Copy();
            cboXNCanLuuY.DisplayMember = "TypeName";
            cboXNCanLuuY.ValueMember = "Type";
            cboXNCanLuuY.CustomAlignment = new string[] { "l", "l" };
            cboXNCanLuuY.CustomColumnStyle = new string[] { "t", "t" };
            //cboXNDeNghi
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

        }
        //Nút thêm
            private void btnThem_Click(object sender, EventArgs e)
            {
                if (txtHoTen.Text.Trim() != "" )
                {
                    if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé! ^-^"))
                    {
                        if (dtNgaySinh.Value < dtNgayNhapVien.Value)
                        {
                            ThemThongTinBN();
                            ThemThongTinKhamLamSang();
                            ThemThongTinKhamTienMe();
                            ev.QFrmThongBao("Đã lưu thành công");
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
                "VALUES (N'" + txtSoVaoVien.Text + "',N'" + txtHoTen.Text + "','" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayNhapVien.Value).ToString("yyyy-MM-dd") + "',N'" + cboKhoa.SelectedValue + "',N'" + txtSoHoSo.Text + "',N'" + cboGioiTinh.SelectedValue + "',N'" + cboChuanDoan.SelectedValue + "',N'" + cboPPPT.SelectedValue + "',N'" + txtGiaDinh.Text + "',N'" + txtSanKhoa.Text + "','" + chkDiUng.Checked + "',N'" + txtDiUng.Text + "','" + chkHenSuyen.Checked + "','" + chkBenhLyDongCamMau.Checked + "','" + chkPhauThuat.Checked + "','" + chkMe.Checked + "','" + chkTe.Checked + "','" + chkTaiBien.Checked + "',N'" + txtTaiBien.Text + "',N'" + cboBenhDangDieuTri.SelectedValue + "',N'" + cboThuocDangSuDung.SelectedValue + "')";
            comm.RunSQL(mconnectstring, msql);
        }

        //Lưu thông tin Khám Lâm Sàng
        private void ThemThongTinKhamLamSang()
        {
            msql = "INSERT INTO [dbo].[tabKhamLamSang]" +
                "([SoVaoVien],[Mach],[HA],[T],[Cao],[CanNang],[DTMiengHaNho],[DTCamLem],[DTCoNgan],[DTNguaCoKho],[DTGayXuongHamNiengHam],[DTRangLungLay],[MallaI],[MallaII],[MallaIII],[MallaIV],[TimMachBT],[TimMachBatThuong],[TimMachBatThuongLiDo],[HoHapBT],[ThanKinhBT],[NoiTietBT],[CoXuongKhopBT],[XNCanLuuY],[XNDeNghi],[ASAI],[ASAII],[ASAIII],[ASAIV],[ChuongTrinh],[CapCuu],[BanKhan])" +
                "VALUES(N'" + txtSoVaoVien.Text + "',N'" + txtMach.Text + "','" + txtHA.Text + "','" + txtT.Text + "','" + txtCao.Text + "','" + txtCanNang.Text + "','"+chkMiengHaNho.Checked+ "','" + chkCamLem.Checked + "','" + chkCoNgan.Checked + "','" + chkNguaCoKho.Checked + "','" + chkGayXuongHamNiengHam.Checked + "','" + chkRangLungLay.Checked + "','" + chkMallaI.Checked + "','" + chkMallaII.Checked + "','" + chkMallaIII.Checked + "','" + chkMallaIV.Checked + "','" + chkTimMachBT.Checked + "','" + chkTimMachBatThuong.Checked + "',N'" + txtTimMachBatThuong.Text + "','" + chkHoHapBT.Checked + "','" + chkThanKinhBT.Checked + "','" + chkNoiTietBT.Checked + "','" + chkCoXuongKhopBT.Checked + "',N'" + cboXNCanLuuY.SelectedValue + "',N'" + cboXNDeNghi.SelectedValue + "','" + chkASAI.Checked + "','" + chkASAII.Checked + "','" + chkASAIII.Checked + "','" + chkASAIV.Checked + "','" + chkChuongTrinh.Checked + "','" + chkCapCuu.Checked + "','" + chkBanKhan.Checked + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        //Thêm thông tin khám tiền mê
        private void ThemThongTinKhamTienMe()
        {
            msql = "INSERT INTO [dbo].[tabPhieuKhamTienMe]" +
                   "([SoVaoVien],[PPVCDNMeNKQ],[PPVCDNMeNMC],[PPVCDNDatCVP],[PPVCDNMeNoiPQ],[PPVCDNTeXuongCung],[PPVCDNDoHADMXL],[PPVCDNMeMaskTQ],[PPVCDNTeTKVung],[PPVCDNCEC],[PPVCDNMeMask],[PPVCDNTeTaiCho],[PPVCDNTMHH],[PPVCDNTeTM],[PPVCDNNSHH],[PPVCDNBisEntropy],[PPVCDNTienMe],[PPVCDNSieuAmTQ],[PPVCDNDienNao],[DichTruyen],[ThuocTienMe],[YLenhKhac],[NhinSuaTu],[UongNuocDuongDen],[KhaNangTruyenMau],[NhomMau],[HCL],[Khac],[NgayThangNam],[BSKhamTienMe])" +
                   " VALUES('" + txtSoVaoVien.Text + "','" + chkMeNKQ.Checked + "','" + chkMeNMC.Checked + "','" + chkDatCVP.Checked + "','" + chkMeNoiPQ.Checked + "','" + chkTeXuongCung.Checked + "','" + chkDoHADMXL.Checked + "','" + chkMeMaskTQ.Checked + "','" + chkTeTKVung.Checked + "','" + chkCEC.Checked + "','" + chkMeMask.Checked + "','" + chkTeTaiCho.Checked + "','" + chkTMHH.Checked + "','" + chkTeTM.Checked + "','" + chkNSHH.Checked + "','" + chkBis.Checked + "','" + chkTienMe.Checked + "','" + chkSieuAmTQ.Checked + "','" + chkDienNao.Checked + "',N'" + cboDichTruyen.SelectedValue + "',N'" + cboThuocTienMe.SelectedValue + "',N'" + txtYLenhKhac.Text + "',N'" + nmNhinSuaTu.Value + "',N'" + nmUongNuocDuongDen.Value + "','" + chkKhaNangTruyenMau.Checked + "',N'" + txtNhomMau.Text + "',N'" + txtHCL.Text + "',N'" + txtKhac.Text + "','" + Convert.ToDateTime(dtChonNgay.Value).ToString("yyyy-MM-dd") + "',N'" + cboBSKhamTienMe.SelectedValue + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        //Nút xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn xóa thông tin này không??"))
            {
                XoaPhieuKhamLamSang();
                XoaPhieuKhamTienMe();
                ev.QFrmThongBao("Đã xóa phiếu thành công");
            }  
        }
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi sửa nhé! ^-^"))
            {
                SuaThongTinBN();
                SuaThongTinKhamLamSang();
                SuaThongTinKhamTienMe();
                ev.QFrmThongBao("Đã sửa phiếu thành công");
            }
        }
        //Sửa Thông tin BN 
        private void SuaThongTinBN()
        {
            msql = "UPDATE[dbo].[tabThongTinBenhNhan]" +
                   "SET [HoTen] = '" + txtHoTen.Text + "',[NgaySinh] = '" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "' ,[NgayNhapVien] = '" + Convert.ToDateTime(dtNgayNhapVien.Value).ToString("yyyy-MM-dd") + "',[Khoa] = N'" + cboKhoa.SelectedValue + "',[MaHoSo] = N'" + txtSoHoSo.Text + "',[GioiTinh] = N'" + cboGioiTinh.SelectedValue + "',[ChuanDoan] = N'" + cboChuanDoan.SelectedValue + "',[PhuongPhapPhauThuat] = N'" + cboPPPT.SelectedValue + "',[GiaDinh] = N'" + txtGiaDinh.Text + "',[SanKhoa] = N'" + txtSanKhoa.Text + "',[DiUng] = '" + chkDiUng.Checked + "',[TenDiUng] = N'" + txtDiUng.Text + "',[HenSuyen] = '" + chkHenSuyen.Checked + "'" +
                   ",[BenhLyDongCamMau] = '" + chkBenhLyDongCamMau.Checked + "',[PhauThuat] = '" + chkPhauThuat.Checked + "',[Me] = '" + chkMe.Checked + "',[Te] = '" + chkTe.Checked + "',[TaiBien] = '" + chkTaiBien.Checked + "',[TenTaiBien] = N'" + txtTaiBien.Text + "',[BenhDangDieuTri] = N'" + cboBenhDangDieuTri.SelectedValue + "',[ThuocDangSuDung] = N'" + cboThuocDangSuDung.SelectedValue + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Sửa Khám Lâm Sàng 
        private void SuaThongTinKhamLamSang()
        {
            msql = "UPDATE [dbo].[tabKhamLamSang]" +
                   "SET [Mach] = N'" + txtMach.Text + "',[HA] = '" + txtHA.Text + "',[T] = '" + txtT.Text + "',[Cao] = '" + txtCao.Text + "',[CanNang] = '" + txtCanNang.Text + "',[DTMiengHaNho] = '"+chkMiengHaNho.Checked+ "',[DTCamLem] = '" + chkCamLem.Checked + "',[DTCoNgan] = '" + chkCoNgan.Checked + "',[DTNguaCoKho] = '" + chkNguaCoKho.Checked + "',[DTGayXuongHamNiengHam] = '" + chkGayXuongHamNiengHam.Checked + "',[DTRangLungLay] = '" + chkRangLungLay.Checked + "',[MallaI] = '" + chkMallaI.Checked + "',[MallaII] = '" + chkMallaII.Checked + "',[MallaIII] = '" + chkMallaIII.Checked + "'" +
                   ",[MallaIV] = '" + chkMallaIV.Checked + "',[TimMachBT] = '" + chkTimMachBT.Checked + "',[TimMachBatThuong] = '" + chkTimMachBatThuong.Checked + "',[TimMachBatThuongLiDo] = N'" + txtTimMachBatThuong.Text + "',[HoHapBT] = '" + chkHoHapBT.Checked + "',[ThanKinhBT] = '" + chkThanKinhBT.Checked + "',[NoiTietBT] = '" + chkNoiTietBT.Checked + "',[CoXuongKhopBT] = '" + chkCoXuongKhopBT.Checked + "',[XNCanLuuY] = N'" + cboXNCanLuuY.SelectedValue + "',[XNDeNghi] = N'" + cboXNDeNghi.SelectedValue + "',[ASAI] = '" + chkASAI.Checked + "',[ASAII] = '" + chkASAII.Checked + "'" +
                   ",[ASAIII] = '" + chkASAIII.Checked + "',[ASAIV] = '" + chkASAIV.Checked + "',[ChuongTrinh] = '" + chkChuongTrinh.Checked + "',[CapCuu] = '" + chkCapCuu.Checked + "',[BanKhan] = '" + chkBanKhan.Checked + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Sửa Thông tin Khám Tiền Mê
        private void SuaThongTinKhamTienMe()
        {
            msql = "UPDATE [dbo].[tabPhieuKhamTienMe]" +
                   "SET [PPVCDNMeNKQ] = '" + chkMeNKQ.Checked + "',[PPVCDNMeNMC] = '" + chkMeNMC.Checked + "',[PPVCDNDatCVP] = '" + chkDatCVP.Checked + "',[PPVCDNMeNoiPQ] = '" + chkMeNoiPQ.Checked + "',[PPVCDNTeXuongCung] = '" + chkTeXuongCung.Checked + "',[PPVCDNDoHADMXL] = '" + chkDoHADMXL.Checked + "',[PPVCDNMeMaskTQ] = '" + chkMeMaskTQ.Checked + "',[PPVCDNTeTKVung] = '" + chkTeTKVung.Checked + "',[PPVCDNCEC] = '" + chkCEC.Checked + "',[PPVCDNMeMask] = '" + chkMeMask.Checked + "',[PPVCDNTeTaiCho] = '" + chkTeTaiCho.Checked + "',[PPVCDNTMHH] = '" + chkTMHH.Checked + "'" +
                   ",[PPVCDNTeTM] = '" + chkTeTM.Checked + "',[PPVCDNNSHH] = '" + chkNSHH.Checked + "',[PPVCDNBisEntropy] = '" + chkBis.Checked + "',[PPVCDNTienMe] = '" + chkTienMe.Checked + "',[PPVCDNSieuAmTQ] = '" + chkSieuAmTQ.Checked + "',[PPVCDNDienNao] = '" + chkDienNao.Checked + "',[DichTruyen] = N'" + cboDichTruyen.SelectedValue + "', [ThuocTienMe] = N'" + cboThuocTienMe.SelectedValue + "', [YLenhKhac] = N'" + txtYLenhKhac.Text + "', [NhinSuaTu] = N'" + nmNhinSuaTu.Value + "', [UongNuocDuongDen] = N'" + nmUongNuocDuongDen.Value + "', [KhaNangTruyenMau] = '" + chkKhaNangTruyenMau.Checked + "'" +
                   ",[NhomMau] = N'" + txtNhomMau.Text + "', [HCL] = N'" + txtHCL.Text + "', [Khac] = N'" + txtKhac.Text + "', [NgayThangNam] = '" + Convert.ToDateTime(dtChonNgay.Value).ToString("yyyy-MM-dd") + "',[BSKhamTienMe] = N'" + cboBSKhamTienMe.SelectedValue + "' WHERE [SoVaoVien] = '" + txtSoVaoVien.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        //Ghi XML
        private void btnGhiXML_Click(object sender, EventArgs e)
        {
            msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabKhamLamSang] as B,[dbo].[tabPhieuKhamTienMe] as C WHERE A.SoVaoVien = B.SoVaoVien AND A.SoVaoVien = C.SoVaoVien";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuKhamTienMe");
            tb.WriteXmlSchema(@"D:\PhieuKhamTienMe.xsd", true);
            ev.QFrmThongBao("Đã ghi thành công");
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
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboXNCanLuuY);
        }

        private void txtTimMachBatThuong_Leave(object sender, EventArgs e)
        {
            txtTimMachBatThuong.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboXNCanLuuY_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboXNCanLuuY_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
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
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNhomMau);
        }

        private void txtYLenhKhac_Leave(object sender, EventArgs e)
        {
            txtYLenhKhac.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNhomMau_Enter(object sender, EventArgs e)
        {
            txtNhomMau.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNhomMau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHCL);
        }

        private void txtNhomMau_Leave(object sender, EventArgs e)
        {
            txtNhomMau.xActive = false;
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
            RpPhieuKhamTienMe RPPhieuKhamTienMe = new RpPhieuKhamTienMe();
            RPPhieuKhamTienMe.ShowDialog();
        }
    }
}
