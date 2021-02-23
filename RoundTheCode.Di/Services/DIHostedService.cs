using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RoundTheCode.Di.Services
{
    public class DIHostedService : IHostedService
    {
        protected readonly IServiceProvider _serviceProvider;

        public DIHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var singletonService = scope.ServiceProvider.GetRequiredService<ISingletonService>();
                var scopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                var transientService = scope.ServiceProvider.GetRequiredService<ITransientService>();

                Debug.WriteLine(string.Format("Singleton time is {0}", singletonService.Time));
                Debug.WriteLine(string.Format("Scoped time is {0}", scopedService.Time));
                Debug.WriteLine(string.Format("Transient time is {0}", transientService.Time));
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                var singletonService = scope.ServiceProvider.GetRequiredService<ISingletonService>();
                var scopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                var transientService = scope.ServiceProvider.GetRequiredService<ITransientService>();

                Debug.WriteLine(string.Format("Singleton time is {0}", singletonService.Time));
                Debug.WriteLine(string.Format("Scoped time is {0}", scopedService.Time));
                Debug.WriteLine(string.Format("Transient time is {0}", transientService.Time));
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
