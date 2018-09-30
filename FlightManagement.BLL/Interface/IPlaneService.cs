using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public interface IPlaneService
    {
        List<Plane> GetAllPlanes();
        List<Plane> GetPlanesById(string planeId);
        int SaveUpdatePlane(Plane plane);
        int DeletePlane(int planeId);
    }
}
