namespace Portafolio.Models
{
    public class TaskContext
    {
        public TaskContext()
        {

        }

        public List<User> Users = new();
        public List<Project> Projects = new();
        public List<Task> Tasks = new();
        public List<TaskPriority> TaskPriorities = new();
        public List<TaskStatus> TaskStatus = new();
    }
}
