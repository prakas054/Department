using Autofac;
using Autofac.Integration.WebApi;
using DepartmentManagement.Models;
using DepartmentManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace DepartmentManagement
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void SetUpForAutofac(HttpConfiguration config)
        {
            // Get your HttpConfiguration.
            var configs = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            //uses reflection
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StudentRepo>().As<IStudentRepo<Student>>().SingleInstance();
            builder.RegisterType<DepartmentRepo>().As<IDepartmentRepo<Department>>().SingleInstance();
            builder.RegisterType<Student>().SingleInstance();
            builder.RegisterType<Department>().SingleInstance();

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(configs);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
