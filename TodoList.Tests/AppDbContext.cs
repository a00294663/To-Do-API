namespace TodoList.Tests;

// TodoList.API/Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<ToDoItem> ToDoItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
public class ToDoItemTests
{
    [Fact]
    public void CanChangeTaskName()
    {
        var x = new ToDoItem { TaskName = "Go to school" };
        x.TaskName = "Find my book";
        Assert.Equal("Find my book", x.TaskName);
    }
    [Fact]
    public void CanChangeTaskName()
    {
        var x = new ToDoItem { TaskName = "Go to school" };
        x.TaskName = "Find my book";
        Assert.Equal("Find my book", x.TaskName);
    }
    [Fact]
    public void CanChangeTaskName()
    {
        var x = new ToDoItem { TaskName = "Go to school" };
        x.TaskName = "Find my book";
        Assert.Equal("Find my book", x.TaskName);
    }
    [Fact]
    public void CanChangeTaskName()
    {
        var x = new ToDoItem { TaskName = "Go to School" };
        x.TaskName = "Find my book";
        Assert.Equal("Find my book", x.TaskName);
    }
} 
