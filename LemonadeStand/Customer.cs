using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
        //different type of customers
        //ability to purchase a cup of lemonade
        //effected by weather conditions
        //<list> of customers
    {

        //member variable
        int temperaturePreference;
        int conditionPreference;
        double pricePreference;
        bool buyCup;
        //constructor
        public Customer()
        {

        }

        //methods
        public void SetTemperaturePreference()
        {

        }

        public void SetConditionPreference()
        {

        }

        public void SetPricePreference()
        {

        }

        public void SetChanceToBuy(Player player, Weather weather)
        {
            if(player.pricePerCup <= pricePreference && conditionPreference >= weather.randomCondition && temperaturePreference >= weather.actualTemperature)
            {
                buyCup = true;
                player.inventory.cashWallet += player.pricePerCup;

            }
            else
            {
                buyCup = false;
            }
        }
    }
}
