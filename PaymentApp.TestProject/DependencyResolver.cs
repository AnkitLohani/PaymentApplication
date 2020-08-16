using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentApp.BusinessLogic.BusinessLogicInterface;
using PaymentApp.Service.ServiceInterfaces;
using System;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Configuration.FileExtensions;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PaymentApp.Service;
using PaymentApp.BusinessLogic;

namespace PaymentApp.TestProject
{
   public static class DependencyResolver
    {
        static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true,
                             reloadOnChange: true);
            return builder.Build();
        }

        public static ServiceProvider ResolveDependency()
        {
            var serviceProvider = new ServiceCollection()
                .AddHttpClient()
                .AddLogging()
                .AddSingleton(LoadConfiguration())
                .AddSingleton(typeof(IPaymentService), typeof(PaymentService))
                .AddSingleton(typeof(IPaymentBusinessLogic), typeof(PaymentBusinessLogic))

                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
