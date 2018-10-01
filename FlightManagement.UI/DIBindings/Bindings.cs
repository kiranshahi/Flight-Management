using FlightManagement.BLL;
using FlightManagement.DAL;
using Ninject.Modules;

namespace FlightManagement.UI.DIBindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerService>();
            Bind<ICustomerRepo>().To<CustomerRepo>();
            Bind<IPlaneService>().To<PlaneService>();
            Bind<IPlaneRepo>().To<PlaneRepo>();
            Bind<ICargoRepo>().To<CargoRepo>();
            Bind<ICargoService>().To<CargoService>();
            Bind<IPlaneBookRepo>().To<PlaneBookRepo>();
            Bind<IPlaneBookService>().To<PlaneBookService>();
            Bind<IDBO>().To<DBO>();
        }
    }
}
