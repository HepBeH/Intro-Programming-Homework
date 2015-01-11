using System;
//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


class AgeAfter
{
    static void Main()
    {
        Console.Write("Enter your age:");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be:{0}", Age + 10);
    }
}

