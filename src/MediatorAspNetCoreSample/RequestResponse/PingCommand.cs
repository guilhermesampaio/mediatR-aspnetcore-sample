using MediatR;

namespace MediatorAspNetCoreSample.RequestResponse
{
    public class PingCommand : IRequest<string>
    {
    }

}
