namespace WinFormsApp1
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
            this.UsernameLOG = new System.Windows.Forms.TextBox();
            this.PasswordLOG = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLOG
            // 
            this.UsernameLOG.Location = new System.Drawing.Point(113, 75);
            this.UsernameLOG.Name = "UsernameLOG";
            this.UsernameLOG.Size = new System.Drawing.Size(125, 27);
            this.UsernameLOG.TabIndex = 0;
            // 
            // PasswordLOG
            // 
            this.PasswordLOG.Location = new System.Drawing.Point(113, 137);
            this.PasswordLOG.Name = "PasswordLOG";
            this.PasswordLOG.PasswordChar = '*';
            this.PasswordLOG.Size = new System.Drawing.Size(125, 27);
            this.PasswordLOG.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(63, 187);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(94, 29);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(201, 187);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(94, 29);
            this.SignUp.TabIndex = 3;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.PasswordLOG);
            this.Controls.Add(this.UsernameLOG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox UsernameLOG;
        private TextBox PasswordLOG;
        private Button login;
        private Button SignUp;
        private Label label1;
        private Label label2;
    }
}