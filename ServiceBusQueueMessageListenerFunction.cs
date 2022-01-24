using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MessageBrokerReceiverDemo
{
    public static class ServiceBusQueueMessageListenerFunction
    {
        [Function("ServiceBusQueueMessageListenerFunction")]
        public static void Run([ServiceBusTrigger("app_queue", Connection= "ServiceBusQueueConnectionString")] string myQueueItem, FunctionContext context)
        {
            var logger = context.GetLogger("ServiceBusQueueMessageListenerFunction");
            logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
