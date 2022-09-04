using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace WinFormsApp1

{
    public class Login {
        public static string username = "";
    }
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {   
            //existující user
            if (UsernameLOG.Text == string.Empty ) {
                MessageBox.Show("PLease enter valid username");
                return;
            }           
            if (PasswordLOG.Text == string.Empty)
            {
                MessageBox.Show("PLease enter password");
                return;
            }
            string password = PasswordLOG.Text;
            string username = UsernameLOG.Text;

            try
            {
                

                string[] lines = System.IO.File.ReadAllLines($"Login_{username}.txt");
                if (lines[0] == username & lines[1] == password)
                {
                    //proceed
                    Login.username = username;
                    Email emailSender = new Email();
                    emailSender.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Password incorrect");
                }
            }
            catch (System.IO.FileNotFoundException) {
                MessageBox.Show("Account does not exist");
            }
            
            
            //check password
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form2 SignUpF = new Form2();
            SignUpF.ShowDialog();
        }
    }
}