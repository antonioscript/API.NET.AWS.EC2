# API.NET.AWS.EC2
A simple and scalable RESTful API built with .NET 8, designed to run on an Amazon EC2 instance. The project demonstrates API deployment, configuration, and hosting in a cloud environment using AWS infrastructure

## Summary
- [AWS Console](#aws-console)
- [Uploading .NET Application to EC2 Instance](#uploading-net-application-to-ec2-instance)



## AWS Console

### Connecting to EC2 and Setting Up .NET Runtime

**1. Clik on Connect**

![image](https://github.com/user-attachments/assets/effbf926-768b-4e83-a856-58418b5cd433)


**2. Copy command and paste terminal**

![image](https://github.com/user-attachments/assets/4ddd7758-339a-49f0-9569-0ebacea54733)

```
ssh -i "ec2-simple-instance.pem" ec2-user@ec2-18-206-115-78.compute-1.amazonaws.com

```

**3. On terminal**

Go to directory at file '.perm1' and execute terminal

![image](https://github.com/user-attachments/assets/41d3b0fa-b688-4490-964e-3549ae9f7554)


## Uploading .NET Application to EC2 Instance

### Go to Page Download .NET 8
https://dotnet.microsoft.com/pt-br/download/dotnet/8.0

**Click on Runtime .NET 8 for Linux**

https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/runtime-aspnetcore-8.0.16-linux-x64-binaries

![image](https://github.com/user-attachments/assets/622a2422-494d-4ca2-97a3-9b8c3a7b6284)


**Click on Runtime .NET 8 for Linux**

**Copy Link**
![image](https://github.com/user-attachments/assets/a471b8eb-10bc-4d0e-94f1-12e398a0a850)


**Paste Terminal**

![image](https://github.com/user-attachments/assets/4b92a13a-5631-49dd-b6bf-137ee8333af4)

**Go to page of SDK and copy command**

https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.410-linux-arm64-binaries

![image](https://github.com/user-attachments/assets/5bdc36c5-3c82-4ab1-8e03-c9eb0ed43be0)

**Paste Terminal**

![image](https://github.com/user-attachments/assets/e492e6a5-4977-4609-bcf6-cea680de2baf)


### Create Application on Linux



## References
https://www.rahulpnath.com/blog/amazon-ec2-dotnet-api-hosting/

https://docs.aws.amazon.com/pt_br/prescriptive-guidance/latest/patterns/run-an-asp-net-core-web-api-docker-container-on-an-amazon-ec2-linux-instance.html
