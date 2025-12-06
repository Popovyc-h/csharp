namespace task
{
    public class Task
    {
        private string name { get; set; }
        private string description { get; set; }
        private TaskStatus status;

        public Task(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.status = TaskStatus.NotStarted;
        }

        public void ChangeStatus(TaskStatus newStatus)
        {
            this.status = newStatus;
        }

        public override string ToString()
        {
            return $"{name}, {description}, {status}";
        }
    }
}
