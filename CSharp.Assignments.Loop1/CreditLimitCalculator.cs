using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            // Enter your sentinel loop here
            int account, beginning_balnce, charges, credits, credit_limit; 
            Console.Error.WriteLine("Please enter your account number");
            account = int.Parse(Console.ReadLine());

            Console.Error.WriteLine("Please enter balance at the beginning of the month");
             beginning_balnce = int.Parse(Console.ReadLine());

            Console.Error.WriteLine("total of all items charged by the customer this month");
            charges = int.Parse(Console.ReadLine());

            Console.Error.WriteLine("total of all credits applied to the customer’s account this month and");
            credits = int.Parse(Console.ReadLine());

            Console.Error.WriteLine("allowed credit limit");
            credit_limit = int.Parse(Console.ReadLine());

            int new_balance = beginning_balnce + charges - credits;

            if (account < 0)
            {
                Console.WriteLine("account number invilde");
            }

            else
            {
                if (new_balance < credit_limit)
                {
                    Console.WriteLine("Credit Limit not exceeded");
                }
                else if (new_balance > credit_limit)
                {
                    Console.WriteLine("Credit Limit exceeded");
                }

                else
                {
                    Console.WriteLine("At Credit Limit");
                }


            }
        }
    }
}
