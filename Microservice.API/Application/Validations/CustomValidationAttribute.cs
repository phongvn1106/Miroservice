﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.API.Application.Validations
{
    public class CustomValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.Where(v => v.Errors.Count > 0)
                        .SelectMany(v => v.Errors)
                        .Select(v => v.ErrorMessage)
                        .ToList();

                var responseObj = new
                {
                    Code = 123456,
                    Message = "lỗi rồi",
                    Errors = errors
                };

                context.Result = new JsonResult(responseObj)
                {
                    StatusCode = 200
                };
            }
        }
    }
}
