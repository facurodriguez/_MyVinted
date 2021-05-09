using MyVinted.Core.Application.Models;

namespace MyVinted.Core.Application.Logic.Responses.Commands
{
    public record ConfirmAccountResponse : BaseResponse
    {
        public ConfirmAccountResponse(Error error = null) : base(error) { }
    }
}