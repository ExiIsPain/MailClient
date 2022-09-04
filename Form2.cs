using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            //vytvoří účet a uloží ho do .txt pokud jsou obě hesla shodná
            string username = UsernameSignUp.Text;
            string password = PasswordSignUp.Text;
            string password2 = PasswordRepeat.Text;
            string emailAD = textBox1.Text;
            switch (password2 == password)
            {
                 case true:
                    var pathWithEnv = @$"Login_{username}.txt";
                    var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
                    TextWriter saveID = new StreamWriter(filePath);
                    saveID.WriteLine(username);
                    saveID.WriteLine(password);
                    saveID.WriteLine(emailAD);
                    saveID.Close();
                    DialogResult dialogOK = MessageBox.Show("Account created.");
                    if (dialogOK == DialogResult.OK)
                    {
                        this.Close();
                    }
                    break;

                  case false:
                    MessageBox.Show("Password does not match.");
                    break;
            }
            
        }
    }
}
