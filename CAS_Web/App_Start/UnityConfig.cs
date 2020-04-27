using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using CAS_Repo;

namespace CAS_Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            UnityConfig.RegisterComponents();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ILogin, LoginRepo>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}