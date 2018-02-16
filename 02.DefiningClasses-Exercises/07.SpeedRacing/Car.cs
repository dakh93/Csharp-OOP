using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double ConsumptionPerKm { get; set; }
        public double DistanceTraveled { get; set; }
        

        private Dictionary<string, Car> cars  = new Dictionary<string, Car>();

        public Car()
        {
            this.DistanceTraveled = 0;
        }
        public Car(string model, double fuelAmount, double fuelConsumption) :this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.ConsumptionPerKm = fuelConsumption;
            
        }

        public void AddCars(string model, Car car)
        {
            this.cars[model] = car;
        }

        public void CanCarTravelDistance(string model, double kmToDrive)
        {
            if (cars.ContainsKey(model))
            {
                var carFuel = cars[model].FuelAmount;
                var wantedFuel = cars[model].ConsumptionPerKm * kmToDrive;

                if (wantedFuel > carFuel )
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
                else
                {
                    cars[model].DistanceTraveled += kmToDrive;
                    cars[model].FuelAmount -= wantedFuel;
                }
            }
        }

        public void PrintCarValues()
        {
            
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTraveled}");
            }
        }
    }
}
