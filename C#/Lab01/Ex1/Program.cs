﻿using System;

namespace Ex1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool boolTest = true;
            short byteTest = 19;
            int intTest;
            string stringTest = "David";
            float floatTest;
            intTest = 14000;
            floatTest = 14.5f;
            Console.WriteLine("boolTest = {0}", boolTest);
            Console.WriteLine("byteTest = " + byteTest);
            Console.WriteLine("intTest = " + intTest);
            Console.WriteLine("stringTest = " + stringTest);
            Console.WriteLine("floatTest = " + floatTest);
            Console.ReadKey();
        }
    }
}