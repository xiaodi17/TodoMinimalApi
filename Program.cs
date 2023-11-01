using Microsoft.EntityFrameworkCore;
using TodoMinimalApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
var app = builder.Build();

var todoItems = app.MapGroup("/todoitems");
todoItems.MapGet("/", GetAllTodosRoute.Handle);
todoItems.MapPost("/", CreateTodoRoute.Handle);

app.Run();

