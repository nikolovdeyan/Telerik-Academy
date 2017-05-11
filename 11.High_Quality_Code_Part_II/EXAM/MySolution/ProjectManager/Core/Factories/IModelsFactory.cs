using ProjectManager.Models;

namespace ProjectManager.Core.Factories
{
    /// <summary>Provides models instanciation for the application.</summary>
    public interface IModelsFactory
    {
        /// <summary>Creates a new project in the application.</summary>
        /// <param name="name">The project name to apply to the new project.</param>
        /// <param name="startingDate">The date that the project is scheduled to start.</param>
        /// <param name="endingDate">The ending date of the project.</param>
        /// <param name="state">The current status of the project</param>
        /// <returns>A new Project instance.</returns>
        Project CreateProject(string name, string startingDate, string endingDate, string state);

        /// <summary>Creates a new task in the application.</summary>
        /// <param name="owner">The owner of the task.</param>
        /// <param name="name">The name of the new task.</param>
        /// <param name="state">The current status of the new task.</param>
        /// <returns>A new Task instance.</returns>
        Task CreateTask(User owner, string name, string state);

        /// <summary>Creates a new User in the application.</summary>
        /// <param name="username">The user name of the new user.</param>
        /// <param name="email">The email of the new user.</param>
        /// <returns>A new User instance.</returns>
        User CreateUser(string username, string email);
    }
}