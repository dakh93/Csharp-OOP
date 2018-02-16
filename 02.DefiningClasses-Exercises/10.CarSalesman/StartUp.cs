using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{

    class StartUp
    {
        static void Main()
        {
            int engineNum = int.Parse(Console.ReadLine());

            var engines = new Dictionary<string, Engine>();
            for (int i = 0; i < engineNum; i++)
            {
                string[] input =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                string model = input[0];
                string power = input[1];
                var displacement = "n/a";
                var efficiency = "n/a";
                if (input.Length == 3)
                {
                    bool isDisplacement = int.TryParse(input[2], out int w);
                    if (isDisplacement)
                    {
                        displacement = w.ToString();
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }
                Engine engine = new Engine();
                engine.Model = model;
                engine.Displacement = displacement;
                engine.Efficiency = efficiency;
                engine.Power = power;

                if (!engines.ContainsKey(model))
                {
                    engines[model] = engine;

                }

            }

            int carNum = int.Parse(Console.ReadLine());

            var carsInfo = new Queue<Car>();
            for (int i = 0; i < carNum; i++)
            {
                var data =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                string model = data[0];
                string engineModel = data[1];
                var weight = "n/a";
                var color = "n/a";

                if (data.Length == 3)
                {
                    bool isWeight = int.TryParse(data[2], out int w);
                    if (isWeight)
                    {
                        weight = w.ToString();
                    }
                    else
                    {
                        color = data[2];
                    }
                }
                else if (data.Length == 4)
                {
                    weight = data[2];
                    color = data[3];
                }
                Car car = new Car();
                car.Model = model;
                car.Weight = weight;
                car.Color = color;
                car.EngineModel = engines[engineModel];

                carsInfo.Enqueue(car);
            }

            foreach (var car in carsInfo)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.EngineModel.Model}:");
                Console.WriteLine($"    Power: {car.EngineModel.Power}");
                Console.WriteLine($"    Displacement: {car.EngineModel.Displacement}");
                Console.WriteLine($"    Efficiency: {car.EngineModel.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}

