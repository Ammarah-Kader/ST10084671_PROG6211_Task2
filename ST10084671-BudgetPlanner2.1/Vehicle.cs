using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084671_BudgetPlanner2._1
{
    // Class to store the vehicle data
    class Vehicle
    {
        // Declaring variables
        public string ModelAndMake;
        public double VehiclePurchasePrice = 0;
        public double VehicleDeposit = 0;
        public double VehicleInterestRate = 0;
        public double InsurancePremium = 0;

        // Constuctor
        public Vehicle(string ModelAndMake, double VehiclePurchasePrice, double VehicleDeposit, double VehicleInterestRate, double InsurancePremium)
        {
            this.ModelAndMake = ModelAndMake;
            this.VehiclePurchasePrice = VehiclePurchasePrice;
            this.VehicleDeposit = VehicleDeposit;
            this.VehicleInterestRate = VehicleInterestRate;
            this.InsurancePremium = InsurancePremium;
        }
        // Method to calculate the monthly installments for the vehicle 
        public double CalculateMonthlyInstallment()
        {
            // Declaring variables
            double VehicleCost = 0;
            double MonthlyInstallment = 0;

            // Calculates the amount that is owed
            double principleAmount = VehiclePurchasePrice - VehicleDeposit;
            // Changes the percentage from 7,5% to 0,075
            VehicleInterestRate = VehicleInterestRate / 100;

            // Calculation using A = P(1 + (i * n))
            VehicleCost = principleAmount * (1 + (VehicleInterestRate * 5));
            // Calculation for each monthly installment
            MonthlyInstallment = VehicleCost / 60;
            // Adds the insurance premium amount to the monthly installment
            MonthlyInstallment += InsurancePremium;

            // Returns MonthlyInstallment
            return MonthlyInstallment;
        }
    }
}
