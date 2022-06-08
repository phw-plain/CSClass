using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Product
    {
        internal static int counter = 0;

        // 클래스 생성 방법
        public string name = "노네임";
        public int price = 1000;
        private int id = -1;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.id = ++counter;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "[" + this.id + "] " + this.name + ": " + this.price;
        }

        ~Product()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
}
