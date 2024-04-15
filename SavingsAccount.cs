using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDBSolution;

namespace midterm
{
    public class Savings : Account
    {
        /// <summary>
        /// Runs the SQLHelper program to construct a class based on the customer number
        /// </summary>
        /// <param name="customerNumber">The account wide customernumber </param>
        public Savings(int customerNumber)
        {
            this.AccountNumber = SQLHelper.GetAccountSavings(customerNumber);
            this.AccountBalance = SQLHelper.GetBalance("SavingsAccount", this.AccountNumber,"SavingsAccountNumber");
        }
        /// <summary>
        /// Functions for accessing values
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
        /// Changes the AccountBalance for the constructed class and uses the classes new value to update the database
        /// </summary>
        /// <param name="value">value subtracted or added to the account</param>
        public void ChangeBalance(int value)
        {
            this.AccountBalance = AccountBalance - value;
            SQLHelper.UpdateDB("SavingsAccount", this.AccountNumber, this.AccountBalance,"SavingsAccountNumber");
        }
    }
}