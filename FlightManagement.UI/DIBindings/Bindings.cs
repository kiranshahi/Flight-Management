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
            Bind<IDBO>().To<DBO>();
        }
    }
}
