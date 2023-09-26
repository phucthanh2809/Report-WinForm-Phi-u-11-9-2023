using Report_WinForm_Phiếu_11_9_2023.Model;
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
    public partial class In_PhieuCamDoanChapNhanGayMeHoiSuc : DevExpress.XtraEditors.XtraForm
    {
        private PhieuCamDoanChapNhanGMHS currentModel = new PhieuCamDoanChapNhanGMHS();
        public In_PhieuCamDoanChapNhanGayMeHoiSuc(PhieuCamDoanChapNhanGMHS model)
        {
            InitializeComponent();
            this.currentModel = model;
            LoadSource();
        }

        private void LoadSource()
        {
            Report_GiayCamDoanChapNhanGayMe s = new Report_GiayCamDoanChapNhanGayMe();
            documentViewer1.DocumentSource = s;
            s.InitData(currentModel);
            s.CreateDocument();
        }
    }
}
