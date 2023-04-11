using WorkoutTracker.Application.Common.Mappings;
using WorkoutTracker.Domain.Entities;

namespace WorkoutTracker.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
