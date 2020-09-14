using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between 
        /// start
        /// and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            int num1 = 0;
            int num2 = 0;
            int odd = 0;
            Console.Error.WriteLine("Enter the starting number");
            num1 = int.Parse(Console.ReadLine());
            // Codes to enter start
            Console.Error.WriteLine("Enter the ending number");
            num2 = int.Parse(Console.ReadLine());
            // Codes to enter end.

            for (int i = num1; i < num2; i++)
            {
                if (i % 2 != 0)
                {
                    odd++;
                }
                
            }
            

        }
    }
}
