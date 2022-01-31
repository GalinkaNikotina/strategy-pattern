using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MallarDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "Display" + " " + this.GetType();
        }
        public string Quack()
        {
            return "Quackable" + " " + this.GetType();
        }
        public string Fly()
        {
            return "Flyable" + " " + this.GetType();
        }
    }
}
