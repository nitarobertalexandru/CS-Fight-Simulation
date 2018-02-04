using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight2Death
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);

            Warrior spartacus = new Warrior("Spartacus", 1000, 120, 40);

            Battle.StartFight(maximus, spartacus);

            Console.ReadLine();
        }
    }
}
