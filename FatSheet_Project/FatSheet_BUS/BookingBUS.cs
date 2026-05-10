using System.Data;
using FatSheet_DAL;
using FatSheet_DTO;

namespace FatSheet_BUS
{
    public class BookingBUS
    {
        ServiceDAL sDal = new ServiceDAL();
        BookingDAL bDal = new BookingDAL();

        // Lấy danh sách dịch vụ để hiện lên ComboBox
        public DataTable GetServices()
        {
            return sDal.GetServices();
        }

        // Xử lý đặt lịch
        public bool CreateBooking(BookingDTO booking)
        {
            // Có thể thêm logic: Ví dụ không cho đặt quá 3 lịch/ngày
            return bDal.InsertBooking(booking);
        }
        public DataTable GetHistory(int userId)
        {
            return bDal.GetHistory(userId);
        }
        public bool CancelBooking(int bookingId)
        {
            return bDal.DeleteBooking(bookingId);
        }
    }
}