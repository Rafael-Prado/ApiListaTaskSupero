using ListaTask.Api.Service;
using ListaTask.Infra.Context;
using ListaTask.Infra.Data;
using ListaTask.Infra.Repositories;
using ListaTask.Infra.Transactions;
using ListTask.Domain.Commands.Handlers;
using ListTask.Domain.Repository.Interface;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ListaTask.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            GlobalConfiguration.Configure(WebApiConfig.Register);
            


            var container = new Container();

        container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<ITaskServece, TaskService>(Lifestyle.Scoped);
            container.Register<ITaskInterfaceRepository, TaskRepository>(Lifestyle.Scoped);
            container.Register<TaskCommandHandler, TaskCommandHandler>(Lifestyle.Scoped);
            container.Register<IUow, Uow>(Lifestyle.Scoped);
            container.Register<ContextListaTask>(Lifestyle.Scoped);
            container.Register<ListaTaskContext>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration); //web api          
        container.Verify();
        
        GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
