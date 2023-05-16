using AjaxDropdown.Repository.Repository;
using AjaxDropdown.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AjaxDropdown
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDropDown, DropDownServices>();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}