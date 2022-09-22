using MediatR;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microservice.API.Application.Queries;
using System;
using Microservice.API.Application.Validations;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddFluentValidation(x =>
{
    x.ImplicitlyValidateChildProperties = true;

});




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

// Register validator with service provider (or use one of the automatic registration methods)
builder.Services.AddScoped<IValidator<GetUserQuery>, GetUserQueryValitor>();
builder.Services.AddValidatorsFromAssemblyContaining<GetUserQueryValitor>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
