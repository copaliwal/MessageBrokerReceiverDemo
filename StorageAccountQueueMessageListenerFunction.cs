using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MessageBrokerReceiverDemo
{
    public static class StorageAccountQueueMessageListenerFunction
    {
        [Function("StorageAccountQueueMessageListenerFunction")]
        public static void Run([QueueTrigger("appqueue", Connection = "StorageAccountQueueConnectionString")] string myQueueItem,
            FunctionContext context)
        {
            var logger = context.GetLogger("StorageAccountQueueMessageListenerFunction");
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
