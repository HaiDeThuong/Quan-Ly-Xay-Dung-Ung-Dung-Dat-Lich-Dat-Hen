using FatSheet_BUS;
using FatSheet_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatSheet_GUI
{
    public partial class frmRegister : Form
    {
        UserBUS bus = new UserBUS();
        public frmRegister()
        {
            InitializeComponent();
            // Khi di chuột vào nút Đăng ký
            btnRegister.MouseEnter += (s, e) =>
            {
                btnRegister.BackColor = Color.FromArgb(64, 64, 64); // Đổi sang xám đậm
            };
            // Khi chuột rời khỏi
            btnRegister.MouseLeave += (s, e) =>
            {
                btnRegister.BackColor = Color.Black; // Trở lại đen
            };
        }

        // Code chuyển form
        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện (Nhớ đặt tên các TextBox đúng nhé)
            UserDTO user = new UserDTO();
            user.FullName = txtFullName.Text.Trim();
            user.PhoneNumber = txtPhone.Text.Trim();
            user.Password = txtPass.Text.Trim();
            string rePass = txtConfirmPass.Text.Trim();

            // 2. Gọi lớp BUS để xử lý
            string result = bus.Register(user, rePass);

            // 3. Hiển thị kết quả
            if (result == "Success")
            {
                MessageBox.Show("Chúc mừng! Bạn đã trở thành thành viên của Fat Sheet Barber.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi đăng ký thành công, tự động chuyển về Form Đăng nhập
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
