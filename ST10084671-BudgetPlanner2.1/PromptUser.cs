using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Class created to print the outputs and store the data thats required
    class PromptUser
    {
        // Declaring Global variables
        public static double GrossMonthlyIncome = 0;
        public static double MonthlyTaxDeducted = 0;
        public static double AccommodationCost = 0;
        public static double MonthlyTotalExpense = 0;
        public static double AvailableMonthlyMoney = 0;
        public static double VehiclePayments = 0;
        public static string ModelAndMake;
        public static double VehiclePurchasePrice = 0;
        public static double VehicleDeposit = 0;
        public static double VehicleInterestRate = 0;
        public static double InsurancePremium = 0;

        // Generic collection list to store the Expenses values
        private static List<double> Expenses = new List<double>();

        // Method for the user to enter values for basic data
        public static void BasicInput()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nIncome and Tax: \n");
            // Thread put in place to create a pause
            Thread.Sleep(1000);

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Prompting the user to enter a value for their gross income
            Console.Write("Enter the gross monthly income (before deductions): \t\t\t\t ");
            GrossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for their tax 
            Console.Write("Enter the estimated monthly tax deducted: \t\t\t\t\t ");
            MonthlyTaxDeducted = Convert.ToDouble(Console.ReadLine());

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
        }

        // Method for the user to enter values for their basic expenses
        public static void InputBasicExpenses()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Expenses: ");
            // Thread put in place to create a pause
            Thread.Sleep(1000);

            Console.WriteLine("Enter the estimated monthly expenditures in each of the following categories: \n");
            // Thread put in place to create a pause
            Thread.Sleep(3000);

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Prompting the user to enter a value for groceries
            Console.Write("1.Groceries: \t\t\t\t\t\t\t\t\t ");
            // Adds the value that was inputted to the list
            Expenses.Add(Convert.ToDouble(Console.ReadLine()));

            // Prompting the user to enter a value for water and lights
            Console.Write("2.Water and lights: \t\t\t\t\t\t\t\t ");
            // Adds the value that was inputted to the list
            Expenses.Add(Convert.ToDouble(Console.ReadLine()));

            // Prompting the user to enter a value for travel costs
            Console.Write("3.Travel costs (including petrol): \t\t\t\t\t\t ");
            // Adds the value that was inputted to the list
            Expenses.Add(Convert.ToDouble(Console.ReadLine()));

            // Prompting the user to enter a value for cell phone and telephone
            Console.Write("4.Cell phone and telephone: \t\t\t\t\t\t\t ");
            // Adds the value that was inputted to the list
            Expenses.Add(Convert.ToDouble(Console.ReadLine()));

            // Prompting the user to enter a value for other expenses
            Console.Write("5.Other expenses: \t\t\t\t\t\t\t\t ");
            // Adds the value that was inputted to the list
            Expenses.Add(Convert.ToDouble(Console.ReadLine()));

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
        }

        // Method for the user to enter values for their accommodation
        public static void Accommodation()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Accommodation:");
            // Thread put in place to create a pause
            Thread.Sleep(1000);

            // Changing the font colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            // The user either enters 1 for renting an accommodation or 2 for buying a property
            Console.WriteLine("Select 1 for renting an accommodation or select 2 for buying a property: ");
            int UserChoice = Convert.ToInt32(Console.ReadLine());

            // If statement, the user needs to enter either 1 or 2 in order to move on in the program
            // If the user input 1, the following will occur
            if (UserChoice == 1)
            {
                // The data from the RentAccommodation method will output
                RentAccommodation();
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            }
            // If the user input 2, the following will occur
            else if (UserChoice == 2)
            {
                // The data from the BuyProperty method will output
                BuyProperty();
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            }
            else
            {
                // The Accommodation method will repeat itself until the user enthers an appropiate value
                Accommodation();
            };
        }

        // Method to store the values for the rent accommodation
        public static void RentAccommodation()
        {
            // An object is created of the Rent class
            Rent RentObj = new Rent();

            // Sets the expenses
            RentObj.SetExpenses(Expenses);

            // Stores the total expense
            MonthlyTotalExpense = RentObj.OutputTotalExpense();

            // Stores the monthly repayments
            AccommodationCost = RentObj.MonthlyRepayments();
        }

        // Method to store the values for the buy accommodation
        public static void BuyProperty()
        {
            // An object is created of the HomeLoan class
            HomeLoan HomeLoanObj = new HomeLoan();

            // Sets the expenses
            HomeLoanObj.SetExpenses(Expenses);

            // Stores the total expense
            MonthlyTotalExpense = HomeLoanObj.OutputTotalExpense();

            // Stores the monthly repayments
            AccommodationCost = HomeLoanObj.MonthlyRepayments();

            // The alaert message to see if the home loan is unlikely to be approved 
            HomeLoanObj.Approval(GrossMonthlyIncome);
        }

        // Method for the user to select whether they want to purchase a car or not
        public static void BuyVehicle()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vehicle: ");
            // Thread put in place to create a pause
            Thread.Sleep(1000);

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            // The user either enters 1 for buying a vehice or 2 if they are not
            Console.WriteLine("Select 1 if you want to buy a vehicle or select 2 if you do not want to buy a vehicle: ");
            int UserChoice = Convert.ToInt32(Console.ReadLine());

            // If statement, the user needs to enter either 1 or 2 in order to move on in the program
            // If the user input 1, the following will occur
            if (UserChoice == 1)
            {
                // The data from the InputVehicleDetails method will output
                InputVehicleDetails();

                // An object is created of the Vehicle class
                Vehicle PurchaseVehicle = new Vehicle(ModelAndMake, VehiclePurchasePrice, VehicleDeposit, VehicleInterestRate, InsurancePremium);

                // Stores the monthly installations
                VehiclePayments = PurchaseVehicle.CalculateMonthlyInstallment();
            }
            // If the user input 2, the following will occur
            else if (UserChoice == 2)
            {
                // The vehicle payments will equal to zero
                VehiclePayments = 0;
            }
            else
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                // The BuyVehicle method will repeat itself until the user enthers an appropiate value
                BuyVehicle();
            }
        }

        // Method for the user to enter values for the vehicle
        public static void InputVehicleDetails()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Prompting the user to enter a value for vehicle model and make
            Console.Write("\nEnter the vehicle model and make: \t\t\t\t\t\t ");
            ModelAndMake = Console.ReadLine();

            // Prompting the user to enter a value for vehicle price
            Console.Write("Enter the purchase price of the vehicle: \t\t\t\t\t ");
            VehiclePurchasePrice = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for deposite amount
            Console.Write("Enter the total deposit amount: \t\t\t\t\t\t ");
            VehicleDeposit = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for interest rate
            Console.Write("Enter the interest rate(format: 15.5 % = 15,5): \t\t\t\t ");
            VehicleInterestRate = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter a value for insurance premium amount
            Console.Write("Enter the estimated insurance premium amount: \t\t\t\t\t ");
            InsurancePremium = Convert.ToDouble(Console.ReadLine());

        }

        // Method to notify the user when their expenses exceed 75% of their income
        public void NotifTheUser()
        {
            // Declaring variable
            double TotalOwed = 0;

            // Claculating the sum of all the expenses
            TotalOwed = PromptUser.AccommodationCost + PromptUser.MonthlyTotalExpense + PromptUser.VehiclePayments + PromptUser.MonthlyTaxDeducted;

            // If the sum is >= 75% of the users income, the following alert message will be outputed
            if (TotalOwed >= (PromptUser.GrossMonthlyIncome * 0.75))
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
                // Changing the background colour
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nALERT: YOUR TOTAL EXPENSES INCLUDING YOUR LOAN REPAYMENTS EXCEEDS 75% OF YOUR INCOME");
                // Changing the background colour
                Console.BackgroundColor = ConsoleColor.Black;
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // Method to display the total costs for the accommodation and vehicle
        public static void DisplayExpenses()
        {
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");
            // Thread put in place to create a pause
            Thread.Sleep(500);
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Expenses listed:");

            int count = 1;

            // A foreach to output all of the expenses in descending order
            foreach (double e in Expenses.OrderByDescending(e => e))
            {
                Console.WriteLine(count + ": R" + e.ToString("F"));
                count++;
            }
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");
            for (int i = 0; i <= 100; i++)
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                // Outputs a calculatng sign
                Console.Write($"\rCalculating: {i}%   ");
                // Thread put in place to create a pause
                Thread.Sleep(25);
            }
            Console.Write("\r                 ");

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Outputs the accommodation cost
            Console.WriteLine("\n\nAccommodation cost: \t\t\t\t\t\t\t\t R " + AccommodationCost.ToString("F"));

            // If the vehicle payments does not equal to 0 then the following will be outputted
            if (VehiclePayments != 0)
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                // Outputs the vehicle cost
                Console.WriteLine("Vehicle cost: \t\t\t\t\t\t\t\t\t R " + VehiclePayments.ToString("F"));
            }
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n");
        }

        // Method to output the available money after all the deductions have been made
        public static void AvailableMoney()
        {
            for (int i = 0; i <= 100; i++)
            {
                // Changing the text colour
                Console.ForegroundColor = ConsoleColor.White;
                // Outputs a loading sign
                Console.Write($"\rCalculating: {i}%   ");
                // Thread put in place to create a pause
                Thread.Sleep(25);
            }
            Console.Write("\r                 ");

            Thread.Sleep(500);
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\nTotal Amount Avialable:");

            // The calculation for the money that is available after all deductions have been made
            AvailableMonthlyMoney = GrossMonthlyIncome - MonthlyTaxDeducted - MonthlyTotalExpense - AccommodationCost - VehiclePayments;

            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Outputs the total amount of money that the user will have after all deductions have been made
            Console.WriteLine("After all deductions you will have: \t\t\t\t\t\t R " + AvailableMonthlyMoney.ToString("F"));
            // Changing the text colour
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");

            // Expenses.Clear() is put into place to clear all the data from the old calculations so that it does not interfere with a new calculation if the user decided to continue
            Expenses.Clear();
        }
    }
}
