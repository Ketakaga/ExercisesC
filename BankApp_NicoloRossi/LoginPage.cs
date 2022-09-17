using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp_NicoloRossi
{
    public partial class LoginPage : Form
    {
        CustomersLoginsDAO DAO;
        public LoginPage()
        {
            InitializeComponent();
            // preventing whitespaces in account number or password
            txtbx_AccNum.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            TxtBx_Pass.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            // restricting length of value inserted in login
           // txtbx_AccNum.MaxLength = 8;
            DAO = new CustomersLoginsDAO();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            //check if there is another account page open and in case
            //informs the user that need to log out first
            foreach (Form f in Application.OpenForms)
            {
                if (f is AccountPage)
                {
                    MessageBox.Show("Please logout from your account before accessing another one.", 
                        "Account already open",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            lbl_errorAccount.Text = string.Empty;
            lbl_errorPass.Text = string.Empty;
            int accountNumber;
            string password = TxtBx_Pass.Text;

            // using two separate IFs to show both errors to user
            if (txtbx_AccNum.Text == string.Empty)
            {
                lbl_errorAccount.Text = "Please insert an account number.";
            }
            if (password == string.Empty)
            {
                lbl_errorPass.Text = "Please insert the password.";
            }

            // checking if there were problems in prev part
            if (lbl_errorAccount.Text == string.Empty && lbl_errorPass.Text == string.Empty){
                accountNumber = checkAccAndPass(out string ValidationErrorMessage);
                if (accountNumber > 0)
                {

                    List<Customer> listOfResults = DAO.Login(accountNumber, password, 
                        out String LoginErrorMessage);

                    if (listOfResults.Count == 1)
                    {
                        // passing the list to new form
                        AccountPage accountPage = new AccountPage( listOfResults);
                        txtbx_AccNum.Text = String.Empty;
                        TxtBx_Pass.Text = String.Empty;
                        accountPage.Show();

                    }
                    else
                    {
                        MessageBox.Show(LoginErrorMessage, "No login found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    lbl_errorPass.Text = ValidationErrorMessage;
                }

            }

            TxtBx_Pass.Text = String.Empty;

        }

        /* this method will check that everything is correct with the account number and
         * the password provided in terms of datatype and lenght. It returns the parsed account number.
         * If anything goes wrong it will return a 0
         */

        private int checkAccAndPass(out string message)
        {
            int accountNumberParsed = 0;
            message = "";

            // checking if the account number is correct and give feedback to user
            if (int.TryParse(txtbx_AccNum.Text, out int accountNum))
            {
                // check if the min length is respected and that user didn't enter sequence of 0s
                if (accountNum >= 10000000)
                {
                    accountNumberParsed = accountNum;
                }
                else
                {
                    message = "Wrong account number inserted. \n " +
                        "The account number a 8 digits number.\n" +
                        "Rememeber: The first digit (from the left) is always greater than 0";
                        
                }
    
            }
            else
            {
                message = "Wrong account number. \nThe account number is an 8 digits number. " +
                    "\nPlease verify your details and try again.";
            }
            // if the account number is correct this part will check the password
            // if the password is already wrong no point in submitting the query
            // the error message won't be specific for security reason
            if (accountNumberParsed > 0)
            {
                if (TxtBx_Pass.Text.Length > 7 && TxtBx_Pass.Text.Length < 17)
                {
                    return accountNumberParsed;
                }
                else
                {
                    message = "Wrong password or account number inserted.";
                    accountNumberParsed = 0;
                }
            }

            return accountNumberParsed;
        }

        // preventing whitespaces in account number or password, this function set as handled
        // the 'event' of user pressing whitespace (without adding the white space)
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // setting handled to true when the key pressed is a white space
            if (e.KeyChar == (char)Keys.Space) {
                e.Handled = true;
            }
        }

        // create the form SignInPage
        private void button1_Click(object sender, EventArgs e)
        {
            TxtBx_Pass.Text = String.Empty;
            txtbx_AccNum.Text = String.Empty;
            ChkBox_ShowPass.Enabled = false;

            // if the form was already created it will just bring it to front and won't create a new one
            foreach (Form f in Application.OpenForms)
            {
                if (f is SignInPage)
                {
                    f.BringToFront();
                    f.Focus();
                    return;
                }
            }
            // if the loop didn't return a SignInPage then it creates one
            SignInPage form = new SignInPage();
            form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // checkbox for the password
        private void ChkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBox_ShowPass.Checked)
            {
                TxtBx_Pass.UseSystemPasswordChar = false;
            }
            else if (!ChkBox_ShowPass.Checked)
            {
                TxtBx_Pass.UseSystemPasswordChar = true;
            }

        }   
    }
}
