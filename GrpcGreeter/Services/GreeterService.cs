﻿using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

#region snippet
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "哈囉～ " + request.Name
        });
    }
}
#endregion