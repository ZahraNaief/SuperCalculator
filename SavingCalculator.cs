using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SavingCalculator
    {
        private double initialDeposit = 0;
        private double monthlyDeposit = 0;
        private double periodInYears = 0;
        private double interestRate = 0;
        private double feesRate = 0;
        private double totalAmountPaid = 0;
        private double totalFees = 0;
        private double finalBalance = 0;
        private double amountEarned = 0;

        //getters and setters
        #region
        public double GetInitialDeposit() {           
            return initialDeposit;
        }
        public void SetIntialDeposit(double initialDeposit) { 
            this.initialDeposit = initialDeposit;      
        }
        public double GetMonthlyDeposit() {  
            return monthlyDeposit; 
        }
        public void SetMonthlyDeposit(double monthlyDeposit) { 
            this.monthlyDeposit = monthlyDeposit;       
        }      
        public double GetPeriodInYears()
        {
            return periodInYears;
        }

        public void SetPeriodInYears(double periodInYears)
        {
            this.periodInYears = periodInYears;
        }
        public double GetinterestRate()
        {
            return interestRate;
        }
        public void SetInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }
        public double GetFeesInPercentAge()
        {
            return feesRate;
        }
        public void SetFeesInPercentage(double feesRate) { 
            this.feesRate = feesRate;
             
        }
        public double GetTotalFees()
        {
            return totalFees;
        }

        public void SetTotalFees(double totalFees)
        {
            this.totalFees = totalFees;
        }

        public double GetFinalBalance()
        {
            return finalBalance;
        }

        public void SetFinalBalance(double finalBalance)
        {
            this.finalBalance = finalBalance;
        }
        public double GetAmountEarned()
        {
            return amountEarned;
        }

        public void SetAmountEarned(double amountEarned)
        {
            this.amountEarned = amountEarned;
        }
        #endregion
        public double CalculateTotalAmountPaid()
        {
            double months = periodInYears * 12;
            double balance = initialDeposit;
            double totalInterest = 0;    
            double monthlyInterest = interestRate / 100.0 / 12;
            double monthlyFees = feesRate / 100.0 / 12;
            
            for (int month = 1; month <= months; month++)
            {
                double interest = monthlyInterest * balance;
                double fees = monthlyFees * balance;
                balance += interest - fees + monthlyDeposit;
                totalInterest += interest;
                totalFees += fees;
            }
            
            totalAmountPaid = Math.Round((initialDeposit+(months * monthlyDeposit)),2);
            SetAmountEarned(Math.Round(totalInterest,2));
            SetFinalBalance(Math.Round(balance,2));
            SetTotalFees(Math.Round(totalFees,2));

            return totalAmountPaid;
        }
    }
}

