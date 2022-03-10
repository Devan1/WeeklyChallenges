using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int boolCounter = 0;
            foreach(bool val in vals)
            {
                if(val == false)
                {
                    boolCounter++;
                }
            }
            if(boolCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }
            var sum = numbers.Sum();
            if(sum % 2 != 0)
            {
                return true;
            }
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            //must be a way to refactor this to be shorter?????
            int upper = 0;
            int lower = 0;
            int number = 0;
            foreach (var chr in password)
            {
                if (Char.IsUpper(chr))
                {
                    upper++;
                }
                if (Char.IsLower(chr))
                {
                    lower++;
                }
                if (Char.IsNumber(chr))
                {
                    number++;
                }
            }
            if (upper > 0 && lower > 0 && number > 0) { return true; } else return false;
            //{
            //    return true;
            //}
            //else return false;
            //{
            //   return false;
            //}
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //int strLength = val.Length - 1;
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if(divisor == 0 || dividend == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
         
        }

        public int LastMinusFirst(int[] nums)
        {
            //int lastNumLoc = nums.Length - 1;
            int lastNum = nums[nums.Length - 1];
            int firstNum = nums[0];
            return lastNum - firstNum;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 >= 1)
                {
                    odds.Add(i);
                }
            }  
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var word in words)
                {
                    words[i++] = word.ToUpper();
                }
            }
        }
    }
}
