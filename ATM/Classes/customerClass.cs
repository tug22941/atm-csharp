using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class customerClass
    {
        //declare variables to hold the partitioned values of the account string
        private string accountString;
        private string accountPin;
        private string accountName;
        private string accountID;
        private string accountChecking;
        private string accountSavings;

        //default constructor for customer class
        public customerClass()
        {

        }

        //constructor for the customer class that accepts a customer account string
        public customerClass(string record)
        {
            //partiion the customer account record string into its identifable parts
            //and store the value into the corresponding varibales
            accountString = record.Trim();
            string[] accountPart;
            accountPart = accountString.Split('*');

            accountPin = accountPart[0].Trim();
            accountName = accountPart[1].Trim();
            accountID = accountPart[2].Trim();
            accountChecking = accountPart[3].Trim();
            accountSavings = accountPart[4].Trim();
        }

        ///////////////PROPERTIES///////////////
        
        //property responsible for retrieving the cash amount in the customer's checking account
        public string AccountChecking
        {
            get { return accountChecking; }
        }

        //property responsible for retrieving the cash amount in the customer's savings account
        public string AccountSavings
        {
            get { return accountSavings; }
        }

        ///////////////METHODS///////////////

        //method responsible for checking whether the user entered account pin matches that of the current record
        public bool accountMatch(string record, string userPin)
        {
            //trim and partion the account string,
            //retrieve the (0th) partion that  holds the value for the account Pin and trim it again
            accountString = record.Trim();
            string[] recordPart = record.Split('*');
            string recordPin = recordPart[0];
            recordPin = recordPin.Trim();

            //check whether the usere entered acocunt pin matches that of the current record
            return recordPin == userPin;

        }

        //method responsible for checking for a username and login pin matching user entry
        public bool nameLoginValid(string userName, string loginPin)
        {
            if(userName == accountName && loginPin == accountID)
            {
                return true;
            }
            return false;
        }

        //method responsible for depositing amount into checkings account
        public void depositTocheckings(string amount)
        {
            string aC = accountChecking.Replace("$","");
            string ac = aC.Replace(",", "");
            double checkingAmount = Convert.ToDouble(aC);
            double depositAmount = Convert.ToDouble(amount);

            double checkingTotal = checkingAmount + depositAmount;
            accountChecking = String.Format("{0:n0}", checkingTotal).Insert(0,"$");


        }
    }
}
