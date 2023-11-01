using MediatR;

namespace TodoMinimalApi.Todo.CreateTodo;
public record CreateTodoCommand(TodoItem TodoItem) : IRequest<TodoItem>;