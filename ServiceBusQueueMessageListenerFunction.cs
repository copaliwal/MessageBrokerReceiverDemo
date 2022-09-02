using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MessageBrokerReceiverDemo
{
    public static class ServiceBusQueueMessageListenerFunction
    {
        [Function("ServiceBusQueueMessageListenerFunction")]
        public static void Run([ServiceBusTrigger("queue123", Connection = "ServiceBusQueueConnectionString")] string myQueueItem, FunctionContext context)
        {
            //throw new System.Exception("Dummy exception");
            var logger = context.GetLogger("ServiceBusQueueMessageListenerFunction");
            logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
