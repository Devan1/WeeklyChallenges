using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 >= 1)
            {
                return true;
            }
            else if(num % -2 <= -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() <1) { return 0; }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) { return 0; }
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) { sum += numbers[i]; }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum =0;
            if(numbers == null) { return 0; }
            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers == null) { return false; }
            foreach(var num in numbers)
            {
                sum += num;
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int counter = 0;
            if(number < 0) { return 0; }
            for(int i = 0; i < number; i++)
            {
                if(i % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
