using System;

namespace _04.HotelReservation
{
    public class StartUp
    {
        public static void Main()
        {

            var input = Console.ReadLine();


            PriceCalculator priceCalc = new PriceCalculator(input);

            Console.WriteLine($"{priceCalc.CalculatePrice():f2}");



        }
    }
}
