using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CarSalesman
{

    public class Car
    {
        public string Model { get; set; }

        public Engine EngineModel { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public Car()
        {
            this.Weight = "n/a";
            this.Color = "n/a";
        }


    }

}