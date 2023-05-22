using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal
{
    internal class Pigeon : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Pigeon is flying");
        }

        public void Land()
        {
            Console.WriteLine("Pigeon has landed");
        }

        public override void Sing()
        {
            Console.WriteLine("Tweet Tweet");
        }
    }
}
