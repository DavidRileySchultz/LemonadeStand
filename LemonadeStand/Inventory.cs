using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        public int cupInventory;
        public int sugarInventory;
        public int lemonInventory;
        public int iceInventory;
        public double cashWallet;
        //making these variables public to update inventory from store
        //constructor

        //methods
        public void Inventory()
        {
            cashWallet = 20;
            cupInventory = 0;
            sugarInventory = 0;
            lemonInventory = 0;
            iceInventory = 0;
        }

        public void DisplayInventoryStatus()
        {
            Console.WriteLine("Cash =" + cashWallet);
            Console.WriteLine("Cups =" + cupInventory);
            Console.WriteLine("Sugar =" + sugarInventory);
            Console.WriteLine("Lemons =" + lemonInventory);
            Console.WriteLine("Ice Cubes =" + iceInventory);
        }
    }
}
