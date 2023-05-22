using SaaV.MinimalApi.Core.Shared.Exceptions;
using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.Core.Domain.UseCases
{
    public class GetDummyByIdUseCase : IUseCase<GetDummyRequest, GetDummyResponse>
    {
        public GetDummyResponse Handle(GetDummyRequest getDummyRequest)
        {
            if (getDummyRequest.Id <= 0) throw new DummyNotFoundException(getDummyRequest.Id);
            
            return new GetDummyResponse(getDummyRequest.Id, $"Dummy-{getDummyRequest.Id}", DateTime.UtcNow);
        }
    }
}
