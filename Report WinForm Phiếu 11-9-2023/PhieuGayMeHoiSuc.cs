using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Report_WinForm_Phiếu_11_9_2023.Report;

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class PhieuGayMeHoiSuc : DevExpress.XtraEditors.XtraForm
    {
        public PhieuGayMeHoiSuc()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            In_PhieuGayMeHoiSuc ph = new In_PhieuGayMeHoiSuc();
            ph.ShowDialog();
        }
    }
}
