using System;
//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter your birtdate: ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
                int Years = Days / 365;
                string message = (Days >= 365) ? "Your age: " + Years + " years" : "Your age: " + Days + " days";


                Console.WriteLine(message);

                int Age = Years = Days / 365;
                int futureAge = Age + 10;
                Console.WriteLine("After 10 years you will be {1} years old!", Age, futureAge);

            }
            catch
            {
                Console.WriteLine("You have entered an invalid date.\n");
            }

            Console.WriteLine("Exit? (y/n)");
            string userValue = Console.ReadLine();

            if (userValue == "y")
            {
                Environment.Exit(0);
            }
        }
    }
}

