using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPredictor.AzureFunction.SendSolarData
{
    public class SolarDataEquationActivity
    {
        private readonly ILogger _logger;
        
        public SolarDataEquationActivity(ILogger logger) 
        { 
            _logger = logger;
        }

        [FunctionName(nameof(SolarDataEquationActivity))]
        public static string SayHello([ActivityTrigger] string name, ILogger log)
        {
            log.LogInformation($"Saying hello to {name}.");
            return $"Hello {name}!";
        }
    }
}
