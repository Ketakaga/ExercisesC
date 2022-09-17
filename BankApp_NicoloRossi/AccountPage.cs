using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BankApp_NicoloRossi
{
    public partial class AccountPage : Form
    {
        // I need to transport customer list from the login page
        List<Customer> customerList;

        // constructor that accept the customer list as parameter
        public AccountPage(List<Customer> customerList)
        {
            InitializeComponent();
            
            this.customerList = customerList;

        }

        // filling all the fields
        private void AccountPage_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text += " " + customerList[0].name + "! :)";
            lbl_accNum.Text = customerList[0].accountNum.ToString();
            lbl_phone.Text = customerList[0].telephone.ToString();
            lbl_address.Text = customerList[0].address;
            lbl_balance.Text = string.Format(new CultureInfo("en-IE"), "{0:c}", customerList[0].balance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
