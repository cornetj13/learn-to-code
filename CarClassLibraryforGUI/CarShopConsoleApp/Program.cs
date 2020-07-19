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

            while (action > 3 || action < 0)
            {
                Console.WriteLine("Sorry, this action is out of range.");
                action = chooseAction();
            }

            while (action != 0) 
            {
                Console.WriteLine("\n");
                Console.WriteLine("You chose action " + action);

                switch (action)
                {
                    // Adds a Car to the Inventory.
                    case 1:

                        Console.WriteLine("You chose to add a new car to the inventory");

                        String carMake = "";
                        String carModel = "";
                        String carColor = "";
                        bool carNew = false;
                        Decimal carPrice = 0;

                        Console.WriteLine("What is the car make? (For example: Ford, GM, Nissan, etc.)");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? (For example: Focus, Corvette, Sentra, etc.)");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car color? (For example: Blue, White, Orange, etc.)");
                        carColor = Console.ReadLine();

                        Console.WriteLine("Is the car new? (yes or no)");
                        string carNewString = Console.ReadLine();
                        if (carNewString == "yes")
                        {
                            carNew = true;
                        } 
                        else if (carNewString == "no")
                        {
                            carNew = false;
                        } 
                        else 
                        {
                            Console.WriteLine("Invalid input, default to used car.");
                        }

                        Console.WriteLine("What is the price of the car?");
                        try     
                        {
                            carPrice = int.Parse(Console.ReadLine());
                        } 
                        catch 
                        {
                            Console.WriteLine("Invalid action. Price set to $0.");
                            Console.ReadLine();
                        }
                    

                        Car newCar = new Car(carMake, carModel, carColor, carNew, carPrice);
                        myStore.CarList.Add(newCar);

                        Console.WriteLine("\n");
                        printInventory(myStore);

                        break;

                    // Adds a Car to the Shopping List.
                    case 2:
                        Console.WriteLine("You chose to add a new car to your shopping cart.");
                        Console.WriteLine("\n");
                        printInventory(myStore);
                        Console.WriteLine("\n");
                        Console.WriteLine("Which car(s) would you like to purchase? (Input car's number to add.)");
                        
                        try 
                        {
                            int carChosen = int.Parse(Console.ReadLine());
                            myStore.ShoppingList.Add(myStore.CarList[carChosen - 1]);
                            Console.WriteLine("\n");
                            printShoppingCart(myStore);
                        } 
                        catch 
                        {
                            Console.WriteLine("Invalid action. Try again.");
                            Console.ReadLine();
                        }

                        break;
                    
                    // Gives Total Price of Purchased Cars.
                    case 3:
                        printShoppingCart(myStore);
                        Console.WriteLine("\n");
                        Console.WriteLine("The total cost of your cars is: " + myStore.Checkout());
                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }
        }

        private static void printShoppingCart(Store myStore) 
        {
            Console.WriteLine("Cars you would like to purchase:");
            for (int i = 0; i < myStore.ShoppingList.Count; i++) 
            {
                int j = i + 1;
                Console.WriteLine("Car #" + j + ": " + myStore.ShoppingList[i]);
            }
        }

        private static void printInventory(Store myStore) 
        {
            for (int i = 0; i < myStore.CarList.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine("Car #" + j + ": " + myStore.CarList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("\n");
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
                Console.ReadLine();
            }

            return choice;
        }
    }
}
