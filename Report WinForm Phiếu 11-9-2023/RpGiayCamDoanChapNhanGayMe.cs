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
    public partial class RpGiayCamDoanChapNhanGayMe : Form
    {
        private string mconnectstring = "server=.;database = GiayCamDoanChapNhanGayMeHoiSuc; uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public RpGiayCamDoanChapNhanGayMe()
        {
            InitializeComponent();
            loadRP();
        }
        private void loadRP()
        {
            msql = "SELECT * FROM [dbo].[tbl_GiayCamDoanChapNhanGayMeHoiSuc] where IDPhieuChapNhanGayMe='"+GiayCamDoanChapNhanGayMeHoiSuc.IDPhieuChapNhanGayMe +"'";
            DataTable phieu = comm.GetDataTable(mconnectstring, msql, "tbl_GiayCamDoanChapNhanGayMeHoiSuc");
            BaoCao.Load(Application.StartupPath + @"\PhieuChapNhanGayMe1409.rpt");
            BaoCao.SetDataSource(phieu);
            crysPhieuChapNhanGayMe.ReportSource = BaoCao;
        }
    }
}
