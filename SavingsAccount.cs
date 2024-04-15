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
        public Savings(int CustomerNumber)
        {
            this.AccountNumber = SQLHelper.GetAccountSavings("SavingsAccount", CustomerNumber);
            this.AccountBalance = SQLHelper.GetBalance("SavingsAccount", this.AccountNumber,"SavingsAccountNumber");
        }
        public int GetAccountNumber()
        {
            return AccountNumber;
        }
        public int GetBalance()
        {
            return AccountBalance;
        }
        public void ChangeBalance(int value)
        {
            this.AccountBalance = AccountBalance - value;
            SQLHelper.updateDB("SavingsAccount", this.AccountNumber, this.AccountBalance,"SavingsAccountNumber");
        }
    }
}