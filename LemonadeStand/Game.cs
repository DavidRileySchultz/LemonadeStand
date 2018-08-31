using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        string rules;
        Player player;
        Store store;
        Random rnd;
        public List<Day> days;
        public int numberOfDaysInGame = 7;

        //constructor
        public Game()
        {
            rnd = new Random();
            rules = "The goal is to make as much money as you can in 7 Days.\nBuy cups, lemons, sugar, and ice cubes; then set your recipe based on the weather and conditions.\nStart with the basic recipe and see if you can do bestter.\nLastly, set your price and sell your lemonade at the stand, try changing the price based on the weather conditions as well.\nSee how much money you can make at the end of 7 days!!";
            player = new Player();
            store = new Store();
            days = new List<Day>();
            
            numberOfDaysInGame = 7;
            for (int i = 0; i < numberOfDaysInGame; i++)
            {
               
                days.Add(new Day(rnd));
           
            }

        }
        //methods
        public void ShowRules()
        {
            Console.WriteLine(rules);
        }

 
        public void RunDay(int currentDay)
        {
            days[currentDay].weather.DisplayActualWeather();
            if (currentDay < numberOfDaysInGame - 1)
            {
                days[currentDay + 1].weather.DisplayForecast();
            }
            player.inventory.DisplayInventoryStatus();
            store.ReplenishInventory(player);
            player.recipe.PromptToChangeRecipe();
            //Sell lemonade
        }

        public void PlayGame()
        {
            ShowRules();
            //do set up stuff
            for(int i = 0; i < numberOfDaysInGame; i++)
            {
                Console.WriteLine("It is day: " + (i+1));
                RunDay(i);
            }
            //do end game stuff
        }

   
    }
}
