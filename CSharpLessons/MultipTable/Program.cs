﻿using System;

namespace MultipTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
            }

            Console.ReadLine();
        }
    }
}