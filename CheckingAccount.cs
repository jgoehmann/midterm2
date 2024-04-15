using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBSolution;

namespace midterm
{
    public class Checking : Account
    {
        /// <summary>
        /// Constructs the class by running a given customerNumber through SQLHelper
        /// </summary>
        /// <param name="customerNumber">customer account number</param>
        public Checking(int customerNumber)
        {
            this.AccountNumber = SQLHelper.GetAccountChecking(customerNumber);
            this.AccountBalance = SQLHelper.GetBalance("CheckingAccount", this.AccountNumber,"CheckingAccountNumber");
        }
        /// <summary>
        /// functions for returning desired values
        /// </summary>
        /// <returns>desired value</returns>
        public int GetAccountNumber()
        {
            return AccountNumber;
        }
        public int GetBalance()
        {
            return AccountBalance;
        }
        /// <summary>
        /// Changes AccounBalance by value and if that value would cause AccountBalance to go below zero, it subtracts the value
        /// that remains in AccountBalance and takes the rest from the customer's savings account
        /// </summary>
        /// <param name="value">desired balance change</param>
        /// <param name="customerNumber">customer account number (needed to check savings account)</param>
        public void ChangeBalance(int value, int customerNumber)
        {
            if ((this.AccountBalance - value) > 0){
                this.AccountBalance= this.AccountBalance - value;
                SQLHelper.UpdateDB("CheckingAccount", this.AccountNumber, this.AccountBalance,"CheckingAccountNumber");
            }
            else
            {
                MessageBox.Show("Amount Exceeds what is left in checking. Taking the excess amount from savings");
                int newvalue = value - this.AccountBalance;
                this.AccountBalance = 0;
                SQLHelper.UpdateDB("CheckingAccount", this.AccountNumber, this.AccountBalance, "CheckingAccountNumber");
                Savings SavingsAccount1 = new Savings(customerNumber);
                SavingsAccount1.ChangeBalance(newvalue);
            }
        }
    }
}