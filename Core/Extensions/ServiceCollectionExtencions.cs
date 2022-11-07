using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtencions
    {
        public static IServiceCollection AddDependecyResovers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var modul in modules)
            {
                modul.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
