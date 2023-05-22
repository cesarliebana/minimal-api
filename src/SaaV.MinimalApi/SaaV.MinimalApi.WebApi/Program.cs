
using Microsoft.OpenApi.Models;
using SaaV.MinimalApi.WebApi.Extensions;
using SaaV.MinimalApi.WebApi.Middlewares;
using System.ComponentModel;

namespace SaaV.MinimalApi.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            builder.Services.AddUseCaseServices();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            OpenApiInfo info = new()
            {
                Version = "v1",
                Title = "Demo Minimal API",
                Description = "This is a demo for a webapi with minimal API"
            };
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
                options.SwaggerDoc(info.Version, info)
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapDummyEndpoints();

            app.UseMiddleware<ExceptionMiddleware>();

            app.Run();
        }
    }
}