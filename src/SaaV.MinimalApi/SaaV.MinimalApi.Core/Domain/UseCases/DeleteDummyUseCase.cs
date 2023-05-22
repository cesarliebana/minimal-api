using SaaV.MinimalApi.Core.Shared.Exceptions;
using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.Core.Domain.UseCases
{
    public class DeleteDummyUseCase : INoResponseUseCase<DeleteDummyRequest>
    {
        public void Handle(DeleteDummyRequest deleteDummyRequest)
        {
            if (deleteDummyRequest.Id <= 0) throw new DummyNotFoundException(deleteDummyRequest.Id);            
        }
    }
}
