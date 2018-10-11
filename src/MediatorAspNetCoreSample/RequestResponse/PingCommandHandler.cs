using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatorAspNetCoreSample.RequestResponse
{
    public class PingCommandHandler : IRequestHandler<PingCommand, string>
    {
        public Task<string> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
        }
    }

}
