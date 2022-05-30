using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Product
    {
        // 클래스 생성 방법
        public string name = "노네임";
        public int price;

        public override string ToString()
        {
            return this.name + ": " + this.price;
        }
    }
}
