using DevExpress.XtraReports.UI;
using Report_WinForm_Phiếu_11_9_2023.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Report_WinForm_Phiếu_11_9_2023.Report
{
    public partial class Report_PhieuThamKhaoBenhNhanTruocPhauThuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_PhieuThamKhaoBenhNhanTruocPhauThuat()
        {
            InitializeComponent();
        }
        public void InitData(PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau model)
        {
            objectDataSource1.DataSource = model;
        }
    }
}
