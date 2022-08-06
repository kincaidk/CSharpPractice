using System;

namespace IsPalindromeFunction
{
    class Program
    {
        /*
            Returns a bool representing whether input is a palindrome.
            Returns an int representing the length of the input, if it is a palindrome. (0 otherwise)
        */
        static (bool,int) IsPalindrome(string input) {
            bool inputIsPalindrome = true;
            int inputLength = input.Length;
            string upperCaseInput = input.ToUpper();

            for (int i = 0; i < inputLength / 2; i++) {
                if (upperCaseInput[i] != upperCaseInput[inputLength-1-i]) {
                    inputIsPalindrome = false;
                    break;
                }
            }

            return (inputIsPalindrome, inputIsPalindrome ? inputLength : 0);
        }

        static void Main(string[] args)
        {
            string[] inputs = {"racecar", " racecar", "", " ", "test", "a.a", "aa", "Aa", "  "};

            foreach (string input in inputs) {
                var result = IsPalindrome(input);
                Console.WriteLine($"Is '{input}' a palindrome? - {result.Item1}. Palindrome length - {result.Item2}");
            }
        }
    }
}
