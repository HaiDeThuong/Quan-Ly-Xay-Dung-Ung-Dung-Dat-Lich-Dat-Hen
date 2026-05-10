using System;
using System.Drawing;
using System.Windows.Forms;

// HÃY KIỂM TRA TÊN DƯỚI ĐÂY CÓ GIỐNG TRONG FILE LOGIN KHÔNG
namespace FatSheet_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hàm thay đổi nội dung vùng trắng
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(uc);
            uc.BringToFront();
        }

        // Nút Trang chủ
        private void btnHome_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_Home());
        }


        // Nút Lịch sử
        private void btnHistory_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_History());
        }

        // Nút Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
            private void SetActiveButton(Button btn)
        {
            // Reset tất cả các nút về màu nền cũ
            btnHome.BackColor = Color.Transparent;
            btnBooking.BackColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;

            // Đổi màu riêng nút đang nhấn cho nổi bật
            btn.BackColor = Color.FromArgb(45, 45, 45); // Màu xám đậm hơn
            btn.ForeColor = Color.Gold; // Chữ chuyển sang màu vàng
        }

        // Trong mỗi sự kiện click nút, bạn gọi hàm này:
        private void btnBooking_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnBooking);
            addUserControl(new UC_Booking());
        }
    }
}