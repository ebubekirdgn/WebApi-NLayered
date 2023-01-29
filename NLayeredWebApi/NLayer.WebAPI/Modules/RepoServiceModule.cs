using Autofac;
using NLayer.API.Extensions;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnifOfWorks;
using NLayer.Repository.Contexts;
using NLayer.Repository.Repositories;
using NLayer.Repository.UnitOfWorks;
using NLayer.Service.Mapping;
using NLayer.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace NLayer.API.Modules
{
    public class RepoServiceModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnifOfWorks>();


            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(BaseDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.IsAssignableToGenericType(typeof(GenericRepository<>)) ).AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.IsAssignableToGenericType(typeof(Service<>))).AsImplementedInterfaces().InstancePerLifetimeScope();

            // builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

            //InstancePerLifetimeScope => scope'a karsilik gelir.
            //InstancePerDependecy => transient'a karsilik gelir.
        }
    }
}