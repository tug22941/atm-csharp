using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmMain : Form
    {
        
        ATMBankClass atm = new ATMBankClass();  //create atm bank object
        int tryCount = 0;                       // declare variable to track user login attempts

        public frmMain()
        {
            InitializeComponent();
        }



        //event handler responsible for validating and searching, for the user entered account
        //pin number from within the ATM bank records and, if found, retrieving the accont
        private void btnSrchAcc_Click(object sender, EventArgs e)
        
        {
            //retrieve user input from textbox
            string accPinString = txtAccPin.Text;

            //check that the user has not exceeded the maximum allowed attempts for account login
            if (tryCount == atm.HiddenTryCountMax)
            {
                MessageBox.Show("You have exceeded the maximum allowed login attempts, " +
                                "Please try again tomorrow", "Maximum login reached");
                //close account files and application
                atm.closeFiles();
                Close();
            }
            //check that the user account pin is the required length of an ATM pin
            else if (accPinString.Length != atm.HiddenAccLength)
            {
                MessageBox.Show("The account pin that you have entered is invalid, Please re-enter a " +
                                "5-digit account pin", "Invalid Length");
                txtAccPin.Focus();
                tryCount++;
            }
            else
            {
                //check that the user account pin is in the correct format
                try
                {
                    int accountPin = Convert.ToInt32(accPinString);

                    //check if there is a customer record associated with the entered account pin
                    if (atm.accountMatch(accPinString))
                    {   //SUCCESS! - retrieve the customer record
                        string record = atm.findCustomerRecord(accPinString);
                        atm.closeFiles();
                        
                        //display success message, hide current form, open user login form
                        MessageBox.Show("Account found. Please enter username and Passcode","Account found - Login");
                        this.Hide();

                        Form userLogin = new frmUserLogin(record);
                        userLogin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("There is no account associated with the entered Pin, retry another", 
                                        "Unknown Pin");
                        tryCount++;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered an invalid format for this textbox \n" +
                                "Please, re-enter a valid 5 digit integer", "Invalid Format");
                    txtAccPin.Clear();
                    txtAccPin.Focus();
                    tryCount++;

                }
                catch (Exception)
                {
                    MessageBox.Show("Your account pin must be exactly five digits long \n" +
                                     "Please, re-enter a valid account pin.", "Invalid Account Number");

                    txtAccPin.Clear();
                    txtAccPin.Focus();
                    tryCount++;
                }
            }
        }
    }
}
