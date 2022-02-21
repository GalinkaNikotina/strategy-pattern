using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Quack";
        }
    }
}
