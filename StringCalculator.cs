using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_Calculator_unit_tests
{
    class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "") return 0;
            else
            {
                string[] strArray = numbers.Split();
                int a, b;
                Int32.TryParse(strArray[0], out a);
                Int32.TryParse(strArray[1], out b);
                return a + b;
            }
        }
    }
}
