using System.IO;
using Microsoft.Azure.WebJobs;

namespace ContosoAdsConsole
{
    public class CreateQueueMessage
    {
        public static void CreateQueueMessages(
            [QueueTrigger("inputqueue")] string queueMessage,
            [Queue("outputqueue")] ICollector<string> outputQueueMessage,
            TextWriter logger)
        {
            logger.WriteLine("Creating 2 messages in outputqueue");
            outputQueueMessage.Add(queueMessage + "1");
            outputQueueMessage.Add(queueMessage + "2");
            var ttt = outputQueueMessage.ToString();
        }
    }
}
