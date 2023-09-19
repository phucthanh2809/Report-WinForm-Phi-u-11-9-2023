using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Report_WinForm_Phiếu_11_9_2023.Model;
using Report_WinForm_Phiếu_11_9_2023.Report;

namespace Report_WinForm_Phiếu_11_9_2023
{
    public partial class PhieuGayMeHoiSuc : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection sqlConnection;
        private int currentID;
        bool state;
        bool error = false;
        public PhieuGayMeHoiSuc(int idphieu)
        {
            InitializeComponent();
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
            LoadCombobox();
            currentID = idphieu;
            if (currentID == 0 )
            {
                state = false;
                cbbGioiTinh.SelectedIndex = 0;
                cbbNhomMau.SelectedIndex = 0;
            }
            else
            {
                state = true;
            }
            LoadData();
            txtSoVaoVien.TextBoxKeyPress += TxtSoVaoVien_TextBoxKeyPress; ;
        }

        private void TxtSoVaoVien_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                findTTBenhNhan(txtSoVaoVien._textBox.Text);
                e.Handled = true; 
            }
        }

        void LoadCombobox()
        {
            LoadKhoa();
            loadBacSi();
            LoadNhomMau();
            loadPhuongPhapPhauThuat();
            loadPhuongPhapVoCam();
            LoadChuanDoan();
        }

        private void LoadChuanDoan()
        {
            try
            {
                sqlConnection.Open();

                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT MaChanDoan, TenChanDoan FROM tabCDSPK";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<ChuanDoan> ChuanDoanList = new List<ChuanDoan>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            ChuanDoan model = new ChuanDoan
                            {
                                Machuandoan = row["MaChanDoan"].ToString(),
                                Tenchuandoan = row["TenChanDoan"].ToString()
                            };
                            ChuanDoanList.Add(model);
                        }

                        cbbChuanDoan.DataSource = ChuanDoanList;
                        cbbChuanDoan.DisplayMember = "Tenchuandoan";
                        cbbChuanDoan.ValueMember = "Machuandoan";
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

        void loadBacSi()
        {
            try
            {
                sqlConnection.Open();

                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT MABACSI, TENBACSI FROM tabMaBS";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<BacSi> BacsiList = new List<BacSi>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            BacSi model = new BacSi
                            {
                                MABACSI = row["MABACSI"].ToString(),
                                TENBACSI = row["TENBACSI"].ToString()
                            };
                            BacsiList.Add(model);
                        }

                        cbbBSGayMe.DataSource = BacsiList;
                        cbbBSGayMe.DisplayMember = "TENBACSI";
                        cbbBSGayMe.ValueMember = "MABACSI";

                        List<BacSi> BacsiList2 = new List<BacSi>(BacsiList);
                        cbbBSPhauThuat.DataSource = BacsiList2;
                        cbbBSPhauThuat.DisplayMember = "TENBACSI";
                        cbbBSPhauThuat.ValueMember = "MABACSI";
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

        void LoadNhomMau()
        {
            try
            {
                sqlConnection.Open();

                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT * FROM tabNhomMau";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<NhomMau> NhomMauList = new List<NhomMau>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            NhomMau model = new NhomMau
                            {
                                Manhommau = row["MaNhomMau"].ToString(),
                                Tennhommau = row["TenNhomMau"].ToString()
                            };
                            NhomMauList.Add(model);
                        }

                        cbbNhomMau.DataSource = NhomMauList;
                        cbbNhomMau.DisplayMember = "TenNhomMau";
                        cbbNhomMau.ValueMember = "MaNhomMau";
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

        void loadPhuongPhapPhauThuat()
        {
            try
            {
                sqlConnection.Open();

                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT TenTat, TenPhuongPhapPhauThuat FROM tabPhuongPhapPhauThuat";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<PhuongPhapPhauThuat> phauthuatList = new List<PhuongPhapPhauThuat>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            PhuongPhapPhauThuat model = new PhuongPhapPhauThuat
                            {
                                Tentat = row["TenTat"].ToString(),
                                Tenphuongphap = row["TenPhuongPhapPhauThuat"].ToString()
                            };
                            phauthuatList.Add(model);
                        }

                        cbbPPPhauThuat.DataSource = phauthuatList;
                        cbbPPPhauThuat.DisplayMember = "Tenphuongphap";
                        cbbPPPhauThuat.ValueMember = "TenTat";
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

        void loadPhuongPhapVoCam()
        {
            try
            {

                sqlConnection.Open();

                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT TenTat, TenPhuongPhapVoCam FROM tabPhuongPhapVoCam";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<PhuongPhapVoCam> vocamList = new List<PhuongPhapVoCam>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            PhuongPhapVoCam model = new PhuongPhapVoCam
                            {
                                Tentat = row["TenTat"].ToString(),
                                Tenphuongphap = row["TenPhuongPhapVoCam"].ToString()
                            };
                            vocamList.Add(model);
                        }
                        cbbPPVoCam.DataSource = vocamList;
                        cbbPPVoCam.DisplayMember = "TenPhuongPhap";
                        cbbPPVoCam.ValueMember = "TenTat";
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

        void LoadKhoa()
        {
            try
            {
                sqlConnection.Open();
                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT TENTAT, TENCHUYENKHOA FROM tabMACHUYENKHOA";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tạo danh sách model từ dữ liệu
                        List<Khoa> KhoaList = new List<Khoa>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Khoa model = new Khoa
                            {
                                TENTAT = row["TENTAT"].ToString(),
                                TENCHUYENKHOA = row["TENCHUYENKHOA"].ToString()
                            };
                            KhoaList.Add(model);
                        }

                        cbbKhoa1.DataSource = KhoaList;
                        cbbKhoa1.DisplayMember = "TENCHUYENKHOA";
                        cbbKhoa1.ValueMember = "TENTAT";
                        List<Khoa> KhoaList2 = new List<Khoa>(KhoaList);
                        cbbKhoa2.DataSource = KhoaList2;
                        cbbKhoa2.DisplayMember = "TENCHUYENKHOA";
                        cbbKhoa2.ValueMember = "TENTAT";
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
        bool KTra_Empty()
        {
            if (
                txtSoVaoVien._textBox.Text == string.Empty ||
                cbbKhoa1.Text == string.Empty ||
                cbbKhoa2.Text == string.Empty ||
                txtTenBenhNhan._textBox.Text == string.Empty ||
                txtTuoi._textBox.Text == string.Empty ||
                cbbGioiTinh.Text == string.Empty ||
                txtBuong._textBox.Text == string.Empty ||
                txtGiuong._textBox.Text == string.Empty ||
                txtCanNang._textBox.Text == string.Empty ||
                txtChieuCao._textBox.Text == string.Empty ||
                cbbChuanDoan.Text == string.Empty ||
                cbbPPPhauThuat.Text == string.Empty ||
                cbbPPVoCam.Text == string.Empty ||
                txtTuThe._textBox.Text == string.Empty ||
                cbbBSPhauThuat.Text == string.Empty ||
                cbbBSGayMe.Text == string.Empty ||
                txtNgay._textBox.Text == string.Empty ||
                txtThang._textBox.Text == string.Empty ||
                txtNam._textBox.Text == string.Empty ||
                txtTienMe._textBox.Text == string.Empty ||
                txtTacDung._textBox.Text == string.Empty ||
                cbbNhomMau.Text == string.Empty
               )
            {
                return false;
            }
            return true;
        }
        void LoadData()
        {
            if (currentID != 0)
            {
                try
                {
                    sqlConnection.Open();
                    string query = "select * from PhieuGayMeHoiSuc where iid = @RowId";

                    // Đặt SqlCommand và kết nối
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@RowId", this.currentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtSoVaoVien._textBox.Text = reader["SoVaoVien"].ToString();
                                cbbKhoa1.SelectedValue = reader["Khoa1"].ToString();
                                cbbKhoa2.SelectedValue = reader["Khoa2"].ToString();
                                txtTenBenhNhan._textBox.Text = reader["HoTen"].ToString();
                                txtTuoi._textBox.Text = reader["Tuoi"].ToString();
                                cbbGioiTinh.Text = reader["GioiTinh"].ToString();
                                txtBuong._textBox.Text = reader["Buong"].ToString();
                                txtGiuong._textBox.Text = reader["Giuong"].ToString();
                                txtCanNang._textBox.Text = reader["CanNang"].ToString();
                                txtChieuCao._textBox.Text = reader["ChieuCao"].ToString();
                                cbbNhomMau.SelectedValue = reader["NhomMau"].ToString();
                                cbbChuanDoan.SelectedValue = reader["ChuanDoan"].ToString();
                                cbbPPPhauThuat.SelectedValue = reader["PPPhauThuat"].ToString();
                                cbbPPVoCam.SelectedValue = reader["PPVoCam"].ToString();
                                txtTuThe._textBox.Text = reader["TuThe"].ToString();
                                cbbBSPhauThuat.SelectedValue = reader["BSPhauThuat"].ToString();
                                cbbBSGayMe.SelectedValue = reader["BSGayMe"].ToString();
                                txtNgay._textBox.Text = reader["Ngay"].ToString();
                                txtThang._textBox.Text = reader["Thang"].ToString();
                                txtNam._textBox.Text = reader["Nam"].ToString();
                                txtTienMe._textBox.Text = reader["TienMe"].ToString();
                                txtTacDung._textBox.Text = reader["TacDung"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dòng dữ liệu với ID đã cho.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    // Đóng kết nối đến cơ sở dữ liệu sau khi hoàn tất
                    sqlConnection.Close();
                }

            }
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print();
        }
        void print()
        {
            String svv = txtSoVaoVien._textBox.Text;
            String khoa1 = cbbKhoa1.Text;
            String khoa2 = cbbKhoa2.Text;
            String hoten = txtTenBenhNhan._textBox.Text;
            int tuoi = Convert.ToInt32(txtTuoi._textBox.Text);
            String gioitinh = cbbGioiTinh.Text;
            int buong = Convert.ToInt32(txtBuong._textBox.Text);
            int giuong = Convert.ToInt32(txtGiuong._textBox.Text);
            float cannang = float.Parse(txtCanNang._textBox.Text);
            int chieucao = Convert.ToInt32(txtChieuCao._textBox.Text);
            String nhommau = cbbNhomMau.Text;
            String chuandoan = cbbChuanDoan.Text;
            String ppphauthuat = cbbPPPhauThuat.Text;
            String ppvocam = cbbPPVoCam.Text;
            String tuthe = txtTuThe._textBox.Text;
            String bsphauthuat = cbbBSPhauThuat.Text;
            String bsgayme = cbbBSGayMe.Text;
            int ngay = Convert.ToInt32(txtNgay._textBox.Text);
            int thang = Convert.ToInt32(txtThang._textBox.Text);
            int nam = Convert.ToInt32(txtNam._textBox.Text);
            String tienme = txtTienMe._textBox.Text;
            String tacdung = txtTacDung._textBox.Text;

            PhieuGayMeHoiSuc_Model model = new PhieuGayMeHoiSuc_Model(svv, khoa1, khoa2, hoten, tuoi, gioitinh, buong, giuong, chieucao, cannang, nhommau,
                chuandoan, ppphauthuat, ppvocam, bsphauthuat, bsgayme, ngay, thang, nam, tienme, tacdung, tuthe);
            In_PhieuGayMeHoiSuc ph = new In_PhieuGayMeHoiSuc(model);
            ph.ShowDialog();
        }
        void Save()
        {
            if (KTra_Empty())
            {
                if (!state)
                {
                    // thêm phiếu
                    try
                    {
                        sqlConnection.Open();
                        string query = $"execute Add_PhieuGayMeHoiSuc '{this.txtSoVaoVien._textBox.Text}', N'{this.cbbKhoa1.SelectedValue}', " +
                            $"N'{this.cbbKhoa2.SelectedValue}', N'{this.txtTenBenhNhan._textBox.Text}', '{this.txtTuoi._textBox.Text}', " +
                            $"N'{this.cbbGioiTinh.Text}', '{this.txtBuong._textBox.Text}' " +
                            $",'{this.txtGiuong._textBox.Text}' ,'{this.txtCanNang._textBox.Text}' ,'{this.txtChieuCao._textBox.Text}'" +
                            $",N'{this.cbbNhomMau.SelectedValue}',N'{this.cbbChuanDoan.SelectedValue}'," +
                            $"N'{this.cbbPPPhauThuat.SelectedValue}',N'{this.cbbPPVoCam.SelectedValue}'," +
                            $"N'{this.cbbBSPhauThuat.SelectedValue}',N'{this.cbbBSGayMe.SelectedValue}','{this.txtNgay._textBox.Text}','{this.txtThang._textBox.Text}'," +
                            $"'{this.txtNam._textBox.Text}',N'{this.txtTienMe._textBox.Text}',N'{this.txtTacDung._textBox.Text}', N'{this.txtTuThe._textBox.Text}' ";

                        // Đặt SqlCommand và kết nối
                        using (SqlCommand command = new SqlCommand(query, sqlConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thêm mới phiếu thành công!");
                            error = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        error = true;
                    }
                    finally
                    {
                        // Đóng kết nối đến cơ sở dữ liệu sau khi hoàn tất
                        sqlConnection.Close();
                    }
                }
                else
                {
                    //cập nhật phiếu
                    try
                    {
                        sqlConnection.Open();
                        string query = $"execute Update_PhieuGayMeHoiSuc '{currentID}','{this.txtSoVaoVien._textBox.Text}', N'{this.cbbKhoa1.SelectedValue}', " +
                            $"N'{this.cbbKhoa2.SelectedValue}', N'{this.txtTenBenhNhan._textBox.Text}', '{this.txtTuoi._textBox.Text}', " +
                            $"N'{this.cbbGioiTinh.Text}', '{this.txtBuong._textBox.Text}' " +
                            $",'{this.txtGiuong._textBox.Text}' ,'{this.txtCanNang._textBox.Text}' ,'{this.txtChieuCao._textBox.Text}'" +
                            $",N'{this.cbbNhomMau.SelectedValue}',N'{this.cbbChuanDoan.SelectedValue}'," +
                            $"N'{this.cbbPPPhauThuat.SelectedValue}',N'{this.cbbPPVoCam.SelectedValue}'," +
                            $"N'{this.cbbBSPhauThuat.SelectedValue}',N'{this.cbbBSGayMe.SelectedValue}','{this.txtNgay._textBox.Text}','{this.txtThang._textBox.Text}'," +
                            $"'{this.txtNam._textBox.Text}',N'{this.txtTienMe._textBox.Text}',N'{this.txtTacDung._textBox.Text}', N'{this.txtTuThe._textBox.Text}' ";

                        // Đặt SqlCommand và kết nối
                        using (SqlCommand command = new SqlCommand(query, sqlConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật phiếu thành công!");
                            error = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        error = true;
                    }
                    finally
                    {
                        // Đóng kết nối đến cơ sở dữ liệu sau khi hoàn tất
                        sqlConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống dữ liệu nào!");
                error = true;
            }
        }
        private void btnSaveandPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
            if(error == false)
            {
                print();
            }
        }
        void findTTBenhNhan(String txt)
        {
            try
            {
                sqlConnection.Open();
                // Truy vấn dữ liệu từ bảng ChuanDoan
                string query = "SELECT SoVaoVien, HoTen FROM tabThongTinBenhNhan where SoVaoVien = '"+txt+"'";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            txtTenBenhNhan._textBox.Text = dataTable.Rows[0]["HoTen"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bệnh nhân phù hợp!");
                        }
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
