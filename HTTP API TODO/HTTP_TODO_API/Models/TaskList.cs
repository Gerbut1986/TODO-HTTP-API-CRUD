namespace HTTP_TODO_API.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.Collections.Generic.List<Task> Tasks { get; set; }

        public TaskList(string title, System.Collections.Generic.List<Task> tasks)
        {
            Title = title;
            Tasks = tasks;
        }

        public TaskList() { }
    }
}
