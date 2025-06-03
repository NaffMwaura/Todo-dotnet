using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTodoApp.Models;
using System.Collections.Generic;

namespace RazorTodoApp.Pages
{
    public class TodoModel : PageModel
    {
        public List<TodoItem> TodoList { get; set; } = new();

        [BindProperty]
        public string NewTask { get; set; }

        public void OnGet()
        {
            // Optionally load from a DB or file here
        }

        public void OnPostAdd()
        {
            if (!string.IsNullOrWhiteSpace(NewTask))
            {
                TodoList.Add(new TodoItem { Task = NewTask, IsDone = false });
            }
        }
    }
}
