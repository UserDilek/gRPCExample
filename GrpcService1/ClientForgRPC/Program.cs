using Grpc.Net.Client;
using GrpcService1;
using System.Linq.Expressions;

Console.WriteLine("Hello from dilek");


var channel = GrpcChannel.ForAddress("https://localhost:7024");
var greeterClient = new Greeter.GreeterClient(channel);

var clientResult = await greeterClient.SayHelloAsync(new HelloRequest { Name = "Example Name" });
Console.WriteLine(clientResult.Message);




Console.ReadLine();





