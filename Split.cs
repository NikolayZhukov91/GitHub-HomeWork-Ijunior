﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет, я выполняю домашние задания в IJunior";
            string[] textArray = text.Split(' ');

            foreach (string subText in textArray)
            {
                Console.WriteLine($"Substring: {subText}");
            }
            Console.ReadKey();
        }
    }
}