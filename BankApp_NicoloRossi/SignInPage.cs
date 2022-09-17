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
    public partial class SignInPage : Form
    {
        CustomersLoginsDAO DAO;
        public SignInPage()
        {

            InitializeComponent();
            // preventing whitespaces in account number or password
            txtbx_AccNum.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            TxtBx_Pass.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtbx_confPass.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            // I've restricted the length of textbox for accountNum
           // txtbx_AccNum.MaxLength = 8;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // instanciating the DAO object
            DAO = new CustomersLoginsDAO();

        }

        // this method checks that everything is correct before adding the new account
        private void btn_register_Click(object sender, EventArgs e)
        {
            // clear all fields
            lbl_accountN.Text = String.Empty;
            lbl_errorAccount.Text = String.Empty;
            lbl_confirmPssw.Text = String.Empty;
            lbl_password.Text = String.Empty;

            // verify that all fields are filled correctly
            if (txtbx_AccNum.Text == String.Empty)
            {
                lbl_accountN.Text = "Please insert Account N.";
            }

            else if (txtbx_AccNum.Text.Length != 8)
            {
                lbl_accountN.Text = "Account Number must be 8 digits number.";
            }
            else if (TxtBx_Pass.Text == String.Empty)
            {
                lbl_password.Text = "Please set your new password.";
            }
            else if (txtbx_confPass.Text == String.Empty)
            {
                lbl_confirmPssw.Text = "Please confirm the password.";
            }
            // using the function validatePassw will check that passoword match and meet standards
            else if (validatePassw(TxtBx_Pass.Text, txtbx_confPass.Text))
            {
                // try parsing the account number
                if (int.TryParse(txtbx_AccNum.Text, out int accountN))
                {
                    // send request to DB and verify result
                    if (DAO.createNewCustomer(accountN, TxtBx_Pass.Text,  out string message))
                    {
                        MessageBox.Show(message, "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtBx_Pass.Clear();
                        txtbx_AccNum.Clear();
                        txtbx_confPass.Clear();
                        btn_exit.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                // if TryParse return value is false then showing error
                else
                {
                    MessageBox.Show("Account Number is a 8 digits length number (only numbers).\n\n " +
                        "Please verify your account number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    
            }


        }

        // this method validate that the two passowords inserted match and are secure enough
        private bool validatePassw(String Password, String PasswordConf)
        {
            lbl_confirmPssw.Text = String.Empty;

            bool isValid = false;
            string message = "";

            if (Password.Equals(PasswordConf))
            {
                // using the method to validate password condition
                if (passwordValidator(TxtBx_Pass.Text))
                {
                    isValid = true;
                }
                else
                {
                    lbl_confirmPssw.Text = "Please verify that all condition for password are met.";
                }
            }
            else
            {
                lbl_confirmPssw.Text = "The passwords don't match. Please insert the same password to confirm.";
                return isValid;
            }


            return isValid;
        }

        // this method is called everytime a key is pressed and helps the user 
        // by turning green the condition that are met using passwordValidator
        private void TxtBx_Pass_TextChanged(object sender, EventArgs e)
        {
            lbl_confirmPssw.Text = String.Empty;
            passwordValidator(TxtBx_Pass.Text);
        }

        // this method verifies that security standard of password are respected
        // and turn green the condition met
        private bool passwordValidator(string password)
        {
            char[] passwordArray = password.ToCharArray();
            bool upperCase = false;
            bool lowerCase = false;
            bool number = false;
            bool length = false;
            bool special = false;

            lbl_Num.ForeColor = Color.Red;
            lbl_Up.ForeColor = Color.Red;
            lbl_lower.ForeColor = Color.Red;
            lbl_length.ForeColor = Color.Red;
            lbl_special.ForeColor = Color.Red;

            if (passwordArray.Length > 7 && passwordArray.Length < 17)
            {
                lbl_length.ForeColor = Color.Green;
                length = true;
            }
            // using ASCII to determine if condition are met
            foreach (char c in passwordArray)
            {
                if (c > 47 && c < 58)
                {
                    number = true;
                    lbl_Num.ForeColor = Color.Green;
                }
                else if (c > 64 && c < 91)
                {
                    upperCase = true;
                    lbl_Up.ForeColor = Color.Green;
                }
                else if (c > 96 && c < 123)
                {
                    lowerCase = true;
                    lbl_lower.ForeColor = Color.Green;
                }
                // if not a number or a letter then should be a special char (accented letters are considered
                // special char)
                else
                {
                    special = true;
                    lbl_special.ForeColor= Color.Green;

                }

            }

            return number && lowerCase && upperCase && length && special;
        }




        // preventing whitespaces in account number or password, this function set as handled
        // the 'event' of user pressing whitespace (without adding the white space)
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // setting handled to true when the key pressed is a white space
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
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

