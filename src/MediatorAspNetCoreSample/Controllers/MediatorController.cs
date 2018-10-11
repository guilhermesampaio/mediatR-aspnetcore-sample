using System.Threading.Tasks;
using MediatorAspNetCoreSample.Notification;
using MediatorAspNetCoreSample.OneWay;
using MediatorAspNetCoreSample.RequestResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorAspNetCoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatorController : ControllerBase
    {
        private readonly IMediator mediator;

        public MediatorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("request/response")]
        public async Task<IActionResult> MediatorRequestResponse()
        {
            var response = await mediator.Send(new PingCommand());
            return Ok(response);
        }

        [HttpPost("oneway")]
        public async Task<IActionResult> MediatorOneWay()
        {
            await mediator.Send(new OneWayCommand());
            return Accepted();
        }

        [HttpPost("notification")]
        public async Task<IActionResult> MediatorNotification()
        {
            await mediator.Publish(new NotificationCommand());
            return Accepted();
        }
    }
}
