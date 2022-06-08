using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class SingleTon
    {
        private static SingleTon instance = null;

        private SingleTon()
        {

        }
        public static SingleTon getInstance()
        {
            if(SingleTon.instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }
    }
}
