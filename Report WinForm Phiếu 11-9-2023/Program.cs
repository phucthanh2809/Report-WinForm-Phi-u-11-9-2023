using Report_WinForm_Phiếu_11_9_2023.Model;
using Report_WinForm_Phiếu_11_9_2023.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_WinForm_Phiếu_11_9_2023
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PhieuCamDoanChapNhanPTTT model = new PhieuCamDoanChapNhanPTTT
            //{
            //    TenBS = "Trần Bá Thiện",
            //    TenKhoaBS = "Gây mê hồi sức",
            //    Chuandoan = "Tê liệt nửa phần bụng dưới",
            //    PPPTTT = "Kích điện",
            //    Bienchung = "Tê luôn não",
            //    Tennguoithan = "Nguyễn Văn A",
            //    Tuoi = 24,
            //    Gioitinh = 1,
            //    Dantoc = "Kinh",
            //    Quoctich = "Việt Nam",
            //    Danhxung = "Cha",
            //    Tenbenhnhan = "Nguyễn văn B",
            //    Khoadieutri = "Khoa thần kinh",
            //    Tinhtrangbenh = "Tê liệt phần thân dưới, mất đi khả năng đi đứng"
            //};
            //Application.Run(new In_PhieuCamDoanChapNhanPhauThuatThuThuat(model));
            
            Application.Run(new GiayCamDoanChapNhanGayMeHoiSuc());
        }
    }
}
