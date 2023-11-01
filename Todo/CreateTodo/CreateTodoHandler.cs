using MediatR;
using TodoMinimalApi.Todo.Models;

namespace TodoMinimalApi.Todo.CreateTodo;
public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, TodoItem>
{
    private readonly TodoItemDb _itemDb;

    public CreateTodoHandler(TodoItemDb itemDb)
    {
        _itemDb = itemDb;
    }

    public async Task<TodoItem> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
    {
        _itemDb.Todos.Add(command.TodoItem);
        await _itemDb.SaveChangesAsync(cancellationToken);
        return command.TodoItem;
    }
}
