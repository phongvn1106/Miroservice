using MediatR;
using Microservice.API.Application.Models;
using Microservice.API.Application.Queries;
using Microservice.Core.Models.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-lists")]
        public async Task<JsonResponse<UserDto>> Index([FromQuery] GetUserQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
