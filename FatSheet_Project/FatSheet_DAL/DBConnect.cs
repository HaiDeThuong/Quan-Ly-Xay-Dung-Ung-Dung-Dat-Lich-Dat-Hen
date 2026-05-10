using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FatSheet_DAL
{
    // Phải có chữ PUBLIC ở đây
    public class DBConnect
    {
        // Phải có chữ PROTECTED ở đây để lớp con (UserDAL) thấy được nó
        protected SqlConnection conn = new SqlConnection(@"Data Source=MSI\HAIXEDAP;Initial Catalog=FatSheetBarber;User ID=sa;Password=Hai21022006");
    }
}
