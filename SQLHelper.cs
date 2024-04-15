
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace TestDBSolution
{
    public static class SQLHelper
    {
        /// <summary>
        /// update function
        /// </summary>
        /// <param name="account">savings or checking account</param>
        /// <param name="accountNumber">account number</param>
        /// <param name="newBalance">new desired balance value</param>
        /// <param name="accountType"> savings or checking accountNumber</param>
        public static void UpdateDB(string account, int accountNumber, int newBalance, string accountType)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;
            sql = "Update " + account + " set Balance=" + newBalance + " Where "+accountType+" = " + accountNumber + "";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

        }
        /// <summary>
        /// Finds the balance of a desired account in the database
        /// </summary>
        /// <param name="account">checking or savings account</param>
        /// <param name="accountNumber">account number</param>
        /// <param name="accountType">checking or savings number</param>
        /// <returns></returns>
        public static int GetBalance(string account, int accountNumber, string accountType)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From " + account + " Where "+accountType+"=" + accountNumber + "";
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int accountBalance;
            string accountBalanceString = string.Empty;
            while (dataReader.Read())
            {
                accountBalanceString = dataReader.GetValue(1).ToString();
            }
            accountBalance = int.Parse(accountBalanceString);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            return accountBalance;
        }
        /// <summary>
        /// Finds the checking account number given a customernumber
        /// </summary>
        /// <param name="customerNumber">the customer account number</param>
        /// <returns> customer CheckingAccountNumber </returns>
        public static int GetAccountChecking(int customerNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From BankCustomer Where CustomerNumber=" + customerNumber + "";
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int AccountNumber;
            string AccountNumberString = string.Empty;
            while (dataReader.Read())
            {
                AccountNumberString = dataReader.GetValue(2).ToString();
            }
            Console.WriteLine(AccountNumberString);
            AccountNumber = int.Parse(AccountNumberString);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            return AccountNumber;
        }
        /// <summary>
        /// Finds the savings account number given a customer number 
        /// </summary>
        /// <param name="customerNumber">the customer account number</param>
        /// <returns>customer SavingsAccountNumber</returns>
        public static int GetAccountSavings(int customerNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From BankCustomer Where CustomerNumber=" + customerNumber + "";
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int AccountNumber;
            string AccountNumberString = string.Empty;
            while (dataReader.Read())
            {
                AccountNumberString = dataReader.GetValue(3).ToString();
            }
            Console.WriteLine(AccountNumberString);
            AccountNumber = int.Parse(AccountNumberString);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            return AccountNumber;
        }
    }
}