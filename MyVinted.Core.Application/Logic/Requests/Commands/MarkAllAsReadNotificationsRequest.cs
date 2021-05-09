using MediatR;
using MyVinted.Core.Application.Logic.Responses.Commands;

namespace MyVinted.Core.Application.Logic.Requests.Commands
{
    public record MarkAllAsReadNotificationsRequest : IRequest<MarkAllAsReadNotificationsResponse>
    { }
}