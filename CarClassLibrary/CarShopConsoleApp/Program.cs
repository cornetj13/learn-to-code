using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Declare a New Store.
            Store myStore = new Store();

            // Greet User.
            Console.WriteLine("Welcome to my car store! First, please create a car inventory.");
            Console.WriteLine("Next, choose the cars you want to buy from your inventory.");
            Console.WriteLine("Last, you can check out and see the total price you'll need to pay!");

            int action = chooseAction();

            while (action != 0) 
            {
                Console.WriteLine("You chose action " + action);

                switch (action)
                {
                    // Adds a Car to the Inventory.
                    case 1:

                        Console.WriteLine("You chose to add a new car to the inventory");

                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;

                        Console.WriteLine("What is the car make? (For example: Ford, GM, Nissan, etc.)");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? (For example: Focus, Corvette, Sentra, etc.)");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the price of the car?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        myStore.CarList.Add(newCar);

                        printInventory(myStore);

                        break;

                    // Adds a Car to the Shopping List.
                    case 2:
                        Console.WriteLine("You chose to add a new car to your shopping cart.");
                        printInventory(myStore);
                        Console.WriteLine("Which car(s) would you like to purchase? (Input car's number to add.)");
                        
                        int carChosen = int.Parse(Console.ReadLine());
                        myStore.ShoppingList.Add(myStore.CarList[carChosen]);

                        printShoppingCart(myStore);

                        break;
                    
                    // Gives Total Price of Purchased Cars.
                    case 3:
                        printShoppingCart(myStore);
                        Console.WriteLine("The total cost of your cars is: " + myStore.Checkout());
                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }
            
            //Car c = new Car("Wayne Industries", "Batmobile", 1340000);
            //Car d = new Car("Ford", "Mustang", 9200);

            //Console.WriteLine("Car c is as follows: " + c.Make + " " + c.Model + " " + c.Price);
            //Console.WriteLine("Car d is as follows: " + d.Make + " " + d.Model + " " + d.Price);

            //myStore.ShoppingList.Add(c);
            //myStore.ShoppingList.Add(d);

            //decimal totalShoppingCost = myStore.Checkout();

            //Console.WriteLine("The Shopping List Total is: " + totalShoppingCost);
        }

        private static void printShoppingCart(Store myStore) 
        {
            Console.WriteLine("Cars you would like to purchase:");
            for (int i = 0; i < myStore.ShoppingList.Count; i++) 
            {
                Console.WriteLine("Car #" + i + ": " + myStore.ShoppingList[i]);
            }
        }

        private static void printInventory(Store myStore) 
        {
            for (int i = 0; i < myStore.CarList.Count; i++)
            {
                // Console.WriteLine("Car: " + car.Make + ", " + car.Model + ", " + car.Price);
                Console.WriteLine("Car #" + i + ": " + myStore.CarList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action:");
            Console.WriteLine("Press 0 to quit.");
            Console.WriteLine("Press 1 to add a car to your inventory.");
            Console.WriteLine("Press 2 to add a car to your shopping list.");
            Console.WriteLine("Press 3 to checkout and see your total price.");

            try 
            {
                choice = int.Parse(Console.ReadLine());
            } 
            catch 
            {
                Console.WriteLine("Invalid action. Quitting Application.");
            }

            return choice;
        }
    }
}
