using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Owin;
using Owin;
using PBLShop.Data;
using PBLShop.Data.Infrastructure;
using System;
using System.Reflection;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(PBLShop.Web.App_Start.Startup))]

namespace PBLShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

        private void ConfigAutofac (IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<PBLShopDbContext>().AsSelf().InstancePerRequest();


        }
    }
}
