using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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

        public void passwordTester(string password)

        {
            Console.WriteLine("Enter your password:");
            string input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Forbidden");
            }
        }

        public double highestNumber(double num1, double num2, double num3)
        {
            double highest = 0;
            if(num1 > num2 || num1 == num2)
            {
                highest = num1;
                if(highest < num3 || highest == num3)
                {
                    highest = num3;
                }
                else
                {
                    return highest;
                }
            }
            else
            {
                highest = num2;

            if(highest < num3 || highest == num3)
                {
                    highest = num3;
                }

            }
            return highest;
        }

        public double calculator() {

            Console.WriteLine("Enter First Number:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Choose Operator: \n 1. + \n 2. - \n 3. * \n 4. / \n");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter Second Number:");
            string num2 = Console.ReadLine();

            double result = 0;
            double parsedNumber = Double.Parse(num1);
            double parsedNumber2 = Double.Parse(num2);
   

            switch(operation) {

                case "1":
                {
                        result = parsedNumber + parsedNumber2;
                        break;
                }
                case "2":
                    {
                        result = parsedNumber - parsedNumber2;
                        break;
                    }
                case "3":
                    {
                        result = parsedNumber * parsedNumber2;
                        break;
                    }
                    case "4":
                    {
                        result = parsedNumber / parsedNumber2;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException();
                    }

            }
                    return result;
        }

        public string legalAgeElection(string age)
        {
            string result;

            int parsedAge = Int16.Parse(age);

            if(parsedAge >= 18)
            {
                result = "You have legal age to parcipicate in the election";
            }
            else
            {
                result = "You are underaged";
            }
            return result;
        }

        public void greetBasedOnTime(int hour)
        {
            if(hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning");
            }else if(hour >= 12 && hour <= 16) {
                Console.WriteLine("Good Afternoon");
            }else if(hour >= 17 && hour <= 20)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }

        public void calculateDiscount(double total)
        {
            double disscount = 0;
            if(total >= 100 && total <= 500)
            {
                disscount = total * 0.10;
            }else if(total > 500)
            {
                disscount = total * 0.20;
            }

            double finalPrice = total - disscount;

            Console.WriteLine("disscount: " + finalPrice);
        }


        public static void checkPurchaseEligibility(int age, string country)
        {
            if((country == "US" && age >= 21) || (country != "US" && age >= 18))
            {
                Console.WriteLine("you are able to buy!");
            }
            else
            {
                Console.WriteLine("you arent able to buy!");
            }
        }

        public void checkLoanEligibility(int age, double income, string hasCoApplicant) { 
        
            if(age >= 18 && (income >= 2500 || hasCoApplicant.ToLower() == "yes"))
            {
                Console.WriteLine("you can get a loan");
            }
            else Console.WriteLine("you cant get a loan");
        }
      

    }
}
