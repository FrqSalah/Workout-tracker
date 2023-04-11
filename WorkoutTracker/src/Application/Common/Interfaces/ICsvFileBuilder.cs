using WorkoutTracker.Application.TodoLists.Queries.ExportTodos;

namespace WorkoutTracker.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
