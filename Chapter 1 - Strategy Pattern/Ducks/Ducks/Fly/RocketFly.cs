using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Fly
{
    class RocketFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("5, 4, 3, 2, 1, Launch!");
        }
    }
}
