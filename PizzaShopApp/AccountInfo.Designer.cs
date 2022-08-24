namespace PizzaShopApp
{
    partial class AccountInfo
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
            this.components = new System.ComponentModel.Container();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.LblStreetAddress = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStreetAddress = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.LBLCustID = new System.Windows.Forms.Label();
            this.LblCustomerID = new System.Windows.Forms.Label();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(PizzaShopApp.Customer);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(18, 49);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(83, 20);
            this.LblFirstName.TabIndex = 3;
            this.LblFirstName.Text = "First Name:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(18, 94);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(82, 20);
            this.LblLastName.TabIndex = 4;
            this.LblLastName.Text = "Last Name:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(137, 49);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.ReadOnly = true;
            this.TxtFirstName.Size = new System.Drawing.Size(285, 27);
            this.TxtFirstName.TabIndex = 5;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(137, 94);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.ReadOnly = true;
            this.TxtLastName.Size = new System.Drawing.Size(285, 27);
            this.TxtLastName.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(18, 138);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 20);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email:";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(18, 324);
            this.LblState.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(46, 20);
            this.LblState.TabIndex = 8;
            this.LblState.Text = "State:";
            // 
            // LblStreetAddress
            // 
            this.LblStreetAddress.AutoSize = true;
            this.LblStreetAddress.Location = new System.Drawing.Point(18, 230);
            this.LblStreetAddress.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblStreetAddress.Name = "LblStreetAddress";
            this.LblStreetAddress.Size = new System.Drawing.Size(108, 20);
            this.LblStreetAddress.TabIndex = 9;
            this.LblStreetAddress.Text = "Street Address:";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(18, 277);
            this.LblCity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(37, 20);
            this.LblCity.TabIndex = 10;
            this.LblCity.Text = "City:";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.Location = new System.Drawing.Point(18, 370);
            this.LblZipCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(73, 20);
            this.LblZipCode.TabIndex = 11;
            this.LblZipCode.Text = "Zip Code:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(137, 138);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(285, 27);
            this.TxtEmail.TabIndex = 12;
            // 
            // TxtStreetAddress
            // 
            this.TxtStreetAddress.Location = new System.Drawing.Point(137, 230);
            this.TxtStreetAddress.Margin = new System.Windows.Forms.Padding(1);
            this.TxtStreetAddress.Name = "TxtStreetAddress";
            this.TxtStreetAddress.ReadOnly = true;
            this.TxtStreetAddress.Size = new System.Drawing.Size(285, 27);
            this.TxtStreetAddress.TabIndex = 13;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(137, 277);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(1);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.ReadOnly = true;
            this.TxtCity.Size = new System.Drawing.Size(285, 27);
            this.TxtCity.TabIndex = 14;
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(137, 370);
            this.TxtZipCode.Margin = new System.Windows.Forms.Padding(1);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.ReadOnly = true;
            this.TxtZipCode.Size = new System.Drawing.Size(285, 27);
            this.TxtZipCode.TabIndex = 15;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(137, 324);
            this.TxtState.Margin = new System.Windows.Forms.Padding(1);
            this.TxtState.Name = "TxtState";
            this.TxtState.ReadOnly = true;
            this.TxtState.Size = new System.Drawing.Size(285, 27);
            this.TxtState.TabIndex = 16;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(535, 49);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(151, 29);
            this.buttonDeleteAccount.TabIndex = 17;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // LBLCustID
            // 
            this.LBLCustID.AutoSize = true;
            this.LBLCustID.Location = new System.Drawing.Point(137, 9);
            this.LBLCustID.Name = "LBLCustID";
            this.LBLCustID.Size = new System.Drawing.Size(165, 20);
            this.LBLCustID.TabIndex = 18;
            this.LBLCustID.Text = "CustomerIDPlaceholder";
            // 
            // LblCustomerID
            // 
            this.LblCustomerID.AutoSize = true;
            this.LblCustomerID.Location = new System.Drawing.Point(15, 9);
            this.LblCustomerID.Name = "LblCustomerID";
            this.LblCustomerID.Size = new System.Drawing.Size(94, 20);
            this.LblCustomerID.TabIndex = 19;
            this.LblCustomerID.Text = "Customer ID:";
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Location = new System.Drawing.Point(535, 94);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(151, 29);
            this.buttonUpdateAccount.TabIndex = 20;
            this.buttonUpdateAccount.Text = "Update Account";
            this.buttonUpdateAccount.UseVisualStyleBackColor = true;
            this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdateAccount_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(535, 138);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(151, 29);
            this.buttonConfirm.TabIndex = 21;
            this.buttonConfirm.Text = "Confirm Update";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(18, 186);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(73, 20);
            this.LblPassword.TabIndex = 22;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(137, 186);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.ReadOnly = true;
            this.TxtPassword.Size = new System.Drawing.Size(285, 27);
            this.TxtPassword.TabIndex = 23;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(535, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 29);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 421);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonUpdateAccount);
            this.Controls.Add(this.LblCustomerID);
            this.Controls.Add(this.LBLCustID);
            this.Controls.Add(this.buttonDeleteAccount);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtStreetAddress);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblZipCode);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblStreetAddress);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "AccountInfo";
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource customerBindingSource;
        private Label LblFirstName;
        private Label LblLastName;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private Label LblEmail;
        private Label LblState;
        private Label LblStreetAddress;
        private Label LblCity;
        private Label LblZipCode;
        private TextBox TxtEmail;
        private TextBox TxtStreetAddress;
        private TextBox TxtCity;
        private TextBox TxtZipCode;
        private TextBox TxtState;
        private Button buttonDeleteAccount;
        private Label LBLCustID;
        private Label LblCustomerID;
        private Button buttonUpdateAccount;
        private Button buttonConfirm;
        private Label LblPassword;
        private TextBox TxtPassword;
        private Button buttonBack;
    }
}