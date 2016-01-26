using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_5_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //create tyre
            Tyres tyres = new Tyres { Name = "Nokia ", Model = "Hakkapeliitat ", Size = "jsjwsefesof" };

            //create car

            Vehichle car = new Vehichle { Name = "Opel", Type = "Vectra " };
            car.AddTyre(tyres); //7 car contains
            car.AddTyre(tyres); //7 car contains
            car.AddTyre(tyres); //7 car contains
            car.AddTyre(tyres); //7 car contains

            Console.WriteLine(car.ToString());

            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
