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
        }
    }
}
