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
    public partial class BangKiemAnToanTrongPhauThuatThuThuat : Form
    {

        private string mconnectstring = "server=.;database = APP_REPORT; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public BangKiemAnToanTrongPhauThuatThuThuat()
        {
            InitializeComponent();
            LoadData();
        }
        public static string maphieunhapkho;

        private void LoadData()
        {
            //"+ FrmNhapThuoc.maphieunhapkho+"
            msql = "SELECT * FROM [APP_REPORT].[dbo].[tbl_ThongTinBN] AS A,[dbo].[tbl_ChuanbiBN_PM] AS B,[dbo].[tbl_ChuanbiBN_PM_GhiChu] AS C,[dbo].[tbl_BangKiemAnToanPTVaSauPT] AS D WHERE A.SoHoSo=B.SoHoSo AND B.SoHoSo=C.SoHoSo AND C.SoHoSo=D.SoHoSo";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tbl_ThongTinBN");
            dgvDanhSachBN.AutoGenerateColumns = false;
            dgvDanhSachBN.DataSource = tb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void thembang1()
        {
            msql = "insert into [APP_REPORT].[dbo].[tbl_ThongTinBN] " +
                        "([HoTenBN],[NgaySinh],[NgayNhapVien],[Khoa] " +
                        ",[SoHoSo],[GioTinh_Nam],[GioiTinh_Nu],[ChuanDoan],[PPPhauThuat],[ChuongTrinh],[Khan])" +
                         "VALUES(N'" + txtTenBN.Text + "','" + Convert.ToDateTime(dtpNgayThangNamSinh.Value).ToString("yyyy-MM-dd") + "'," +
                         "'" + Convert.ToDateTime(dtpNgayNhapVien.Value).ToString("yyyy-MM-dd") + "', N'" + cboKhoa.SelectedValue + "'," +
                         "N'"+txtSoHoSo.Text+"','"+cbNam.Checked+"','"+cbNu.Checked+ "',N'" + txtChuanDoan.Text+ "',N'" + txtPPPhauThuat.Text + "','"+cbChuongTrinh.Checked+"','"+cbKhan.Checked+"')";
            comm.RunSQL(mconnectstring, msql);
        }
        private void thembang2()
        {

            msql = "INSERT INTO [APP_REPORT].[dbo].[tbl_ChuanbiBN_PM]" +

       "([SoHoSo]" +
       ",[YeuCauTheoDoiKhacNhau]" +
       ",[ThucHienThuocTruocMo]" +
      ",[ThuocBanGiaoPM]" +
       ",[HoSoBA]" +
       ",[CoVongDeoTayVaDungTenBN]" +
       ",[DanhDauVetMo]" +
       ",[BienBanHoiChuanCoChuKy]" +
       ",[GiayCamKetMoCoChuKyDayDu]" +
       ",[GiayCamKetGayMeCoChuKyDayDu]" +
       ",[PhieuKhamTienMe]" +
       ",[TrangSucDaDuocThao]" +
       ",[MongTayMongChanKhongCoSonRangLungLayVaTocDuocKT]" +
       ",[QuanAoMoSachVaThichHop]" +
       ",[ThoiGianAnUongLanCuoi]" +
       ",[GhiNhanCanNangHienTai]" +
       ",[KimLuon]" +
       ",[DichTruyenVaTocDoChayThicHop]" +
       ",[SLDichTruyenConLai]" +
       ",[TongPhanTichTeBao]" +
       ",[ChucNangDongMau]" +
       ",[ChucNangGan]" +
       ",[ChucNangThan]" +
       ",[IonDo]" +
       ",[NhomMau]" +
       ",[DangKyMau]" +
       ",[Phim]" +
       ",[BienBanHoiChuanCoChuKy_KAD]" +
       ",[DanhDauVetMo_KAD]" +
       ",[KimLuon_KAD]" +
       ",[DichTruyenVaTocDoChayThicHop_KAD]" +
       ",[SLDichTruyenConLai_KAD]" +
       ",[ChucNangDongMau_KAD]" +
       ",[ChucNangGan_KAD]" +
       ",[ChucNangThanKAD]" +
       ",[IonDo_KAD]" +
       ",[NhomMau_KAD]" +
       ",[DangKyMau_KAD]" +
       ",[Phim_KAD])" +
                     "VALUES(N'" + txtSoHoSo.Text + "',N'" + txtYeuCauKhac.Text + "', N'" + txtThucHienTruocKhiMo.Text + "', N'" + txtThuocBanGiaoChoPhongMo.Text + "'," +
                     "'" + cbCo1.Checked + "', '" + cbCo2.Checked + "','" + cbCo3.Checked + "','" + cbCo4.Checked + "','" + cbCo5.Checked + "','" + cbCo6.Checked + "','" + cbCo7.Checked + "'," +
                     "'" + cbCo8_1.Checked + "', '" + cbCo8_2.Checked + "', '" + cbCo8_3.Checked + "','" + cbCo9.Checked + "', '" + txtKg.Text + "','" + cbCo11_1.Checked + "'," +
                     "'" + cbCo11_2.Checked + "','" + txtMl.Text + "','" + cbCo13_1.Checked + "','" + cbCo13_2.Checked + "','" + cbCo13_3.Checked + "','" + cbCo13_4.Checked + "'," +
                     "'" + cbCo13_5.Checked + "','" + cbCo13_6.Checked + "','" + cbCo14.Checked + "','" + cbCo15.Checked + "','" + cbKhong3.Checked + "','" + cbKhong4.Checked + "','" + cbKhong11_1.Checked + "'," +
                     "'" + cbKhong11_2.Checked + "','" + cbKhong12.Checked + "','" + cbKhong13_2.Checked + "','" + cbKhong13_3.Checked + "','" + cbKhong13_4.Checked + "'," +
                     "'" + cbKhong13_5.Checked + "','" + cbKhong13_6.Checked + "','" + cbKhong14.Checked + "','" + cbKhong15.Checked + "')";
            comm.RunSQL(mconnectstring, msql);




        }

        private void thembang3()
        {
            msql = "INSERT INTO [APP_REPORT].[dbo].[tbl_ChuanbiBN_PM_Ghichu]" +

          "([SoHoSo],[HoSoBA_GhiChu]" +
           ",[CoVongDeoTayVaDungTenBN]" +
           ",[DanhDauVetMo]" +
           ",[BienBanHoiChuanCoChuKy]" +
           ",[GiayCamKetMoCoChuKyDayDu]" +
           ",[GiayCamKetGayMeCoChuKyDayDu]" +
           ",[PhieuKhamTienMe]" +
           ",[TrangSucDaDuocThao]" +
           ",[MongTayMongChanKhongCoSonRangLungLayVaTocDuocKT]" +
           ",[QuanAoMoSachVaThichHop]" +
           ",[ThucAnDacBiet]" +
           ",[ThucAnLong]" +
           ",[Nuoc]" +
           ",[ThoiDiemAnLanCuoi]" +
           ",[GhiNhanCanNangHienTai]" +
           ",[KimLuon]" +
            ",[DichTruyenVaTocDoChayThicHop_Loai]" +
           ",[DichTruyenVaTocDoChayThicHop_TocDo]" +
           ",[SLDichTruyenConLai]" +
           ",[TongPhanTichTeBao]" +
           ",[ChucNangDongMau]" +
           ",[ChucNangGan]" +
           ",[ChucNangThan]" +
           ",[IonDo]" +
           ",[NhomMau]" +
           ",[XetNghiemKhac]" +
           ",[DangKyMau]" +
           ",[LoaiPhim]" +
           ",[SoLuongPhim])" +
           "VALUES('" + txtSoHoSo.Text + "',N'" + txtHoSoBN.Text + "', N'" + txtCoVongDeoTayVaDungTenBN.Text + "', N'" + txtDanhDauVetMo.Text + "'," +
           "N'" + txtBienBanHoiChanCoChuKyDayDu.Text + "',N'" + txtGiayCamKetMoCoChuKyDayDu.Text + "',N'" + txtGiayCamKetGayMeCoChuKyDayDu.Text + "'," +
           "N'" + txtPhieuKhamTienMe + "','N" + txtTrangSucDaDuocThao.Text + "','N" + txtMongTay_MongChan.Text + "','N" + txtQuanAoMoSachVaThicHop.Text + "'," +
           "'" + cbThucAnDacBiet.Checked + "','" + cbThucAnLong.Checked + "','" + cbNuoc.Checked + "','" + txtThoiDiemAnLanCuoi.Text + "'," +
           "N'" + txtGhiNhanCanNangHienTai.Text + "',N'" + txtKimLuon_ViTri.Text + "',N'" + txtDichTruyenVaTocDoChayThichHop_Loai.Text + "'," +
           "N'" + txtDichTruyenVaTocDoChayThichHop_TocDo.Text + "','" + txtSLDichTruyenConLai.Text + "','" + txtTongPhanTichTeBao.Text + "'," +
           "N'" + txtChucNangDongDongMau.Text + "',N'" + txtChucNangGan.Text + "',N'" + txtChucNangThan.Text + "',N'" + txtI_onDo.Text + "'," +
           "N'" + txtNhomMau.Text + "',N'" + txtXetNghiemKhac.Text + "',N'" + txtSoLuong_DangKyMau.Text + "',N'" + cboLoai_Phim.SelectedValue + "',N'" + txtSoLuong_Phim.Text + "')";

            comm.RunSQL(mconnectstring, msql);
        }

        private void thembang4()
        {
            msql = "INSERT INTO [APP_REPORT].[dbo].[tbl_BangKiemAnToanPTVaSauPT]" +
           "([SoHoSo]" +
           ",[DaKiemTraTen_Tuoi_GioiTinh_LoaiPhauThuat_ViTriPTChua]" +
           ",[ViTriPTDaDuocDanhDauChua]"+
          ",[MayGayMeVaThuocDaDuocKTHaonTatChua]" +
          ",[MayDoDoBaoHoaOxyDaGanVaoBNVaHoatDongChua]" +
           ",[DiUngDaBiet]"+
           ",[DatNKQKhoHoacNguyCoHitSac]"+
           ",[NguyCoMatHon500mlmau]"+

           ",[XacDinhLaiCacThanhVienEkipPhauThuat_MoiNguoiTuGioiThieuTenVaVaiTroCuaMinh]"+
           ",[DocTenBN]"+
           ",[ChuanDoanBNVaPPDieuTri]"+
           ",[DaCoDinhBN]"+
           ",[DaXacDinhRachDa]"+
           ",[DaKTVeKhangSinhDuPhong]"+
           ",[DaKTViecTraVaDanVungMatChoBN]"+
           ",[DaNoiCacNguyCoCoTheXayRaTrongPTNay]"+
           ",[ThoiGianDuKien]"+
           ",[DuKienLuongMauMat]"+
           ",[GayMe_DaNoiNguyCoTheChoEkipNghe]" +
           ",[DamBaoVanDeVoTrungPT]" +
           ",[DungCuPT]" +
           ",[DaTreoPhimLenBangDien]" +
           ",[DaDanTamDienCuc]" +

           ",[TenPhauThuatVuaThucHien]" +
           ",[HoanTatDiemDungCu_Gac_KimDayDu]" +
           ",[PTV_BSGayMeVaDieuDuongDaLuuYCacVanDeSauKhiTinhMeVaChamSocBNNay]"+

           ",[ViTriPTDaDuocDanhDauChua_KAD]"+
           ",[DatNKQKhoHoacNguyCoHitSac_Khong]"+
           ",[NguyCoMatHon500mlmau_Khong]"+
           ",[DaCoDinhBN_KAD]"+
           ",[DaKTVeKhangSinhDuPhong_KAD]"+ 
           ",[DamBaoVanDeVoTrungPT_KAD]" +
           ",[DaTreoPhimLenBangDien_KAD]"+
           ",[DaDanTamDienCuc_KAD]"+
           ",[TenPhauThuatVuaThucHien_KAD])"+
           "VALUES('"
           +txtSoHoSo.Text+"'," +
           "'" + cbCoGayMe_1.Checked + "'," +
           "'" + cbCoGayMe_2.Checked + "'," +
           " '" + cbCoGayMe_3.Checked + "'," +
           "'"+ cbCoGayMe_4.Checked + "'," +
           "'"+ cbCoGayMe5_1.Checked + "'," +
           "'"+ cbCoGayMe5_2.Checked + "'," +
           "'"+ cbCoGayMe5_3.Checked + "'," +

           "'"+cbCoRachDa1.Checked+"'," +
           "'"+cbCoRachDa2_1.Checked+"'," +
           "'"+cbCoRachDa2_2.Checked+"'," +
           "'"+cbCoRachDa3.Checked+"'," +
           "'"+cbCoRachDa4.Checked+"'," +
           "'"+cbCoRachDa5.Checked+"',"+
                "'"+cbCoRachDa6.Checked+"'," +
                "'"+cbCoRachDa7_PT.Checked+"'," +
                "'"+ Convert.ToDateTime(dtpThoiGianDuKien.Value).ToString("yyyy-MM-dd") + "'," +
                "'"+txtDuKiebnLuongMauMat.Text+"'," +
                "'"+cbCoRachDa7_GayMe.Checked+"'," +
                "'"+cbCoRachDa7_DieuDuong1.Checked+"'," +
                "'"+cbCoRachDa7_DieuDuong2.Checked+"'," +
                "'"+cbCoRachDa7_TreoPhimLenBangDien.Checked+"'," +
                "'" + cbCoRachDa7_DaDanTamDienCuc.Checked + "'," +

                "'" + cbCoPhongMo1_TenPhauThuatVuaThucHien.Checked+"'," +
                "'"+cbCoPhongMo1_HoanTatDiem.Checked+"'," +
                "'"+cbCoPhongMo2.Checked+"'," +

                "'"+cbKhongGayMe_2.Checked+"'," +
                "'"+ cbKhongGayMe5_2.Checked+"'," +
                "'"+cboKhongGayMe5_3.Checked+ "'," +
                "'"+ cbKhongRachDa3.Checked+ "'," +
                 "'" + cbKhongRachDa5.Checked + "'," +
                "'" + cbKhongRachDa7_DieuDuong1.Checked+ "'," +
                "'" + cbKhongRachDa7_TreoPhimLenBangDien.Checked + "'," +
                "'" + cbKhongRachDa7_DaDanTamDienCuc.Checked + "'," +
                "'" + cbKhongPhonMo1_TenPhauThuatVuaThucHien2.Checked+ "')";
            comm.RunSQL(mconnectstring, msql);
        }
        private void btnThem_Click_2(object sender, EventArgs e)
        {
            
            BangKiemAnToanTrongPhauThuatThuThuat frm = new BangKiemAnToanTrongPhauThuatThuThuat(); //tạo Frm mới
            frm.ShowDialog();
            

        }

        private void suabang1()
        {

            msql = " UPDATE [APP_REPORT].[dbo].[tbl_ThongTinBN]" +
"SET[HoTenBN] = N'" + txtTenBN.Text + "' " +
",[NgaySinh] = '" + Convert.ToDateTime(dtpNgayThangNamSinh.Value).ToString("yyyy-MM-dd") + "' " +
" ,[NgayNhapVien] = '" + Convert.ToDateTime(dtpNgayNhapVien.Value).ToString("yyyy-MM-dd") + "' " +
",[Khoa] = '" + cboKhoa.SelectedValue + "' " +
",[GioTinh_Nam] = '" + cbNam.Checked + "' " +
",[GioiTinh_Nu] = '" + cbNu.Checked + "' " +
",[ChuanDoan] = N'" + txtChuanDoan.Text + "' " +
",[PPPhauThuat] = N'" + txtPPPhauThuat.Text + "' " +
",[ChuongTrinh] = N'" + cbChuongTrinh.Checked + "' " +
",[Khan] = '" + cbKhan.Text + "' " +
"WHERE SoHoSo = '" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);






        }







        private void suabang2()
        {
            msql = "UPDATE[dbo].[tbl_ChuanbiBN_PM]" +
               "SET[YeuCauTheoDoiKhacNhau] = '" + txtYeuCauKhac.Text + "'" +
                ",[ThucHienThuocTruocMo] = '" + txtThucHienTruocKhiMo.Text + "'" +
                ",[ThuocBanGiaoPM] = '" + txtThuocBanGiaoChoPhongMo.Text + "'" +

             ",[HoSoBA] = '" + cbCo1.Checked + "'" +
              ",[CoVongDeoTayVaDungTenBN] = '" + cbCo2.Checked + "' " +
               ",[DanhDauVetMo] = '" + cbCo3.Checked + "'" +
                ",[BienBanHoiChuanCoChuKy] = '" + cbCo4.Checked + "'" +
            ",[GiayCamKetMoCoChuKyDayDu] = '" + cbCo5.Checked + "'" +
            ",[GiayCamKetGayMeCoChuKyDayDu] = '" + cbCo6.Checked + "'" +
             ",[PhieuKhamTienMe] = '" + cbCo7.Checked + "'" +
              ",[TrangSucDaDuocThao] = '" + cbCo8_1.Checked + "'" +
               ",[MongTayMongChanKhongCoSonRangLungLayVaTocDuocKT] = '" + cbCo8_2.Checked + "'" +
               ",[QuanAoMoSachVaThichHop] = '" + cbCo8_3.Checked + "'" +

                ",[ThoiGianAnUongLanCuoi] = '" + cbCo9.Checked + "'" +
                ",[GhiNhanCanNangHienTai] = '" + txtKg.Text + "'" +
                 ",[KimLuon] = '" + cbCo11_1.Checked + "'" +
                  ",[DichTruyenVaTocDoChayThicHop] = '" + cbCo11_2.Checked + "'" +
             ",[SLDichTruyenConLai] = '" + txtMl.Text + "'" +
              ",[TongPhanTichTeBao] = '" + cbCo13_1.Checked + "'" +
               ",[ChucNangDongMau] = '" + cbCo13_2.Checked + "'" +
                ",[ChucNangGan] = '" + cbCo13_3.Checked + "'" +
                 ",[ChucNangThan] = '" + cbCo13_4.Checked + "'" +
                  ",[IonDo] = '" + cbCo13_5.Checked + "'" +
            ",[NhomMau] = '" + cbCo13_6.Checked + "'" +
              //""     ,[XetNghiemKhac] = < XetNghiemKhac, bit,>+
              ",[DangKyMau] ='" + cbCo14.Checked + "'" +
               ",[Phim] = '" + cbCo15.Checked + "'" +

                ",[BienBanHoiChuanCoChuKy_KAD] ='" + cbKhong3.Checked + "'" +
                 ",[DanhDauVetMo_KAD] = '" + cbKhong4.Checked + "'" +
             ",[KimLuon_KAD] = '" + cbKhong11_1.Checked + "'" +
              ",[DichTruyenVaTocDoChayThicHop_KAD] = '" + cbKhong11_2.Checked + "'" +
               ",[SLDichTruyenConLai_KAD] = '" + cbKhong12.Checked + "'" +
                ",[ChucNangDongMau_KAD] = '" + cbKhong13_2.Checked + "'" +
                 ",[ChucNangGan_KAD] ='" + cbKhong13_3.Checked + "'" +
             " ,[ChucNangThanKAD] = '" + cbKhong13_4.Checked + "'" +
             ",[IonDo_KAD] = '" + cbKhong13_5.Checked + "'" +
              ",[NhomMau_KAD] = '" + cbKhong13_6.Checked + "'" +
               ",[DangKyMau_KAD] = '" + cbKhong14.Checked + "'" +
                ",[Phim_KAD] = '" + cbKhong15.Checked + "'" +
 "WHERE SoHoSo = '" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }

        private void suabang3()
        {
 msql = " UPDATE[dbo].[tbl_ChuanbiBN_PM_Ghichu]" +
   "SET[HoSoBA_GhiChu] = N'" + txtHoSoBN.Text + "'" +
",[CoVongDeoTayVaDungTenBN] = N'" + txtCoVongDeoTayVaDungTenBN.Text + "'" +
",[DanhDauVetMo] = N'" + txtDanhDauVetMo.Text + "'" +
",[BienBanHoiChuanCoChuKy] = N'" + txtBienBanHoiChanCoChuKyDayDu.Text + "'" +
" ,[GiayCamKetMoCoChuKyDayDu] = N'" + txtGiayCamKetMoCoChuKyDayDu.Text + "'" +
",[GiayCamKetGayMeCoChuKyDayDu] = N'" + txtGiayCamKetGayMeCoChuKyDayDu.Text + "'" +
",[PhieuKhamTienMe] = N'" + txtPhieuKhamTienMe.Text + "'" +
",[TrangSucDaDuocThao] = N'" + txtTrangSucDaDuocThao.Text + "'" +
 " ,[MongTayMongChanKhongCoSonRangLungLayVaTocDuocKT] = N'" + txtMongTay_MongChan.Text + "'" +
 " ,[QuanAoMoSachVaThichHop] = N'" + txtQuanAoMoSachVaThicHop.Text + "'" +
" ,[ThucAnDacBiet] = '" + cbThucAnDacBiet.Checked + "'" +
",[ThucAnLong] = '" + cbThucAnLong.Checked + "'" +
",[Nuoc] ='" + cbNuoc.Checked + "'" +
 ",[ThoiDiemAnLanCuoi] = N'" + txtThoiDiemAnLanCuoi.Text + "'" +
",[GhiNhanCanNangHienTai] = N'" + txtGhiNhanCanNangHienTai.Text + "'" +
",[KimLuon] = N'" + txtKimLuon_ViTri.Text + "'" +
",[DichTruyenVaTocDoChayThicHop_Loai] =N'" + txtDichTruyenVaTocDoChayThichHop_Loai.Text + "'" +
",[DichTruyenVaTocDoChayThicHop_TocDo] = N'" + txtDichTruyenVaTocDoChayThichHop_TocDo.Text + "'" +
",[SLDichTruyenConLai] = N'" + txtSLDichTruyenConLai.Text + "'" +
",[TongPhanTichTeBao] = N'" + txtTongPhanTichTeBao.Text + "'" +
",[ChucNangDongMau] = N'" + txtChucNangDongDongMau.Text + "'" +
",[ChucNangGan] = N'" + txtChucNangGan.Text + "'" +
",[ChucNangThan] = N'" + txtChucNangThan.Text + "'" +
",[IonDo] = N'" + txtI_onDo.Text + "'" +
",[NhomMau] = N'" + txtNhomMau.Text + "'" +
",[XetNghiemKhac] = N'" + txtXetNghiemKhac.Text + "'" +
",[DangKyMau] = N'" + txtSoLuong_DangKyMau.Text + "'" +
" ,[LoaiPhim] ='" + cboLoai_Phim.SelectedValue + "'" +
",[SoLuongPhim] = N'" + txtSoLuong_Phim.Text + "'" +
 "WHERE SoHoSo = '" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);




        }



        private void suabang4()
        {

            msql = " UPDATE [dbo].[tbl_BangKiemAnToanPTVaSauPT]"+
         "SET[DaKiemTraTen_Tuoi_GioiTinh_LoaiPhauThuat_ViTriPTChua] = '" + cbCoGayMe_1.Checked + "'" +
        ",[ViTriPTDaDuocDanhDauChua] = '" + cbCoGayMe_2.Checked + "'" +
         ",[MayGayMeVaThuocDaDuocKTHaonTatChua] = '" + cbCoGayMe_3.Checked + "'" +
          ",[MayDoDoBaoHoaOxyDaGanVaoBNVaHoatDongChua] = '" + cbCoGayMe_4.Checked + "'" +
           ",[DiUngDaBiet] = N'" + cbCoGayMe5_1.Checked + "'" +
            ",[DatNKQKhoHoacNguyCoHitSac] = N'" + cbCoGayMe5_2.Checked + "'" +
             ",[NguyCoMatHon500mlmau] = '" + cbCoGayMe5_3.Checked + "'" +
              ",[XacDinhLaiCacThanhVienEkipPhauThuat_MoiNguoiTuGioiThieuTenVaVaiTroCuaMinh] = '" + cbCoRachDa1.Checked + "'" +
        ",[DocTenBN] = '" + cbCoRachDa2_1.Checked + "'" +
         ",[ChuanDoanBNVaPPDieuTri] = '" + cbCoRachDa2_2.Checked + "'" +
          ",[DaCoDinhBN] =N'" + cbCoRachDa3.Checked + "'" +
           ",[DaXacDinhRachDa] = '" + cbCoRachDa4.Checked + "'" +
            ",[DaKTVeKhangSinhDuPhong] = '" + cbCoRachDa5.Checked + "'" +
             ",[DaKTViecTraVaDanVungMatChoBN] ='" + cbCoRachDa6.Checked + "'" +
",[DaNoiCacNguyCoCoTheXayRaTrongPTNay] = '" + cbCoRachDa7_PT.Checked + "'" +
 ",[ThoiGianDuKien] = '" +   Convert.ToDateTime(dtpThoiGianDuKien.Value).ToString("yyyy-MM-dd") + "'" +
  ",[DuKienLuongMauMat] = '" + txtDuKiebnLuongMauMat.Text + "'" +
   ",[GayMe_DaNoiNguyCoTheChoEkipNghe] ='" + cbCoRachDa7_GayMe.Checked + "'" +
    " ,[DamBaoVanDeVoTrungPT] = '" + cbCoRachDa7_DieuDuong1.Checked + "'" +
     ",[DungCuPT] = '" + cbCoRachDa7_DieuDuong2.Checked + "'" +
      ",[DaTreoPhimLenBangDien] ='" + cbCoRachDa7_TreoPhimLenBangDien.Checked + "'" +
       ",[DaDanTamDienCuc] =  '" + cbCoRachDa7_DaDanTamDienCuc.Checked + "'" +
        ",[TenPhauThuatVuaThucHien] = '" + cbCoRachDa7_DaDanTamDienCuc.Checked + "'" +
         ",[HoanTatDiemDungCu_Gac_KimDayDu] ='" + cbCoPhongMo1_TenPhauThuatVuaThucHien.Checked + "'" +
          ",[PTV_BSGayMeVaDieuDuongDaLuuYCacVanDeSauKhiTinhMeVaChamSocBNNay] = '" + cbCoPhongMo2.Checked + "'" +
           ",[ViTriPTDaDuocDanhDauChua_KAD] = '" + cbKhongGayMe_2.Checked + "'" +
             ",[DatNKQKhoHoacNguyCoHitSac_Khong] = '" + cbKhongGayMe5_2.Checked + "'" +
              ",[NguyCoMatHon500mlmau_Khong] = '" + cboKhongGayMe5_3.Checked + "'" +
" ,[DaCoDinhBN_KAD] = '" + cbKhongRachDa3.Checked + "'" +
 ",[DaKTVeKhangSinhDuPhong_KAD] ='" + cbKhongRachDa5.Checked + "'" +
  ",[DamBaoVanDeVoTrungPT_KAD] = '" + cbKhongRachDa7_DieuDuong1.Checked + "'" +
   ",[DaTreoPhimLenBangDien_KAD] = '" + cbKhongRachDa7_TreoPhimLenBangDien.Checked + "'" +
    " ,[DaDanTamDienCuc_KAD] = '" + cbKhongRachDa7_DaDanTamDienCuc.Checked + "'" +
       ",[TenPhauThuatVuaThucHien_KAD] = '" + cbKhongPhonMo1_TenPhauThuatVuaThucHien2.Checked + "'" +
"WHERE SoHoSo = '" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);






        }





    








     
        private void btnLuu_Click(object sender, EventArgs e)
        {
           

        }
        private void xoabang2()
        {
            msql = "DELETE FROM[dbo].[tbl_ChuanbiBN_PM] where SoHoSo ='" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        private void xoabang3()
        {

          
            

            msql = "DELETE FROM[dbo].[tbl_ChuanbiBN_PM_Ghichu]  where SoHoSo ='" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);

        }
        private void xoabang4()
        {



            msql = "DELETE FROM[dbo].[tbl_BangKiemAnToanPTVaSauPT]  where SoHoSo ='" + txtSoHoSo.Text + "'";
            comm.RunSQL(mconnectstring, msql);


        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void dgvDanhSachBN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvDanhSachBN["cXoa", e.RowIndex] == dgvDanhSachBN.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa số hồ sơ " + dgvDanhSachBN.CurrentRow.Cells["cSoHoSo"].Value.ToString() + " này không ?"))
                {
                    //msql = "delete FROM [dbo].[tbl_ThongTinBN] where SoHoSo= '" + dgvDanhSachBN.CurrentRow.Cells["cSoHoSo"].Value.ToString() + "'";
                    //comm.RunSQL(mconnectstring, msql);
                    xoabang2();
                    xoabang3();
                    xoabang4();
                    LoadData();
                }
            }

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            xoabang2();
            xoabang3();
            xoabang4();
            LoadData();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            //thembang1();
            //thembang2();
            //thembang3();
            //thembang4();

            if (txtSoHoSo.Text.Trim() != "")
            {
                thembang1();
                thembang2();
                thembang3();
                thembang4();
                LoadData();
            }
            else
            {
                ev.QFrmThongBaoError("Lỗi chưa có số hồ sơ");
                txtSoHoSo.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suabang1();
            suabang2();
            suabang3();
            suabang4();
            LoadData();
        }

        private void txtTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoHoSo);

        }

        private void txtTenBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);

        }

        private void txtTenBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);

        }

        private void txtChuanDoan_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);

        }

        private void txtChuanDoan_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);

        }

        private void txtChuanDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPPPhauThuat);

        }
       

        private void txtPPPhauThuat_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtPPPhauThuat_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);

        }

        private void txtPPPhauThuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuu);

        }

        private void txtSoHoSo_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);

        }

        private void txtSoHoSo_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);

        }

        private void txtSoHoSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtChuanDoan);

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            Report_BangKiemChuanBiBNChuyenPhongMo R = new Report_BangKiemChuanBiBNChuyenPhongMo();
            R.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    msql = "SELECT * FROM [APP_REPORT].[dbo].[tbl_ThongTinBN] AS A,[dbo].[tbl_ChuanbiBN_PM] AS B,[dbo].[tbl_ChuanbiBN_PM_GhiChu] AS C,[dbo].[tbl_BangKiemAnToanPTVaSauPT] AS D WHERE A.SoHoSo=B.SoHoSo AND B.SoHoSo=C.SoHoSo AND C.SoHoSo=D.SoHoSo";
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "nhanvien");
        //    tb.WriteXmlSchema(@"D:\rp1.xsd", true);
        //}


    }
}
