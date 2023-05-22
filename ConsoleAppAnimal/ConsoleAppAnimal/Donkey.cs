using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal
{
    internal class Donkey : Animal, IRidable
    {
        public void Dismount()
        {
            Console.WriteLine("Donkey has been dismounted");
        }

        public void Mount()
        {
            Console.WriteLine("Donkey has been mounted");
        }
    }
}
