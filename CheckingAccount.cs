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
        public Checking(int CustomerNumber)
        {
            this.AccountNumber = SQLHelper.GetAccountChecking("CheckingAccountNumber", CustomerNumber);
            this.AccountBalance = SQLHelper.GetBalance("CheckingAccount", this.AccountNumber,"CheckingAccountNumber");
        }
        public int GetAccountNumber()
        {
            return AccountNumber;
        }
        public int GetBalance()
        {
            return AccountBalance;
        }
        public void ChangeBalance(int value, int CustomerNumber)
        {
            if ((this.AccountBalance - value) > 0){
                this.AccountBalance= this.AccountBalance - value;
                SQLHelper.updateDB("CheckingAccount", this.AccountNumber, this.AccountBalance,"CheckingAccountNumber");
            }
            else
            {
                MessageBox.Show("Amount Exceeds what is left in checking. Taking the excess amount from savings");
                int newvalue = value - this.AccountBalance;
                this.AccountBalance = 0;
                SQLHelper.updateDB("CheckingAccount", this.AccountNumber, this.AccountBalance, "CheckingAccountNumber");
                Savings SavingsAccount1 = new Savings(CustomerNumber);
                SavingsAccount1.ChangeBalance(newvalue);
            }
        }
    }
}