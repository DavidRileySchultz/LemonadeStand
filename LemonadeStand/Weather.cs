using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int actualTemperature;
        public int forecastedTemperature;
        public string actualCondition;
        public string forecastedCondition;
        int randomCondition;
        public Weather(Random rnd)
        {
            SetAllTheWeatherStuff(rnd);
            
        }

        public void SetAllTheWeatherStuff(Random rnd)
        {
            SetForecastedWeather(rnd);
            SetActualWeather(rnd);
            
        }
        public void DisplayActualWeather()
        {
            Console.WriteLine("Today's weather is: " + actualTemperature + "°F and " + actualCondition + ".");
        }

        public void DisplayForecast()
        {
            Console.WriteLine("Tomorrow's forecasted weather is: " + forecastedTemperature + "°F and " + forecastedCondition + ".");
        }

        public void SetForecastedWeather(Random rnd)
        {
            randomCondition = rnd.Next(1, 5);
            switch (randomCondition)
            {
                case 1:
                    forecastedCondition = "Sunny";
                    forecastedTemperature = rnd.Next(75, 91);
                    break;

                case 2:
                    forecastedCondition = "Cloudy";
                    forecastedTemperature = rnd.Next(75, 85);
                    break;

                case 3:
                    forecastedCondition = "Rainy";
                    forecastedTemperature = rnd.Next(65, 78);
                    break;

                case 4:
                    forecastedCondition = "Cool";
                    forecastedTemperature = rnd.Next(55, 66);
                    break;
            }
        }

        public void SetActualWeather(Random rnd)
        {
            if (randomCondition == 1)
            {
                
                randomCondition = rnd.Next(1, 4);
                switch (randomCondition)
                {
                    case 1:
                        actualCondition = "Sunny";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                    case 2:
                        actualCondition = "Cloudy";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                    case 3:
                        actualCondition = "Rainy";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                }

            }

            else if (randomCondition == 2)
            {
                
                randomCondition = rnd.Next(1, 4);
                switch (randomCondition)
                {
                    case 1:
                        actualCondition = "Cloudy";
                        actualTemperature = rnd.Next(75, 85);
                        break;
                    case 2:
                        actualCondition = "Rainy";
                        actualTemperature = rnd.Next(75, 85);
                        break;
                    case 3:
                        actualCondition = "Cool";
                        actualTemperature = rnd.Next(57, 70);
                        break;
                }
            }

            else if (randomCondition == 3)
            {

                randomCondition = rnd.Next(1, 4);
                switch (randomCondition)
                {
                    case 1:
                        actualCondition = "Rainy";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                    case 2:
                        actualCondition = "Sunny";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                    case 3:
                        actualCondition = "Cloudy";
                        actualTemperature = rnd.Next(75, 91);
                        break;
                }
            }

            else if (randomCondition == 4)
            {
                
                randomCondition = rnd.Next(1, 4);
                switch (randomCondition)
                {
                    case 1:
                        actualCondition = "Cool";
                        actualTemperature = rnd.Next(55, 67);
                        break;
                    case 2:
                        actualCondition = "Cloudy";
                        actualTemperature = rnd.Next(55, 67);
                        break;
                    case 3:
                        actualCondition = "Rainy";
                        actualTemperature = rnd.Next(55, 67);
                        break;
                }
            }
        }
    }
}
