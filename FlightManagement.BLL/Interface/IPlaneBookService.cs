using FlightManagement.Domain;
using System;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public interface IPlaneBookService
    {
        List<PlaneBook> GetAllBooking();
        List<PlaneBook> GetAllBookingCurrentDate(string departureDate);
        List<PlaneBook> GetBookingByCustName(string custName, string departureDate);
        int SaveUpdateBookingCust(PlaneBook planeBook);
        int SaveUpdateBookingCargo(PlaneBook planeBook);
        int Cancelbooking(string custName);
    }
}
