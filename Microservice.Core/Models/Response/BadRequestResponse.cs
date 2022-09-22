using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Microservice.Core.Models.Response
{
    public class BadRequestResponse<T> : JsonResponse<T>
    {
        public BadRequestResponse()
        {

        }
        public BadRequestResponse(string message, IEnumerable<ErrorDetail> errors = null)
        {
            Message = message;
            Errors = errors;
            Code = 400;
        }
    }
}
