using todo.Models;

namespace todo.ViewModels
{
    public class TodoViewModel
    {
       

        public List<Todo> TodoList { get => TodoList; set => TodoList = value; }
        public Todo Todo { get => Todo; set => Todo = value; }

    }


}
