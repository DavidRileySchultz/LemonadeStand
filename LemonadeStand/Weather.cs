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
        
        public string weatherCondition;
        public int temperature;
        //constructor

        //methods
        
        public void GetWeatherConditions()
        {
            Random randomTemperature = new Random();
            Random randomWeatherCondition = new Random();
            int number = randomWeatherCondition.Next(1, 7);
            switch (number)
            {
                case 1:
                    weatherCondition = "Sunny";
                    temperature = randomTemperature.Next(75, 91);
                    break;

                case 2:
                    weatherCondition = "Cloudy";
                    temperature = randomTemperature.Next(65, 78);
                    break;

                case 3:
                    weatherCondition = "Rainy";
                    temperature = randomTemperature.Next(65, 78);
                    break;

                case 4:
                    weatherCondition = "Cool";
                    temperature = randomTemperature.Next(55, 66);
                    break;

                case 5:
                    weatherCondition = "HOT!!";
                    temperature = randomTemperature.Next(89,99);
                    break;

                case 6:
                    weatherCondition = "Hazey";
                    temperature = randomTemperature.Next(80, 93);
                    break;
            }
        }

        public void GetWeatherForecast()
        {

        }
    }
}
