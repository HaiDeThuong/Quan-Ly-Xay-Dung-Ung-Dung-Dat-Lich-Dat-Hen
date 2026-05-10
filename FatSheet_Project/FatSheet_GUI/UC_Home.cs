using System;
using System.Windows.Forms;
using FatSheet_DTO; // Phải có dòng này

namespace FatSheet_GUI
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem GlobalUser đã có dữ liệu chưa
            if (GlobalUser.UserID != 0)
            {
                // Bây giờ mình dùng đúng tên lblWelcome
                lblWelcome.Text = "XIN CHÀO, " + GlobalUser.FullName.ToUpper() + "!";
            }
            else
            {
                lblWelcome.Text = "CHÀO MỪNG BẠN ĐẾN VỚI FAT SHEET BARBER!";
            }
        }
    }
}