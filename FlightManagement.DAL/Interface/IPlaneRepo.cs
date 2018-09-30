using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.DAL
{
    public interface IPlaneRepo
    {
        List<Plane> GetAllPlanes();
        List<Plane> GetPlanesById(string planeId);
        int SaveUpdatePlane(Plane plane);
        int DeletePlane(int planeId);
    }
}
