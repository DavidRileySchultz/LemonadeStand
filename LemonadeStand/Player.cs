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
        public double pricePerCup = .20;
        int cupsSold;
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

        public void SellLemonade()
        {
            if(recipe.cupsPerPitcher >= 0 && inventory.cupInventory != 0 && recipe.iceCubesPerCup > inventory.iceInventory)
            {
                recipe.cupsPerPitcher -= 1;
                inventory.cupInventory -= 1;
                inventory.iceInventory -= recipe.iceCubesPerCup;
                inventory.cashWallet += pricePerCup;
                cupsSold++;

            }
            else
            {
                //make method to check if enough ingredients to make another pitcher
                //make method to refil pitcher
                //end day if not enough in inventory to refil pitcher
            }
        }
    }
}
