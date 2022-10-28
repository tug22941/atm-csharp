using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    class ATMBankClass
    {
        //declare and define class variables for the required account length, login pin length,
        //maximum user login attempts and maximum user withdraw amount
        private int hiddenAccLength = 5;
        private int hiddenPinLength = 4;
        private int hiddenTryCountMax = 3;
        private decimal hiddenWDAmount = 300.00m;

        //delcare and define the paths to the current and updated ATM records files
        private static string currentFilePath = @"CurrentATMBankFile.txt";
        private static string updateFilePath = @"UpdatedATMBankFile.txt";

        //create object of the current file class and updated file class
        private currentFileClass currentFile = new currentFileClass(currentFilePath);
        private updatedFileClass updatedFile = new updatedFileClass(updateFilePath);

        //default construcotr for the ATMBankClass
        public ATMBankClass()
        {

        }

        ///////////////PROPERTIES///////////////
        
        //property responsible for reading the required length of an ATM account pin
        public int HiddenAccLength
        {
            get { return hiddenAccLength; }
        }

        //property responsible for reading the required lenght of an ATM login pin
        public int HiddenPinLength
        {
            get { return hiddenPinLength; }
        }

        //property responsible for reading the maximum allowed attempts for user ATM account login
        public int HiddenTryCountMax
        {
            get { return hiddenTryCountMax; }
        }

        //property responsible for reading the maximum amount allowed to be withdrawn from an ATM account
        public decimal HiddenWDAmount
        {
            get { return hiddenWDAmount; }
        }
        ///////////////METHODS///////////////

        //method responsible for determining whether there is a customer record matching the user account Pin
        public bool accountMatch(string userPin)
        {
            currentFile.rewindfile();
            customerClass customer = new customerClass();
            bool isEndOfFile = false;
            string nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                if (customer.accountMatch(nextRecord, userPin))
                {
                    return true;
                }
                else
                {
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                }
            }
            return false;
        }

        //method responsible for searching the current file record
        //and returning a customer record associated with the account pin
        public string findCustomerRecord(string userPin)
        {
            currentFile.rewindfile();
            customerClass customer = new customerClass(); //create customer object
            bool isEndOfFile = false;
            string nextRecord = currentFile.getNextRecord(ref isEndOfFile);

            while (!isEndOfFile)
            {
                if (customer.accountMatch(nextRecord, userPin))
                {
                    //change found reference variable to true, return current(next) record
                    return nextRecord;
                }
                else
                {
                    //add the current record to the updated file
                    //update the value of next record to the following record in the current file
                    updatedFile.writeNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                }
            }
            return nextRecord;
        }

        //method responsible for writing a single customer record to the updated file
        public void writeOut(string record)
        {
            updatedFile.writeNextRecord(record);
        }

        //method responsible for copying the remaining customer records fromt he current file to the updated file
        public void copyRemainingRecords()
        {
            bool isEndOfFile = false;
            string nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.writeNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            }

            //end of records message
            MessageBox.Show("End of program execution." + "\n"
                + "The number of records read is: " + currentFile.RecordsReadCount.ToString() + "\n"
                + "The number of records written is: " + updatedFile.RecordsWrittenCount.ToString());
        }

        //method responsible for rewinding the current and updated file to their state before modifications
        public void rewindFile()
        {
            currentFile.rewindfile();
            updatedFile.rewindFile();
        }

        //method responsible for closing the current and updated file
        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }
    }
}
