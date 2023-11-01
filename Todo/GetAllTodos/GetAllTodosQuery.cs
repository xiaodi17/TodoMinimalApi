using MediatR;
using TodoMinimalApi.Todo.Models;

namespace TodoMinimalApi.Todo.GetAllTodos;
public record GetAllTodosQuery() : IRequest<IEnumerable<TodoItem>>;
