using BusinessCommon;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class RpPhieuKhamTienMe : Form
    {
        private string mconnectstring = "server=.;database = ITTT; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        ReportDocument BaoCao = new ReportDocument();
        public RpPhieuKhamTienMe()
        {
            InitializeComponent();
            LoadRP();
            
        }
        private void LoadRP()
        {
            msql = "SELECT * FROM [dbo].[tabThongTinBenhNhan] as A,[dbo].[tabKhamLamSang] as B,[dbo].[tabPhieuKhamTienMe] as C,[dbo].[tabMaBS] as BS,[dbo].[tabMACHUYENKHOA] AS KHOA,[dbo].[tabCDSPK] AS CHUANDOAN, [dbo].[tabPhuongPhapPhauThuat] AS PHAUTHUAT, [dbo].[tabMABENH] AS BENH, [dbo].[tabDanhMucThuoc] AS THUOC,[dbo].[tabGioiTinh] AS GIOITINH,[dbo].[XN_tabKieuXN] AS XN, [dbo].[tabDichTruyen] AS DICHTRUYEN,[dbo].[tabNhomMau] AS MAU WHERE A.SoVaoVien = '" + PhieuKhamTienMe.a+"' AND A.SoVaoVien = B.SoVaoVien AND A.SoVaoVien = C.SoVaoVien AND C.BSKhamTienMe = BS.MABACSI AND A.Khoa = KHOA.TENTAT AND A.ChuanDoan = CHUANDOAN.MaChanDoan AND A.PhuongPhapPhauThuat = PHAUTHUAT.TenTat AND A.BenhDangDieuTri = BENH.MaBenh AND A.GioiTinh = GIOITINH.IDGioiTinh AND B.XNDeNghi = XN.Type AND C.DichTruyen = DICHTRUYEN.MaDichTruyen AND C.ThuocTienMe = THUOC.MaThuoc AND c.NhomMau = mau.MaNhomMau ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuKhamTienMe");
            BaoCao.Load(Application.StartupPath + @"\PhieuKhamTienMe.rpt");
            BaoCao.SetDataSource(tb);
            cRPPhieuKhamTienMe.ReportSource = BaoCao;
        }
    }
}
