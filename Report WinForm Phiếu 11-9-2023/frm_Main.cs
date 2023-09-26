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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_PhieuGayMeHoiSuc view = new View_PhieuGayMeHoiSuc();
            view.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiayCamDoanChapNhanGayMeHoiSuc view = new GiayCamDoanChapNhanGayMeHoiSuc();
            view.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiayCamDoanChapNhanPhauThuat_Chinh view = new GiayCamDoanChapNhanPhauThuat_Chinh();
            view.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau view = new PhieuKhamThaoBenhNhanTruocKhiGayMeGiaiPhau();
            view.ShowDialog();
            this.Show();
        }
    }
}
