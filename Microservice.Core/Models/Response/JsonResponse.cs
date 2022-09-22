using System.Collections.Generic;

namespace Microservice.Core.Models.Response
{
    public class JsonResponse<T>
    {
        public JsonResponse()
        {

        }

        public JsonResponse(int code, string message, T data, IEnumerable<ErrorDetail> errors)
        {
            Code = code;
            Message = message;
            Data = data;
            Errors = errors;
        }

        public int Code { get; set; }

        public T Data { get; set; }

        public IEnumerable<ErrorDetail> Errors { get; set; }

        public string Message { get; set; }

        //public bool Success() => Code == 200;

        //  public bool Success();
    }
}
