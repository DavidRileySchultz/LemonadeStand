using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int lemonsPerPitcher = 4;
        public int cupsOfSugarPerPitcher = 4;
        public int iceCubesPerCup = 4;
        
        //constructor

        //methods
        public void ChangeRecipe()
        {
            ChangeLemonAmount();
            ChangeSugarAmount();
            ChangeIceAmount();

        }

        public void ChangeLemonAmount()
        {
            Console.WriteLine("Many many Lemons do you want to use per pitcher?\n(1) 2 Lemons\n(2) 4 Lemons\n(3) 6 Lemons\n(4) Back to Change Recipe menu.");
            switch(Console.ReadLine())
            {
                case "1":
                    lemonsPerPitcher = 2;
                    break;
                case "2":
                    lemonsPerPitcher = 4;
                    break;
                case "3":
                    lemonsPerPitcher = 6;
                    break;
                case "4":
                    ChangeRecipe();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input, try again...");
                    ChangeLemonAmount();
                    break;

            }

        }

        public void ChangeSugarAmount()
        {

        }

        public void ChangeIceAmount()
        {

        }
    }
}
