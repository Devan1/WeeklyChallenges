using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    answ += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    answ -= numbers[i];
                }
            }
            return answ;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            double number = 0;
            var isaNumber = double.TryParse(input, out number);

            return isaNumber;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            int nullCount = 0;
            int notNullCount = 0;
            foreach (var item in objs)
            {
                if(item == null)
                {
                    nullCount++;
                }
                else
                {
                    notNullCount++;
                }
            }
            if(nullCount > notNullCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            double evensCount = 0.00;
            double evensTotal = 0.00;
                        
            if(numbers == null) { return 0; }
            foreach(var item in numbers)
            {
                if(item % 2 == 0)
                {
                    evensCount++;
                    evensTotal += item;
                }
            }
            if(evensCount > 0)
            {
                return evensTotal / evensCount;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            int factorial = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0) { return 1; }
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
            
        }
    }
}
