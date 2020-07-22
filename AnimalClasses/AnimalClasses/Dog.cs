using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses 
{
    class Dog : Animal, IDomesticated
    {
        public Dog(bool isPet, int weight) : base(isPet, weight)
        {

        }

        public void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }

        public void Sing()
        {
            Console.WriteLine("Awooo");
        }

        public void Fetch(string thing) 
        {
            Console.WriteLine("Here you go! Here is your " + thing + ". Let's do it again!");
        }

        public void PetMe() 
        {
            Console.WriteLine("Please scratch behind my ears!");
        }

        public void FeedMe() 
        {
            Console.WriteLine("Dinnertime, my favorite!");
        }
    }
}
