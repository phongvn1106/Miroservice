using System.Net;

namespace Microservice.Core.Models.Response
{
    public class OkResponse<T> : JsonResponse<T>
    {
        public OkResponse()
        {

        }
        public OkResponse(string message, T data = default)
        {
            Message = message;
            Data = data;
            Code = (int)HttpStatusCode.OK;
        }
    }
}
