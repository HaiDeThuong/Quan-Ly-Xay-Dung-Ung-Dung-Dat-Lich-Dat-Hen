using FatSheet_BUS;
using FatSheet_DTO; // Quan trọng để dùng GlobalUser
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FatSheet_GUI
{
    public partial class UC_History : UserControl
    {
        BookingBUS bookingBus = new BookingBUS();

        public UC_History()
        {
            InitializeComponent();
        }

        // 1. Hàm nạp dữ liệu (Sửa ID cố định thành ID người đang đăng nhập)
        public void LoadData()
        {
            try
            {
                // Lấy ID của người vừa đăng nhập thành công
                int currentUserId = GlobalUser.UserID;

                // Gọi BUS lấy dữ liệu lịch sử từ SQL
                DataTable dt = bookingBus.GetHistory(currentUserId);

                if (dt != null)
                {
                    // Đổ dữ liệu vào bảng DataGridView
                    dgvHistory.DataSource = dt;

                    // Nếu muốn chuyên nghiệp, bạn có thể ẩn thông báo này đi sau khi test xong
                    // MessageBox.Show("Đã cập nhật lịch sử cho khách hàng: " + GlobalUser.FullName);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối với Database hoặc lỗi truy vấn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử: " + ex.Message);
            }
        }

        // 2. Sự kiện nạp dữ liệu khi trang vừa hiện lên
        private void UC_History_Load(object sender, EventArgs e)
        {
            // 1. Chỉnh màu chữ của các dòng là màu Đen
            dgvHistory.DefaultCellStyle.ForeColor = Color.Black;

            // 2. Chỉnh màu chữ khi bạn Click chuột vào dòng cũng là màu Đen
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 3. Đảm bảo các hàng mặc định cũng màu đen
            dgvHistory.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Sau đó mới gọi hàm load dữ liệu
            LoadData();
        // Làm cho các cột tự động giãn đều đẹp mắt
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi màu dòng khi khách click chuột vào (màu vàng đen cho ngầu)
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 191, 0); // Vàng Gold
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.Black;

            LoadData(); // Gọi hàm lấy dữ liệu từ SQL
        }

        // 3. Nút bấm Làm mới danh sách
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Đã cập nhật danh sách lịch hẹn mới nhất!", "Fat Sheet Barber");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên bảng chưa
            if (dgvHistory.SelectedRows.Count > 0)
            {
                // 2. Lấy BookingID từ cột đầu tiên của dòng đang chọn
                // Lưu ý: Cột 0 phải là cột 'Mã' (BookingID)
                int bookingId = Convert.ToInt32(dgvHistory.SelectedRows[0].Cells[0].Value);

                // 3. Hiện bảng hỏi xác nhận cho chắc chắn
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // 4. Gọi BUS để thực hiện xóa trong SQL
                    if (bookingBus.CancelBooking(bookingId))
                    {
                        MessageBox.Show("Đã hủy lịch hẹn thành công!", "Thông báo");
                        LoadData(); // Load lại bảng để cập nhật danh sách mới
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể hủy lịch!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một dòng lịch hẹn để hủy!", "Thông báo");
            }
        }
    }
}