
namespace ATM
{
    partial class frmOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCheckings = new System.Windows.Forms.Label();
            this.lblCheckingBal = new System.Windows.Forms.Label();
            this.lblSavingBalance = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.btnAmountOK = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransSavToChck = new System.Windows.Forms.Button();
            this.btnTransChckToSav = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnChecking = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(192, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(424, 42);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Jonah\'s Bank Overview";
            // 
            // lblCheckings
            // 
            this.lblCheckings.AutoSize = true;
            this.lblCheckings.Font = new System.Drawing.Font("Sitka Display", 17F);
            this.lblCheckings.Location = new System.Drawing.Point(193, 90);
            this.lblCheckings.Name = "lblCheckings";
            this.lblCheckings.Size = new System.Drawing.Size(183, 33);
            this.lblCheckings.TabIndex = 8;
            this.lblCheckings.Text = "Checking Account:";
            // 
            // lblCheckingBal
            // 
            this.lblCheckingBal.AutoSize = true;
            this.lblCheckingBal.Font = new System.Drawing.Font("Sitka Display", 17F);
            this.lblCheckingBal.Location = new System.Drawing.Point(376, 90);
            this.lblCheckingBal.Name = "lblCheckingBal";
            this.lblCheckingBal.Size = new System.Drawing.Size(63, 33);
            this.lblCheckingBal.TabIndex = 9;
            this.lblCheckingBal.Text = "$N/A";
            // 
            // lblSavingBalance
            // 
            this.lblSavingBalance.AutoSize = true;
            this.lblSavingBalance.Font = new System.Drawing.Font("Sitka Display", 17F);
            this.lblSavingBalance.Location = new System.Drawing.Point(376, 143);
            this.lblSavingBalance.Name = "lblSavingBalance";
            this.lblSavingBalance.Size = new System.Drawing.Size(69, 33);
            this.lblSavingBalance.TabIndex = 11;
            this.lblSavingBalance.Text = "$:N/A";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Sitka Display", 17F);
            this.lblSavings.Location = new System.Drawing.Point(193, 143);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(169, 33);
            this.lblSavings.TabIndex = 10;
            this.lblSavings.Text = "Savings Account:";
            // 
            // btnAmountOK
            // 
            this.btnAmountOK.BackColor = System.Drawing.Color.Lime;
            this.btnAmountOK.Location = new System.Drawing.Point(523, 407);
            this.btnAmountOK.Name = "btnAmountOK";
            this.btnAmountOK.Size = new System.Drawing.Size(103, 34);
            this.btnAmountOK.TabIndex = 7;
            this.btnAmountOK.Text = "OK";
            this.btnAmountOK.UseVisualStyleBackColor = false;
            this.btnAmountOK.Visible = false;
            this.btnAmountOK.Click += new System.EventHandler(this.btnAmountOK_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(199, 415);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(273, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.Visible = false;
            // 
            // btnTransSavToChck
            // 
            this.btnTransSavToChck.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransSavToChck.Location = new System.Drawing.Point(405, 309);
            this.btnTransSavToChck.Name = "btnTransSavToChck";
            this.btnTransSavToChck.Size = new System.Drawing.Size(252, 35);
            this.btnTransSavToChck.TabIndex = 5;
            this.btnTransSavToChck.Text = "Transfer Savings-Checking";
            this.btnTransSavToChck.UseVisualStyleBackColor = false;
            this.btnTransSavToChck.Click += new System.EventHandler(this.btnTransSavToChck_Click);
            // 
            // btnTransChckToSav
            // 
            this.btnTransChckToSav.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransChckToSav.Location = new System.Drawing.Point(150, 309);
            this.btnTransChckToSav.Name = "btnTransChckToSav";
            this.btnTransChckToSav.Size = new System.Drawing.Size(252, 35);
            this.btnTransChckToSav.TabIndex = 4;
            this.btnTransChckToSav.Text = "Transfer Checking-Savings";
            this.btnTransChckToSav.UseVisualStyleBackColor = false;
            this.btnTransChckToSav.Click += new System.EventHandler(this.btnTransChckToSav_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Sitka Display", 17F);
            this.lblAmount.Location = new System.Drawing.Point(193, 367);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(262, 33);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Enter Transaction Amount:";
            this.lblAmount.Visible = false;
            // 
            // btnSavings
            // 
            this.btnSavings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavings.Location = new System.Drawing.Point(405, 201);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(252, 35);
            this.btnSavings.TabIndex = 1;
            this.btnSavings.Text = "Savings";
            this.btnSavings.UseVisualStyleBackColor = false;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnChecking
            // 
            this.btnChecking.BackColor = System.Drawing.SystemColors.Control;
            this.btnChecking.Location = new System.Drawing.Point(150, 201);
            this.btnChecking.Name = "btnChecking";
            this.btnChecking.Size = new System.Drawing.Size(252, 35);
            this.btnChecking.TabIndex = 0;
            this.btnChecking.Text = "Checking";
            this.btnChecking.UseVisualStyleBackColor = false;
            this.btnChecking.Click += new System.EventHandler(this.btnChecking_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.Location = new System.Drawing.Point(290, 242);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(103, 34);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDepost_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnWithdraw.Location = new System.Drawing.Point(415, 242);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(103, 34);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // frmOverview
            // 
            this.AcceptButton = this.btnAmountOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnSavings);
            this.Controls.Add(this.btnChecking);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnTransSavToChck);
            this.Controls.Add(this.btnTransChckToSav);
            this.Controls.Add(this.btnAmountOK);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblSavingBalance);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblCheckingBal);
            this.Controls.Add(this.lblCheckings);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmOverview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCheckings;
        private System.Windows.Forms.Label lblCheckingBal;
        private System.Windows.Forms.Label lblSavingBalance;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Button btnAmountOK;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransSavToChck;
        private System.Windows.Forms.Button btnTransChckToSav;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnChecking;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
    }
}