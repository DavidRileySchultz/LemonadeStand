using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        const int totalDays = 7;
        const int minTemperature = 55;
        const int maxTemperature = 95;
        public string weatherCondition;
        public int temperature;
        //constructor

        //methods
        public void GetTemperature()
        {
            Random randomTemperature = new Random();
            temperature = randomTemperature.Next(minTemperature, maxTemperature);
           
        }

        public void GetWeatherConditions()
        {
            Random randomWeatherCondition = new Random();
            int number = randomWeatherCondition.Next(1, 8);
            switch (number)
            {
                case 1:
                    weatherCondition = "Sunny";
                    break;

                case 2:
                    weatherCondition = "Cloudy";
                    break;

                case 3:
                    weatherCondition = "Rainy";
                    break;

                case 4:
                    weatherCondition = "Partly Cloudy";
                    break;


            }

        }

    }
}
