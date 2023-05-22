using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.Core.Domain.UseCases
{
    public class CreateDummyUseCase : IUseCase<CreateDummyRequest, GetDummyResponse>
    {

        public CreateDummyUseCase()
        {
        }

        public GetDummyResponse Handle(CreateDummyRequest createDummyRequest)
        {
            return new GetDummyResponse(Random.Shared.Next(), createDummyRequest.Name, DateTime.UtcNow);
        }
    }
}
