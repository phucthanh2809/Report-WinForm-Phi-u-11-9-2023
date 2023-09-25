using Report_WinForm_Phiếu_11_9_2023.Report;
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
    public partial class In_PhieuThamKhaoBNTruocGayMe_GiaiPhau : DevExpress.XtraEditors.XtraForm
    {
        private PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau currentModel = new PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau();
        public In_PhieuThamKhaoBNTruocGayMe_GiaiPhau(PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau Model)
        {
            InitializeComponent();
            this.currentModel = Model;
            LoadSource();
        }
        public void LoadSource()
        {
            Report_PhieuThamKhaoBenhNhanTruocPhauThuat s = new Report_PhieuThamKhaoBenhNhanTruocPhauThuat();
            documentViewer1.DocumentSource = s;
            s.InitData(currentModel);
            s.CreateDocument();
        }
    }
}
