﻿using System;

class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 33; i <= 126; i++)
        {
            Console.Write((char)i);
        }
    }
}