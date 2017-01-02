using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class ExtendStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder source, int start, int length)
        {
            StringBuilder sb = new StringBuilder();

            if (start < 0 || length < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (start > source.Length - 1 || start + length > source.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = start; i < start + length; i++)
            {
                sb.Append(source[i]);

                if (i >= source.Length - 1)
                {
                    break; 
                }
            }

            return sb;
        }

        // This is not part of the task at hand. I am implementing it for completeness and exercise.
        public static StringBuilder Substring(this StringBuilder source, int start)
        {
            var length = source.Length - start;

            return source.Substring(start, length);
        }
    }
}
