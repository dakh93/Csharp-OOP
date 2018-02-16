using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Car car = new Car();
            for (int i = 0; i < n; i++)
            {
                var currCarr =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                string carModel = currCarr[0];
                double fuelAmout = double.Parse(currCarr[1]);
                double consumption = double.Parse(currCarr[2]);

                car.AddCars(carModel,new Car(carModel, fuelAmout, consumption));
            }
            

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var currInput = input.Split(' ').ToArray();

                string model = currInput[1];
                double kmToDrive = double.Parse(currInput[2]);

                car.CanCarTravelDistance(model, kmToDrive);
            }



            car.PrintCarValues();
            
        }
    }
}
