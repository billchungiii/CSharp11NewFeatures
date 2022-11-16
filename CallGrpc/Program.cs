using Grpc.Net.Client;
using GrpcServiceSample001;
using System.Net.Http.Headers;

namespace CallGrpc
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("input ..");
            var name = Console.ReadLine();
            using (var channel = GrpcChannel.ForAddress("https://localhost:7119"))
            {
                var client = new GrpcServiceSample001.Greeter.GreeterClient(channel);
                var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
                Console.WriteLine($"回應 : {reply.Message}");
            }
            Console.ReadLine();
        }
    }
}