using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Data;

namespace FlightManagement.DAL
{
    public interface IPlaneBookRepo
    {
        List<PlaneBook> GetAllBooking();
        List<PlaneBook> GetAllBookingCurrentDate(string departureDate);
        List<PlaneBook> GetBookingByCustName(string custName, string departureDate);
        DataTable CheckBookStatus(int PlaneId, DateTime departureTime);
        int SaveUpdateBookingCust(PlaneBook planeBook);
        int SaveUpdateBookingCargo(PlaneBook planeBook);
        int Cancelbooking(string custName);
    }
}
