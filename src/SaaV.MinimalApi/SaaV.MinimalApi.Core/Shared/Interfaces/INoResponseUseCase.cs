namespace SaaV.MinimalApi.Core.Shared.Interfaces
{
    public interface INoResponseUseCase<TRequest>
    {
        void Handle(TRequest request);
    }
}
