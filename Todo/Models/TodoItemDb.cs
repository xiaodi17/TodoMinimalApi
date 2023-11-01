using Microsoft.EntityFrameworkCore;

namespace TodoMinimalApi.Todo.Models;

public class TodoItemDb : DbContext
{
    public TodoItemDb(DbContextOptions<TodoItemDb> options)
        : base(options) { }

    public DbSet<TodoItem> Todos => Set<TodoItem>();
}