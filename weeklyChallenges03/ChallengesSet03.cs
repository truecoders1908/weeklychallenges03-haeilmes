using System;
using System.Collections.Generic;
using System.Linq;



namespace weeklyChallenges03
{

    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return char.Parse(val.Substring(0, 1));
        }

        public char GetLastLetterOfString(string val)
        {
            return char.Parse(val.Substring(val.Length - 1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
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
                words[i] = words[i].ToUpper();
            }

        }

    }
}
