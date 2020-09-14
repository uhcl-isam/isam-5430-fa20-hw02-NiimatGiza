using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out n*n 
        /// integers with the following pattern; for n=3, the app will print out 0, 0, 1,   
        /// 0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            // Write your codes here

            int num;
            

            Console.WriteLine("enter the value of n");
            num = int.Parse(Console.ReadLine());
            int n = num;
            int nums = n * n;
            int k = 0;
            for(int i =0; i <= n; i++)
            {
                int m = 0;

                for(int j =0; j < n; j++)
                {
                    if(n - j <= 1)
                    {
                        m = n - j; 
                    }
                    nums(k++) = m;
                }
                
            }

           


        }
    }
}
