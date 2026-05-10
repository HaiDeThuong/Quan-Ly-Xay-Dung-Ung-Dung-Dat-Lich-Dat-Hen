using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatSheet_DTO
{
    internal class BookingDTO
    {
    }
}
public class BookingDTO
{
    public int BookingID { get; set; }
    public int UserID { get; set; }
    public int ServiceID { get; set; }
    public int BarberID { get; set; }
    public DateTime BookingDate { get; set; }
    public string Status { get; set; }
}

