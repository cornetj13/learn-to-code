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
            // Initialize an object (spot) of the Dog class.
            Dog spot = new Dog(true, 25);

            // Methods for Dog class.
            spot.Greet();
            spot.Talk();
            spot.Sing();
            spot.Fetch("stick");

            // Interface for Dog class.
            spot.PetMe();
            spot.FeedMe();

            Console.WriteLine(spot.ToString());

            // Initialize an object (red) of the Robin class.
            Robin red = new Robin();

            // Methods for Robin class.
            red.Talk();
            red.Sing();

            Console.ReadLine();
        }
    }
}
