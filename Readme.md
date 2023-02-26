## About

Lambda function written in .NET 6 that receives and processes events inserted in EventBridge.

## Installation

To test the Lambda function, you first need to deploy it and then post an event to AWS EventBridge.

To deploy it, run the following command:

```
cd Lambda-EventBridge-Consumer\LambdaConsumer
dotnet lambda deploy-function
```

NOTE: You need to create a role in your AWS account with the proper permissions and change the ARN in the ```aws-lambda-tools-defaults``` file.

Event that must be posted:

```
{
  "Id": 1,
  "Message": "Test Message!"
}
```