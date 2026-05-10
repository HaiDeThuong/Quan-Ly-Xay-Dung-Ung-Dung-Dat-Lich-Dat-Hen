using FatSheet_DAL;
using FatSheet_DTO;
using System;
using System.Data;

namespace FatSheet_BUS
{
    public class UserBUS
    {
        UserDAL userDAL = new UserDAL();

        // Hàm Đăng Nhập
        public bool Login(string phone, string pass)
        {
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(pass)) return false;
            return userDAL.CheckLogin(phone, pass);
        }

        // Hàm Đăng Ký (BẠN ĐANG THIẾU CÁI NÀY NÈ)
        public string Register(UserDTO user, string confirmPass)
        {
            if (string.IsNullOrEmpty(user.FullName) || string.IsNullOrEmpty(user.PhoneNumber) || string.IsNullOrEmpty(user.Password))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (user.Password != confirmPass)
                return "Mật khẩu xác nhận không khớp!";

            if (userDAL.InsertUser(user))
                return "Success";

            return "Đăng ký thất bại (Số điện thoại có thể đã tồn tại)!";
        }
        public DataTable GetBarberList()
        {
            return userDAL.GetBarbers();
        }
    }
}