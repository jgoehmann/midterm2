using midterm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBSolution;

namespace midterm2
{
    public partial class AccountMenu : Form
    {
        public AccountMenu(int CustomerNumber)
        {
            InitializeComponent();
            AccountCustomerNumberlbl.Text = CustomerNumber.ToString();
        }

        private void CheckCheckingbtn_Click(object sender, EventArgs e)
        {
            Checking CheckingAccount1 = new Checking(int.Parse(AccountCustomerNumberlbl.Text));
            CheckingBalancelbl.Text=CheckingAccount1.GetBalance().ToString();
        }

        private void CheckSavingsbtn_Click(object sender, EventArgs e)
        {
            Savings SavingsAccount1 = new Savings(int.Parse(AccountCustomerNumberlbl.Text));
            SavingsBalancelbl.Text=SavingsAccount1.GetBalance().ToString();
        }

        private void WithdrawCheckingbtn_Click(object sender, EventArgs e)
        {
            Checking CheckingAccount1 = new Checking(int.Parse(AccountCustomerNumberlbl.Text));
            CheckingAccount1.ChangeBalance(int.Parse(Checkingtxb.Text), int.Parse(AccountCustomerNumberlbl.Text));
        }

        private void WithdrawSavingsbtn_Click(object sender, EventArgs e)
        {
            Savings SavingsAccount1 = new Savings(int.Parse(AccountCustomerNumberlbl.Text));
            SavingsAccount1.ChangeBalance(int.Parse(Savingstxb.Text));
        }

        private void TransferCheckingbtn_Click(object sender, EventArgs e)
        {
            Checking CheckingAccount1 = new Checking(int.Parse(AccountCustomerNumberlbl.Text));
            CheckingAccount1.ChangeBalance(int.Parse(Checkingtxb.Text), int.Parse(AccountCustomerNumberlbl.Text));
            Savings SavingsAccount1 = new Savings(int.Parse(AccountCustomerNumberlbl.Text));
            SavingsAccount1.ChangeBalance(-int.Parse(Checkingtxb.Text));
        }

        private void TransferSavingsbtn_Click(object sender, EventArgs e)
        {
            Savings SavingsAccount1 = new Savings(int.Parse(AccountCustomerNumberlbl.Text));
            SavingsAccount1.ChangeBalance(int.Parse(Savingstxb.Text));
            Checking CheckingAccount1 = new Checking(int.Parse(AccountCustomerNumberlbl.Text));
            CheckingAccount1.ChangeBalance(-int.Parse(Savingstxb.Text), int.Parse(AccountCustomerNumberlbl.Text));
        }

        private void AddCheckingbtn_Click(object sender, EventArgs e)
        {
            Checking CheckingAccount1 = new Checking(int.Parse(AccountCustomerNumberlbl.Text));
            CheckingAccount1.ChangeBalance(-int.Parse(Checkingtxb.Text), int.Parse(AccountCustomerNumberlbl.Text));
        }

        private void AddSavingsbtn_Click(object sender, EventArgs e)
        {
            Savings SavingsAccount1 = new Savings(int.Parse(AccountCustomerNumberlbl.Text));
            SavingsAccount1.ChangeBalance(-int.Parse(Savingstxb.Text));
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.Show();
        }
    }
}
