using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaConsumer;

public class Function
{
    public void FunctionHandler(CloudWatchEvent<TestEvent> input, ILambdaContext context)
    {
        context.Logger.LogInformation($"Lambda consumer received test event Id: {input.Detail.Id}, Message: {input.Detail.Message}");
    }
}