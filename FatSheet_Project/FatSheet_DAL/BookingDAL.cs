using FatSheet_DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FatSheet_DAL
{
    public class BookingDAL : DBConnect
    {
        public bool InsertBooking(BookingDTO booking)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "INSERT INTO Bookings(UserID, BarberID, ServiceID, BookingDate, Status) " +
                             "VALUES(@uid, @bid, @sid, @date, N'Pending')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", booking.UserID);
                cmd.Parameters.AddWithValue("@bid", booking.BarberID); 
                cmd.Parameters.AddWithValue("@sid", booking.ServiceID);
                cmd.Parameters.AddWithValue("@date", booking.BookingDate);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { conn.Close(); }
        }
        public DataTable GetHistory(int userId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT b.BookingID as 'Mã', 
                              s.ServiceName as 'Dịch vụ', 
                              k.FullName as 'Khách hàng', 
                              t.FullName as 'Thợ cắt', 
                              b.BookingDate as 'Ngày hẹn', 
                              b.Status as 'Trạng thái'
                       FROM Bookings b
                       JOIN Services s ON b.ServiceID = s.ServiceID
                       JOIN Users k ON b.UserID = k.UserID
                       JOIN Users t ON b.BarberID = t.UserID";

                if (userId != 1)
                {
                    sql += " WHERE b.UserID = @uid";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (userId != 1) cmd.Parameters.AddWithValue("@uid", userId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally { conn.Close(); }
        }
        public bool DeleteBooking(int bookingId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "DELETE FROM Bookings WHERE BookingID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", bookingId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}