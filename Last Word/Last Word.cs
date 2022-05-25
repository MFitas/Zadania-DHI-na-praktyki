using System;

namespace Last_Word
{
    class Program
    {
        static int LastWord(string arg)
        {
            int lastWorld = 0;
            int doubleSpaceProtection = 0;
            char[] charTable = arg.ToCharArray();
            for (int i = 0; i < charTable.Length; i++)
            {

                if (charTable[i] == ' ')
                {
                    if (lastWorld != 0)
                    {
                        doubleSpaceProtection = lastWorld;
                        lastWorld = 0;
                    }
                }
                else lastWorld++;
            }
            if (lastWorld != 0)
            {
                return lastWorld;
            }
            else return doubleSpaceProtection;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence here, and I will count letters in the last word");
            string sentence = Console.ReadLine();
            int lastWordLength = LastWord(sentence);
            Console.WriteLine("Last word length is equal to: " + lastWordLength);
        }
    }
}
