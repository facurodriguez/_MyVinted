using FluentValidation;
using MediatR;
using MyVinted.Core.Application.Logic.Responses.Queries;

namespace MyVinted.Core.Application.Logic.Requests.Queries
{
    public record GetUserRequest : IRequest<GetUserResponse>
    {
        public string UserId { get; init; }
    }

    public class GetUserRequestValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserRequestValidator()
        {
            RuleFor(x => x.UserId).NotNull();
        }
    }
}