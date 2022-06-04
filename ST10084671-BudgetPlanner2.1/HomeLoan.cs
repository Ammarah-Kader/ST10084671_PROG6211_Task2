using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Class to store the home loan data
    // Inheritance
    class HomeLoan : Expense
    {
        // Declaring variables
        public double PropertyPurchasePrice = 0;
        public double PropertyDeposit = 0;
        public double PropertyInterestRate = 0;
        public double MonthsToRepay = 0;
        public double HomeLoanRepayments = 0;

        // Method created to calculate the users monthly repayments
        // Overrides the base method 
        override public double MonthlyRepayments()
        {
            // Declaring variables
            double PrincipalAmount = 0;
            double LoanPeriod = 0;
            double TotalMoneyOwed = 0;

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Prompting the user to enter a value for the purchase price of the property
            Console.Write("\nEnter the purchase price of the property: \t\t\t\t\t ");
            PropertyPurchasePrice = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for the deposite amount
            Console.Write("Enter the total deposit amount: \t\t\t\t\t\t ");
            PropertyDeposit = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for interest rate
            Console.Write("Enter the interest rate (format: 15.5% = 15,5): \t\t\t\t ");
            PropertyInterestRate = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                // If statement, the user needs to enter a value between 240 and 360 
                Console.Write("Enter the number of months to repay (between 240 and 360):\t\t\t ");
                MonthsToRepay = Convert.ToDouble(Console.ReadLine());

                if (MonthsToRepay >= 240 && MonthsToRepay <= 360)
                {
                    break;
                }
            }
            // Calculation using A = P(1 + (i * n))
            // Calculates the amount that is owed
            PrincipalAmount = PropertyPurchasePrice - PropertyDeposit;
            // Changes the percentage from 7,5% to 0,075
            PropertyInterestRate = PropertyInterestRate / 100;
            // Calculates the amount of years to repay 
            LoanPeriod = MonthsToRepay / 12;

            // Calculation
            TotalMoneyOwed = PrincipalAmount * (1 + (PropertyInterestRate * LoanPeriod));

            // Calculation for each monthly repayment 
            HomeLoanRepayments = TotalMoneyOwed / MonthsToRepay;
            HomeLoanRepayments = Math.Round(HomeLoanRepayments, 2);

            // Return the HomeLoanRepayments
            return HomeLoanRepayments;
        }

        // Method to check whether or not the home loan is unlikely to be approved
        public void Approval(double grossMonthlyIncome)
        {
            // If a third of the total is less than the home loan repayments then the following alert message will be outputted
            if ((PromptUser.GrossMonthlyIncome / 3) < HomeLoanRepayments)
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
                // Changing the background colour
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nALERT: APPROVAL OF THE HOME LOAN IS UNLIKELY");
                // Changing the background colour
                Console.BackgroundColor = ConsoleColor.Black;
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
