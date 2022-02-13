using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Repository;
using VY.Covid19Vaccination.Infrastrucure.Repository;

namespace VY.Covid19Vaccination.Infrastrucure
{

    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICovid19Repository, Covid19Repository>();
        }
    }
}
