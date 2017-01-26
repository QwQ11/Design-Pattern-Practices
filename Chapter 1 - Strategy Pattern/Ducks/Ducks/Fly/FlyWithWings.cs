using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Fly
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }
    }
}
