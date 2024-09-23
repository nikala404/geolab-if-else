using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geolab_if_else
{
    internal class Conditionals
    {

        public string typeOfNumber(long number)
        {
            if (number > 0)
            {
                return "number is positive";
            }
            else if (number < 0)
            {
                return "number is negative";
            }
            else
            {
                return "number is zero";
            }
        }

      
    }
}
