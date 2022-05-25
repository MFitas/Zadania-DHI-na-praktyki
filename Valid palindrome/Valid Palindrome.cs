using System;

namespace Valid_palindrome
{
    class Program
    {
        static bool IsItAPalindrome(string palindrome)
        {
            palindrome = palindrome.ToLower();
            char[] removedSigns = palindrome.ToCharArray();
            removedSigns = Array.FindAll<char>(removedSigns, (c => char.IsLetterOrDigit(c)));

            palindrome = new string(removedSigns);
            Array.Reverse(removedSigns);
            string reversedPalindrome = new string(removedSigns);

            bool isEqual = String.Equals(reversedPalindrome, palindrome);
            if (isEqual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string, I will check if it is a palindrome");

            string query = Console.ReadLine();

            if (IsItAPalindrome(query))
            {
                Console.WriteLine("It really is a palindrome");
            }
            else
            {
                Console.WriteLine("It's not a palindrome");
            }
        }
}
