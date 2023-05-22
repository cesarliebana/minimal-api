﻿namespace SaaV.MinimalApi.Core.Domain
{
    public record struct GetDummyResponse(int Id, string Name, DateTime UpdatedDateTime);
    public record struct DummyListItem(int Id, string Name);
    public record struct GetAllDummiesResponse(IList<DummyListItem> Dummies);
}
