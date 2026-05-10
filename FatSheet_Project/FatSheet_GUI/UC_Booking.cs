using FatSheet_BUS;
using FatSheet_DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FatSheet_GUI
{
    public partial class UC_Booking : UserControl
    {
        BookingBUS bookingBus = new BookingBUS();
        UserBUS userBus = new UserBUS();

        public UC_Booking()
        {
            InitializeComponent();
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            dgvPreview.DefaultCellStyle.ForeColor = Color.Black;
            dgvPreview.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Đổi màu chữ lúc bạn click chọn dòng cũng thành màu đen/trắng cho rõ
            dgvPreview.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPreview.DefaultCellStyle.SelectionBackColor = Color.Black;

            try
            {
                // 1. Tạo sẵn 4 hàng cho bảng Preview (Hóa đơn)
                dgvPreview.Rows.Clear();
                dgvPreview.Rows.Add("Dịch vụ", "---");
                dgvPreview.Rows.Add("Thợ cắt", "---");
                dgvPreview.Rows.Add("Thời gian", "---");
                dgvPreview.Rows.Add("Giá tiền", "0 VNĐ");

                // 2. Load danh sách Dịch vụ
                DataTable dtServices = bookingBus.GetServices();
                if (dtServices != null)
                {
                    cboService.DataSource = dtServices;
                    cboService.DisplayMember = "ServiceName";
                    cboService.ValueMember = "ServiceID";
                }

                // 3. Load danh sách Thợ (Barber)
                DataTable dtBarbers = userBus.GetBarberList();
                if (dtBarbers != null)
                {
                    cboBarber.DataSource = dtBarbers;
                    cboBarber.DisplayMember = "FullName";
                    cboBarber.ValueMember = "UserID";
                }

                // 4. Quan trọng: Reset để ban đầu hiện dấu "---"
                cboService.SelectedIndex = -1;
                cboBarber.SelectedIndex = -1;
                cboTime.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        // Cập nhật Dịch vụ & Giá
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvPreview.Rows.Count > 0 && cboService.SelectedIndex != -1)
            {
                if (cboService.SelectedItem is DataRowView row)
                {
                    dgvPreview.Rows[0].Cells[1].Value = row["ServiceName"].ToString();
                    decimal price = Convert.ToDecimal(row["Price"]);
                    dgvPreview.Rows[3].Cells[1].Value = price.ToString("#,##0") + " VNĐ";
                }
            }
        }

        // Cập nhật Thợ cắt
        private void cboBarber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvPreview.Rows.Count > 1 && cboBarber.SelectedIndex != -1)
            {
                dgvPreview.Rows[1].Cells[1].Value = cboBarber.Text;
            }
        }

        // Các sự kiện thay đổi Thời gian
        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTimePreview();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateTimePreview();
        }

        // Hàm chung để cập nhật dòng Thời gian (Dòng số 2)
        private void UpdateDateTimePreview()
        {
            if (dgvPreview.Rows.Count > 2)
            {
                string gio = string.IsNullOrEmpty(cboTime.Text) ? "---" : cboTime.Text;
                string ngay = dtpDate.Value.ToString("dd/MM/yyyy");
                dgvPreview.Rows[2].Cells[1].Value = gio + " | " + ngay;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboService.SelectedIndex == -1 || cboBarber.SelectedIndex == -1 || string.IsNullOrEmpty(cboTime.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Dịch vụ, Thợ và Giờ hẹn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BookingDTO booking = new BookingDTO();
                booking.UserID = GlobalUser.UserID;
                booking.ServiceID = (int)cboService.SelectedValue;
                booking.BarberID = (int)cboBarber.SelectedValue;

                DateTime ngay = dtpDate.Value.Date;
                TimeSpan gio = TimeSpan.Parse(cboTime.Text);
                booking.BookingDate = ngay.Add(gio);

                if (bookingBus.CreateBooking(booking))
                {
                    MessageBox.Show("ĐẶT LỊCH THÀNH CÔNG!\nBarber " + cboBarber.Text + " sẽ đợi bạn.",
                                    "Fat Sheet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt lịch thất bại!", "Lỗi");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}