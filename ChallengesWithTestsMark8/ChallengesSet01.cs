﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();
            var answ = minuend - subtrahend;
            return answ;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            if(number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            //throw new NotImplementedException();
            var answ = factor1 * factor2;
            return answ;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                var greeting = $"Hello, {nameOfPerson}!";
                return greeting;
            }         
            
        }

        public string GetHey()
        {
            //throw new NotImplementedException();
            return "HEY!";
        }
    }
}
