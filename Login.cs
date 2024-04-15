using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Connection String
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Programming\\programming 2\\Homework\\midterm\\midterm2\\ATM_data.mdf\";Integrated Security=True;Connect Timeout=30";
        //btn_Submit Click event
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (CustomerNumbertxb.Text == "" || Pintxb.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                int CustomerNumber = int.Parse(CustomerNumbertxb.Text);
                int Pin = int.Parse(Pintxb.Text);
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from BankCustomer where CustomerNumber="+CustomerNumber+" and Pin="+Pin+"", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    AccountMenu fm = new AccountMenu(int.Parse(CustomerNumbertxb.Text));
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
