using Microsoft.EntityFrameworkCore;

namespace TodoMinimalApi;

public class TodoItemDb : DbContext
{
    public TodoItemDb(DbContextOptions<TodoItemDb> options)
        : base(options) { }

    public DbSet<TodoItem> Todos => Set<TodoItem>();
}