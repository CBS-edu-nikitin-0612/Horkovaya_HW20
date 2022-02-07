using System;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bithday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Days to bithday: {0}", DateCounter.DaysToBirthday(bithday));
        }
    }
}