using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            duck.Fly();
            duck.Quack();
            Console.ReadKey();
        }
    }
}
