namespace SaaV.MinimalApi.Core.Domain
{
    public record struct GetDummyRequest(int Id);
    public record struct CreateDummyRequest(string Name);
    public record struct UpdateDummyRequest(int Id, string Name);
    public record struct DeleteDummyRequest(int Id);
}
