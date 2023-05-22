using SaaV.MinimalApi.Core.Shared.Exceptions;
using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.Core.Domain.UseCases
{
    public class UpdateDummyUseCase : IUseCase<UpdateDummyRequest, GetDummyResponse>
    {
        public GetDummyResponse Handle(UpdateDummyRequest updateDummyRequest)
        {
            if (updateDummyRequest.Id <= 0) throw new DummyNotFoundException(updateDummyRequest.Id);

            return new GetDummyResponse(updateDummyRequest.Id, updateDummyRequest.Name, DateTime.UtcNow);
        }
    }
}
