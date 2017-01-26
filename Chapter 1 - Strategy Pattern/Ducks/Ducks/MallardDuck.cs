using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Fly;
using Ducks.Quack;

namespace Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new GeneralQuack();
        }
    }
}
