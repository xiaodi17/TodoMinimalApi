using MediatR;
using Microsoft.EntityFrameworkCore;
using TodoMinimalApi.Todo.Models;

namespace TodoMinimalApi.Todo.GetAllTodos;
public class GetAllTodosHandler : IRequestHandler<GetAllTodosQuery, IEnumerable<TodoItem>>
{
    private readonly TodoItemDb _itemDb;
    public GetAllTodosHandler(TodoItemDb itemDb) => _itemDb = itemDb;

    public async Task<IEnumerable<TodoItem>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
    {
        return await _itemDb.Todos.ToListAsync(cancellationToken);
    }
}