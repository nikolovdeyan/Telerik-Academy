using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder()
                .Append(string.Format("{0} {1} | ", this.FirstName, this.LastName))
                .Append(string.Format("Age: {0} | ", this.Age.ToString()))
                .Append(string.Format("FN: {0} | ", this.FN))
                .Append(string.Format("Phone: {0} | ", this.Tel))
                .Append(string.Format("email: {0} | ", this.Email));

            return sb.ToString();
        }
    }
}
