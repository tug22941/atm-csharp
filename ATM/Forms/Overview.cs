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
    public partial class frmOverview : Form
    {
        string record;                                  //declare string variable to hold customer record
        customerClass customer;                         //create customer object using customer record
        ATMBankClass atm = new ATMBankClass();

        bool checking = false;
        bool savings = false;
        bool deposit = false;
        bool withdraw = false;
        bool transferToChecking = false;
        bool transferToSavings = false;

        ///////////////EVENT HANDLERS///////////////

        //event handler for when the form is loaded in
        public frmOverview(string recordString)
        {
            InitializeComponent();
            record = recordString;
            customer = new customerClass(record);

            //display customer bank records using customer object
            lblCheckingBal.Text = customer.AccountChecking;
            lblSavingBalance.Text = customer.AccountSavings;
            
        }

        //event handler responsible for activating the Checking account button options
        private void btnChecking_Click(object sender, EventArgs e)
        {
            //calls method that toggles between checking and saving button - when checking is picked
            // and displays deposit and withdraw button;
            CheckSaveSelect(btnChecking, btnSavings);
        }

        //event handler responsible for activating the Savings account button options
        private void btnSavings_Click(object sender, EventArgs e)
        {
            //calls method that toggles between checking and saving button - when savings is picked
            // and displays deposit and withdraw button;
            CheckSaveSelect(btnSavings, btnChecking);
        }

        //event handler responsible for making visible controls for user to enter deposit amount into an account
        private void btnDepost_Click(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.Lime;
            btnWithdraw.BackColor = DefaultBackColor;
            lblAmount.Text = "Enter Deposit Amount:";
            lblAmount.Visible = true;
            txtAmount.Visible = true;
            txtAmount.Focus();
            btnAmountOK.Visible = true;

            deposit = true;
            withdraw = false;
        }

        //event handler responsible for making visible controls for user to enter withdraw amount from an account
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            btnWithdraw.BackColor = Color.Lime;
            btnDeposit.BackColor = DefaultBackColor;
            lblAmount.Text = "Enter Withdraw Amount:";
            lblAmount.Visible = true;
            txtAmount.Visible = true;
            txtAmount.Focus();
            btnAmountOK.Visible = true;

            deposit = false;
            withdraw = true;
        }

        //event handler responsible for making ontrols vsible for user to transer amount from Checking to Saving account
        private void btnTransChckToSav_Click(object sender, EventArgs e)
        {
            ClearForm();
            TransferSelect(btnTransChckToSav, btnTransSavToChck);
            transferToSavings = true;      
        }

        //event handler responsible for making ontrols vsible for user to transer amount from Saving to Checking account
        private void btnTransSavToChck_Click(object sender, EventArgs e)
        {
            ClearForm();
            TransferSelect(btnTransSavToChck, btnTransChckToSav);
            transferToChecking = true;
        }

        //event handler responsible for completing user transaction
        private void btnAmountOK_Click(object sender, EventArgs e)
        {
            try { 
                //convert the string entry to decimal, round the decimal amount, format the resulting string
                
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                amount = Math.Round(amount, 0);
                string amountString = amount.ToString("F2");

                if (checking == true){ //deposit to checking
                    if (deposit == true) {
                        customer.depositToChecking(amountString);
                    }
                    else { //withdraw from checkings
                        customer.withdrawFromChecking(amountString);
                    }
                }
                else if (savings == true)
                {
                    if (deposit == true)
                    {   //deposit to savings
                        customer.depositToSavings(amountString);
                    }
                    else{ //withdraw from savings
                        customer.withdrawFromSavings(amountString);
                    }
                }
                else if (transferToChecking)
                {   //transfer from checkings to savings
                    customer.transferToCheckings(amountString);
                }
                else if (transferToSavings)
                {   //transfer from savings to checkings
                    customer.transferToSavings(amountString);
                }

                //display customer bank records using customer object
                atm.writeOut(record);
                atm.copyRemainingRecords();
                lblCheckingBal.Text = customer.AccountChecking;
                lblSavingBalance.Text = customer.AccountSavings;
                txtAmount.Clear();


            }
            catch {  MessageBox.Show("amount conversion failed"); }
        }

        ///////////////METHODS///////////////

        //method responsible for toggling controls between savings and checking account selections
        public void CheckSaveSelect(Button pick, Button notPick)
        {
            ClearForm();
            if (pick.BackColor == Color.Turquoise)
            {
                pick.BackColor = DefaultBackColor;
                btnDeposit.Visible = false;
                btnWithdraw.Visible = false;
            }
            else
            {
                notPick.BackColor = DefaultBackColor;
                pick.BackColor = Color.Turquoise;
                btnDeposit.Visible = true;
                btnWithdraw.Visible = true;

                if (pick == btnChecking) { checking = true;}
                else { savings = true;}

            }

            btnDeposit.BackColor = DefaultBackColor;
            btnWithdraw.BackColor = DefaultBackColor;
            //Hide display of the transaction controls
            lblAmount.Visible = false;
            txtAmount.Visible = false;
            btnAmountOK.Visible = false;

        }

        //method responsible for toggling the controls for bank transfers
        public void TransferSelect(Button pick, Button notPick)
        {
            if(pick.BackColor == Color.Turquoise)
            {
                pick.BackColor = DefaultBackColor;
                lblAmount.Visible = false;
                txtAmount.Visible = false;
                btnAmountOK.Visible = false;
            }
            else
            {
                notPick.BackColor = DefaultBackColor;
                pick.BackColor = Color.Turquoise;

                if(pick == btnTransChckToSav)
                {
                    lblAmount.Text = "Enter amount to transfer from Checking to Savings:";
                }
                else
                {
                    lblAmount.Text = "Enter amount to transfer from Savings to Checking:";
                }

                lblAmount.Visible = true;
                txtAmount.Visible = true;
                txtAmount.Focus();
                btnAmountOK.Visible = true;
            }
        }

        //method responsible for returning the form to a state before user selection
        public void ClearForm()
        {
            btnChecking.BackColor = DefaultBackColor;
            btnSavings.BackColor = DefaultBackColor;
            //
            btnDeposit.BackColor = DefaultBackColor;
            btnWithdraw.BackColor = DefaultBackColor;
            btnDeposit.Visible = false;
            btnWithdraw.Visible = false;
            //
            btnTransChckToSav.BackColor = DefaultBackColor;
            btnTransSavToChck.BackColor = DefaultBackColor;
            //
            lblAmount.Visible = false;
            txtAmount.Visible = false;
            btnAmountOK.Visible = false;
            //
            checking = false;
            savings = false;
            deposit = false;
            withdraw = false;
            transferToChecking = false;
            transferToSavings = false;
        }

    }
}
