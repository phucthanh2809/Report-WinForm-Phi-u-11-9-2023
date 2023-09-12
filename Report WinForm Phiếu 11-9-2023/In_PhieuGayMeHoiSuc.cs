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
    public partial class In_PhieuGayMeHoiSuc : Form
    {
        public In_PhieuGayMeHoiSuc()
        {
            InitializeComponent();
            LoadSource();
        }

        public void LoadSource()
        {
            Report_PhieuGayMeHoiSuc s = new Report_PhieuGayMeHoiSuc();
            documentViewer1.DocumentSource = s;
            s.CreateDocument();
        }

    }
}
