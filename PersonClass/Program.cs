﻿using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This employee is going to say their name!!");
            System.Threading.Thread.Sleep(1000);
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };
            emp.SayName();

            Console.WriteLine("\nWOW!  That's a weird name!");
            Console.Read();
        }
    }
}
