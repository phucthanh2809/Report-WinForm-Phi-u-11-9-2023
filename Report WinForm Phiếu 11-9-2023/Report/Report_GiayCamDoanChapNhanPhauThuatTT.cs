using DevExpress.XtraReports.UI;
using Report_WinForm_Phiếu_11_9_2023.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Report_WinForm_Phiếu_11_9_2023.Report
{
    public partial class Report_GiayCamDoanChapNhanPhauThuatTT : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_GiayCamDoanChapNhanPhauThuatTT()
        {
            InitializeComponent();
        }
        public void InitData(PhieuCamDoanChapNhanPTTT model)
        {
            objectDataSource1.DataSource = model;
        }

    }
}
