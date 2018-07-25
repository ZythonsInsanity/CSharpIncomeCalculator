using System;



    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.ReadLine();
        Console.WriteLine("Person 1");
        Console.ReadLine();
        Console.WriteLine("How much do they make per hour?");
        int p1Hourly = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many hours do they work per week?");
        int p1workWeek = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();
        Console.WriteLine("Person 2");
        Console.ReadLine();
        Console.WriteLine("How much do they make per hour?");
        int p2Hourly = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many hours do they work per week?");
        int p2workWeek = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();
        Console.WriteLine("Annual salary for person 1: {0}", (p1Hourly * p1workWeek) * 52);
        Console.ReadLine();
        Console.WriteLine("Annual salary for person 2: {0}", (p2Hourly * p2workWeek) * 52);
        Console.WriteLine("Does person 1 make more money than person 2?");
        bool p1Overp2 = (p1Hourly * p1workWeek) > (p2Hourly * p2workWeek);
        Console.WriteLine("Person 1 making money over person 2 is {0}", p1Overp2);
        Console.ReadLine();
        }
    }

