using System;
using Xunit;

namespace Palindrome.Tests
{
    public class PalindromeTesting
    {
        [Theory]
        [InlineData("stats", true)]
        public void check_if_string_is_a_palindrome(string input, bool expectedResult)
        {
            var pal = new CheckPalindrome();

            var actualResult = pal.IsAPalindrome(input);

            Assert.Equal(expectedResult, actualResult);

        }
    }
}
