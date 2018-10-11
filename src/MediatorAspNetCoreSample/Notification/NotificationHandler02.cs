using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatorAspNetCoreSample.Notification
{
    public class NotificationHandler02 : INotificationHandler<NotificationCommand>
    {
        public async Task Handle(NotificationCommand notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => Debug.WriteLine("Notification Handler 02"));
        }
    }

}
