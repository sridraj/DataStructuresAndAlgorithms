﻿using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayImplementation();
            var reversedString = array.ReverseString2("Hi My name is Sriditya");
            Console.WriteLine(reversedString);
        }
    }
}