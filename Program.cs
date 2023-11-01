using Microsoft.EntityFrameworkCore;
using TodoMinimalApi.Todo.CreateTodo;
using TodoMinimalApi.Todo.GetAllTodos;
using TodoMinimalApi.Todo.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoItemDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
var app = builder.Build();

// Map the routes
// We can go 1 step further to use reflection to auto discover and map routes
GetAllTodosRoute.Map(app);
CreateTodoRoute.Map(app);

app.Run();

