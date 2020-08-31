using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Totvs.Application;
using Totvs.Application.Interface;
using Totvs.Domain.Interfaces.Repositories;
using Totvs.Domain.Interfaces.Services;
using Totvs.Domain.Services;
using Totvs.Infra.Data.Repositories;

namespace Totvs.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();            
            
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IPacienteAppService, PacienteAppService>(Lifestyle.Scoped);
            container.Register<IEnderecoAppService, EnderecoAppService>(Lifestyle.Scoped);
            container.Register<IPacienteService, PacienteService>(Lifestyle.Scoped);
            container.Register<IEnderecoService, EnderecoService>(Lifestyle.Scoped);
            container.Register<IPacienteRepository,PacienteRepository > (Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
