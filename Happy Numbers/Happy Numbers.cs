using System;
using System.Linq;

namespace Happy_Numbers
{
    class Program
    {
        static double Conversion(double number)
        {
            string temp = number.ToString();
            char[] temp2 = new char[temp.Length];
            temp2 = temp.ToCharArray();
            double[] intarray = new double[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                intarray[i] = Convert.ToDouble(temp2[i].ToString());
                Console.WriteLine("int" + intarray[i]);
                Console.WriteLine("char" + temp2[i]);
            }
            return Powers(intarray);
        }
        static double Powers(double[] number)
        {

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Math.Pow(number[i], 2);
            }
            double sum = number.Sum();
            return sum;
        }
        static bool isItHappy(double sum)
        {
            double[] memory = new double[20];
            int m = 0;
            if (sum == 1)
            {
                return true;
            }
            else
            {
                memory[m] = sum;
                m++;
                for (int i = 0; i < memory.Length; i++)
                {
                    if (sum == memory[i])
                    {
                        return false;
                    }

                }
                Conversion(sum);
            }

        }
        static void Main(string[] args)
        {
            double number;
            do
            {
                Console.WriteLine("Enter your number, I'll check if it is a happy number");
                if (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid value entered \nClick any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    break;
                }

            } while (true);


            if (isItHappy(number))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(number + " that you have entered is in fact a happy number!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(number + " is not a happy number.");
            }
        }
    }
}
