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
    public partial class Report_BangKiemChuanBiBNChuyenPhongMo : Form
    {
        private string mconnectstring = "server=.;database = APP_REPORT ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        ReportDocument BaoCao = new ReportDocument();
        public Report_BangKiemChuanBiBNChuyenPhongMo()
        {
            InitializeComponent();
            Report();
        }

        private void Report()
        {
            msql = "SELECT * FROM [APP_REPORT].[dbo].[tbl_ThongTinBN] AS A,[dbo].[tbl_ChuanbiBN_PM] AS B,[dbo].[tbl_ChuanbiBN_PM_GhiChu] AS C,[dbo].[tbl_BangKiemAnToanPTVaSauPT] AS D WHERE A.SoHoSo=B.SoHoSo AND B.SoHoSo=C.SoHoSo AND C.SoHoSo=D.SoHoSo";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhieuAnToanPhauThuat");
            BaoCao.Load(Application.StartupPath + @"\Phieuantoanphauthuat.rpt");
            BaoCao.SetDataSource(tb);
            crv_Report_BangKiemChuanBiBNChuyenPhongMo.ReportSource = BaoCao;
        }

    }
}
