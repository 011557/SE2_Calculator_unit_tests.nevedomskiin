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
            // comment 0 empty string check
	    if (numbers == "") return 0;
            else
            {
                string[] strArray = numbers.Split();
                int a, b;
		// comment parsing
                Int32.TryParse(strArray[0], out a);
                Int32.TryParse(strArray[1], out b);
		// comment 2 sum
                return a + b;
            }
        }
    }
}
