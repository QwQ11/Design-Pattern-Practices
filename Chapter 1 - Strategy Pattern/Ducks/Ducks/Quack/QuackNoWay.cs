using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Quack
{
    public class QuackNoWay : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack.");
        }
    }
}
