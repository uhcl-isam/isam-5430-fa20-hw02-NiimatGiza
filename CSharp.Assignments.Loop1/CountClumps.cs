using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            bool match = false;
            int count = 0;
            int num;
            Console.Error.WriteLine("Please enter any set of numbers");
            num = int.Parse(Console.ReadLine());
           
            int j = num;

            for (int i =0; i < num.length-1; i++)
            {
                if (num[i] == num[i + 1] && !match)
                {
                    match = true;
                    count++;
                }
                else if (num[i] != num[i + 1])
                {
                    match = false;
                }
            }
            return count;
        }
       
       
    }
}
