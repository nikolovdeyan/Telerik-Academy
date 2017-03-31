using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MinAndMax
{
    public class GenericList<T>
        where T : IComparable, IComparable<T>
    {
        private const int DefListSize = 4;

        private int size;
        private int lastElement;
        private T[] contents;

        public GenericList()
            : this(DefListSize)
        {
        }
        public GenericList(int capacity)
        {
            this.Size = capacity;
            this.LastElement = -1;
            this.Contents = new T[capacity];
        }
        public GenericList(int capacity, T[] items)
        {
            this.Size = capacity;
            this.LastElement = items.Length - 1;
            this.Contents = items;
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = (value > DefListSize) ? value : DefListSize; }
        }
        public int LastElement
        {
            get { return this.lastElement; }
            set { this.lastElement = value; }
        }
        public int Count
        {
            get { return this.LastElement + 1; }
        }
        public T[] Contents
        {
            get { return this.contents; }
            set { this.contents = value; }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Size)
                {
                    return this.contents[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < this.Size)
                {
                    this.contents[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Add(T element)
        {
            this.LastElement++;

            // Check if resizing is needed
            if (this.LastElement == this.Size)
            {
                this.ResizeArray("grow");
            }

            this.Contents[this.LastElement] = element;
        }

        public void RemoveAt(int pos)
        {
            this.LastElement--;

            if (pos > this.Contents.Length || pos < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                int tmpIndex = 1;
                for (int i = 0; i < this.Contents.Length; i++)
                {
                    if (i != pos)
                    {
                        this.Contents[tmpIndex - 1] = this.Contents[i];
                        tmpIndex++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            // Check if shrinking of the array is needed
            if (this.LastElement < (this.Size / 2) && (this.Size / 2 >= DefListSize))
            {
                this.ResizeArray("shrink");
            }
        }

        public void Insert(T element, int pos)
        {

            if (pos < 0 || pos > this.LastElement)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.LastElement++;
                if (this.LastElement == 0)
                {
                    this.Add(element);
                }
                else
                {
                    T tmp = this[pos];
                    this[pos] = element;
                    for (int i = pos + 1; i < this.LastElement + 1; i++)
                    {
                        // Check if resizing is needed
                        if (this.LastElement == this.Size)
                        {
                            this.ResizeArray("grow");
                        }

                        T tmpItem = this[i];
                        this[i] = tmp;
                        tmp = tmpItem;
                    }
                }
                
            }
        }

        public void Clear()
        {
            this.Contents = new T[DefListSize];
            this.LastElement = -1;
            this.ResizeArray("shrink");
        }

        public int Find(T element)
        {
            if (this.LastElement == -1)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i <= this.LastElement; i++)
                {
                    if (this[i].ToString() == element.ToString())
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        private void ResizeArray(string operation)
        {
            // If growing: 
            if (operation == "grow")
            {
                this.Size *= 2;
                var resizedArr = new T[this.Size];
                this.Contents.CopyTo(resizedArr, 0);
                this.Contents = resizedArr;
                
            }
            // If shrinking:
            else if (operation == "shrink")
            {
                this.Size /= 2;
                var resizedArr = new T[this.Size];
                this.Contents.CopyTo(resizedArr, 0);
                this.Contents = resizedArr;
            }
        }

        // Implementing Min<T>()
        public T Min<U>()
        {
            dynamic result = this.Contents.Min();
            return result;
        }

        // Implementing Max<T>()
        public T Max<U>()
        {
            dynamic result = this.Contents.Max();
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Count > 0)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    sb.Append(this[i])
                      .Append(" ");
                }
            }
            // Trimming the end space here
            return sb.ToString().TrimEnd();
        }
    }
}
