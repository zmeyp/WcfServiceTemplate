using Business.Logic;
using Data.Access;
using Microsoft.Practices.Unity;
using Service.Contracts;
using Service.Implementation;
using Unity.Wcf;

namespace Service.WebHost
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // register all your components with the container here
            container
               .RegisterType<IService1, Service1>()
               .RegisterType<IAction, Action>()
               .RegisterType<IRepository, Repository>(new HierarchicalLifetimeManager());
        }
    }    
}