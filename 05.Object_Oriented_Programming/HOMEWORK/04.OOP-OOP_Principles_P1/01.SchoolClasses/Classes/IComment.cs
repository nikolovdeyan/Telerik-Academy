using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    // As students, classes, teachers and disciplines all have optional comments,
    // we take that functionality out as an interface
    public interface IComment
    {
        string Comment { get; }
    }
}
