using FatSheet_BUS;
using System;
using System.Windows.Forms;

namespace FatSheet_GUI
{
    public partial class frmLogin : Form
    {
        UserBUS bus = new UserBUS(); // Gọi lớp BUS

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (bus.Login(phone, pass))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form Chính (Chúng ta sẽ tạo ở bước dưới)
                frmMain main = new frmMain();
                this.Hide(); // Ẩn form đăng nhập đi
                main.Show();
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            // Chuyển sang Form Đăng Ký nếu chưa có tài khoản
            frmRegister reg = new frmRegister();
            this.Hide();
            reg.Show();
        }
    }
}