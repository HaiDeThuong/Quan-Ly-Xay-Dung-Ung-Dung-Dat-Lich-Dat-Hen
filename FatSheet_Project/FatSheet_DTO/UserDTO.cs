using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatSheet_DTO
{
    public class UserDTO
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; } // 1: Admin, 2: Khách hàng
    }
}
