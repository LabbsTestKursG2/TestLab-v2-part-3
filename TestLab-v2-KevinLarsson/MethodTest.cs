using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestLab_v2_KevinLarsson
{
    public class MethodTest
    {
        public int StrCount(string value)
        {
            return value.Length;
        }
        public string StrType(string value)
        {
            string type = "";   
            var isWord = Regex.IsMatch(value, @"^[a-zA-Z]+$");
            var isNumber = Regex.IsMatch(value, @"^\d+$");

            if (isWord != false)
            {
                type = "word";
            }
            else if (isNumber != false)
            {
                type = "number";   
            }
            else
            {
                type = "none";
            }

            return type;
        }
        public int NextPalindrome(int value)
        {
            var valuedigits = Math.Ceiling(Math.Log10(value));
            int palindromeNumber = value;
            if (valuedigits == 3)
            {
                string firstHalf = value.ToString().Substring(0, (value.ToString().Length + 1) / 2);
                string incrementedFirstHalf = (int.Parse(firstHalf) + 1).ToString();
                var candidates = new List<string>();
                candidates.Add(firstHalf + new String(firstHalf.Reverse().ToArray()));
                candidates.Add(firstHalf + new String(firstHalf.Reverse().Skip(1).ToArray()));
                candidates.Add(incrementedFirstHalf + new String(incrementedFirstHalf.Reverse().ToArray()));
                candidates.Add(incrementedFirstHalf + new String(incrementedFirstHalf.Reverse().Skip(1).ToArray()));
                candidates.Add("1" + new String('0', value.ToString().Length - 1) + "1");
                palindromeNumber = candidates.Select(s => int.Parse(s))
                            .Where(i => i > value)
                            .OrderBy(i => i)
                            .First();

                var palindromedigits = Math.Ceiling(Math.Log10(palindromeNumber));
                if (palindromedigits > 3 || 3 > palindromedigits)
                {
                    throw new ApplicationException("The requested palindromenumber are More or Less then three digits.");
                }
            }
            else
            {
                throw new ApplicationException("Input digits are More or Less then three digits.");
            }

            return palindromeNumber;
        }
        public int[] NextPrime(int value)
        {
            int[] primeArrayList = new int[3];
            int count = 0;

            while (true)
            {
                bool isPrime = true;
                int squaredNumber = (int)Math.Sqrt(value);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (value % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeArrayList[count] = value;
                    if ((count + 1) == 3)
                    {
                        break;
                    }
                    count += 1;
                }
                value = value + 1;
            }

            return primeArrayList;
        }
    }
}