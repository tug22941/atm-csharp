
namespace ATM
{
    partial class frmMain
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAccPin = new System.Windows.Forms.TextBox();
            this.btnSrchAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(140, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(549, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Jonah\'s Bank ATM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(200, 134);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(377, 35);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter your FIVE digit account number";
            // 
            // txtAccPin
            // 
            this.txtAccPin.Location = new System.Drawing.Point(307, 200);
            this.txtAccPin.Name = "txtAccPin";
            this.txtAccPin.Size = new System.Drawing.Size(180, 20);
            this.txtAccPin.TabIndex = 2;
            // 
            // btnSrchAcc
            // 
            this.btnSrchAcc.BackColor = System.Drawing.Color.Lime;
            this.btnSrchAcc.Location = new System.Drawing.Point(360, 238);
            this.btnSrchAcc.Name = "btnSrchAcc";
            this.btnSrchAcc.Size = new System.Drawing.Size(75, 34);
            this.btnSrchAcc.TabIndex = 3;
            this.btnSrchAcc.Text = "Search";
            this.btnSrchAcc.UseVisualStyleBackColor = false;
            this.btnSrchAcc.Click += new System.EventHandler(this.btnSrchAcc_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSrchAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSrchAcc);
            this.Controls.Add(this.txtAccPin);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtAccPin;
        private System.Windows.Forms.Button btnSrchAcc;
    }
}

