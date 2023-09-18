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
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
            LoadData();
        }
        bool KTra_Empty()
        {
            if (
                txtSoVaoVien._textBox.Text == string.Empty ||
                txtKhoa._textBox.Text == string.Empty ||
                txtKhoa2._textBox.Text == string.Empty ||
                txtTenBenhNhan._textBox.Text == string.Empty ||
                txtTuoi._textBox.Text == string.Empty ||
                cbbGioiTinh.Text == string.Empty ||
                txtBuong._textBox.Text == string.Empty ||
                txtGiuong._textBox.Text == string.Empty ||
                txtCanNang._textBox.Text == string.Empty ||
                txtChieuCao._textBox.Text == string.Empty ||
                txtChuanDoan._textBox.Text == string.Empty ||
                txtPPPhauThuat._textBox.Text == string.Empty ||
                txtPPVoCam._textBox.Text == string.Empty ||
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
                                txtKhoa._textBox.Text = reader["Khoa1"].ToString();
                                txtKhoa2._textBox.Text = reader["Khoa2"].ToString();
                                txtTenBenhNhan._textBox.Text = reader["HoTen"].ToString();
                                txtTuoi._textBox.Text = reader["Tuoi"].ToString();
                                cbbGioiTinh.Text = reader["GioiTinh"].ToString();
                                txtBuong._textBox.Text = reader["Buong"].ToString();
                                txtGiuong._textBox.Text = reader["Giuong"].ToString();
                                txtCanNang._textBox.Text = reader["CanNang"].ToString();
                                txtChieuCao._textBox.Text = reader["ChieuCao"].ToString();
                                loadNhomMau(reader["NhomMau"].ToString());
                                txtChuanDoan._textBox.Text = reader["ChuanDoan"].ToString();
                                txtPPPhauThuat._textBox.Text = reader["PPPhauThuat"].ToString();
                                txtPPVoCam._textBox.Text = reader["PPVoCam"].ToString();
                                txtTuThe._textBox.Text = reader["TuThe"].ToString();
                                cbbBSPhauThuat.Text = reader["BSPhauThuat"].ToString();
                                cbbBSGayMe.Text = reader["BSGayMe"].ToString();
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
        void loadNhomMau(String nhom)
        {
            int plusIndex = nhom.IndexOf("+");
            int minusIndex = nhom.IndexOf("-");
            string bloodGroup;
            string rhFactor;

            if (plusIndex >= 0)
            {
                bloodGroup = nhom.Substring(0, plusIndex);
                rhFactor = nhom.Substring(plusIndex);
            }
            else if (minusIndex >= 0)
            {
                bloodGroup = nhom.Substring(0, minusIndex);
                rhFactor = nhom.Substring(minusIndex);
            }
            else
            {
                bloodGroup = nhom;
                rhFactor = string.Empty;
            }

            // Gán giá trị cho các ComboBox
            cbbNhomMau.Text = bloodGroup;
            cbbRH.Text = rhFactor;
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
            String khoa1 = txtKhoa._textBox.Text;
            String khoa2 = txtKhoa2._textBox.Text;
            String hoten = txtTenBenhNhan._textBox.Text;
            int tuoi = Convert.ToInt32(txtTuoi._textBox.Text);
            String gioitinh = cbbGioiTinh.Text;
            int buong = Convert.ToInt32(txtBuong._textBox.Text);
            int giuong = Convert.ToInt32(txtGiuong._textBox.Text);
            float cannang = float.Parse(txtCanNang._textBox.Text);
            int chieucao = Convert.ToInt32(txtChieuCao._textBox.Text);
            String nhommau = (cbbNhomMau.Text + cbbRH.Text);
            String chuandoan = txtChuanDoan._textBox.Text;
            String ppphauthuat = txtPPPhauThuat._textBox.Text;
            String ppvocam = txtPPVoCam._textBox.Text;
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
                        string query = $"execute Add_PhieuGayMeHoiSuc '{this.txtSoVaoVien._textBox.Text}', N'{this.txtKhoa._textBox.Text}', " +
                            $"N'{this.txtKhoa2._textBox.Text}', N'{this.txtTenBenhNhan._textBox.Text}', '{this.txtTuoi._textBox.Text}', " +
                            $"N'{this.cbbGioiTinh.Text}', '{this.txtBuong._textBox.Text}' " +
                            $",'{this.txtGiuong._textBox.Text}' ,'{this.txtCanNang._textBox.Text}' ,'{this.txtChieuCao._textBox.Text}'" +
                            $",N'{this.cbbNhomMau.Text + this.cbbRH.Text}',N'{this.txtChuanDoan._textBox.Text}'," +
                            $"N'{this.txtPPPhauThuat._textBox.Text}',N'{this.txtPPVoCam._textBox.Text}'," +
                            $"N'{this.cbbBSPhauThuat.Text}',N'{this.cbbBSGayMe.Text}','{this.txtNgay._textBox.Text}','{this.txtThang._textBox.Text}'," +
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
                        string query = $"execute Update_PhieuGayMeHoiSuc '{currentID}','{this.txtSoVaoVien._textBox.Text}', N'{this.txtKhoa._textBox.Text}', " +
                            $"N'{this.txtKhoa2._textBox.Text}', N'{this.txtTenBenhNhan._textBox.Text}', '{this.txtTuoi._textBox.Text}', " +
                            $"N'{this.cbbGioiTinh.Text}', '{this.txtBuong._textBox.Text}' " +
                            $",'{this.txtGiuong._textBox.Text}' ,'{this.txtCanNang._textBox.Text}' ,'{this.txtChieuCao._textBox.Text}'" +
                            $",N'{this.cbbNhomMau.Text + this.cbbRH.Text}',N'{this.txtChuanDoan._textBox.Text}'," +
                            $"N'{this.txtPPPhauThuat._textBox.Text}',N'{this.txtPPVoCam._textBox.Text}'," +
                            $"N'{this.cbbBSPhauThuat.Text}',N'{this.cbbBSGayMe.Text}','{this.txtNgay._textBox.Text}','{this.txtThang._textBox.Text}'," +
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
    }
}
