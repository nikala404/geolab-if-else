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

        public string isNumberEvenOrOdd(long number)
        {
            if (number % 2 == 0)
            {
                return "number is even";
            }
            else
            {
                return "number is odd";
            }
        }

        public string studentRate(float number) {
        
            if(number >= 90 && number <= 100)
            {
                return "A";
            } else if(number >= 80 && number <= 89)
            {
                return "B";
            } else if(number >= 70 && number <= 79)
            {
                return "C";
            } else if(number >= 60 && number <= 69)
            {
                return "D";
            } else if(number >= 0 && number <= 59)
            {
                return "F";
            }
             else
            {
                return "Invalid number";
            }   
        }

        public string IsYearLeap(int year)
        {
            string result = "";
            if(year % 4 == 0 & year % 100 != 0)
            {
                if(year % 400 == 0)
                {

                    result = "This year is Leap";
                }
            }
            else
            {
                result =  "This year is not leap";
            }
            return result;

        }

        public void passwordTester(string password, string usersInput)
        {
            if(usersInput == password)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Forbidden");
            }
        }

      
    }
}
