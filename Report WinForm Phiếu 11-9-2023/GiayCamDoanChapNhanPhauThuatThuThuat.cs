
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using DevExpress.Xpo;
using Report_WinForm_Phiếu_11_9_2023.Model;

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class GiayCamDoanChapNhanPhauThuatThuThuat : Form
    {
        public static string mconnectstring = Properties.Resources.connectStr;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private int currentID;
        public GiayCamDoanChapNhanPhauThuatThuThuat(int maphieu)
        {
            InitializeComponent();
            this.currentID = maphieu;
            LoadCombobox();
            if (currentID != 0)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            msql = $"SELECT * FROM [GiayCamDoanChapNhanPhauThuatThuThuat] where PhieuID='{currentID}'";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "GiayCamDoan");
            var row = ncc.Rows[0];
            cboHoTenBS.SelectedValue = row[1].ToString();
            cboKhoa.SelectedValue = row[2].ToString();
            cboChuanDoan.SelectedValue = row[3].ToString();
            cboPhuongPhap.SelectedValue = row[4].ToString();
            txtBienChung.Text = row[5].ToString();
            txtHoTenBN.Text = row[6].ToString();
            txtTuoi.Text = row[7].ToString();
            if (row[8].ToString() == "1")
                btnNam.Checked = true;
            else btnNu.Checked = true;
            txtDanToc.Text = row[9].ToString();
            cboQuocTich.SelectedValue = row[10].ToString();
            txtNgheNghiep.Text = row[11].ToString();
            txtNoiLamViec.Text = row[12].ToString();
            txtDiaChi.Text = row[13].ToString();
            cboDanhXungGD.Text = row[14].ToString();
            txtHoTenDanhXung.Text = row[15].ToString();
            cbo_Khoa.SelectedValue = row[16].ToString();
            txtTinhTrangBenh.Text = row[17].ToString();
        }

        #region enter
        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChuanDoan_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e); ev.Qtxt_Enter(sender, e);
        }

        private void txtPhuongPhap_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtBienChung_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHoTenBN_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDanToc_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTuoi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiLamViec_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void HoTenThanNhan_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txt_Khoa_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChuanDoan_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtPhuongPhap_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtBienChung_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHoTenBN_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTuoi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDanToc_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiLamViec_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void HoTenThanNhan_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txt_Khoa_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, linktxtChuanDoan);
        }

        private void txtChuanDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboPhuongPhap);
        }

        private void txtPhuongPhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtBienChung);
        }

        private void txtBienChung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHoTenBN);
        }

        private void txtHoTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTuoi);
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDanToc);
        }

        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiLamViec);
        }

        private void txtNoiLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDiaChi);
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHoTenDanhXung);
        }

        private void HoTenThanNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuu);
        }
        #endregion

        private void LoadCombobox()
        {
            // cbo Khoa
            msql = "SELECT * FROM [dbo].[tabMACHUYENKHOA]";
            DataTable k = comm.GetDataTable(mconnectstring, msql, "khoa");
            cboKhoa.DataSource = k.Copy();
            cboKhoa.DisplayMember = "TENCHUYENKHOA";
            cboKhoa.ValueMember = "TENTAT";
            cboKhoa.CustomAlignment = new string[] { "l", "l" };
            cboKhoa.CustomColumnStyle = new string[] { "t", "t" };
            cbo_Khoa.DataSource = k.Copy();
            cbo_Khoa.DisplayMember = "TENCHUYENKHOA";
            cbo_Khoa.ValueMember = "TENTAT";
            cbo_Khoa.CustomAlignment = new string[] { "l", "l" };
            cbo_Khoa.CustomColumnStyle = new string[] { "t", "t" };

            // cbo Tên BS
            msql = "SELECT * FROM [dbo].[tabMaBS]";
            DataTable bs = comm.GetDataTable(mconnectstring, msql, "BacSi");
            cboHoTenBS.DataSource = bs.Copy();
            cboHoTenBS.DisplayMember = "TENBACSI";
            cboHoTenBS.ValueMember = "MABACSI";
            cboHoTenBS.CustomAlignment = new string[] { "l", "l" };
            cboHoTenBS.CustomColumnStyle = new string[] { "t", "t" };
            // cbo Chuẩn Đoán
            msql = "SELECT * FROM [dbo].[tabCDSPK]";
            DataTable cd = comm.GetDataTable(mconnectstring, msql, "ChuanDoan");
            cboChuanDoan.DataSource = cd.Copy();
            cboChuanDoan.DisplayMember = "TenChanDoan";
            cboChuanDoan.ValueMember = "MaChanDoan";
            cboChuanDoan.CustomAlignment = new string[] { "l", "l" };
            cboChuanDoan.CustomColumnStyle = new string[] { "t", "t" };
            cboChuanDoan.sf = setfocusTensearch;
            // cbo Quốc tịch
            msql = "SELECT * FROM [dbo].[tabQuocGia]";
            DataTable qt = comm.GetDataTable(mconnectstring, msql, "QuocGia");
            cboQuocTich.DataSource = qt.Copy();
            cboQuocTich.DisplayMember = "TenQuocTich";
            cboQuocTich.ValueMember = "MaQuocTich";
            cboQuocTich.CustomAlignment = new string[] { "l", "l" };
            cboQuocTich.CustomColumnStyle = new string[] { "t", "t" };
            // cbo Quốc tịch
            msql = "SELECT * FROM [dbo].[tabPhuongPhapPhauThuat]";
            DataTable pp = comm.GetDataTable(mconnectstring, msql, "PPPT");
            cboPhuongPhap.DataSource = pp.Copy();
            cboPhuongPhap.DisplayMember = "TenPhuongPhapPhauThuat";
            cboPhuongPhap.ValueMember = "TenTat";
            cboPhuongPhap.CustomAlignment = new string[] { "l", "l" };
            cboPhuongPhap.CustomColumnStyle = new string[] { "t", "t" };
        }
        private int setfocusTensearch()
        {
            linktxtChuanDoan.Focus();
            return 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu();
        }
        int ktraGioiTinh()
        {
            if (btnNam.Checked == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        bool kTraThongTin()
        {
            if (cboHoTenBS.SelectedValue == null || cboKhoa.SelectedValue == null || cboChuanDoan.SelectedValue == null ||
                cboPhuongPhap.SelectedValue == null || txtBienChung.Text == "" || txtHoTenBN.Text == "" || txtTuoi.Text =="" ||
                txtDanToc.Text == ""|| cboQuocTich.SelectedValue == null || txtNgheNghiep.Text == "" || txtNoiLamViec.Text == "" ||
                txtDiaChi.Text =="" || cboDanhXungGD.Text == null || txtHoTenDanhXung.Text == "" || cbo_Khoa.SelectedValue == null || txtTinhTrangBenh.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (kTraThongTin())
            {
                In();
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng điền đầy đủ thông tin cần thiết!");
            }
        }

        private void btnLuuvaIn_Click(object sender, EventArgs e)
        {
            if (kTraThongTin())
            {
                try
                {
                    if (currentID == 0)
                    {
                        //thêm phiếu
                        msql = $"Execute add_GiayCamDoanPTTT '{cboHoTenBS.SelectedValue.ToString().Trim()}','{cboKhoa.SelectedValue.ToString().Trim()}','{cboChuanDoan.SelectedValue}'," +
                            $"'{cboPhuongPhap.SelectedValue}',N'{txtBienChung.Text}',N'{txtHoTenBN.Text}','{txtTuoi.Text}','{ktraGioiTinh()}'," +
                            $"N'{txtDanToc.Text}','{cboQuocTich.SelectedValue}',N'{txtNgheNghiep.Text}',N'{txtNoiLamViec.Text}'," +
                            $"N'{txtDiaChi.Text}',N'{cboDanhXungGD.Text}',N'{txtHoTenDanhXung.Text}','{cbo_Khoa.SelectedValue.ToString().Trim()}',N'{txtTinhTrangBenh.Text}'";
                        comm.RunSQL(mconnectstring, msql);
                    }
                    else
                    {
                        //sửa phiếu
                        msql = $"Execute up_GiayCamDoanPTTT '{currentID}','{cboHoTenBS.SelectedValue.ToString().Trim()}','{cboKhoa.SelectedValue.ToString().Trim()}','{cboChuanDoan.SelectedValue}'," +
                            $"'{cboPhuongPhap.SelectedValue}',N'{txtBienChung.Text}',N'{txtHoTenBN.Text}','{txtTuoi.Text}','{ktraGioiTinh()}'," +
                            $"N'{txtDanToc.Text}','{cboQuocTich.SelectedValue}',N'{txtNgheNghiep.Text}',N'{txtNoiLamViec.Text}'," +
                            $"N'{txtDiaChi.Text}',N'{cboDanhXungGD.Text}',N'{txtHoTenDanhXung.Text}','{cbo_Khoa.SelectedValue.ToString().Trim()}',N'{txtTinhTrangBenh.Text}'";
                        comm.RunSQL(mconnectstring, msql);
                    }
                    ev.QFrmThongBao("Sửa phiếu thành công !!");
                    In();
                    this.Close();
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Lỗi cơ sở dữ liệu, Vui lòng kiểm tra lại");
                }
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }
        void Luu()
        {
            if (kTraThongTin())
            {
                try
                {
                    if (currentID == 0)
                    {
                        //thêm phiếu
                        msql = $"Execute add_GiayCamDoanPTTT '{cboHoTenBS.SelectedValue.ToString().Trim()}','{cboKhoa.SelectedValue.ToString().Trim()}','{cboChuanDoan.SelectedValue}'," +
                            $"'{cboPhuongPhap.SelectedValue}',N'{txtBienChung.Text}',N'{txtHoTenBN.Text}','{txtTuoi.Text}','{ktraGioiTinh()}'," +
                            $"N'{txtDanToc.Text}','{cboQuocTich.SelectedValue}',N'{txtNgheNghiep.Text}',N'{txtNoiLamViec.Text}'," +
                            $"N'{txtDiaChi.Text}',N'{cboDanhXungGD.Text}',N'{txtHoTenDanhXung.Text}','{cbo_Khoa.SelectedValue.ToString().Trim()}',N'{txtTinhTrangBenh.Text}'";
                        comm.RunSQL(mconnectstring, msql);
                    }
                    else
                    {
                        //sửa phiếu
                        msql = $"Execute up_GiayCamDoanPTTT '{currentID}','{cboHoTenBS.SelectedValue.ToString().Trim()}','{cboKhoa.SelectedValue.ToString().Trim()}','{cboChuanDoan.SelectedValue}'," +
                            $"'{cboPhuongPhap.SelectedValue}',N'{txtBienChung.Text}',N'{txtHoTenBN.Text}','{txtTuoi.Text}','{ktraGioiTinh()}'," +
                            $"N'{txtDanToc.Text}','{cboQuocTich.SelectedValue}',N'{txtNgheNghiep.Text}',N'{txtNoiLamViec.Text}'," +
                            $"N'{txtDiaChi.Text}',N'{cboDanhXungGD.Text}',N'{txtHoTenDanhXung.Text}','{cbo_Khoa.SelectedValue.ToString().Trim()}',N'{txtTinhTrangBenh.Text}'";
                        comm.RunSQL(mconnectstring, msql);
                    }
                    ev.QFrmThongBao("Sửa phiếu thành công !!");
                    this.Close();
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Lỗi cơ sở dữ liệu, Vui lòng kiểm tra lại");
                }
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }
        void In()
        {
            PhieuCamDoanChapNhanPTTT model = new PhieuCamDoanChapNhanPTTT();
            model.IdPhieu = currentID;
            model.MaBS = cboHoTenBS.SelectedValue.ToString();
            model.MaKhoa = cboKhoa.SelectedValue.ToString();
            model.MaChuanDoan = cboChuanDoan.SelectedValue.ToString();
            model.MaPPTT = cboPhuongPhap.SelectedValue.ToString();
            model.Bienchung = txtBienChung.Text;
            model.Tennguoithan = txtHoTenBN.Text;
            model.Tuoi = Int32.Parse(txtTuoi.Text);
            model.Gioitinhso = ktraGioiTinh();
            model.Dantoc = txtDanToc.Text;
            model.MaQuocTich = cboQuocTich.SelectedValue.ToString();
            model.Nghenghiep = txtNgheNghiep.Text;
            model.Noilamviec = txtNoiLamViec.Text;
            model.Diachi = txtDiaChi.Text;
            model.Danhxung = cboDanhXungGD.Text;
            model.Tenbenhnhan = txtHoTenDanhXung.Text;
            model.MaKhoaDieuTri = cbo_Khoa.SelectedValue.ToString();
            model.Tinhtrangbenh = txtTinhTrangBenh.Text;
            In_PhieuCamDoanChapNhanPhauThuatThuThuat phieu = new In_PhieuCamDoanChapNhanPhauThuatThuThuat(model);
            phieu.ShowDialog();
        }
    }
}
