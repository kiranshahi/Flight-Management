using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public interface IPlaneBookService
    {
        List<PlaneBook> GetAllBooking();
        List<PlaneBook> GetBookingByCustName(string custName);
        int SaveUpdateBooking(PlaneBook planeBook);
        int Cancelbooking(string custName);
    }
}
