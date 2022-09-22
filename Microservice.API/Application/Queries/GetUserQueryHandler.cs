using MediatR;
using Microservice.API.Application.Models;
using Microservice.Core.Models.Response;

namespace Microservice.API.Application.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, JsonResponse<UserDto>>
    {
        public async Task<JsonResponse<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return new OkResponse<UserDto>("", new UserDto
            {
                Id = request.Id,
                Name = "sd"
            });
        }
    }
}
