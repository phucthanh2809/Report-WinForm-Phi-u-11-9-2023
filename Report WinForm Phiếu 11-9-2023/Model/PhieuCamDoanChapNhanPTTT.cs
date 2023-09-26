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
    public class PhieuCamDoanChapNhanPTTT
    {
        private SqlConnection sqlConnection;
        private int _idPhieu;
        private int _gioitinhso;
        private String _MaBS;
        private String _MaKhoa;
        private String _MaChuanDoan;
        private String _MaPPTT;
        private String _MaQuocTich;
        private String _MaKhoaDieuTri;
        private String _TenBS; //khóa ngoại
        private String _TenKhoaBS; //khóa ngoại
        private String _chuandoan; // khóa ngoại
        private String _PPPTTT; //khóa ngoại
        private String _bienchung;
        private String _tennguoithan;
        private int _tuoi;
        private String _gioitinh;
        private String _dantoc;
        private String _quoctich; // khóa ngoại
        private String _nghenghiep;
        private String _noilamviec;
        private String _diachi;
        private String _danhxung;
        private String _tenbenhnhan;
        private String _khoadieutri; //khóa ngoại
        private String _tinhtrangbenh;

        public int IdPhieu { get => _idPhieu; set => _idPhieu = value; }
        public string TenBS { get => _TenBS; set => _TenBS = value; }
        public string TenKhoaBS { get => _TenKhoaBS; set => _TenKhoaBS = value; }
        public string Chuandoan { get => _chuandoan; set => _chuandoan = value; }
        public string PPPTTT { get => _PPPTTT; set => _PPPTTT = value; }
        public string Bienchung { get => _bienchung; set => _bienchung = value; }
        public string Tennguoithan { get => _tennguoithan; set => _tennguoithan = value; }
        public int Tuoi { get => _tuoi; set => _tuoi = value; }
        public String Gioitinh { get => _gioitinh; set => _gioitinh = value; }
        public string Dantoc { get => _dantoc; set => _dantoc = value; }
        public string Quoctich { get => _quoctich; set => _quoctich = value; }
        public string Nghenghiep { get => _nghenghiep; set => _nghenghiep = value; }
        public string Noilamviec { get => _noilamviec; set => _noilamviec = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Danhxung { get => _danhxung; set => _danhxung = value; }
        public string Tenbenhnhan { get => _tenbenhnhan; set => _tenbenhnhan = value; }
        public string Khoadieutri { get => _khoadieutri; set => _khoadieutri = value; }
        public string Tinhtrangbenh { get => _tinhtrangbenh; set => _tinhtrangbenh = value; }
        public PhieuCamDoanChapNhanPTTT()
        {
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
        }

        //load dữ liệu ngoại
        public string MaBS { get => _MaBS;
            set
            {
                _MaBS = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TENBACSI FROM tabMaBS where MABACSI = N'"+value+"'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TenBS = dataTable.Rows[0]["TENBACSI"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public string MaKhoa { get => _MaKhoa; set 
            {
                _MaKhoa = value;
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
                            TenKhoaBS = dataTable.Rows[0]["TENCHUYENKHOA"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }  
        }
        public string MaChuanDoan { get => _MaChuanDoan; 
            set 
            {
                _MaChuanDoan = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TenChanDoan FROM tabCDSPK where MaChanDoan = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Chuandoan = dataTable.Rows[0]["TenChanDoan"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            } 
        }
        public string MaPPTT { get => _MaPPTT;
            set 
            {
                _MaPPTT = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TenPhuongPhapPhauThuat FROM tabPhuongPhapPhauThuat where TenTat = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            PPPTTT = dataTable.Rows[0]["TenPhuongPhapPhauThuat"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public string MaQuocTich { get => _MaQuocTich; 
            set 
            {
                _MaQuocTich = value;
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TenQuocTich FROM tabQuocGia where Maquoctich = N'" + value + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Quoctich = dataTable.Rows[0]["TenQuoctich"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            } 
        }
        public string MaKhoaDieuTri { get => _MaKhoaDieuTri; 
            set 
            {
                _MaKhoaDieuTri = value;
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
                            Khoadieutri = dataTable.Rows[0]["TENCHUYENKHOA"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public int Gioitinhso { get => _gioitinhso; 
            set 
            { 
                _gioitinhso = value;
                if (value == 1)
                {
                    Gioitinh = "Nam";
                }
                else
                {
                    Gioitinh = "Nữ";
                }
            } 
        }
    }
}
