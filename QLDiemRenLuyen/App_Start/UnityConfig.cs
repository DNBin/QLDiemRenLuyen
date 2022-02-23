using QLDiemRenLuyen.Data;
using QLDiemRenLuyen.Interfaces;
using QLDiemRenLuyen.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace QLDiemRenLuyen
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            //container.RegisterType<DataContext>();
            container.RegisterType<ISinhVienService, SinhVienService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}