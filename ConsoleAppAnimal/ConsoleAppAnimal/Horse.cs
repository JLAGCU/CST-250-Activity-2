using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal
{
    internal class Horse : Animal, IRidable
    {
        public void Dismount()
        {
            Console.WriteLine("Horse has been dismounted");
        }

        public void Mount()
        {
            Console.WriteLine("Horse has been mounted");
        }
        public override void Greet()
        {
            Console.WriteLine("NEIGH!");
        }
    }
}
