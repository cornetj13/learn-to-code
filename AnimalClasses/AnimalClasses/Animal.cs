using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses 
{
    abstract class Animal
    {
        Boolean isPet { get; set; }
        int weight { get; set; }

        public Animal() 
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(Boolean isPet, int weight)
        {
            this.isPet = isPet;
            this.weight = weight;
        }

        public void Greet() 
        {
            Console.WriteLine("Animal says 'Hello'");
        }

        public void Talk() 
        {
            Console.WriteLine("Animal talks");
        }

        public void Sing()
        {
            Console.WriteLine("Animal sings");
        }

        public string ToString() 
        {
            return "Status: " + isPet + "; Weight: " + weight;
        }
    }
}
