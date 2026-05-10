using FatSheet_DTO; 
using System;
using System.Data;
using System.Data.SqlClient;

namespace FatSheet_DAL
{
    public class UserDAL : DBConnect
    {
        
        public bool InsertUser(UserDTO user)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

               
                string sql = "INSERT INTO Users(FullName, PhoneNumber, Password, RoleID) VALUES(@name, @phone, @pass, 2)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.FullName);
                cmd.Parameters.AddWithValue("@phone", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@pass", user.Password);

                return cmd.ExecuteNonQuery() > 0; 
            }
            catch (Exception) { return false; }
            finally { conn.Close(); }
        }

  
        public bool CheckLogin(string phone, string pass)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT UserID, FullName FROM Users WHERE PhoneNumber=@p AND Password=@pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                  
                    GlobalUser.UserID = (int)dr["UserID"];
                    GlobalUser.FullName = dr["FullName"].ToString();
                    return true;
                }
                return false;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBarbers()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string sql = "SELECT UserID, FullName FROM Users WHERE RoleID = 3"; 
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}