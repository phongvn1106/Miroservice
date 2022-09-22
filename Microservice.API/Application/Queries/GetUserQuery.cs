using MediatR;
using Microservice.API.Application.Models;
using Microservice.Core.Models;
using Microservice.Core.Models.Response;

namespace Microservice.API.Application.Queries
{
    public class GetUserQuery : RequestBase, IRequest<JsonResponse<UserDto>>
    {
        public int Id { get; set; }
    }
}
