using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                var input =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                Car car = new Car();

                List<Tire> tires = new List<Tire>();
                var model = input[0];

                var enginePower = int.Parse(input[2]);
                var engineSpeed = int.Parse(input[1]);

                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];

                var firstP = double.Parse(input[5]);
                var firstA = int.Parse(input[6]);
                Tire firstT = new Tire(firstP, firstA);

                var secondP = double.Parse(input[7]);
                var secondA = int.Parse(input[8]);
                Tire secondT = new Tire(secondP, secondA);

                var thirdP = double.Parse(input[9]);
                var thirdA = int.Parse(input[10]);
                Tire thirdT = new Tire(thirdP, thirdA);

                var fourthP = double.Parse(input[11]);
                var fourthA = int.Parse(input[12]);
                Tire fourthT = new Tire(fourthP, fourthA);

                tires.Add(firstT);
                tires.Add(secondT);
                tires.Add(thirdT);
                tires.Add(fourthT);

                car.AddCar(
                    model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoWeight, cargoType),
                    tires);
                allCars[model] = car;
            }

            string command = Console.ReadLine();


            if (command == "fragile")
            {
                allCars
                    .Where(x => x.Value.Tire.Any(p => p.Pressure < 1) &&
                                x.Value.Cargo.Type == "fragile")
                    .Select(x => x.Key)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x));

            }
            else if (command == "flamable")
            {
                allCars
                    .Where(x => x.Value.Engine.EnginePower > 250 &&
                                x.Value.Cargo.Type == "flamable")
                    .Select(x => x.Key)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x));
            }





        }
    }
}
