using MediatR;

namespace TodoMinimalApi;
public static class CreateTodoRoute
{
    public static async Task<IResult> Handle(Todo todo, IMediator mediator)
    {
        var createdTodo = await mediator.Send(new CreateTodoCommand(todo));
        return TypedResults.Created($"/todoitems/{createdTodo.Id}", createdTodo);
    }
}