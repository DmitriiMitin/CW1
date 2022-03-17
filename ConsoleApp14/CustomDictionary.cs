using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class CustomDictionary
    {
        private Pair[] pairs;
        public CustomDictionary(String filenames)
        {

        }

        public CustomDictionary(Pair[] pairs)
        {
            this.pairs = pairs;
        }

        public void Show()
        {
            foreach (var p in pairs)
            {
                Console.WriteLine(p.Key + " - " + p.Value);
            }
        }
    }

    public class Pair
    {
        public string Key { get; set; }
        public string Value;
        public Pair(string key, string val)
        {
            Key = key;
            Value = val;
        }
    }
}
