using SaaV.MinimalApi.Core.Shared.Interfaces;

namespace SaaV.MinimalApi.Core.Domain.UseCases
{
    public class GetAllDummiesUseCase : INoRequestUseCase<GetAllDummiesResponse>
    {
        public GetAllDummiesResponse Handle()
        {
            List<DummyListItem> dummies = new()
            {
                new DummyListItem(1, "Dummy-01"),
                new DummyListItem(2, "Dummy-02"),
                new DummyListItem(3, "Dummy-03")
            };

            return new GetAllDummiesResponse(dummies);
        }
    }
}
