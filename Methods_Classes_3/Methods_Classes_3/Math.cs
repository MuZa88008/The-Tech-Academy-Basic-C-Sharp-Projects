﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes_3
{
    class Math
    {
        public int math(int num1)
        {
            return num1 * 100;
        }

        public decimal math(decimal num1)
        {
            return num1 * 100;
        }

        public int math(string string1)
        {
            int temp;
            int.TryParse(string1, out temp);
            return temp* 200;
        }
    }
}
