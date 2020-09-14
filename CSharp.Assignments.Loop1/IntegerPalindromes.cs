using System;
using System.Diagnostics.Tracing;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs

            int counter, num, k, rev = 0;
            bool ic = true;
            do
            {
                counter = 0;
                Console.Error.WriteLine("Please enter 9 digits");
                num = int.Parse(Console.ReadLine());
                int j = num;

                for (; j >= 1 || counter < j; j /= 10)
                    counter = counter + 1;

                if (counter != 9)
                {
                    Console.Error.WriteLine("Enter 9 digits");
                    ic = true;
                }
                else 
                {
                    ic = false;
                    k = num;

                    for (; num >= 1; num /= 10)
                        rev = rev * 10 + (num % 10);

                    if (rev == k)
                        Console.WriteLine("a palindrome");
                    else
                    
                        Console.WriteLine("not a palindrome");
                    
                }
                
            }
            while (ic);
            // then check the palindrome only once.
            // loop for entering
            //second loop for calculation
        }
    }
}
