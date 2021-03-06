﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;
        int numberOfCustomersPerDay = 100;
        Random rnd;

        //constructor
        public Day(Random rnd)
        {
            this.rnd = rnd;
            weather = new Weather(rnd);
            customers = new List<Customer>();
           

        }
        //methods
        public void CustomersPerDay(Player player, int currentDay)
        {
            numberOfCustomersPerDay = 100;
            for (int i = 0; i < numberOfCustomersPerDay; i++)
            {

                customers.Add(new Customer(player, weather, rnd, currentDay));
                customers[i].GetChanceToBuy(player, weather, rnd, currentDay);
                
            }
        }
        
        public void EndOfDay(Player player)
        {
            Console.WriteLine("The day has ended, let's see how many cups you sold and how much money you have!");
            Console.WriteLine("You managed to sell " + player.cupsSold + " cups of Lemonade today");
            Console.WriteLine("You managed to make $" + (player.cupsSold * player.pricePerCup) + ".");
            Console.WriteLine("Your profits are $" + (Math.Round(player.inventory.cashWallet, 2) - 20) + ".");
            Console.WriteLine("You're ice left over from today has melted... Sorry, but this isn't Antarctica\n");
            player.inventory.iceInventory = 0;
            player.recipe.cupsLeftInPitcher = 0;
            player.cupsSold = 0;
            Console.WriteLine("Hit any key to continue onto the next day!\n");
            Console.ReadKey();
        }
        
    }
}
