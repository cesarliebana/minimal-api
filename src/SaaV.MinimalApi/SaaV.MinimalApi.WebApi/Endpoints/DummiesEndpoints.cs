using SaaV.MinimalApi.Core.Domain;
using SaaV.MinimalApi.Core.Shared.Interfaces;
using SaaV.MinimalApi.WebApi.Models;

namespace SaaV.MinimalApi.WebApi.Endpoints
{
    internal static class DummiesEndpoints
    {
        public static IResult GetAllDummies(INoRequestUseCase<GetAllDummiesResponse> getAllDummiesUseCase)
        {
            return Results.Ok(getAllDummiesUseCase.Handle());
        }

        public static IResult GetDummyById(int id, IUseCase<GetDummyRequest, GetDummyResponse> getDummyByIdUseCase)
        {
            return Results.Ok(getDummyByIdUseCase.Handle(new GetDummyRequest(id)));
        }

        public static IResult CreateDummy(CreateDummyModel createDummyModel, IUseCase<CreateDummyRequest, GetDummyResponse> createDummyUseCase)
        {
            CreateDummyRequest createDummyRequest = new(createDummyModel.Name);
            GetDummyResponse createDummyResponse = createDummyUseCase.Handle(createDummyRequest);
            
            return Results.Created($"/dummies/{createDummyResponse.Id}", createDummyResponse);
        }

        public static IResult UpdateDummy(int id, UpdateDummyModel updateDummyModel, IUseCase<UpdateDummyRequest, GetDummyResponse> updateDummyUseCase)
        {
            UpdateDummyRequest updateDummyRequest = new(id, updateDummyModel.Name);
            GetDummyResponse updateDummyResponse = updateDummyUseCase.Handle(updateDummyRequest);
                       
            return Results.Ok(updateDummyResponse);
        }

        public static IResult DeleteDummy(int id, INoResponseUseCase<DeleteDummyRequest> deleteDummyUseCase)
        {
            DeleteDummyRequest deleteDummyRequest = new(id);
            deleteDummyUseCase.Handle(deleteDummyRequest);
            
            return Results.NoContent();
        }
    }
}
