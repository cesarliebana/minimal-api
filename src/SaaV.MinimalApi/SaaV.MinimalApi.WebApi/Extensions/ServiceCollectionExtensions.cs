using SaaV.MinimalApi.Core.Domain;
using SaaV.MinimalApi.Core.Domain.UseCases;
using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUseCaseServices(this IServiceCollection services)
        {
            // Add Dummy use cases to the container
            services.AddTransient<IUseCase<GetDummyRequest, GetDummyResponse>, GetDummyByIdUseCase>();
            services.AddTransient<INoRequestUseCase<GetAllDummiesResponse>, GetAllDummiesUseCase>();
            services.AddTransient<IUseCase<CreateDummyRequest, GetDummyResponse>, CreateDummyUseCase>();
            services.AddTransient<IUseCase<UpdateDummyRequest, GetDummyResponse>, UpdateDummyUseCase>();
            services.AddTransient<INoResponseUseCase<DeleteDummyRequest>, DeleteDummyUseCase>();
        }
    }
}
