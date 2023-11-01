using MediatR;
using TodoMinimalApi.Todo.Models;

namespace TodoMinimalApi.Todo.CreateTodo;
public static class CreateTodoRoute
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/todoitems", Handle);
    }

    public static async Task<IResult> Handle(TodoItem todoItem, IMediator mediator)
    {
        var createdTodo = await mediator.Send(new CreateTodoCommand(todoItem));
        return TypedResults.Created($"/todoitems/{createdTodo.Id}", createdTodo);
    }
}