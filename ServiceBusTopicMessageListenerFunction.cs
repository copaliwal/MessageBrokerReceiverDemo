using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MessageBrokerReceiverDemo
{
    public static class ServiceBusTopicMessageListenerFunction
    {
        [Function("ServiceBusTopicMessageListenerFunction")]
        public static void Run([ServiceBusTrigger("app_topic", "SubscriptionA", Connection = "ServiceBusTopicConnectionString")] string mySbMsg, FunctionContext context)
        {
            var logger = context.GetLogger("ServiceBusTopicMessageListenerFunction");
            logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
