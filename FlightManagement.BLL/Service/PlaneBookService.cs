using FlightManagement.DAL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public class PlaneBookService : IPlaneBookService
    {
        private readonly IPlaneBookRepo _planeBookRepo;
        public PlaneBookService(IPlaneBookRepo _planeBookRepo)
        {
            this._planeBookRepo = _planeBookRepo;
        }
        public int Cancelbooking(string custName)
        {
            try
            {
                return _planeBookRepo.Cancelbooking(custName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PlaneBook> GetAllBooking()
        {
            try
            {
                return _planeBookRepo.GetAllBooking();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PlaneBook> GetAllBookingCurrentDate(string departureDate)
        {
            try
            {
                return _planeBookRepo.GetAllBookingCurrentDate(departureDate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PlaneBook> GetBookingByCustName(string custName, string departureDate)
        {
            try
            {
                return _planeBookRepo.GetBookingByCustName(custName, departureDate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdateBookingCargo(PlaneBook planeBook)
        {
            try
            {
                return _planeBookRepo.SaveUpdateBookingCargo(planeBook);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdateBookingCust(PlaneBook planeBook)
        {
            try
            {
                return _planeBookRepo.SaveUpdateBookingCust(planeBook);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
