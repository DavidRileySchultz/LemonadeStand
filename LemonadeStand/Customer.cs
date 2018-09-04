using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
        
    {

        //member variable
        int temperaturePreference;
        int conditionPreference;
        double pricePreference;
        
        //constructor
        public Customer(Player player, Weather weather, Random rnd, int currentDay)
        {
            GetChanceToBuy(player, weather, rnd, currentDay);
        }

        //methods
        public void SetTemperaturePreference(Random rnd)
        {
            temperaturePreference = rnd.Next(57, 91);
        }

        public void SetConditionPreference(Random rnd)
        {
            conditionPreference = rnd.Next(1, 5);
        }

        public void SetPricePreference(Random rnd)
        {
            pricePreference = rnd.NextDouble();
        }

        public void GetChanceToBuy(Player player, Weather weather, Random rnd, int currentDay)
        {
            SetConditionPreference(rnd);
            SetTemperaturePreference(rnd);
            SetPricePreference(rnd);

            if(player.pricePerCup <= pricePreference && conditionPreference >= weather.randomCondition && temperaturePreference >= weather.actualTemperature)
            {
                player.SellLemonade(currentDay);
               
            }  
        }
    }
}
