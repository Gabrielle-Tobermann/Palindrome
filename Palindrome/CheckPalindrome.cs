using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class CheckPalindrome
    {
        public bool IsAPalindrome(string words)
        {
            bool result = false;
            List<string> wordsList = words.Split(" ").ToList();

            var wordsCombined = string.Join("", wordsList).ToLower();

            var reversed = wordsCombined.Reverse();

            var reversedWords = string.Join("", reversed);
            
            if (reversedWords == wordsCombined)
            {
                result = true;
            }
            return result;
        }
    }
}
