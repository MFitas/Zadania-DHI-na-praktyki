using System;

namespace RemoveDuplicats
{
    class Program
    {
        static int removeDuplicates(int[] array)
        {
            int j = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] != array[i])
                {
                    array[++j] = array[i];
                }
            }

            return ++j;
        }
        static void Main(string[] args)
        {


        }
    }
}
