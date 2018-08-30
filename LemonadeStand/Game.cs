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
        Weather weather;
        Player player;
        Store store;
        public List<Day> days;
        public int numberOfDaysInGame;

        //constructor
        public Game()
        {
            rules = "The goal is to make as much money as you can in 7 Days.\nBuy cups, lemons, sugar, and ice cubes; then set your recipe based on the weather and conditions.\nStart with the basic recipe and see if you can do bestter.\nLastly, set your price and sell your lemonade at the stand, try changing the price based on the weather conditions as well.\nSee how much money you can make at the end of 7 days!!";
            player = new Player();
            store = new Store();
            weather = new Weather();
            
        }
        //methods
        public void ShowRules()
        {
            Console.WriteLine(rules);
        }

        public void GetTodaysWeather()
        {
            //weather.SetTemperature();
            weather.SetWeatherConditions();
            Console.WriteLine("Today's weather is: " + weather.temperature + "°F and " + weather.weatherCondition + ".");

        }
        public void RunDay()
        {
            GetTodaysWeather();
            player.inventory.DisplayInventoryStatus();
            store.ReplenishInventory(player);
            player.recipe.PromptChangeRecipe();
            //Sell lemonade
        }

        public void PlayGame()
        {
            ShowRules();
            //do set up stuff
            for(int i = 0; i < numberOfDaysInGame; i++)
            {
                RunDay();
            }
            //do end game stuff
        }

   
    }
}
