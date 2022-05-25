using System;
using System.Linq;

namespace Happy_Numbers
{
    class Program
    {
        static double ConversionToDouble(double givenNumber)
        {
            string convertedToString = givenNumber.ToString();
            char[] charArray = new char[convertedToString.Length];
            charArray = convertedToString.ToCharArray();
            double[] convertedBackToDouble = new double[convertedToString.Length];

            for (int i = 0; i < convertedToString.Length; i++)
            {
                convertedBackToDouble[i] = Convert.ToDouble(charArray[i].ToString());
                
            }
            double resultOfConversion = SquareOf(convertedBackToDouble);
            return resultOfConversion;
        }
        static double SquareOf(double[] convertedDouble)
        {

            for (int i = 0; i < convertedDouble.Length; i++)
            {
                convertedDouble[i] = Math.Pow(convertedDouble[i], 2);
            }

            double squareOfDigits = convertedDouble.Sum();           
            return squareOfDigits;
        }
        static bool IsItHappy(double isItHappy)
        {
            double[] endlessLoopProtection = new double[200];
            for (int i = 0; i < endlessLoopProtection.Length; i++)            
            {              
                if (isItHappy == 1)
                {
                    return true;
                }
                else
                {
                    endlessLoopProtection[i] = isItHappy;                    
                    for (int j = 0; j < i; j++)
                    {
                        
                        if (endlessLoopProtection[i]==endlessLoopProtection[j])
                        {
                            Console.WriteLine("warunek");
                            return false;
                            
                        }
                    }
                    
                }
                isItHappy = ConversionToDouble(isItHappy);              

            }
            return false;
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


            if (IsItHappy(number))
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
