using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ContosoAdsWebJob
{
    public class Functions
    {
        public static void CreateQueueMessages(
            [QueueTrigger("thumbnailrequest")] string queueMessage,
            [Queue("outputqueue")] ICollector<string> outputQueueMessage,
            TextWriter logger)
        {
            logger.WriteLine("Creating 2 messages in outputqueue");
            outputQueueMessage.Add(queueMessage + "1");
            outputQueueMessage.Add(queueMessage + "2");
            Console.WriteLine(logger);
            Console.WriteLine(outputQueueMessage.ToString());
        }
    }
}
