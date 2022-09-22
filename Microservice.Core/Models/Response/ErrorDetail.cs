using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Models.Response
{
    public sealed class ErrorDetail
    {
        public ErrorDetail()
        {

        }

        public ErrorDetail(string location, string locationType, string message)
        {
            Location = location;
            LocationType = locationType;
            Message = message;
        }

        public string Location { get; set; }
        public string LocationType { get; set; }
        public string Message { get; set; }
    }
}
