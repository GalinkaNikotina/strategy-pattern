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
            Duck mallarDuck = new MallarDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();

            Duck[] ducks = new Duck[] { mallarDuck, redheadDuck, decoyDuck, rubberDuck };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                if (ducks[i] is IFlyBehavior)
                {
                    Console.WriteLine((ducks[i] as IFlyBehavior).Fly());
                }
                if (ducks[i] is IQuackBehavior)
                {
                    Console.WriteLine((ducks[i] as IQuackBehavior).Quack());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
