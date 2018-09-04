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
        public int cupsLeftInPitcher = 10;
        public int lemonsPerPitcher = 4;
        public int cupsOfSugarPerPitcher = 4;
        public int iceCubesPerCup = 4;

        //constructor

        //methods
        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("Your current recipe is:");
            Console.WriteLine("Number of Lemons per pitcher = " + lemonsPerPitcher);
            Console.WriteLine("Cups of Sugar per pitcher = " + cupsOfSugarPerPitcher);
            Console.WriteLine("Number of Ice Cubes per cup = " + iceCubesPerCup);
        }

        public void PromptToChangeRecipe()
        {
            Console.WriteLine("Would you like to change your recipe?\n(1) Yes\n(2) No");
            switch(Console.ReadLine())
            {
                case "1":
                    ChangeRecipe();
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Please enter valid input, try again...");
                    PromptToChangeRecipe();
                    break;

            }
        }
        public void ChangeRecipe()
        {
            DisplayCurrentRecipe();
            ChangeLemonAmount();
            ChangeSugarAmount();
            ChangeIceAmount();
            DisplayCurrentRecipe();
        }

        public void ChangeLemonAmount()
        {
            Console.WriteLine("How many Lemons do you want to use per pitcher?\n(1) 2 Lemons\n(2) 4 Lemons\n(3) 6 Lemons\n(4) Exit back to Change Recipe menu.");
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
            Console.WriteLine("How many cups of sugar do you want to use per pitcher?\n(1) 2 Cups of Sugar\n(2) 4 Cups of Sugar\n(3) 6 Cups of Sugar\n(4) Exit back to Change Recipe menu." );
            switch(Console.ReadLine())
            {
                case "1":
                    cupsOfSugarPerPitcher = 2;
                    break;
                case "2":
                    cupsOfSugarPerPitcher = 4;
                    break;
                case "3":
                    cupsOfSugarPerPitcher = 6;
                    break;
                case "4":
                    ChangeRecipe();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input, try again...");
                    ChangeSugarAmount();
                    break;
            }
        }

        public void ChangeIceAmount()
        {
            Console.WriteLine("How many Ice Cubes do you want to use per cup?\n(1) 2 Ice Cubes per pitcher\n(2) 4 Ice Cubes per pitcher\n(3) 6 Ice Cubes per pitcher\n(4) Exit back to the Change Recipe menu.");
            switch(Console.ReadLine())
            {
                case "1":
                    iceCubesPerCup = 2;
                    break;
                case "2":
                    iceCubesPerCup = 4;
                    break;
                case "3":
                    iceCubesPerCup = 6;
                    break;
                case "4":
                    ChangeRecipe();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input, try again...");
                    ChangeIceAmount();
                    break;
            }
        }
    }
}
