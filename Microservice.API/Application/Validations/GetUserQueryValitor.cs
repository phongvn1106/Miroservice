using FluentValidation;
using Microservice.API.Application.Queries;

namespace Microservice.API.Application.Validations
{
    public class GetUserQueryValitor : AbstractValidator<GetUserQuery>
    {
        public GetUserQueryValitor()
        {
            RuleFor(command => command.Id).NotNull().WithMessage("Command sdsd");
        }
    }
}
