using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankApp_NicoloRossi.BankAppDataSet;
using System.Data.SqlClient;

namespace BankApp_NicoloRossi
{
    // this class will act as DAO and access all the data of the DB using query etc.

    internal class CustomersLoginsDAO
    {

        public bool createNewCustomer(int accountNum, string password, out string message)
        {
            // I will use these Table adapter that will act itself as a DAL and DataSet and run the queries

            BankAppDataSetTableAdapters.CustomersTableAdapter customersTableAdapter =
            new BankAppDataSetTableAdapters.CustomersTableAdapter();

            BankAppDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter =
            new BankAppDataSetTableAdapters.LoginsTableAdapter();
            // this try and catch block will mostly handle SQL queries errors since there are no loops
            // or anything else that could throw errors in the block
            // I will catch SQLException but also 'normal' exceptions just in case
            try
            {
                // the method GetDataByAccountNum(int ID) was generated before in the dataset
                // using the configuration wizard and it returns a datatable
                CustomersDataTable table = customersTableAdapter.GetDataByAccountNum(accountNum);
                int customerReturned = table.Count();



                bool wasInserted = false;
                message = "";

                // verifying that the number of rows returned is equal to 1 

                if (customerReturned == 1)
                {
 
                        LoginsDataTable table2 = loginsTableAdapter.GetDataBy(accountNum);
                        int loginReturned = table2.Count();

                        if (loginReturned == 0)
                        {
                            // this nested Try Catch block is to verify if there was an error inserting the
                            // new login. This will help identify specific errors
                            try
                            {
                                int rowAffected = loginsTableAdapter.InsertLogin(accountNum, password);
                                if (rowAffected == 1)
                                {
                                    wasInserted = true;
                                    message = $"Account created successfully!\n\nYou can now login to see your balance!";

                                }
                            }
                            catch (SqlException ex2)
                            {
                                message = "Error inserting data in the Logins database, please contact support.\n\n" +
                                         $"Error: {ex2}";
                                return false;
                            }

                        }
                        else
                        {
                            message = "Online account already exists. \n\n" +
                                "If you forgot the password, please contact the bank to recover access.";
                        }
                    } 

                // now must verify that the user doesn't have an account already

                // this checks if there are more account with same number (just in case)
                else if (customerReturned > 1)
                {
                    message = "More than one retult returned.\n\n Please contact our Customer Service for more assistance";
                }

                // this checks if user has an account in the bank
                else if (customerReturned == 0)
                {
                    message = $"No customer found with the account id {accountNum}. \n\n" +
                        $"You need a bank account in order to access the online service.\n\n" +
                        $"Please verify your data and try again.\n\n" +
                        $"Remember: Account number are 8 digits and the first number is not a zero. " +
                        $"If you forgot it please contact our support.";
                }

                return wasInserted;
            }
            catch (SqlException Sqlex)
            {
                message = "Error retrieving or inserting data in the database, please verify the values inserted or contact support.\n\n" +
                    $"Error: {Sqlex}";
                return false;
            }
            catch (Exception ex)
            {
                message = "There was an error running the program. Please contact the support.\n\n" +
                    $"Error: {ex}";
                return false;
            }

        }

        // this method will return a list of Customers object (there will be only 1 or 0 element inside)
        // this will help with validation later
        public List<Customer> Login(int AccNum, String Password, out String Message)
        {
            // I will use these Table adapter that will act itself as a DAL and DataSet and run the queries

            BankAppDataSetTableAdapters.CustomersTableAdapter customersTableAdapter =
            new BankAppDataSetTableAdapters.CustomersTableAdapter();

            BankAppDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter =
            new BankAppDataSetTableAdapters.LoginsTableAdapter();

            Message = "";
           List<Customer> listResult = new List<Customer>();

            // try block for SQL query
            try
            {
                // getting Datatable with login corresponding with password and accountN passed to
                // the Logins table query
                LoginsDataTable tableLogin = loginsTableAdapter.GetDataBy2(AccNum, Password);
                int resultsNumber = tableLogin.Rows.Count;

                // if the result is 1 row than we got the right account
                if (resultsNumber == 1)
                {
                        // new query but this time on the Customer table
                    CustomersDataTable tableCustomers = customersTableAdapter.GetDataByAccountNum(AccNum);
                    // using data received to create a Customer object   
                    Customer customerDetails = new Customer()
                        {
                            name = tableCustomers[0].Name,
                            accountNum = tableCustomers[0].AccountNum,
                            address = tableCustomers[0].Address,
                            telephone = tableCustomers[0].Phone,
                            balance = tableCustomers[0].Balance,
                        };
                    // adding it to the list that will be returned
                        listResult.Add(customerDetails);
        
                } 

                // if no row than the data were incorrect
                else if (resultsNumber == 0)
                {
                    Message = "No account was found with login and password inserted.\n\n " +
                        "Please try again or Sign in. " +
                        "\n\nIf you forgot the password please contact the bank.";
                }
                // if more than one row than there is some serious issue
                else if (resultsNumber > 1)
                {
                    Message = "Multiple accounts found. Please contact the bank as soon as possible.";
                }
            }

            // catching SQL exception
            catch(SqlException ex)
            {
                Message = "Error accessing the Database. Please verify data inserted.\n\n" +
                    $"Error= {ex}";

            }
            // catching 'normal' exception

            catch (Exception e)
            {
                Message = "The program returned error. Please try again or contact support.\n\n" +
                    $"Error = {e}";

            }

            return listResult;
        }

    }
}
