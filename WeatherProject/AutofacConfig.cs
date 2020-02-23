using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Features.AttributeFilters;
using Autofac.Integration.Mvc;
using WeatherProject.Interfaces.Repositories;
using WeatherProject.Repositories;
using WeatherProject.Services;

namespace WeatherProject
{
    /// <summary>
    /// Autofac類型註冊
    /// </summary> 
    public static class AutofacConfig
    { 
        /// <summary>
        /// 註冊類型
        /// </summary>
        /// <param name="builder">Used to build an Autofac.IContainer from component registrations.</param>
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<WeatherService>()
            .As<IWeatherService>()
            .InstancePerRequest();

            builder.RegisterType<WeatherReportRepository>()
           .As<IWeatherReportRepository>()
           .InstancePerRequest();
             
            builder.RegisterFilterProvider();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}