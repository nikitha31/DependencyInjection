using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreeTierDIUnity.Services;
using Unity;

namespace ThreeTierDIUnity.App_Start
{
    
    public static class ClassForUnity
    {
        public static void ConfigureUnity()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IEmployee, Employee>();
            DependencyResolver.SetResolver();
        }
    }
}