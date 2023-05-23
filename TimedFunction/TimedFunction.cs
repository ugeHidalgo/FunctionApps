using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace TimedFunction
{
    public class TimedFunction
    {
        [FunctionName("TimedFunction")]
        public void Run([TimerTrigger("* */2 * * * *")]TimerInfo myTimer, ILogger log) //Every 2 minutes
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
