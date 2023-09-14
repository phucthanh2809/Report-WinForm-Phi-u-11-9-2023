using DevExpress.XtraRichEdit.Model;
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

namespace Report_WinForm_Phiếu_11_9_2023.Report
{
    public partial class View_PhieuGayMeHoiSuc : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        int id_phieu = 0;
        public View_PhieuGayMeHoiSuc()
        {
            InitializeComponent();
            string connectionString = Properties.Resources.connectStr;
            sqlConnection = new SqlConnection(connectionString);
            sqlDataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhieuGayMeHoiSuc ph = new PhieuGayMeHoiSuc(0);
            this.Hide();
            ph.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id_phieu == 0)
            {
                MessageBox.Show("Hãy chọn một phiếu trước khi ấn sửa!");
            }
            else
            {
                PhieuGayMeHoiSuc ph = new PhieuGayMeHoiSuc(id_phieu);
                this.Hide();
                ph.ShowDialog();
                this.Show();
                LoadData();
            }
        }

        void LoadData()
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM PhieuGayMeHoiSuc";
                sqlDataAdapter.SelectCommand = new SqlCommand(query, sqlConnection);
                dataTable.Clear();
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi: Load dữ liệu không thành công");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void View_PhieuGayMeHoiSuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (value != null)
                {
                    id_phieu = (int) value;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id_phieu == 0)
            {
                MessageBox.Show("Hãy chọn một phiếu trước khi ấn xóa phiếu!");
            }
            else
            {
                DialogResult cl = MessageBox.Show( "Bạn có thực sự muốn xóa phiếu này chứ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cl == DialogResult.Yes)
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = $"Execute Delete_PhieuGayMeHoiSuc '{id_phieu}'";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi: Xóa không thành công");
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                    LoadData();
                }
            }
        }
    }
}
