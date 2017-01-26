using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Fly;
using Ducks.Quack;

namespace Ducks
{
    public class Duck
    {
        public IFly FlyBehavior { get; set; }
        public IQuack QuackBehavior { get; set; }
        public void Fly()
        {
            this.FlyBehavior.Fly();
        }
        public void Quack() {
            this.QuackBehavior.Quack();
        }
    }
}
