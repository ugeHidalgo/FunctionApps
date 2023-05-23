using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.IO;

namespace BlobTriggeredFunction
{
    public class BlobFunction
    {
        [FunctionName("BlobFunction")]
        public void Run([BlobTrigger("uge-blob-container/{name}", Connection = "connection")]Stream myBlob, string name, ILogger log)
        {
            if (myBlob != null) 
            {
                log.LogInformation($"C# Blob trigger function processed: Name{name}");
            }
            else
            {
                log.LogInformation($"C# Blob trigger function processed: deleted file: {name}");
            }
        }
    }
}
