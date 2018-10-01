using FlightManagement.DAL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepo _cargoRepo;
        public CargoService(ICargoRepo _cargoRepo)
        {
            this._cargoRepo = _cargoRepo;
        }

        public int DeleteCargo(int cargoId)
        {
            try
            {
                return _cargoRepo.DeleteCargo(cargoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Cargo> GetAllCargo()
        {
            try
            {
                return _cargoRepo.GetAllCargo();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Cargo> GetCargoById(string cargoId)
        {
            try
            {
                return _cargoRepo.GetCargoById(cargoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdateCargo(Cargo cargo)
        {
            try
            {
                return _cargoRepo.SaveUpdateCargo(cargo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
