using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes_5
{
    class Divide
    {
        public void Math(int num1, out int outResult)
        {
            outResult = num1 / 2;
            //outresult = result;
            //Console.WriteLine(result);
        }

        public void Math(decimal num1, out decimal outResult)
        {
            outResult = num1 / 2;
            //outresult = result;
            //Console.WriteLine(result);
        }
    }
}
