using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        //property responsible for retrieving entire customer record;
        public string AccountString
        {
            get { return accountString; }
        }

        //property responsible for retrieving the account pin of the customer's record
        public string AccountPin
        {
            get { return accountPin; }
        }

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

        //method responsible for depositing amount into checking account
        public void depositToChecking(string amount)
        {
            //remove the dollar sign and comma character from the string amount
            string checkingString = accountChecking.Replace("$","");
            checkingString = checkingString.Replace(",", "");

            // add the user amount to the checking account
            double checkingAmount = Convert.ToDouble(checkingString);
            double depositAmount = Convert.ToDouble(amount);
            double checkingTotal = checkingAmount + depositAmount;

            //update the checking account record with the string total w/ dollar sign and commas
            accountChecking = String.Format("{0:n0}", checkingTotal).Insert(0,"$");
            reconstructRecord();
        }

        //method responsible for withdrawing amount from checking account
        public void withdrawFromChecking(string amount)
        {
            //remove the dollar sign and comma character from the string amount
            string checkingString = accountChecking.Replace("$", "");
            checkingString = checkingString.Replace(",", "");

            // add the user amount to the checking account
            double checkingAmount = Convert.ToDouble(checkingString);
            double withdrawAmount = Convert.ToDouble(amount);

            if((checkingAmount - withdrawAmount) >= 0)
            {
                double checkingTotal = checkingAmount - withdrawAmount;
                //update the checkings account record with the string total w/ dollar sign and commas
                accountChecking = String.Format("{0:n0}", checkingTotal).Insert(0, "$");
                reconstructRecord();
            }
            else { MessageBox.Show("The withdraw amount is larger than the account total.", "Insufficient Funds"); }

        }

        //method responsible for despositing amount into savings account
        public void depositToSavings(string amount)
        {
            //remove the dollar sign and comma character from the string amount
            string savingString = accountSavings.Replace("$", "");
            savingString = savingString.Replace(",", "");

            //add the user amount to the saving account
            double savingsAmount = Convert.ToDouble(savingString);
            double depositAmount = Convert.ToDouble(amount);
            double savingsTotal = savingsAmount + depositAmount;

            //update the savings account record with the string total w/ dollar sign and commas
            accountSavings = String.Format("{0:n0}", savingsTotal).Insert(0, "$");
            reconstructRecord();
        }

        //method responsible for withdrawing amount from savings account
        public void withdrawFromSavings(string amount)
        {
            //remove the dollar sign and comma character from the string amount
            string savingsString = accountSavings.Replace("$", "");
            savingsString = savingsString.Replace(",", "");

            // add the user amount to the checking account
            double savingsAmount = Convert.ToDouble(savingsString);
            double withdrawAmount = Convert.ToDouble(amount);

            if ((savingsAmount - withdrawAmount) >= 0)
            {
                double savingsTotal = savingsAmount - withdrawAmount;
                //update the savings account record with the string total w/ dollar sign and commas
                accountSavings = String.Format("{0:n0}", savingsTotal).Insert(0, "$");
                reconstructRecord();
            }
            else
            {
                MessageBox.Show("The withdraw amount is larger than the account total.", "Insufficient Funds");
            }
        }

        //method responsible for transfering amount from user savings account, into user checking account
        public void transferToCheckings(string amount)
        {
            string checkingString = accountChecking.Replace("$", "");
            checkingString = checkingString.Replace(",", "");
            double checkingAmount = Convert.ToDouble(checkingString);
            //
            string savingsString = accountSavings.Replace("$", "");
            savingsString = savingsString.Replace(",", "");
            double savingsAmount = Convert.ToDouble(savingsString);
            //
            double transferAmount = Convert.ToDouble(amount);

            if ((savingsAmount - transferAmount) > 0)
            {
                //update the savings and checking account records with the string total
                //w/ dollar sign and commas
                double savingsTotal = savingsAmount - transferAmount;
                double checkingTotal = checkingAmount + transferAmount;
                accountSavings = String.Format("{0:n0}", savingsTotal).Insert(0, "$");
                accountChecking = String.Format("{0:n0}", checkingTotal).Insert(0, "$");
                reconstructRecord();
            }
            else
            {
                MessageBox.Show("Invalid Transfer! \n" +
                                "The transfer amount is larger than the savings account total.", "Insufficient Savings Funds");
            }
        }

        //method responsible for transfering amount from user checking account, into user savings account
        public void transferToSavings(string amount)
        {
            string checkingString = accountChecking.Replace("$", "");
            checkingString = checkingString.Replace(",", "");
            double checkingAmount = Convert.ToDouble(checkingString);
            //
            string savingsString = accountSavings.Replace("$", "");
            savingsString = savingsString.Replace(",", "");
            double savingsAmount = Convert.ToDouble(savingsString);
            //
            double transferAmount = Convert.ToDouble(amount);

            if((checkingAmount- transferAmount) > 0)
            {
                //update the savings and checking account records with the string total
                //w/ dollar sign and commas
                double savingsTotal = savingsAmount + transferAmount;
                double checkingTotal = checkingAmount - transferAmount;
                accountSavings = String.Format("{0:n0}", savingsTotal).Insert(0, "$");
                accountChecking = String.Format("{0:n0}", checkingTotal).Insert(0, "$");
                reconstructRecord();
            }
            else
            {
                MessageBox.Show("Invalid Transfer! \n" +
                                "The transfer amount is larger than the checking account total.", "Insufficient Checking Funds");
            }
        }

        //method responsible for reconstructing customer's account string
        public void reconstructRecord()
        {
            accountString = accountPin + " * ";
            accountString += accountName + " * ";
            accountString += accountID + " * ";
            accountString += accountChecking + " * ";
            accountString += accountSavings;
        }
    }
}
