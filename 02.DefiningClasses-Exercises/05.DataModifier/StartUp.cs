using System;

namespace _05.DataModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DataModifier data = new DataModifier();

            int result = data.CalculateDifference(firstDate, secondDate);
            Console.WriteLine(result);
        }
    }
}
