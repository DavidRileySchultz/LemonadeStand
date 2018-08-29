using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables

        //constructor

        //methods
        //method switchcase to show menu of items ot buy
        public void ReplenishInventory()
        {
            Console.WriteLine("What would you like to replenish:\n(1)Cups\n(2)Sugar\n(3)Lemons)\n(4)Ice\n(5)Exit shop");
            string chooseItem = Console.ReadLine();
            switch(chooseItem)
            {
                case "1":
                    BuyCups();//display inventroy before entering each item to purchase?
                    break;
                case "2":
                    BuyCupsOfSugar();
                    break;
                case "3":
                    BuyLemons();
                    break;
                case "4":
                    BuyIceCubes();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    ReplenishInventory();
                    break;
            }
        }

        public void BuyCups()
        {
            Console.WriteLine("So, you need some cups?! \n50 cups at $.60\n75 cups at $1.00\n100 cups at $1.30");
            string buyCups = Console.ReadLine();
            //use switch case to choose different amounts?
            //here set prices for items depending on quantity.
            //figure out how to check if player has enough money
            //figure out how to subtract from players wallet
            //figure out how to add to inventory
            double priceOfCups = 0;
            int amountOfCups = 0;
            switch(buyCups)
            {
                case "1":
                    priceOfCups = 0.60;
                    amountOfCups = 50;
                    break;
                case "2":
                    priceOfCups = 1.00;
                    amountOfCups = 75;
                    break;
                case "3":
                    priceOfCups = 1.30;
                    amountOfCups = 100;
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    BuyCups();
                    break;

            }
        }

        public void BuyCupsOfSugar()
        {

        }

        public void BuyLemons()
        {

        }

        public void BuyIceCubes()
        {

        }
    }
}
