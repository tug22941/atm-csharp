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
    public partial class frmUserLogin : Form
    {
        string record; //variable for storing account record string
        ATMBankClass atm = new ATMBankClass();
        int tryCount = 0;
        public frmUserLogin(string accountRecord)
        {
            InitializeComponent();
            record = accountRecord;
        }

        //event handler responsible for validating username and the associated login pin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //retrieve username and login pin from the corresponding textboxes
            string userName = txtUserName.Text;
            string userPin = txtUserPin.Text;

            //check that the user has not exceeded the maximum allowed attempts for account login
            if (tryCount == atm.HiddenTryCountMax)
            {
                MessageBox.Show("You have exceeded the maximum allowed login attempts, " +
                               "Please try again tomorrow", "Maximum login reached");
                //close account files and application
                atm.closeFiles();
                Close();
            }
            //check that a user name has been entered
           else if(userName == "")
            {
                MessageBox.Show("User name is blank, please enter a valid username", "Blank Username");
                txtUserName.Focus();
                tryCount++;
            }
            else
            {
                //check that the user account pin is the required length of an ATM pin
                if (userPin.Length != atm.HiddenPinLength)
                {
                    MessageBox.Show("The login pin that you have entered is invalid, Please re-enter a " +
                                    "4-digit account pin", "Invalid Length");
                    txtUserPin.Focus();
                    tryCount++;
                }
                else
                {
                    //check that the user login pin is in the correct format
                    try
                    {
                        int loginPin = Convert.ToInt32(userPin);
                        customerClass customer = new customerClass(record);
                        if (customer.nameLoginValid(userName, userPin))
                        {
                            MessageBox.Show("Username and Pin successful, logging into account", "Invalid Username and Pin");
                            this.Hide();
                            Form frmOverview = new frmOverview(record);
                            frmOverview.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("The username and pin you have entered is invalid", "Invalid Username and Pin");
                            tryCount++;
                        }


                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("You have entered an invalid format for the user login \n" +
                                        "Please, re-enter a valid 4 digit integer", "Invalid Login Pin Format");
                        txtUserPin.Focus();
                        tryCount++;
                    }
                }
            }
        }
    }
}
