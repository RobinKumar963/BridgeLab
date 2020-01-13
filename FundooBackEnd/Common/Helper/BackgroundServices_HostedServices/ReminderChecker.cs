using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Helper.BackgroundServices_HostedServices
{
    public class ReminderChecker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Debug.WriteLine("Hello World");
                await Task.Delay(10000, stoppingToken);
            }

            
        }
    }
}
