using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCatTocMoi
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MSI\HAIXEDAP;Initial Catalog=QuanLyCatTocDB_Full;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadLichHen();
        }

        private void LoadDichVu()
        {
            string query = "SELECT * FROM DichVu";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbDichVu.DataSource = dt;
                cbDichVu.DisplayMember = "TenDichVu";
                cbDichVu.ValueMember = "MaDichVu";
            }
        }

        private void LoadLichHen()
        {
            string query = "SELECT lh.MaLich, lh.HoTen, lh.SoDienThoai, lh.Email, lh.NgayGioHen, dv.TenDichVu FROM LichHen lh JOIN DichVu dv ON lh.MaDichVu = dv.MaDichVu";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachLich.DataSource = dt;
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string sdt = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            DateTime ngayHen = dtpNgayHen.Value;
            int maDV = Convert.ToInt32(cbDichVu.SelectedValue);

            if (hoTen == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!");
                return;
            }

            string query = "INSERT INTO LichHen (HoTen, SoDienThoai, Email, NgayGioHen, MaDichVu) VALUES (@Ten, @SDT, @Email, @Ngay, @MaDV)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", hoTen);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Ngay", ngayHen);
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đặt lịch thành công!");

                txtHoTen.Clear();
                txtSoDienThoai.Clear();
                txtEmail.Clear();
                LoadLichHen();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên bảng chưa
            if (dgvDanhSachLich.SelectedRows.Count > 0)
            {
                // 2. Lấy Mã lịch (cột MaLich) của dòng đang được chọn
                string maLich = dgvDanhSachLich.SelectedRows[0].Cells["MaLich"].Value.ToString();

                // 3. Hiển thị hộp thoại hỏi xác nhận cho giống sinh viên cẩn thận
                DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (xacNhan == DialogResult.Yes)
                {
                    // 4. Thực thi câu lệnh xóa
                    string query = "DELETE FROM LichHen WHERE MaLich = @MaLich";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaLich", maLich);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa lịch hẹn thành công!");
                        LoadLichHen(); // Cập nhật lại bảng dữ liệu
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một dòng trong bảng bên phải để xóa!");
            }
        }

        private void dgvDanhSachLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có bấm vào dòng dữ liệu không (tránh bấm vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachLich.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dtpNgayHen.Value = Convert.ToDateTime(row.Cells["NgayGioHen"].Value);
                cbDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
            }
        }
    }
}
