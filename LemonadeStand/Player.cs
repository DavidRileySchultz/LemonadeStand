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
        public List<Day> days;
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
            Console.WriteLine("What would you like to charge per cup?");
            pricePerCup = double.Parse(Console.ReadLine());

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

            }
            else
            {
                CheckForPitcherRefill(player, currentDay);
                RefillPitcher();
                SellLemonade(currentDay);
            }
        }

        public void CheckForPitcherRefill(Player player, int currentDay)
        {
            if(inventory.lemonInventory < recipe.lemonsPerPitcher || inventory.sugarInventory < recipe.cupsOfSugarPerPitcher)
            {
                Console.WriteLine("Not enough inventory to make another pitcher! You are sold out for the day... Better planning next time!");
                days[currentDay].EndOfDay(player);
            }

        }

        public void RefillPitcher()
        {
            inventory.sugarInventory -= recipe.cupsOfSugarPerPitcher;
            inventory.lemonInventory -= recipe.lemonsPerPitcher;
            recipe.cupsLeftInPitcher = 10;
            Console.WriteLine("Your Pitcher has been refilled! Go sell some more Lemonade to those thirsty customers!");
        }
    }
}
