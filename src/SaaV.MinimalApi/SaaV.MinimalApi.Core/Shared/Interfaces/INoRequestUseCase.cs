namespace SaaV.MinimalApi.Core.Shared.Interfaces
{
    public interface INoRequestUseCase<TResponse>
    {
        TResponse Handle();
    }
}
