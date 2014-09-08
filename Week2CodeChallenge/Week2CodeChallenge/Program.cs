using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling fizzbuzz for all numbers between 0 and 20
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }

            //call LetterCounter
            LetterCounter('i', "I love biscuts and gravy. It's the best breakfast ever.");
           
            //ReadKey to keep the console open
            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            //see if number is divisalbe by both 5 and 3 first so that it doesn't just print fizz
            if (number % 5 ==0 && number%3==0)
            {
                //if true print FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
                //see if number is divisable by 5
            else if (number % 5==0)
            {
                //if true print Fizz
                Console.WriteLine("Fizz");
            }
                //see if number is divisable by 3
            else if (number % 3 == 0)
            {
                //if true print Buzz
                Console.WriteLine("Buzz");
            }
                //if number is not divisable by 5 or 3
            else
            {
                //print the number
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {
            int numLetter = 0;
            int upLetter = 0;
           
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString.ToLower().Contains(letter))
                {
                    numLetter++;
                }
                
            }
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter);
            Console.WriteLine("Total number of " + numLetter);
        }

    }
}
