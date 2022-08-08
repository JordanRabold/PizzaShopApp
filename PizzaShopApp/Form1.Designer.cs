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
            this.BtnLogin.Location = new System.Drawing.Point(338, 231);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(140, 28);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(338, 274);
            this.BtnCreateAccount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(140, 28);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(142, 178);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(339, 27);
            this.TxtCustomerEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 178);
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
            this.LbEmailError.Location = new System.Drawing.Point(142, 202);
            this.LbEmailError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbEmailError.Name = "LbEmailError";
            this.LbEmailError.Size = new System.Drawing.Size(126, 20);
            this.LbEmailError.TabIndex = 4;
            this.LbEmailError.Text = "*Email Not Found";
            this.LbEmailError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 416);
            this.Controls.Add(this.LbEmailError);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerEmail);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
    }
}