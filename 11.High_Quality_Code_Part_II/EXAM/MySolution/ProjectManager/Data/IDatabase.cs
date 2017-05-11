using ProjectManager.Models.Contracts;
using System.Collections.Generic;

namespace ProjectManager.Data
{
    /// <summary>Holds a <see cref="IList{T}"/> of <see cref="IProject"/> containing the program database.</summary>
    public interface IDatabase
    {
        /// <summary>Holds an <see cref="IList{T}"/>  of <see cref="IProject"/></summary>
        IList<IProject> Projects { get; }
    }
}