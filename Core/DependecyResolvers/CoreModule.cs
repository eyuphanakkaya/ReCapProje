using Autofac.Core;
using Core.CrossCuttinConcerns.Cache;
using Core.CrossCuttinConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependecyResovers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddMemoryCache();//Imemorycache karşılığı
            serviceDescriptors.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            serviceDescriptors.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
