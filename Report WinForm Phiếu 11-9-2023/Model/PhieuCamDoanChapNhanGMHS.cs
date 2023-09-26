using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_WinForm_Phiếu_11_9_2023.Model
{
    public class PhieuCamDoanChapNhanGMHS
    {
        private SqlConnection sqlConnection;
        private String _maBacSi;
        private String _tenBacSi;
        private String _maKhoa;
        private String _tenKhoa;
        private bool _mask;
        private bool _noiKhiQuan;
        private bool _maskThanhQuan;
        private bool _noiPheQuan;
        private bool _teTaiCho;
        private bool _teKhoangXuongCung;
        private bool _teNgoaiMangCung;
        private bool _teVung;
        private bool _datDongMachXamLan;
        private bool _datCatheter;
        private String _tenBenhNhan;
        private string _tuoi;
        private String _danToc;
        private String _maQuoctich;
        private String _tenQuocTich;
        private String _ngheNghiep;
        private String _noiLamViec;
        private String _diaChi;
        private String _nguoiDaiDien;
        private String _tenNguoiDaiDien;
        private String _maDieuTritaiKhoa;
        private String _tenDieuTritaiKhoa;
        private String _tinhTrangBenh;
        private bool _dongYGayMe;
        private int _gioiTinh;
        public PhieuCamDoanChapNhanGMHS()
        {
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
        }
        public string MaBacSi { get => _maBacSi;
            set 
            {
                _maBacSi = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TENBACSI FROM tabMaBS where MABACSI = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TenBacSi = dataTable.Rows[0]["TENBACSI"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không tìm thấy bác sĩ");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }  
        }
        public string TenBacSi { get => _tenBacSi; set => _tenBacSi = value; }
        public string MaKhoa { get => _maKhoa; 
            set 
            {
                _maKhoa = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TENCHUYENKHOA FROM tabMACHUYENKHOA where TENTAT = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TenKhoa = dataTable.Rows[0]["TENCHUYENKHOA"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không tìm thấy khoa");
                }
                finally
                {
                    sqlConnection.Close();
                }
            } 
        }
        public string TenKhoa { get => _tenKhoa; set => _tenKhoa = value; }
        public bool Mask { get => _mask; set => _mask = value; }
        public bool NoiKhiQuan { get => _noiKhiQuan; set => _noiKhiQuan = value; }
        public bool MaskThanhQuan { get => _maskThanhQuan; set => _maskThanhQuan = value; }
        public bool NoiPheQuan { get => _noiPheQuan; set => _noiPheQuan = value; }
        public bool TeTaiCho { get => _teTaiCho; set => _teTaiCho = value; }
        public bool TeKhoangXuongCung { get => _teKhoangXuongCung; set => _teKhoangXuongCung = value; }
        public bool TeVung { get => _teVung; set => _teVung = value; }
        public bool DatDongMachXamLan { get => _datDongMachXamLan; set => _datDongMachXamLan = value; }
        public bool DatCatheter { get => _datCatheter; set => _datCatheter = value; }
        public string TenBenhNhan { get => _tenBenhNhan; set => _tenBenhNhan = value; }
        public string DanToc { get => _danToc; set => _danToc = value; }
        public string MaQuoctich { get => _maQuoctich; 
            set 
            {
                _maQuoctich = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TenQuocTich FROM tabQuocGia where TenTat = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TenQuocTich = dataTable.Rows[0]["TenQuocTich"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không tìm thấy Quoc Tich");
                }
                finally
                {
                    sqlConnection.Close();
                }
            } 
        }
        public string TenQuocTich { get => _tenQuocTich; set => _tenQuocTich = value; }
        public string NgheNghiep { get => _ngheNghiep; set => _ngheNghiep = value; }
        public string NoiLamViec { get => _noiLamViec; set => _noiLamViec = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string NguoiDaiDien { get => _nguoiDaiDien; set => _nguoiDaiDien = value; }
        public string TenNguoiDaiDien { get => _tenNguoiDaiDien; set => _tenNguoiDaiDien = value; }
        public string MaDieuTritaiKhoa { get => _maDieuTritaiKhoa; 
            set 
            {
                _maDieuTritaiKhoa = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TENCHUYENKHOA FROM tabMACHUYENKHOA where TENTAT = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TenDieuTritaiKhoa = dataTable.Rows[0]["TENCHUYENKHOA"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không tìm thấy khoa");
                }
                finally
                {
                    sqlConnection.Close();
                }
            } 
        }
        public string TenDieuTritaiKhoa { get => _tenDieuTritaiKhoa; set => _tenDieuTritaiKhoa = value; }
        public string TinhTrangBenh { get => _tinhTrangBenh; set => _tinhTrangBenh = value; }
        public bool DongYGayMe { get => _dongYGayMe; set => _dongYGayMe = value; }
        public int GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public bool TeNgoaiMangCung { get => _teNgoaiMangCung; set => _teNgoaiMangCung = value; }
        public string Tuoi { get => _tuoi; set => _tuoi = value; }
    }
}
