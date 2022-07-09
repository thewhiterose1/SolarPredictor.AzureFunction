using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarPredictor.AzureFunction.SendSolarData
{
    public class SendSolarDataOrchestrator
    {
        public SendSolarDataOrchestrator() { 
        
        }

        [FunctionName(nameof(SendSolarDataOrchestrator))]
        public static async Task<List<string>> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var outputs = new List<string>();

            try
            {
                // Query NoSQL database based on longitude/latitude

                // Apply the solar power equation with all input variables and retrieved postcode

                // Send email to relevant users
            }
            catch (Exception ex) 
            { 
                
            }

            return outputs;
        }
    }
}