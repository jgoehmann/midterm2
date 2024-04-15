
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
        //update function
        public static void updateDB(string Account, int AccountNumber, int NewBalance, string AccountType)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;
            sql = "Update " + Account + " set Balance=" + NewBalance + " Where "+AccountType+" = " + AccountNumber + "";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

        }
        public static int GetBalance(string Account, int AccountNumber, string AccountType)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From " + Account + " Where "+AccountType+"=" + AccountNumber + "";
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int AccountBalance;
            string AccountBalanceString = string.Empty;
            while (dataReader.Read())
            {
                AccountBalanceString = dataReader.GetValue(1).ToString();
            }
            AccountBalance = int.Parse(AccountBalanceString);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            return AccountBalance;
        }
        //Select from database function 
        public static int GetAccountChecking(string Account, int CustomerNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From BankCustomer Where CustomerNumber=" + CustomerNumber + "";
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
        public static int GetAccountSavings(string Account, int CustomerNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\programming 2\Homework\midterm\midterm2\ATM_data.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            string sql = String.Empty;
            sql = "Select* From BankCustomer Where CustomerNumber=" + CustomerNumber + "";
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