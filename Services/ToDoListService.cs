using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services;

public class ToDoListService
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Projekty" },
        new ToDoItem { Description = "Zaliczenia" },
        new ToDoItem { Description = "Egazminy" },
    };
}