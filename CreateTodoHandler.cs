using MediatR;

namespace TodoMinimalApi;
public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, Todo>
{
    private readonly TodoDb _db;

    public CreateTodoHandler(TodoDb db)
    {
        _db = db;
    }

    public async Task<Todo> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
    {
        _db.Todos.Add(command.Todo);
        await _db.SaveChangesAsync(cancellationToken);
        return command.Todo;
    }
}
