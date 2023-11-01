using MediatR;

namespace TodoMinimalApi.Todo.GetAllTodos;
public record GetAllTodosQuery() : IRequest<IEnumerable<TodoItem>>;
