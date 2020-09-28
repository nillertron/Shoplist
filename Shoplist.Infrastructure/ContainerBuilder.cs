using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Shoplist.Infrastructure
{
    public static class ContainerBuilder
    {
        public static void ConfigureInfrastructure(this IServiceCollection services)
        {
            var list = Assembly.Load("Shoplist.Infrastructure").GetTypes().Where(x => !x.IsNested && !x.IsInterface && !x.FullName.Contains("DTO")).ToList();
            list.ForEach(x =>
            {
                if (x.Name == "ContainerBuilder")
                {

                }
                else
                {
                    services.AddTransient(x.GetInterfaces().FirstOrDefault(), x);
                }
            });
        }
        public static void ConfigureDatabase(this IServiceCollection services)
        {
            var list = Assembly.Load("Shoplist.Database").GetTypes().Where(x => !x.IsNested && !x.FullName.Contains("Migrations") && x.Name != "ShopContext" && !x.Name.Contains("Anonymous") && !x.IsInterface).ToList();
            list.ForEach(x =>
            {
                services.AddTransient(x.GetInterfaces().FirstOrDefault(), x);
            });
        }
    }
}
