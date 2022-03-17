using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var pairs = new Pair[5];
            pairs[0] = new Pair("Дом", "House");
            pairs[1] = new Pair("Человек", "Human");
            pairs[2] = new Pair("Воздух", "Air");
            pairs[3] = new Pair("Камень", "Rock");
            pairs[4] = new Pair("Трава", "Grass");


            var customDictionary = new CustomDictionary(pairs);
            customDictionary.Show();

            Console.ReadKey();
        }
    }
}
