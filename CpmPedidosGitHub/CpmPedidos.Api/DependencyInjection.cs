using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpmPedidos.Api
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependency(serviceProvider);
        }

        private static void RepositoryDependency(IServiceCollection serviceProvider)
        {

        }
    }
}
