using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public double BlockMax { get; set;}

        Random rnd = new Random();

        public Warrior(string name = "Warrior",
            double health = 0, 
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public double Block()
        {
            return rnd.Next(1,(int)BlockMax);
        }
    }
}
