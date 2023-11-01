using MediatR;
namespace TodoMinimalApi;


public static class GetAllTodosRoute
{
    public static async Task<IResult> Handle(IMediator mediator)
    {
        var todos = await mediator.Send(new GetAllTodosQuery());
        return TypedResults.Ok(todos);
    }
}
