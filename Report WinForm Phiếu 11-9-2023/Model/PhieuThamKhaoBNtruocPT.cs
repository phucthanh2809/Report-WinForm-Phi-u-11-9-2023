using CrystalDecisions.ReportAppServer.DataDefModel;
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
    public class PhieuThamKhaoBNtruocPT
    {
        private SqlConnection sqlConnection;
        private int _maphieu;
        private String _hotenbn;
        private String _tuoi;
        private String _cannang;
        private String _chieucao;
        private String _diachi;
        private int _vandesausanh;
        private String _tenvandesausanh;
        private int _dagaymegiaiphau;
        private String _ngaygaymegiaiphau;
        private String _maphuongphapgayme;
        private String _mabenhviengayme;
        private String _tenphuongphapgayme;
        private String _tenbenhviengayme;
        private int _suyen;
        private int _chamnoimeday;
        private int _diungthuocthucpham;
        private String _tenthuocdiung;
        private int _bienchungsaugayme;
        private int _danamvien;
        private String _lydonamvien;
        private int _sotcaocogiat;
        private int _dongkinh;
        private String _dadieutri;
        private int _chaymaucamkeodai;
        private int _anhemho;
        private int _timbamsinh;
        private String _neurotimbamsinh;
        private int _datungtruyenmau;
        private int _dungthuocthuongxuyen;
        private String _lydodungthuoc;
        private string _neurothuocdungthuongxuyen;
        private string _tenthuockhangsinh;
        private string _lieudungthuockhangsinh;
        private string _tenthuocchongviem;
        private string _lieudungthuocchongviem;
        private string _tenthuochasotgiamdau;
        private string _lieudungthuochasotgiamdau;
        private string _tenthuockhac;
        private string _lieudungthuockhac;
        private string _luuybacsi;
        private string _ngaythangnam;
        public PhieuThamKhaoBNtruocPT()
        {
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
        }
        public int Maphieu { get => _maphieu; set => _maphieu = value; }
        public string Hotenbn { get => _hotenbn; set => _hotenbn = value; }
        public string Tuoi { get => _tuoi; set => _tuoi = value; }
        public string Cannang { get => _cannang; set => _cannang = value; }
        public string Chieucao { get => _chieucao; set => _chieucao = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public int Vandesausanh { get => _vandesausanh; set => _vandesausanh = value; }
        public string Tenvandesausanh { get => _tenvandesausanh; set => _tenvandesausanh = value; }
        public int Dagaymegiaiphau { get => _dagaymegiaiphau; set => _dagaymegiaiphau = value; }
        public string Ngaygaymegiaiphau { get => _ngaygaymegiaiphau; set => _ngaygaymegiaiphau = value; }
        public string Maphuongphapgayme { get => _maphuongphapgayme; 
            set
            {
                _maphuongphapgayme = value;
                if (value != null)
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT TenPhuongPhapPhauThuat FROM [tabPhuongPhapPhauThuat] where TenTat = N'" + value + "'";
                        using (SqlCommand command = new SqlCommand(query, sqlConnection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                Tenphuongphapgayme = dataTable.Rows[0]["TenPhuongPhapPhauThuat"].ToString();
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
        }
        public string Mabenhviengayme { get => _mabenhviengayme;
            set
            {
                _mabenhviengayme = value;
                if (value != null)
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT TenBenhVien FROM [tabBenhVien] where MaBenhVien = N'" + value + "'";
                        using (SqlCommand command = new SqlCommand(query, sqlConnection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                Tenbenhviengayme = dataTable.Rows[0]["TenBenhVien"].ToString();
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
        }
        public string Tenphuongphapgayme { get => _tenphuongphapgayme; set => _tenphuongphapgayme = value; }
        public string Tenbenhviengayme { get => _tenbenhviengayme; set => _tenbenhviengayme = value; }
        public int Suyen { get => _suyen; set => _suyen = value; }
        public int Chamnoimeday { get => _chamnoimeday; set => _chamnoimeday = value; }
        public int Diungthuocthucpham { get => _diungthuocthucpham; set => _diungthuocthucpham = value; }
        public string Tenthuocdiung { get => _tenthuocdiung; set => _tenthuocdiung = value; }
        public int Bienchungsaugayme { get => _bienchungsaugayme; set => _bienchungsaugayme = value; }
        public int Danamvien { get => _danamvien; set => _danamvien = value; }
        public string Lydonamvien { get => _lydonamvien; set => _lydonamvien = value; }
        public int Sotcaocogiat { get => _sotcaocogiat; set => _sotcaocogiat = value; }
        public int Dongkinh { get => _dongkinh; set => _dongkinh = value; }
        public string Dadieutri { get => _dadieutri; set => _dadieutri = value; }
        public int Chaymaucamkeodai { get => _chaymaucamkeodai; set => _chaymaucamkeodai = value; }
        public int Anhemho { get => _anhemho; set => _anhemho = value; }
        public int Timbamsinh { get => _timbamsinh; set => _timbamsinh = value; }
        public string Neurotimbamsinh { get => _neurotimbamsinh; set => _neurotimbamsinh = value; }
        public int Datungtruyenmau { get => _datungtruyenmau; set => _datungtruyenmau = value; }
        public int Dungthuocthuongxuyen { get => _dungthuocthuongxuyen; set => _dungthuocthuongxuyen = value; }
        public string Lydodungthuoc { get => _lydodungthuoc; set => _lydodungthuoc = value; }
        public string Neurothuocdungthuongxuyen { get => _neurothuocdungthuongxuyen; set => _neurothuocdungthuongxuyen = value; }
        public string Tenthuockhangsinh { get => _tenthuockhangsinh; set => _tenthuockhangsinh = value; }
        public string Lieudungthuockhangsinh { get => _lieudungthuockhangsinh; set => _lieudungthuockhangsinh = value; }
        public string Tenthuocchongviem { get => _tenthuocchongviem; set => _tenthuocchongviem = value; }
        public string Lieudungthuocchongviem { get => _lieudungthuocchongviem; set => _lieudungthuocchongviem = value; }
        public string Tenthuochasotgiamdau { get => _tenthuochasotgiamdau; set => _tenthuochasotgiamdau = value; }
        public string Lieudungthuochasotgiamdau { get => _lieudungthuochasotgiamdau; set => _lieudungthuochasotgiamdau = value; }
        public string Tenthuockhac { get => _tenthuockhac; set => _tenthuockhac = value; }
        public string Lieudungthuockhac { get => _lieudungthuockhac; set => _lieudungthuockhac = value; }
        public string Luuybacsi { get => _luuybacsi; set => _luuybacsi = value; }
        public string Ngaythangnam { get => _ngaythangnam; set => _ngaythangnam = value; }
    }
}
