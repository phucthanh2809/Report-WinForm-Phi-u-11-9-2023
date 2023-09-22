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
    public partial class PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau : Form
    {
        private string mconnectstring = "server=.;database = ITTT; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau()
        {
            InitializeComponent();
            LoadCbo();
            LoaddgrDanhSachBN();
        }
        //Load Combobox
        private void LoadCbo()
        {
            //cboChuẩn đoán
            msql = "SELECT * FROM [dbo].[tabPhuongPhapPhauThuat]";
            DataTable PPPT = comm.GetDataTable(mconnectstring, msql, "tabPhuongPhapPhauThuat");
            cboPT.DataSource = PPPT.Copy();
            cboPT.DisplayMember = "TenPhuongPhapPhauThuat";
            cboPT.ValueMember = "TenTat";
            cboPT.CustomAlignment = new string[] { "l", "l" };
            cboPT.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT * FROM [dbo].[tabBenhVien]";
            DataTable BenhVien = comm.GetDataTable(mconnectstring, msql, "tabBenhVien");
            cboBV.DataSource = BenhVien.Copy();
            cboBV.DisplayMember = "TenBenhVien";
            cboBV.ValueMember = "MaBenhVien";
            cboBV.CustomAlignment = new string[] { "l", "l" };
            cboBV.CustomColumnStyle = new string[] { "t", "t" };
        }
        //Load GridView
        private void LoaddgrDanhSachBN()
        {
            msql = "SELECT * FROM [dbo].[PhieuThamKhaoBenhNhanTruocKhiGayMeGiaiPhau]";
            DataTable DanhSachBN = comm.GetDataTable(mconnectstring, msql, "PhieuThamKhaoBenhNhanTruocKhiGayMeGiaiPhau");
            dgrDanhSachBN.AutoGenerateColumns = false;
            dgrDanhSachBN.DataSource = DanhSachBN;
        }
        //Reset form 
        private void ResetForm()
         {
            // Clear textboxes  
            txtTenBenNhan.Text = string.Empty;
            txtTuoi.Text = string.Empty;
            txtCanNang.Text = string.Empty;
            txtChieuCao.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtVanDeSauSanh.Text = string.Empty;
            txtDiUngThuoc.Text = string.Empty;
            txtLyDoNamVien.Text = string.Empty;
            txtDaDuocDieuTri.Text = string.Empty;
            txtNeuRoBenhTim.Text = string.Empty;
            txtXinNeuRoDungThuoc.Text = string.Empty;
            txtKhangSinhTT.Text = string.Empty;
            txtKhangSinhLD.Text = string.Empty;
            txtChongViemTT.Text = string.Empty;
            txtChongViemLD.Text = string.Empty;
            txtHaSotTT.Text = string.Empty;
            txtHaSotLD.Text = string.Empty;
            txtThuocKhacTT.Text = string.Empty;
            txtThuocKhacLD.Text = string.Empty;
            txtVanDeKhac.Text = string.Empty;

            //Radio
            rdCoSauSanh.Checked = false;
            rdKhongSauSanh.Checked = false;
            rdKhongBietSauSanh.Checked = false;
            rdCoGiaiPhau.Checked = false;
            rdKhongGiaiPhau.Checked = false;
            rdKhongBietGiaiPhau.Checked = false;
            rdCoSuyen.Checked = false;
            rdKhongSuyen.Checked = false;
            rdKhongBietSuyen.Checked = false;
            rdCoChamMeDayNguaNgoaiDa.Checked = false;
            rdKhongChamMeDayNguaNgoaiDa.Checked = false;
            rdKhongBietChamMeDayNguaNgoaiDa.Checked = false;
            rdCoDiUngThuocThucPham.Checked = false;
            rdKhongDiUngThuocThucPham.Checked = false;
            rdKhongBietDiUngThuocThucPham.Checked = false;
            rdCoBienChungGayMe.Checked = false;
            rdKoBienChungGayMe.Checked = false;
            rdKoBietBienChungGayMe.Checked = false;
            rdCoNamVien.Checked = false;
            rdKoNamVien.Checked = false;
            rdKoBietNamVien.Checked = false;
            rdCoSotCaoCoGiat.Checked = false;
            rdKoSotCaoCoGiat.Checked = false;
            rdKoBietSotCaoCoGiat.Checked = false;
            rdCoDongKinh.Checked = false;
            rdKoDongKinh.Checked = false;
            rdKoBietDongKinh.Checked = false;
            rdCoChayMauCam.Checked = false;
            rdKhongChayMauCam.Checked = false;
            rdKhongBietChayMauCam.Checked = false;
            rdCoAnhEmHo.Checked = false;
            rdKhongAnhEmHo.Checked = false;
            rdKhongBietAnhEmHo.Checked = false;
            rdCoMacBenhTim.Checked = false;
            rdKhongMacBenhTim.Checked = false;
            rdKhongBietMacBenhTim.Checked = false;
            rdCoTruyenMau.Checked = false;
            rdKhongTruyenMau.Checked = false;
            rdKhongBietTruyenMau.Checked = false;
            rdCoDungThuoc.Checked = false;
            rdKhongDungThuoc.Checked = false;
            rdKhongBietDungThuoc.Checked = false;
            rdCoDungThuoc15Ngay.Checked = false;
            rdKhongDungThuoc15Ngay.Checked = false;
            rdKhongBietDungThuoc15Ngay.Checked = false;

            //Datetime
            dtNgayMo.Value = DateTime.Now;
            dtNgayThangNam.Value = DateTime.Now;

        }
    //GroupBox radio button
    private string RdVanDeSauSanh()
        {
            if (rdCoSauSanh.Checked)
            {
                return "1";
            }
            else if (rdKhongSauSanh.Checked)
            {
                return "0";
            }
            else if (rdKhongBietSauSanh.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty; 
            }
        }
        private string RdGiaiPhau()
        {
            if (rdCoGiaiPhau.Checked)
            {
                return "1";
            }
            else if (rdKhongGiaiPhau.Checked)
            {
                return "0";
            }
            else if (rdKhongBietGiaiPhau.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string RdSuyen()
        {
            if (rdCoSuyen.Checked)
            {
                return "1";
            }
            else if (rdKhongSuyen.Checked)
            {
                return "0";
            }
            else if (rdKhongBietSuyen.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdChamMeDayNguaNgoaiDa()
        {
            if (rdCoChamMeDayNguaNgoaiDa.Checked)
            {
                return "1";
            }
            else if (rdKhongChamMeDayNguaNgoaiDa.Checked)
            {
                return "0";
            }
            else if (rdKhongBietChamMeDayNguaNgoaiDa.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdDiUngThuocThucPham()
        {
            if (rdCoDiUngThuocThucPham.Checked)
            {
                return "1";
            }
            else if (rdKhongDiUngThuocThucPham.Checked)
            {
                return "0";
            }
            else if (rdKhongBietDiUngThuocThucPham.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdBienChungGayMe()
        {
            if (rdCoBienChungGayMe.Checked)
            {
                return "1";
            }
            else if (rdKoBienChungGayMe.Checked)
            {
                return "0";
            }
            else if (rdKoBietBienChungGayMe.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdNamVien()
        {
            if (rdCoNamVien.Checked)
            {
                return "1";
            }
            else if (rdKoNamVien.Checked)
            {
                return "0";
            }
            else if (rdKoBietNamVien.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdSotCaoCoGiat()
        {
            if (rdCoSotCaoCoGiat.Checked)
            {
                return "1";
            }
            else if (rdKoSotCaoCoGiat.Checked)
            {
                return "0";
            }
            else if (rdKoBietSotCaoCoGiat.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdDongKinh()
        {
            if (rdCoDongKinh.Checked)
            {
                return "1";
            }
            else if (rdKoDongKinh.Checked)
            {
                return "0";
            }
            else if (rdKoBietDongKinh.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdChayMauCam()
        {
            if (rdCoChayMauCam.Checked)
            {
                return "1";
            }
            else if (rdKhongChayMauCam.Checked)
            {
                return "0";
            }
            else if (rdKhongBietChayMauCam.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdAnhEmHo()
        {
            if (rdCoAnhEmHo.Checked)
            {
                return "1";
            }
            else if (rdKhongAnhEmHo.Checked)
            {
                return "0";
            }
            else if (rdKhongBietAnhEmHo.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdMacBenhTim()
        {
            if (rdCoMacBenhTim.Checked)
            {
                return "1";
            }
            else if (rdKhongMacBenhTim.Checked)
            {
                return "0";
            }
            else if (rdKhongBietMacBenhTim.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdTruyenMau()
        {
            if (rdCoTruyenMau.Checked)
            {
                return "1";
            }
            else if (rdKhongTruyenMau.Checked)
            {
                return "0";
            }
            else if (rdKhongBietTruyenMau.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdDungThuoc()
        {
            if (rdCoDungThuoc.Checked)
            {
                return "1";
            }
            else if (rdKhongDungThuoc.Checked)
            {
                return "0";
            }
            else if (rdKhongBietDungThuoc.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        private string rdDungThuoc15Ngay()
        {
            if (rdCoDungThuoc15Ngay.Checked)
            {
                return "1";
            }
            else if (rdKhongDungThuoc15Ngay.Checked)
            {
                return "0";
            }
            else if (rdKhongBietDungThuoc15Ngay.Checked)
            {
                return "2";
            }
            else
            {
                return string.Empty;
            }
        }
        //Thêm Thông tin Phiếu 

        private void ThemThongTinPhieu()
        {
            string VanDeSauSanh = RdVanDeSauSanh();
            string GiaiPhau = RdGiaiPhau();
            string Suyen = RdSuyen();
            string ChamMeDayNguaNgoaiDa = rdChamMeDayNguaNgoaiDa();
            string DiUngThuocThucPham = rdDiUngThuocThucPham();
            string BienChungGayMe = rdBienChungGayMe();
            string NamVien = rdNamVien();
            string SotCaoCoGiat = rdSotCaoCoGiat();
            string DongKinh = rdDongKinh();
            string ChayMauCam = rdChayMauCam();
            string AnhEmHo = rdAnhEmHo();
            string MacBenhTim = rdMacBenhTim();
            string TruyenMau = rdTruyenMau();
            string DungThuoc = rdDungThuoc();
            string DungThuoc15Ngay = rdDungThuoc15Ngay();

            msql = "INSERT INTO [dbo].[PhieuThamKhaoBenhNhanTruocKhiGayMeGiaiPhau] " +
                   "([HoTenBN],[Tuoi],[CanNang],[ChieuCao],[DiaChi],[VanDeSauSanh],[TenVanDeSauSanh],[DaGayMeGiaiPhau],[NgayMoGayMeGiaiPhau],[PhauThuatGayMeGiaiPhau],[BenhVienGayMeGiaiPhau],[Suyen],[ChamNoiMeDayNguaNgoaiDa],[DiUngThuocThucPham],[TenDiUngThuocThucPham],[BienChungHoHangGayMeGiaiPhau],[DaNamVien],[LiDoNamVien],[SotCaoCoGiat],[DongKinh],[DaDieuTriDongKinh],[ChayMauCamhChayMauKeoDaihBamTimChanThuong],[AnhEmHoRuotBiChayMauKeoDai],[TimBamSinhhViemPheQuanhVangDahBenhThan],[NeuRoTimBamSinhhViemPheQuanhVangDahBenhThan],[DaTungTruyenMau],[DungThuocThuongXuyen],[NeuRoThuocDungThuongXuyen],[ThuocDungHienTaiTu15NgayTroLai],[TenThuocKhangSinh],[LieuDungKhangSinh],[TenThuocChongViem],[LieuDungChongViem],[TenThuocHaSotGiamDau],[LieuDungHaSotGiamDau],[TenThuocThuocKhac],[LieuDungThuocKhac],[LuuYChoBSGayMeHoiSuc],[NgayThangNam])" +
                   "VALUES (N'" + txtTenBenNhan.Text + "','" + txtTuoi.Text + "','" + txtCanNang.Text + "','" + txtChieuCao.Text + "',N'" + txtDiaChi.Text + "','" + VanDeSauSanh + "',N'" + txtVanDeSauSanh.Text + "','" + GiaiPhau + "','" + Convert.ToDateTime(dtNgayMo.Value).ToString("yyyy-MM-dd") + "','" + cboPT.SelectedValue + "','"+cboBV.SelectedValue+ "','"+Suyen+ "','" + ChamMeDayNguaNgoaiDa + "','" + DiUngThuocThucPham + "',N'" + txtDiUngThuoc.Text + "','"+ BienChungGayMe + "','" + NamVien + "',N'" + txtLyDoNamVien.Text + "','" + SotCaoCoGiat + "','" + DongKinh + "',N'" + txtDaDuocDieuTri.Text + "'," +
                   "'"+ ChayMauCam + "','"+ AnhEmHo + "','" + MacBenhTim + "',N'" + txtNeuRoBenhTim.Text + "','" + TruyenMau + "','" + DungThuoc + "',N'" + txtXinNeuRoDungThuoc.Text + "','" + DungThuoc15Ngay + "',N'" + txtKhangSinhTT.Text + "',N'" + txtKhangSinhLD.Text + "',N'" + txtChongViemTT.Text + "',N'" + txtChongViemLD.Text + "',N'" + txtHaSotTT.Text + "',N'" + txtHaSotLD.Text + "',N'" + txtThuocKhacTT.Text + "',N'" + txtThuocKhacLD.Text + "',N'" + txtVanDeKhac.Text + "','" + Convert.ToDateTime(dtNgayThangNam.Value).ToString("yyyy-MM-dd") + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        private void SuaThongTinPhieu()
        {
            string VanDeSauSanh = RdVanDeSauSanh();
            string GiaiPhau = RdGiaiPhau();
            string Suyen = RdSuyen();
            string ChamMeDayNguaNgoaiDa = rdChamMeDayNguaNgoaiDa();
            string DiUngThuocThucPham = rdDiUngThuocThucPham();
            string BienChungGayMe = rdBienChungGayMe();
            string NamVien = rdNamVien();
            string SotCaoCoGiat = rdSotCaoCoGiat();
            string DongKinh = rdDongKinh();
            string ChayMauCam = rdChayMauCam();
            string AnhEmHo = rdAnhEmHo();
            string MacBenhTim = rdMacBenhTim();
            string TruyenMau = rdTruyenMau();
            string DungThuoc = rdDungThuoc();
            string DungThuoc15Ngay = rdDungThuoc15Ngay();
            msql = "UPDATE [dbo].[PhieuThamKhaoBenhNhanTruocKhiGayMeGiaiPhau]" +
                   "SET [HoTenBN] = N'" + txtTenBenNhan.Text + "',[Tuoi] = '" + txtTuoi.Text + "',[CanNang] = '" + txtCanNang.Text + "',[ChieuCao] = '" + txtChieuCao.Text + "',[DiaChi] = N'" + txtDiaChi.Text + "',[VanDeSauSanh] = '" + VanDeSauSanh + "',[TenVanDeSauSanh] = N'" + txtVanDeSauSanh.Text + "',[DaGayMeGiaiPhau] = '" + GiaiPhau + "',[NgayMoGayMeGiaiPhau] = '" + Convert.ToDateTime(dtNgayMo.Value).ToString("yyyy-MM-dd") + "',[PhauThuatGayMeGiaiPhau] = '" + cboPT.SelectedValue + "',[BenhVienGayMeGiaiPhau] = '" + cboBV.SelectedValue + "',[Suyen] = '" + Suyen + "',[ChamNoiMeDayNguaNgoaiDa] = '" + ChamMeDayNguaNgoaiDa + "',[DiUngThuocThucPham] = '" + DiUngThuocThucPham + "',[TenDiUngThuocThucPham] = N'" + txtDiUngThuoc.Text + "',[BienChungHoHangGayMeGiaiPhau] = '" + BienChungGayMe + "',[DaNamVien] = '" + NamVien + "',[LiDoNamVien] = N'" + txtLyDoNamVien.Text + "'," +
                   "[SotCaoCoGiat] = '" + SotCaoCoGiat + "',[DongKinh] = '" + DongKinh + "',[DaDieuTriDongKinh] = N'" + txtDaDuocDieuTri.Text + "',[ChayMauCamhChayMauKeoDaihBamTimChanThuong] = '" + ChayMauCam + "',[AnhEmHoRuotBiChayMauKeoDai] = '" + AnhEmHo + "',[TimBamSinhhViemPheQuanhVangDahBenhThan] = '" + MacBenhTim + "',[NeuRoTimBamSinhhViemPheQuanhVangDahBenhThan] = N'" + txtNeuRoBenhTim.Text + "',[DaTungTruyenMau] = '" + TruyenMau + "',[DungThuocThuongXuyen] = '" + DungThuoc + "',[NeuRoThuocDungThuongXuyen] = N'" + txtXinNeuRoDungThuoc.Text + "',[ThuocDungHienTaiTu15NgayTroLai] = '" + DungThuoc15Ngay + "',[TenThuocKhangSinh] = N'" + txtKhangSinhTT.Text + "',[LieuDungKhangSinh] = N'" + txtKhangSinhLD.Text + "',[TenThuocChongViem] = N'" + txtChongViemTT.Text + "',[LieuDungChongViem] = N'" + txtChongViemLD.Text + "',[TenThuocHaSotGiamDau] = N'" + txtHaSotTT.Text + "'," +
                   "[LieuDungHaSotGiamDau] = N'" + txtHaSotLD.Text + "',[TenThuocThuocKhac] = N'" + txtThuocKhacTT.Text + "',[LieuDungThuocKhac] = N'" + txtThuocKhacLD.Text + "',[LuuYChoBSGayMeHoiSuc] = N'" + txtVanDeKhac.Text + "',[NgayThangNam] = '" + Convert.ToDateTime(dtNgayThangNam.Value).ToString("yyyy-MM-dd") + "'WHERE MaPhieuThamKhaoBNTruocKhiGayMeGiaiPhau = '" + txtMaPhieu.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtTenBenNhan.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi thêm nhé! ^-^"))
                {
                    ThemThongTinPhieu();
                    ev.QFrmThongBao("Đã lưu thành công");
                    ResetForm();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ^-^");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập đầy đủ thông tin");
            txtTenBenNhan.Focus();
            
        }
        private void rdCoGiaiPhau_CheckedChanged(object sender, EventArgs e)
        {
            dtNgayMo.Visible = true;
            cboPT.Visible = true;
            cboBV.Visible = true;
        }

        private void rdKhongGiaiPhau_CheckedChanged(object sender, EventArgs e)
        {
            dtNgayMo.Visible = false;
            cboPT.Visible = false;
            cboBV.Visible = false;
        }

        private void rdKhongBietGiaiPhau_CheckedChanged(object sender, EventArgs e)
        {
            dtNgayMo.Visible = false;
            cboPT.Visible = false;
            cboBV.Visible = false;
        }

        private void rdCoDiUngThuocThucPham_CheckedChanged(object sender, EventArgs e)
        {
            txtDiUngThuoc.Visible = true;
        }

        private void rdKhongDiUngThuocThucPham_CheckedChanged(object sender, EventArgs e)
        {
            txtDiUngThuoc.Visible = false;
        }

        private void rdKhongBietDiUngThuocThucPham_CheckedChanged(object sender, EventArgs e)
        {
            txtDiUngThuoc.Visible = false;
        }

        private void rdCoNamVien_CheckedChanged(object sender, EventArgs e)
        {
            txtLyDoNamVien.Visible = true;
        }

        private void rdKoNamVien_CheckedChanged(object sender, EventArgs e)
        {
            txtLyDoNamVien.Visible = false;
        }

        private void rdKoBietNamVien_CheckedChanged(object sender, EventArgs e)
        {
            txtLyDoNamVien.Visible = false;
        }

        private void rdCoDongKinh_CheckedChanged(object sender, EventArgs e)
        {
            txtDaDuocDieuTri.Visible = true;
        }

        private void rdKoDongKinh_CheckedChanged(object sender, EventArgs e)
        {
            txtDaDuocDieuTri.Visible = false;
        }

        private void rdKoBietDongKinh_CheckedChanged(object sender, EventArgs e)
        {
            txtDaDuocDieuTri.Visible = false;
        }

        private void rdCoSauSanh_CheckedChanged(object sender, EventArgs e)
        {
            txtVanDeSauSanh.Visible = true;
        }

        private void rdKhongSauSanh_CheckedChanged(object sender, EventArgs e)
        {
            txtVanDeSauSanh.Visible = false;
        }

        private void rdKhongBietSauSanh_CheckedChanged(object sender, EventArgs e)
        {
            txtVanDeSauSanh.Visible = false;
        }
        private void dgrDanhSachBN_MouseLeave(object sender, EventArgs e)
        {
            dgrDanhSachBN.Visible = false;
        }

        private void btnDanhSachBN_Click(object sender, EventArgs e)
        {
            dgrDanhSachBN.Visible = true;
        }

        private void dgrDanhSachBN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachBN);
        }

        private void dgrDanhSachBN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;         

            //Textbox
            txtMaPhieu.Text = dgrDanhSachBN.CurrentRow.Cells["cMaPhieu"].Value.ToString();
            txtTenBenNhan.Text = dgrDanhSachBN.CurrentRow.Cells["cTenBN"].Value.ToString();
            txtTuoi.Text = dgrDanhSachBN.CurrentRow.Cells["cTuoi"].Value.ToString();
            txtCanNang.Text = dgrDanhSachBN.CurrentRow.Cells["cCanNang"].Value.ToString();
            txtChieuCao.Text = dgrDanhSachBN.CurrentRow.Cells["cChieuCao"].Value.ToString();
            txtDiaChi.Text = dgrDanhSachBN.CurrentRow.Cells["cDiaChi"].Value.ToString();
            txtVanDeSauSanh.Text = dgrDanhSachBN.CurrentRow.Cells["cTenVanDeSauSanh"].Value.ToString();
            txtDiUngThuoc.Text = dgrDanhSachBN.CurrentRow.Cells["cTenDiUngThuocThucPham"].Value.ToString();
            txtLyDoNamVien.Text = dgrDanhSachBN.CurrentRow.Cells["cLiDoNamVien"].Value.ToString();
            txtDaDuocDieuTri.Text = dgrDanhSachBN.CurrentRow.Cells["cDaDieuTriDongKinh"].Value.ToString();
            txtNeuRoBenhTim.Text = dgrDanhSachBN.CurrentRow.Cells["cNeuRoTimBamSinhhViemPheQuanhVangDahBenhThan"].Value.ToString();
            txtXinNeuRoDungThuoc.Text = dgrDanhSachBN.CurrentRow.Cells["cNeuRoThuocDungThuongXuyen"].Value.ToString();
            txtKhangSinhTT.Text = dgrDanhSachBN.CurrentRow.Cells["cTenThuocKhangSinh"].Value.ToString();
            txtKhangSinhLD.Text = dgrDanhSachBN.CurrentRow.Cells["cLieuDungKhangSinh"].Value.ToString();
            txtChongViemTT.Text = dgrDanhSachBN.CurrentRow.Cells["cTenThuocChongViem"].Value.ToString();
            txtChongViemLD.Text = dgrDanhSachBN.CurrentRow.Cells["cLieuDungChongViem"].Value.ToString();
            txtHaSotTT.Text = dgrDanhSachBN.CurrentRow.Cells["cTenThuocHaSotGiamDau"].Value.ToString();
            txtHaSotLD.Text = dgrDanhSachBN.CurrentRow.Cells["cLieuDungHaSotGiamDau"].Value.ToString();
            txtThuocKhacTT.Text = dgrDanhSachBN.CurrentRow.Cells["cTenThuocThuocKhac"].Value.ToString();
            txtThuocKhacLD.Text = dgrDanhSachBN.CurrentRow.Cells["cLieuDungThuocKhac"].Value.ToString();
            txtVanDeKhac.Text = dgrDanhSachBN.CurrentRow.Cells["cLuuYChoBSGayMeHoiSuc"].Value.ToString();

            //Radio Button
            //rdSauSanh
            int SauSanh = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cVanDeSauSanh"].Value);
            if (SauSanh == 1)
            {
                rdCoSauSanh.Checked = true;
            }
            else if (SauSanh == 0)
            {
                rdKhongSauSanh.Checked = true;
            }
            else if (SauSanh == 2)
            {
                rdKhongBietSauSanh.Checked = true;
            }
            //rdGiaiPhau
            int GiaiPhau = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cGiaiPhau"].Value);
            if (GiaiPhau == 1)
            {
                rdCoGiaiPhau.Checked = true;
            }
            else if (GiaiPhau == 0)
            {
                rdKhongGiaiPhau.Checked = true;
            }
            else if (GiaiPhau == 2)
            {
                rdKhongBietGiaiPhau.Checked = true;
            }
            //rdSuyen
            int Suyen = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cSuyen"].Value);
            if (Suyen == 1)
            {
                rdCoSuyen.Checked = true;
            }
            else if (Suyen == 0)
            {
                rdKhongSuyen.Checked = true;
            }
            else if (Suyen == 2)
            {
                rdKhongBietSuyen.Checked = true;
            }
            //ChamMeDayNguaNgoaiDa
            int ChamMeDayNguaNgoaiDa = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cChamMeDayNguaNgoaiDa"].Value);
            if (ChamMeDayNguaNgoaiDa == 1)
            {
                rdCoChamMeDayNguaNgoaiDa.Checked = true;
            }
            else if (ChamMeDayNguaNgoaiDa == 0)
            {
                rdKhongChamMeDayNguaNgoaiDa.Checked = true;
            }
            else if (ChamMeDayNguaNgoaiDa == 2)
            {
                rdKhongBietChamMeDayNguaNgoaiDa.Checked = true;
            }

            //DiUngThuocThucPham
            int DiUngThuocThucPham = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cDiUngThuocThucPham"].Value);
            if (DiUngThuocThucPham == 1)
            {
                rdCoDiUngThuocThucPham.Checked = true;
            }
            else if (DiUngThuocThucPham == 0)
            {
                rdKhongDiUngThuocThucPham.Checked = true;
            }
            else if (DiUngThuocThucPham == 2)
            {
                rdKhongBietDiUngThuocThucPham.Checked = true;
            }
            //rdCoBienChungGayMe
            int BienChungGayMe = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cBienChungHoHangGayMeGiaiPhau"].Value);
            if (BienChungGayMe == 1)
            {
                rdCoBienChungGayMe.Checked = true;
            }
            else if (BienChungGayMe == 0)
            {
                rdKoBienChungGayMe.Checked = true;
            }
            else if (BienChungGayMe == 2)
            {
                rdKoBietBienChungGayMe.Checked = true;
            }
            //rdNamVien
            int NamVien = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cDaNamVien"].Value);
            if (NamVien == 1)
            {
                rdCoNamVien.Checked = true;
            }
            else if (NamVien == 0)
            {
                rdKoNamVien.Checked = true;
            }
            else if (NamVien == 2)
            {
                rdKoBietNamVien.Checked = true;
            }
            //rdSotCaoCoGiat
            int SotCaoCoGiat = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cSotCaoCoGiat"].Value);
            if (SotCaoCoGiat == 1)
            {
                rdCoSotCaoCoGiat.Checked = true;
            }
            else if (SotCaoCoGiat == 0)
            {
                rdKoSotCaoCoGiat.Checked = true;
            }
            else if (SotCaoCoGiat == 2)
            {
                rdKoBietSotCaoCoGiat.Checked = true;
            }
            //rdCoDongKinh
            int DongKinh = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cDongKinh"].Value);
            if (DongKinh == 1)
            {
                rdCoDongKinh.Checked = true;
            }
            else if (DongKinh == 0)
            {
                rdKoDongKinh.Checked = true;
            }
            else if (DongKinh == 2)
            {
                rdKoBietDongKinh.Checked = true;
            }
            //rdChayMauCam
            int ChayMauCam = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cChayMauCamhChayMauKeoDaihBamTimChanThuong"].Value);
            if (ChayMauCam == 1)
            {
                rdCoChayMauCam.Checked = true;
            }
            else if (ChayMauCam == 0)
            {
                rdKhongChayMauCam.Checked = true;
            }
            else if (ChayMauCam == 2)
            {
                rdKhongBietChayMauCam.Checked = true;
            }
            //rdAnhEmHo
            int AnhEmHo = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cAnhEmHoRuotBiChayMauKeoDai"].Value);
            if (AnhEmHo == 1)
            {
                rdCoAnhEmHo.Checked = true;
            }
            else if (AnhEmHo == 0)
            {
                rdKhongAnhEmHo.Checked = true;
            }
            else if (AnhEmHo == 2)
            {
                rdKhongBietAnhEmHo.Checked = true;
            }
            //rdMacBenhTim
            int MacBenhTim = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cTimBamSinhhViemPheQuanhVangDahBenhThan"].Value);
            if (MacBenhTim == 1)
            {
                rdCoMacBenhTim.Checked = true;
            }
            else if (MacBenhTim == 0)
            {
                rdKhongMacBenhTim.Checked = true;
            }
            else if (MacBenhTim == 2)
            {
                rdKhongBietMacBenhTim.Checked = true;
            }
            //rdTruyenMau
            int TruyenMau = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cDaTungTruyenMau"].Value);
            if (TruyenMau == 1)
            {
                rdCoTruyenMau.Checked = true;
            }
            else if (TruyenMau == 0)
            {
                rdKhongTruyenMau.Checked = true;
            }
            else if (TruyenMau == 2)
            {
                rdKhongBietTruyenMau.Checked = true;
            }
            //DungThuoc
            int DungThuoc = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cDungThuocThuongXuyen"].Value);
            if (DungThuoc == 1)
            {
                rdCoDungThuoc.Checked = true;
            }
            else if (DungThuoc == 0)
            {
                rdKhongDungThuoc.Checked = true;
            }
            else if (DungThuoc == 2)
            {
                rdKhongBietDungThuoc.Checked = true;
            }
            //rdDungThuoc15Ngay
            int DungThuoc15Ngay = Convert.ToInt32(dgrDanhSachBN.Rows[e.RowIndex].Cells["cThuocDungHienTaiTu15NgayTroLai"].Value);
            if (DungThuoc15Ngay == 1)
            {
                rdCoDungThuoc15Ngay.Checked = true;
            }
            else if (DungThuoc15Ngay == 0)
            {
                rdKhongDungThuoc15Ngay.Checked = true;
            }
            else if (DungThuoc15Ngay == 2)
            {
                rdKhongBietDungThuoc15Ngay.Checked = true;
            }

            //Combobox
            cboPT.SelectedValue = dgrDanhSachBN.CurrentRow.Cells["cPPPT"].Value.ToString();
            cboBV.SelectedValue = dgrDanhSachBN.CurrentRow.Cells["cBenhVienGayMeGiaiPhau"].Value.ToString();

            //datetime
            dtNgayMo.Text = dgrDanhSachBN.CurrentRow.Cells["cNgayMoGayMeGiaiPhau"].Value.ToString();
            dtNgayThangNam.Text = dgrDanhSachBN.CurrentRow.Cells["cNgayThangNam"].Value.ToString();



            //
            if (dgrDanhSachBN["cXoa", e.RowIndex] == dgrDanhSachBN.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa mã phiếu " + dgrDanhSachBN.CurrentRow.Cells["cMaPhieu"].Value.ToString() + " này không ?"))
                {
                    msql = "DELETE FROM [dbo].[PhieuThamKhaoBenhNhanTruocKhiGayMeGiaiPhau] WHERE MaPhieuThamKhaoBNTruocKhiGayMeGiaiPhau = '"+ dgrDanhSachBN.CurrentRow.Cells["cMaPhieu"].Value.ToString() + "'";
                    comm.RunSQL(mconnectstring, msql);
                    LoaddgrDanhSachBN();
                    ev.QFrmThongBao("Đã xóa phiếu thành công");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            SuaThongTinPhieu();
        }
    }
}
