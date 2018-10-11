using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatorAspNetCoreSample.OneWay
{
    public class OneWayCommandHandler : AsyncRequestHandler<OneWayCommand>
    {
        protected override async Task Handle(OneWayCommand request, CancellationToken cancellationToken)
        {
            await Task.Run(() => Debug.WriteLine("One Way handling"));
        }
    }

}
