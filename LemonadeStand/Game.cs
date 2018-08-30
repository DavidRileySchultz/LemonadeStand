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

        public void SetTodaysWeather()
        {
            weather.GetTemperature();
            weather.GetWeatherConditions();
            Console.WriteLine("Today's weather is:" + " " + weather.temperature + "°F and" + weather.weatherCondition + ".");

        }

        public void RunGame()
        {

        }

   
    }
}
