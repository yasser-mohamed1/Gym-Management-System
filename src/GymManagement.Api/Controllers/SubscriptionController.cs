using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using GymManagement.Application.Subscriptions.Commands;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionController : ControllerBase
{
    private readonly ISender _mediator;
    public SubscriptionController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public  async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(
            request.SubscriptionType.ToString(),
            request.AdminId);
            
        var subscriptionId = await _mediator.Send(command);

        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

        return Ok(response);
    }
}