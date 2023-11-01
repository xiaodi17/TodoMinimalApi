using MediatR;

namespace TodoMinimalApi;
public record GetAllTodosQuery() : IRequest<IEnumerable<Todo>>;
