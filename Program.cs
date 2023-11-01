using Microsoft.EntityFrameworkCore;
using TodoMinimalApi.Todo.CreateTodo;
using TodoMinimalApi.Todo.GetAllTodos;
using TodoMinimalApi.Todo.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoItemDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
var app = builder.Build();

var todoItems = app.MapGroup("/todoitems");
todoItems.MapGet("/", GetAllTodosRoute.Handle);
todoItems.MapPost("/", CreateTodoRoute.Handle);

app.Run();

