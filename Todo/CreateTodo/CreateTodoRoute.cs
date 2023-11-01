using MediatR;

namespace TodoMinimalApi.Todo.CreateTodo;
public static class CreateTodoRoute
{
    public static async Task<IResult> Handle(TodoItem todoItem, IMediator mediator)
    {
        var createdTodo = await mediator.Send(new CreateTodoCommand(todoItem));
        return TypedResults.Created($"/todoitems/{createdTodo.Id}", createdTodo);
    }
}