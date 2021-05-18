namespace MyUsers
{
    partial class SignForm
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
            this.LogIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.logInUN = new System.Windows.Forms.TextBox();
            this.logInPass = new System.Windows.Forms.TextBox();
            this.regPass = new System.Windows.Forms.TextBox();
            this.regUN = new System.Windows.Forms.TextBox();
            this.regAddress = new System.Windows.Forms.TextBox();
            this.regPhone = new System.Windows.Forms.TextBox();
            this.regName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(221, 280);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogInClick);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(489, 280);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUpClick);
            // 
            // logInUN
            // 
            this.logInUN.Location = new System.Drawing.Point(210, 207);
            this.logInUN.Name = "logInUN";
            this.logInUN.Size = new System.Drawing.Size(100, 23);
            this.logInUN.TabIndex = 2;
            // 
            // logInPass
            // 
            this.logInPass.Location = new System.Drawing.Point(210, 251);
            this.logInPass.Name = "logInPass";
            this.logInPass.Size = new System.Drawing.Size(100, 23);
            this.logInPass.TabIndex = 3;
            // 
            // regPass
            // 
            this.regPass.Location = new System.Drawing.Point(476, 251);
            this.regPass.Name = "regPass";
            this.regPass.Size = new System.Drawing.Size(100, 23);
            this.regPass.TabIndex = 4;
            // 
            // regUN
            // 
            this.regUN.Location = new System.Drawing.Point(476, 213);
            this.regUN.Name = "regUN";
            this.regUN.Size = new System.Drawing.Size(100, 23);
            this.regUN.TabIndex = 5;
            // 
            // regAddress
            // 
            this.regAddress.Location = new System.Drawing.Point(476, 173);
            this.regAddress.Name = "regAddress";
            this.regAddress.Size = new System.Drawing.Size(100, 23);
            this.regAddress.TabIndex = 6;
            // 
            // regPhone
            // 
            this.regPhone.Location = new System.Drawing.Point(476, 131);
            this.regPhone.Name = "regPhone";
            this.regPhone.Size = new System.Drawing.Size(100, 23);
            this.regPhone.TabIndex = 7;
            // 
            // regName
            // 
            this.regName.Location = new System.Drawing.Point(476, 87);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(100, 23);
            this.regName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.regPhone);
            this.Controls.Add(this.regAddress);
            this.Controls.Add(this.regUN);
            this.Controls.Add(this.regPass);
            this.Controls.Add(this.logInPass);
            this.Controls.Add(this.logInUN);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LogIn);
            this.Name = "SignForm";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignForm_FormClosing);
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.TextBox logInUN;
        private System.Windows.Forms.TextBox logInPass;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.TextBox regUN;
        private System.Windows.Forms.TextBox regAddress;
        private System.Windows.Forms.TextBox regPhone;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

