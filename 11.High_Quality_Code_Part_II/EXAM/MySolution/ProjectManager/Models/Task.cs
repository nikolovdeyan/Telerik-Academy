using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class Task
    {
        internal const string InvalidRequiredTaskNameMessage = "Task Name is required!";
        internal const string InvalidRequiredTaskOwnerMessage = "Task Owner is required";

        public Task(string name, User owner, string state)
        {
            this.TaskName = name;
            this.TaskOwner = owner;
            this.State = state;
        }

        [Required(ErrorMessage = InvalidRequiredTaskNameMessage)]
        public string TaskName { get; set; }

        [Required(ErrorMessage = InvalidRequiredTaskOwnerMessage)]
        public User TaskOwner { get; set; }

        public string State { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("    Name: " + this.TaskName);

            builder.Append("    State: " + this.State);

            return builder.ToString();
        }
    }
}