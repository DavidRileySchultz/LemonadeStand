﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public int cupInventory;
        public int sugarInventory;
        public int lemonInventory;
        public int iceInventory;
        public double cashWallet;
        
        //constructor
        public Inventory()
        {
            cashWallet = 20;
            cupInventory = 0;
            sugarInventory = 0;
            lemonInventory = 0;
            iceInventory = 0;           
        }
        //methods


        public void DisplayInventoryStatus()
        {
            Console.WriteLine("Cash = $" + Math.Round(cashWallet, 2));
            Console.WriteLine("Cups = " + cupInventory);
            Console.WriteLine("Sugar = " + sugarInventory);
            Console.WriteLine("Lemons = " + lemonInventory);
            Console.WriteLine("Ice Cubes = " + iceInventory);
        }
    }
}
