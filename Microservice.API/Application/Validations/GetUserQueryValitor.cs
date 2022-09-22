using FluentValidation;
using Microservice.API.Application.Queries;

namespace Microservice.API.Application.Validations;

public class GetUserQueryValitor : AbstractValidator<GetUserQuery>
{
    public GetUserQueryValitor()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("not null");
        RuleFor(x => x.Id).NotEmpty().WithMessage("xz");
    }
}