using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourname;
            Console.WriteLine("O namae wa");
            yourname = Console.Readline();
            Console.WriteLine("Harro {0}", yourname);
            int age = Convert.TOInt32(Console.ReadLine());
            Console.WriteLine("You are {0} Years old", age);
        }
    }
}