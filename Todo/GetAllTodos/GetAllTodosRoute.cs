using MediatR;

namespace TodoMinimalApi.Todo.GetAllTodos;

public static class GetAllTodosRoute
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/todoitems", Handle);
    }

    public static async Task<IResult> Handle(IMediator mediator)
    {
        var todos = await mediator.Send(new GetAllTodosQuery());
        return TypedResults.Ok(todos);
    }
}
