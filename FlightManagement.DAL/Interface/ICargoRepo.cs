using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.DAL
{
    public interface ICargoRepo
    {
        List<Cargo> GetAllCargo();
        List<Cargo> GetCargoById(string cargoId);
        List<Plane> GetAllCargoPlanes();
        int SaveUpdateCargo(Cargo cargo);
        int DeleteCargo(int cargoId);
    }
}
