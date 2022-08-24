namespace PizzaShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.TxtCustomerEmail = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.LbEmailError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCustomerPassword = new System.Windows.Forms.TextBox();
            this.LblPasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(77, 257);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(140, 28);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(364, 257);
            this.BtnCreateAccount.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(140, 28);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(165, 69);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(339, 27);
            this.TxtCustomerEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // LbEmailError
            // 
            this.LbEmailError.AutoSize = true;
            this.LbEmailError.ForeColor = System.Drawing.Color.Red;
            this.LbEmailError.Location = new System.Drawing.Point(165, 110);
            this.LbEmailError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbEmailError.Name = "LbEmailError";
            this.LbEmailError.Size = new System.Drawing.Size(126, 20);
            this.LbEmailError.TabIndex = 4;
            this.LbEmailError.Text = "*Email Not Found";
            this.LbEmailError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // TxtCustomerPassword
            // 
            this.TxtCustomerPassword.Location = new System.Drawing.Point(165, 151);
            this.TxtCustomerPassword.Name = "TxtCustomerPassword";
            this.TxtCustomerPassword.PasswordChar = '●';
            this.TxtCustomerPassword.Size = new System.Drawing.Size(339, 27);
            this.TxtCustomerPassword.TabIndex = 6;
            // 
            // LblPasswordError
            // 
            this.LblPasswordError.AutoSize = true;
            this.LblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.LblPasswordError.Location = new System.Drawing.Point(167, 198);
            this.LblPasswordError.Name = "LblPasswordError";
            this.LblPasswordError.Size = new System.Drawing.Size(150, 20);
            this.LblPasswordError.TabIndex = 7;
            this.LblPasswordError.Text = "*Password Not Found";
            this.LblPasswordError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 416);
            this.Controls.Add(this.LblPasswordError);
            this.Controls.Add(this.TxtCustomerPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbEmailError);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerEmail);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnLogin;
        private Button BtnCreateAccount;
        private TextBox TxtCustomerEmail;
        private HelpProvider helpProvider1;
        private Label label1;
        private Label LbEmailError;
        private Label label2;
        private TextBox TxtCustomerPassword;
        private Label LblPasswordError;
    }
}