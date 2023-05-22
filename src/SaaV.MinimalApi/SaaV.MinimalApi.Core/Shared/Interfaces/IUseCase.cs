namespace SaaV.MinimalApi.Core.Shared.Interfaces
{
    public interface IUseCase<TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
