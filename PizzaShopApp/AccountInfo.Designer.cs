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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStreetAddress = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(PizzaShopApp.Customer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Street Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zip Code:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Customer ID:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(137, 186);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.ReadOnly = true;
            this.TxtPassword.Size = new System.Drawing.Size(285, 27);
            this.TxtPassword.TabIndex = 23;
            this.TxtPassword.Visible = false;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 421);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonUpdateAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDeleteAccount);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtStreetAddress);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource customerBindingSource;
        private Label label1;
        private Label label2;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtEmail;
        private TextBox TxtStreetAddress;
        private TextBox TxtCity;
        private TextBox TxtZipCode;
        private TextBox TxtState;
        private Button buttonDeleteAccount;
        private Label label8;
        private Label label9;
        private Button buttonUpdateAccount;
        private Button buttonConfirm;
        private Label label10;
        private TextBox TxtPassword;
    }
}