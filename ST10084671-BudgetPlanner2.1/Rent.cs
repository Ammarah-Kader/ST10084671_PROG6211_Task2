using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Class to store the renting data
    // Inheritance
    class Rent : Expense
    {
        // Declaring variable
        public double MonthlyRentAmount = 0;

        // Method created for the user to input the monthly repayments
        // Overrides the base method
        override public double MonthlyRepayments()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Prompting the user to enter a value for rent
            Console.Write("Enter the monthly rental amount: \t\t\t\t\t\t ");
            MonthlyRentAmount = Convert.ToDouble(Console.ReadLine());

            // Returns the MonthlyRentAmount
            return MonthlyRentAmount;
        }
    }
}
