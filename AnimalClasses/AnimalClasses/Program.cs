using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses 
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal beast = new Animal(false, 100);

            beast.Greet();
            beast.Talk();
            beast.Sing();

            Console.WriteLine(beast.ToString());

            Dog spot = new Dog(true, 25);

            spot.Greet();
            spot.Talk();
            spot.Sing();
            spot.Fetch("stick");

            Console.WriteLine(spot.ToString());

            Console.ReadLine();
        }
    }
}
