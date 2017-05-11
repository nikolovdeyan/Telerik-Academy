using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class User
    {
        internal const string InvalidRequiredUserNameMessage = "User Username is required!";
        internal const string InvalidRequiredUserMailMessage = "User Email is required!";
        internal const string InvalidUserMailMessage = "User Email is not valid!";

        public User(string username, string email)
        {
            this.UserName = username;

            this.UserEmail = email;
        }

        [Required(ErrorMessage = InvalidRequiredUserNameMessage)]
        public string UserName { get; set; }

        [Required(ErrorMessage = InvalidRequiredUserMailMessage)]
        [EmailAddress(ErrorMessage = InvalidUserMailMessage)]
        public string UserEmail { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("    Username: " + this.UserName);
            sb.AppendLine("    Email: " + this.UserEmail);
            return sb.ToString();
        }
    }
}