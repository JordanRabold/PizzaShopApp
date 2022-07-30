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
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(718, 473);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(298, 58);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(718, 561);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(298, 58);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(301, 364);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(715, 47);
            this.TxtCustomerEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // LbEmailError
            // 
            this.LbEmailError.AutoSize = true;
            this.LbEmailError.ForeColor = System.Drawing.Color.Red;
            this.LbEmailError.Location = new System.Drawing.Point(301, 414);
            this.LbEmailError.Name = "LbEmailError";
            this.LbEmailError.Size = new System.Drawing.Size(252, 41);
            this.LbEmailError.TabIndex = 4;
            this.LbEmailError.Text = "*Email Not Found";
            this.LbEmailError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 853);
            this.Controls.Add(this.LbEmailError);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerEmail);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}