namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Login_Page
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
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.Location = new System.Drawing.Point(112, 89);
            this.lblLoginWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(896, 92);
            this.lblLoginWelcome.TabIndex = 0;
            this.lblLoginWelcome.Text = "Welcome to APU Car Insurance Management System";
            this.lblLoginWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1017, 1175);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblLogin.Location = new System.Drawing.Point(330, 183);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(459, 55);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Please fill in your details to access your account.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsername.Location = new System.Drawing.Point(158, 266);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(164, 74);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPassword.Location = new System.Drawing.Point(158, 357);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(154, 74);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(344, 266);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(601, 75);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(344, 357);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(601, 75);
            this.txtPassword.TabIndex = 6;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(389, 464);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(339, 88);
            this.btnSignin.TabIndex = 7;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Location = new System.Drawing.Point(817, 649);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 74F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginWelcome);
            this.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(5, 14, 5, 14);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnExit;
    }
}

