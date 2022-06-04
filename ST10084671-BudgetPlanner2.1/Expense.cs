using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Abstract class Expense to store the expense data
    abstract class Expense
    {
        // Expense List 
        private List<double> Expenses = new List<double>();

        // Delcaring variables
        public double TotalExpenses = 0;

        // Method created to populate all of the different expenses that are in the array
        public void SetExpenses(List<double> InputExpenses)
        {
            // Setting the list = list
            Expenses = InputExpenses;
        }

        // Method created to add up all the expenses
        public double OutputTotalExpense()
        {
            // Gets the total from the expense list and adds them
            TotalExpenses = Expenses.Sum();

            // Return the TotalExpenses
            return TotalExpenses;
        }
        // Abstract method that is overriden with either the HomeLoan or the Rent
        public abstract double MonthlyRepayments();
    }
}
