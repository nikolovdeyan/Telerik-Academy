using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private string errorMessage;
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }
        public InvalidRangeException(string message, T start, T end, Exception innerException)
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            private set
            {
                this.errorMessage = value;
            }
        }

        public T Start
        {
            get
            {
                return this.start;
            }

            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                this.end = value;
            }
        }

    }
}
