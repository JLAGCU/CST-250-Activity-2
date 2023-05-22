using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog demonstration:");
            Dog bowser = new Dog();
            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();
            Console.WriteLine("======================");

            Console.WriteLine("Robin demonstration:");
            Robin red = new Robin();
            red.Talk();
            red.Greet();
            red.Sing();
            Console.WriteLine("======================");

            Console.WriteLine("Pigeon demonstration:");
            Pigeon lola = new Pigeon();
            lola.Talk();
            lola.Greet();
            lola.Sing();
            lola.Fly();
            lola.Land();
            Console.WriteLine("======================");

            Console.WriteLine("Donkey demonstration:");
            Donkey stallion = new Donkey();
            stallion.Talk();
            stallion.Greet();
            stallion.Sing(); 
            stallion.Mount();
            stallion.Dismount();
            Console.WriteLine("======================");

            Console.WriteLine("Horse demonstration:");
            Horse dusty = new Horse();
            dusty.Talk();
            dusty.Greet();
            dusty.Sing();
            dusty.Mount();
            dusty.Dismount();
            Console.WriteLine("======================");

            Console.ReadLine();
        }
    }
}
