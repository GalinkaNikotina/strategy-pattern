using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            IFlyBehavior flyBehavior = new FlyNoWay();
            IQuackBehavior quackBehavior = new DQuack();

            mallardDuck.SetFlyBehavior(flyBehavior);
            rubberDuck.SetQuackBehavior(quackBehavior);

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck, decoyDuck, rubberDuck };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].PerformFly());
                Console.WriteLine(ducks[i].PerformQuack());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
