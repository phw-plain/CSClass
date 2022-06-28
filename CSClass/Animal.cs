using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    public class Animal
    {
        int Age;

        public Animal()
        {
            Age = 0;
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
        public override void Eat()
        {
            Console.WriteLine("냠냠");
        }
    }
}
