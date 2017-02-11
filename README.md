# Microsoft Azure Exam 70-534 Prep
## Service Bus demonstration

### What's in this repository?
In this repository are the files to recreate the demonstration of Service Bus, which is part of the Microsoft Azure Exam 70-534 prep course.

You can use these files to build the services demonstrated and run them on your own.

**Important Note**: Azure services are _not_ included in your Linux Academy subscription. If you choose to deploy the services used in this demo, you may be charged by Microsoft for Azure services. If so, you will be billed directly by Microsoft. Again, your Linux Academy subscription does _not_ include Azure services.

Included in this repositiory are four folders:

**functions**: This code is for the Azure Functions which put messages on a Service Bus queue and topic.

**ServiceBusQueueReceiver**: This is a .NET 4.6 console application that pulls messages off a service bus queue. Note that you can only build and run this console application on a Windows computer, because the Service Bus clients for .NET Core are not mature enough to be used in a console application.

**ServiceBusTopicReceiver**: This is another .NET 4.6 console application that pulls messages in a specific subscription off a topic queue. Note that you can only build and run this console application on a Windows computer, because the Service Bus clients for .NET Core are not mature enough to be used in a console application.

**template** This folder contains an ARM template and parameter file you can use to create the services used in the demo. Note that if you choose to use the parameter file, you must provide valid values for each parameter.

Note also that in the functions and both console applications, you will need to correct all connection strings to connect to your Service Bus account and queues.