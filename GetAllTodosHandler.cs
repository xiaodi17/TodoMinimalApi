using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TodoMinimalApi;
public class GetAllTodosHandler : IRequestHandler<GetAllTodosQuery, IEnumerable<Todo>>
{
    private readonly TodoDb _db;
    public GetAllTodosHandler(TodoDb db) => _db = db;

    public async Task<IEnumerable<Todo>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
    {
        return await _db.Todos.ToListAsync(cancellationToken);
    }
}