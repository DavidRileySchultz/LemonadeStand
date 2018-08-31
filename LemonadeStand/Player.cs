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

            }
        }
    }
}
