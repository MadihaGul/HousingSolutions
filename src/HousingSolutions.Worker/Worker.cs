using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HousingSolutions.Worker
{
    // The Worker class inherits from BackgroundService,
    // allowing it to run as a long-running service.
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        // Constructor injects a logger instance for logging messages
        public Worker(ILogger<Worker> logger) => _logger = logger;

        // This method is called when the worker starts and contains the main execution loop
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Loop runs until the service is stopped via the stoppingToken
            while (!stoppingToken.IsCancellationRequested)
            {
                // Logs the current time each iteration
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                // Wait for 5 seconds or until cancellation is requested
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
