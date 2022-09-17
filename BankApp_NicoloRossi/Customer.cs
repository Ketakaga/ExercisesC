using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_NicoloRossi
{
    // this class contains all the data from customer table as properties
    public class Customer
    {
        public string name;
        public int accountNum;
        public string address;
        public string telephone;
        public decimal balance;

        
        public Customer(string name, int accountNum, string address, string telephone, decimal balance)
        {
            this.name = name;
            this.accountNum = accountNum;
            this.address = address;
            this.telephone = telephone;
            this.balance = balance;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return $"name:{name}\nAcc num:{accountNum}\nAddress:{address}\nphone:{telephone}";
        }
    }
}
