using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public interface IPlaneService
    {
        List<Plane> GetAllPlanes();
        List<Plane> GetPlanesById(string planeId);
        List<Plane> GetPlanesByPlaneType(string planeType);
        int SaveUpdatePlane(Plane cust);
        int DeletePlane(int planeId);
    }
}
