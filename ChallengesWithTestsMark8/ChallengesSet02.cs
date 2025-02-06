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
           return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
           return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentException("The collection cannot be null or empty.");

            double min = double.MaxValue;
            double max = double.MinValue;
            
            foreach (var number in numbers)
            {
                if (number < min) min = number;
                if (number > max) max = number;
            }

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) return 0;

            long count = 0;
            for (long i = 1; i < number; i+= 2)
            {
                if (i > 0) count++;
            }
            return count;
        }
    }
}
