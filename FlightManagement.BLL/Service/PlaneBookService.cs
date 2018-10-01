using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement.DAL;
using FlightManagement.Domain;

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

        public List<PlaneBook> GetBookingByCustName(string custName)
        {
            try
            {
                return _planeBookRepo.GetBookingByCustName(custName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdateBooking(PlaneBook planeBook)
        {
            try
            {
                return _planeBookRepo.SaveUpdateBooking(planeBook);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
