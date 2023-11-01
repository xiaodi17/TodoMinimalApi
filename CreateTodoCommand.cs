using MediatR;

namespace TodoMinimalApi;
public record CreateTodoCommand(Todo Todo) : IRequest<Todo>;