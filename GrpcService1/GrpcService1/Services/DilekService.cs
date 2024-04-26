using Grpc.Core;
using GrpcService1;

namespace GrpcService1.Services
{
    public class DilekService:Dilek.DilekBase
    {
        public override Task<DilekReply> HiDilek(DilekRequest request, ServerCallContext context)
        {
            return Task.FromResult(new DilekReply
            {
                Message = "Hello from Dilek"
            });
        }
    }
}
