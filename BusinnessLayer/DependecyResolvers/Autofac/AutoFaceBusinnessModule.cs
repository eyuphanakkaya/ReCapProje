using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinnessLayer.Abstract;
using BusinnessLayer.Concrete;
using Castle.DynamicProxy;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.DependecyResolvers.Autofac
{
    public class AutoFaceBusinnessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUsersDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
