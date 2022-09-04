namespace WinFormsApp1
{
    partial class Form2
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
            this.username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameSignUp = new System.Windows.Forms.TextBox();
            this.PasswordSignUp = new System.Windows.Forms.TextBox();
            this.PasswordRepeat = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailAD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(48, 110);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(48, 143);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repeat Password";
            // 
            // UsernameSignUp
            // 
            this.UsernameSignUp.Location = new System.Drawing.Point(198, 107);
            this.UsernameSignUp.Name = "UsernameSignUp";
            this.UsernameSignUp.Size = new System.Drawing.Size(125, 27);
            this.UsernameSignUp.TabIndex = 3;
            // 
            // PasswordSignUp
            // 
            this.PasswordSignUp.Location = new System.Drawing.Point(198, 140);
            this.PasswordSignUp.Name = "PasswordSignUp";
            this.PasswordSignUp.PasswordChar = '*';
            this.PasswordSignUp.Size = new System.Drawing.Size(125, 27);
            this.PasswordSignUp.TabIndex = 4;
            // 
            // PasswordRepeat
            // 
            this.PasswordRepeat.Location = new System.Drawing.Point(198, 173);
            this.PasswordRepeat.Name = "PasswordRepeat";
            this.PasswordRepeat.PasswordChar = '*';
            this.PasswordRepeat.Size = new System.Drawing.Size(125, 27);
            this.PasswordRepeat.TabIndex = 5;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(198, 299);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(94, 29);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // emailAD
            // 
            this.emailAD.AutoSize = true;
            this.emailAD.Location = new System.Drawing.Point(48, 77);
            this.emailAD.Name = "emailAD";
            this.emailAD.Size = new System.Drawing.Size(101, 20);
            this.emailAD.TabIndex = 8;
            this.emailAD.Text = "Email address";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.emailAD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.PasswordRepeat);
            this.Controls.Add(this.PasswordSignUp);
            this.Controls.Add(this.UsernameSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username;
        private Label Password;
        private Label label1;
        private TextBox UsernameSignUp;
        private TextBox PasswordSignUp;
        private TextBox PasswordRepeat;
        private Button SignUp;
        private TextBox textBox1;
        private Label emailAD;
    }
}