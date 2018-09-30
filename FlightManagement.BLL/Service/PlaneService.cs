using FlightManagement.DAL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public class PlaneService : IPlaneService
    {
        private readonly IPlaneRepo _planeRepo;
        public PlaneService(IPlaneRepo _planeRepo)
        {
            this._planeRepo = _planeRepo;
        }

        public int DeletePlane(int custId)
        {
            try
            {
                return _planeRepo.DeletePlane(custId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Plane> GetAllPlanes()
        {
            try
            {
                return _planeRepo.GetAllPlanes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Plane> GetPlanesById(string custId)
        {
            try
            {
                return _planeRepo.GetPlanesById(custId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdatePlane(Plane cust)
        {
            try
            {
                return _planeRepo.SaveUpdatePlane(cust);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
