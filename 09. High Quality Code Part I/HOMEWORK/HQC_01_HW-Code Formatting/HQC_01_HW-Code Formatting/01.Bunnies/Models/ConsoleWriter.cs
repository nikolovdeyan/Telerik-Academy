﻿using System;
using Bunnies.Contracts;

namespace Bunnies.Models.ConsoleWriter
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
