using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        public Inventory inventory;
        public Recipe recipe;
        Player player;
        Day day;
        public double pricePerCup = .20;
        public int cupsSold;
        //constructor
        public Player()
        {
            
            inventory = new Inventory();
            recipe = new Recipe();
            
            
        }

        //methods
        public void SetPricePerCup()
        {
            Console.WriteLine("Currently charging $" + pricePerCup  + " per cup.");
            Console.WriteLine("What would you like to charge per cup?\n");
                      
            try
            {
                pricePerCup = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid input, number or decimal to declare your price.");
                SetPricePerCup();
            }

        }

        public void SellLemonade(int currentDay)
        {
            if(recipe.cupsLeftInPitcher > 0 && inventory.cupInventory != 0 && inventory.iceInventory >= 4)
            {
                recipe.cupsLeftInPitcher -= 1;
                inventory.cupInventory -= 1;
                inventory.iceInventory -= recipe.iceCubesPerCup;
                inventory.cashWallet += pricePerCup;
                cupsSold++;
                Console.WriteLine("Congratulations!!!, you've sold a cup of lemonade!");
            }
            else
            {
                CheckForPitcherRefill(player);
                RefillPitcher();
                recipe.cupsLeftInPitcher -= 1;
                inventory.cupInventory -= 1;
                inventory.iceInventory -= recipe.iceCubesPerCup;
                inventory.cashWallet += pricePerCup;
                cupsSold++;
                Console.WriteLine("Congratulations!!!, you've sold a cup of lemonade!");

            }
        }

        public void CheckForPitcherRefill(Player player)
        {
            if(inventory.lemonInventory < recipe.lemonsPerPitcher || inventory.sugarInventory < recipe.cupsOfSugarPerPitcher)
            {
                Console.WriteLine("Not enough inventory to make another pitcher! You are sold out for the day... Better planning next time!\n");
                //this is one of my methods that fulfills the single responsibility principle, all it is designed to do is check inventory to see if there is available inventory to make a new pitcher.
            }
        }

        public void RefillPitcher()
        {
            inventory.sugarInventory -= recipe.cupsOfSugarPerPitcher;
            inventory.lemonInventory -= recipe.lemonsPerPitcher;
            recipe.cupsLeftInPitcher = 10;
            Console.WriteLine("Your Pitcher has been refilled! Go sell some more Lemonade to those thirsty customers!\n");
            //This is another method that fulfills the single responsibility principle, all it is designed to do is replenish the pitcher to sell more lemonade.
        }
    }
}
