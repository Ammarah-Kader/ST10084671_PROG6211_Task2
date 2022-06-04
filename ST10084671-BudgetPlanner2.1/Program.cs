using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Delegate used to notify the user when their expenses exceed 75% of their income
    public delegate void NotifyTheUserDelegate();
    class Program
    {
        // Declaring Global variables fields
        public static double MonthlyTotalExpense = 0;
        public static double AccommodationCost = 0;
        public static double VehiclePayments = 0;
        public static double GrossMonthlyIncome = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                //instantiate the object
                PromptUser pm = new PromptUser();

                // Instantiate the delegate
                NotifyTheUserDelegate notify = new NotifyTheUserDelegate(pm.NotifTheUser);
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        // Changing the text colour
                        Console.ForegroundColor = ConsoleColor.White;
                        // Outputs a loading sign
                        Console.Write($"\rLoading: {i}%   ");
                        // Thread put in place to create a pause
                        Thread.Sleep(25);
                    }
                    Console.Write("\r               ");

                    Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\tBUDGET PLANNING APP");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");

                    // Thread put in place to create a pause
                    Thread.Sleep(1000);
                };
                // The data from the BasicInput method will output
                PromptUser.BasicInput();

                // The data from the InputBasicExpenses method will output
                PromptUser.InputBasicExpenses();

                // The data from the Accommodation method will output
                PromptUser.Accommodation();

                // The data from the BuyVehicle method will output
                PromptUser.BuyVehicle();

                // Checks that the total costs is less than 75% of the income
                notify();

                // The data from the DisplayExpenses method will output
                PromptUser.DisplayExpenses();

                // The data from the AvailableMoney method will output
                PromptUser.AvailableMoney();

                // Declare variiable
                int key = 0;

                Console.WriteLine("\nENTER 1 TO BEGIN A NEW CALCULATION OR ANY OTHER KEY TO EXIT THE PROGRAM: ");
                int.TryParse(Console.ReadLine(), out key);

                // If the user input 1, the following will occur
                if (key == 1)
                {
                    // The program will run again from the begining
                    continue;
                }
                else
                {
                    // The program will close
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
