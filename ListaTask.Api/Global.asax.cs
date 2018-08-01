using ListaTask.Api.Service;
using ListaTask.Infra.Repositories;
using ListTask.Domain.Repository.Interface;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace ListaTask.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            GlobalConfiguration.Configure(WebApiConfig.Register);        


        var container = new Container();

        container.Register<ITaskServece, TaskService>(Lifestyle.Scoped);
        container.Register<ITaskInterfaceRepository, TaskRepository>(Lifestyle.Scoped);
 
        container.RegisterWebApiControllers(GlobalConfiguration.Configuration); //web api          
        container.Verify();
        
        GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
