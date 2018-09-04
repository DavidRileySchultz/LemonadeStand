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
        Player player;
        
        //constructor
        
        //methods
        
        bool CheckFunds(double price, double cashWallet)
        {
            if (price > cashWallet)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        
        public void ReplenishInventory(Player player)
        {
            Console.WriteLine("\nWhat would you like to buy:\n(1)Cups\n(2)Sugar\n(3)Lemons\n(4)Ice\n(5)Exit shop");
            switch(Console.ReadLine())
            {
                case "1":
                    BuyCups(player);
                    break;
                case "2":
                    BuyCupsOfSugar(player);
                    break;
                case "3":
                    BuyLemons(player);
                    break;
                case "4":
                    BuyIceCubes(player);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    ReplenishInventory(player);
                    break;
            }
        }

        public void BuyCups(Player player)
        {
            Console.WriteLine("\nSo, you need some Cups? \n(1) 25 Cups at $0.95\n(2) 50 Cups at $1.72\n(3) 100 Cups at $3.07\n(4) Exit back to store");
            double price = 0;
            int amount = 0;
                        
            switch(Console.ReadLine())
            {
                case "1":
                    price = 0.95;
                    amount = 25;
                    break;
                case "2":
                    price = 1.72;
                    amount = 50;
                    break;
                case "3":
                    price = 3.07;
                    amount = 100;
                    break;
                case "4":
                    ReplenishInventory(player);
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    BuyCups(player);
                    break;

            }
            if(CheckFunds(price, player.inventory.cashWallet) == false)
            {
                Console.WriteLine("\nNot enough cash, try buying a smaller amount...");
                BuyCups(player);
            }
            else
            {
                player.inventory.cupInventory += amount;
                player.inventory.cashWallet -= price;
                Console.WriteLine("\nYou bought " + amount + " cups at $" + price);
                player.inventory.DisplayInventoryStatus();
                ReplenishInventory(player);
            }
        }

        public void BuyCupsOfSugar(Player player)
        {
            Console.WriteLine("\nYou need to buy some Sugar?\n(1) 6 cups of Sugar = $0.60\n(2) 12 cups of Sugar = $1.55\n(3) 20 cups of Sugar = $3.40\n(4) Exit back to store");
            double price = 0;
            int amount = 0;

            switch (Console.ReadLine())
            {
                case "1":
                    price = 0.60;
                    amount = 6;
                    break;
                case "2":
                    price = 1.55;
                    amount = 12;
                    break;
                case "3":
                    price = 3.40;
                    amount = 20;
                    break;
                case "4":
                    ReplenishInventory(player);
                    break;
                default:
                    Console.WriteLine("please enter valid input, try again...");
                    BuyCupsOfSugar(player);
                    break;
            }
            if (CheckFunds(price, player.inventory.cashWallet) == false)
            {
                Console.WriteLine("\nNot enough cash, try buying a smaller amount...");
                BuyCupsOfSugar(player);
            }
            else
            {
                player.inventory.sugarInventory += amount;
                player.inventory.cashWallet -= price;
                Console.WriteLine("\nYou bought " + amount + " Cups of Sugar at $" + price);
                player.inventory.DisplayInventoryStatus();
                ReplenishInventory(player);
            }

        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("\nSo, you need to buy some Lemons?\n(1) 10 Lemons = $0.69\n(2) 15 Lemons = $2.32\n(3) 25 Lemons = $4.31\n(4) Exit back to store");
            double price = 0;
            int amount = 0;

            switch (Console.ReadLine())
            {
                case "1":
                    price = 0.69;
                    amount = 10;
                    break;
                case "2":
                    price = 2.32;
                    amount = 15;
                    break;
                case "3":
                    price = 4.31;
                    amount = 25;
                    break;
                case "4":
                    ReplenishInventory(player);
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    BuyLemons(player);
                    break;
            }
            if (CheckFunds(price, player.inventory.cashWallet) == false)
            {
                Console.WriteLine("\nNot enough cash, try buying a smaller amount...");
                BuyLemons(player);
            }
            else
            {
                player.inventory.lemonInventory += amount;
                player.inventory.cashWallet -= price;
                Console.WriteLine("\nYou bought " + amount + " Lemons at $" + price);
                player.inventory.DisplayInventoryStatus();
                ReplenishInventory(player);
            }
        }

        public void BuyIceCubes(Player player)
        {
            Console.WriteLine("\nYou need to buy some Ice?\n(1) 100 Ice Cubes = $0.81\n(2) 250 Ice Cubes = $2.10\n(3) 350 Ice Cubes = $3.62\n(4) Exit back to store");
            double price = 0;
            int amount = 0;

            switch (Console.ReadLine())
            {
                case "1":
                    price = 0.81;
                    amount = 100;
                    break;
                case "2":
                    price = 2.10;
                    amount = 250;
                    break;
                case "3":
                    price = 3.62;
                    amount = 350;
                    break;
                case "4":
                    ReplenishInventory(player);
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    BuyIceCubes(player);
                    break;
            }
            if (CheckFunds(price, player.inventory.cashWallet) == false)
            {
                Console.WriteLine("\nNot enough cash, try buying a smaller amount...");
                BuyIceCubes(player);
            }
            else
            {
                player.inventory.iceInventory += amount;
                player.inventory.cashWallet -= price;
                Console.WriteLine("\nYou bought " + amount + " ice cubes at $" + price);
                player.inventory.DisplayInventoryStatus();
                ReplenishInventory(player);
            }
        }
    }
}
