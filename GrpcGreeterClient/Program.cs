#region snippet2
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

#region snippet
Console.OutputEncoding=System.Text.Encoding.Unicode;
Console.InputEncoding=System.Text.Encoding.Unicode;

Console.WriteLine("Press any key to connect...");
Console.ReadKey();
// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:62541");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "David" });
Console.WriteLine("伺服器端回傳: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
#endregion
#endregion
