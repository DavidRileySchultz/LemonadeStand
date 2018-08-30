using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Player player = new Player();
            store.ReplenishInventory(player);
        }
    }
}
