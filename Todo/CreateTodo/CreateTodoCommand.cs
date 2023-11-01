using MediatR;
using TodoMinimalApi.Todo.Models;

namespace TodoMinimalApi.Todo.CreateTodo;
public record CreateTodoCommand(TodoItem TodoItem) : IRequest<TodoItem>;