namespace PizzaShopApp
{
    partial class HomePage
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
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Location = new System.Drawing.Point(158, 180);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(94, 29);
            this.btnAccountInfo.TabIndex = 0;
            this.btnAccountInfo.Text = "Account";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            this.btnAccountInfo.Click += new System.EventHandler(this.btnAccountInfo_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(129, 24);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(72, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "InputUser";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(158, 105);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(94, 29);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 304);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.btnAccountInfo);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccountInfo;
        private Label labelUserName;
        private Button btnMenu;
    }
}