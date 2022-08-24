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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(77, 289);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(339, 28);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "SIGN IN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(77, 346);
            this.BtnCreateAccount.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(339, 28);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "CREATE ACCOUNT";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(77, 160);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(339, 27);
            this.TxtCustomerEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 139);
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
            this.LbEmailError.Location = new System.Drawing.Point(290, 130);
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
            this.label2.Location = new System.Drawing.Point(77, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // TxtCustomerPassword
            // 
            this.TxtCustomerPassword.Location = new System.Drawing.Point(77, 236);
            this.TxtCustomerPassword.Name = "TxtCustomerPassword";
            this.TxtCustomerPassword.PasswordChar = '●';
            this.TxtCustomerPassword.Size = new System.Drawing.Size(339, 27);
            this.TxtCustomerPassword.TabIndex = 6;
            // 
            // LblPasswordError
            // 
            this.LblPasswordError.AutoSize = true;
            this.LblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.LblPasswordError.Location = new System.Drawing.Point(266, 213);
            this.LblPasswordError.Name = "LblPasswordError";
            this.LblPasswordError.Size = new System.Drawing.Size(150, 20);
            this.LblPasswordError.TabIndex = 7;
            this.LblPasswordError.Text = "*Password Not Found";
            this.LblPasswordError.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(52, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "JK Pizza Co.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(77, 400);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(339, 30);
            this.BtnContinue.TabIndex = 9;
            this.BtnContinue.Text = "CONTINUE AS GUEST";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 461);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.label3);
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
        private Label label3;
        private Button BtnContinue;
    }
}