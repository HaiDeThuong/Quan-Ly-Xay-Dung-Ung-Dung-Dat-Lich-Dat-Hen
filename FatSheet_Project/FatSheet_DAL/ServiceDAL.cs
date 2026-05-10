using System;
using System.Data;
using System.Data.SqlClient;

namespace FatSheet_DAL
{
    // 1. Phải có chữ public
    // 2. Phải có : DBConnect để lấy biến 'conn'
    public class ServiceDAL : DBConnect
    {
        // Hàm này phải nằm TRONG dấu ngoặc nhọn của Class
        public DataTable GetServices()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "SELECT * FROM Services";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}