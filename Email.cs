using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.IO;
using System.Drawing.Text;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        public void Form1(string username) { 
            InitializeComponent();
        }
        public void SendBT_Click(object sender, EventArgs e)
        {

            string password;
            string emailAD;
            //načte login údaje
            string filename = @$"Login_{Login.username}.txt";
            string text = File.ReadAllText(filename);
            string[] read = text.Split(Environment.NewLine);
            password = read[1];
            emailAD = read[2];
            //zkontroluje správné zadání domény
            string [] domanai = SendToTB.Text.Split("@");
            if (domanai.Length < 2)
            {
                MessageBox.Show("Invalid Email adress", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //vyhledá jestli host existuje
            string damain = domanai[1];
            try
            {
                var ips = System.Net.Dns.GetHostEntry(damain).AddressList;
            }
            catch (System.Net.Sockets.SocketException asd)
            {
                MessageBox.Show("Domain not found" + asd, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            //spustí Smtp client
            var smtpClient = new SmtpClient("smtp-mail.outlook.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(emailAD, password),
                EnableSsl = true,
            };
            //pokusí se odeslat email
            try
            {

                smtpClient.Send(emailAD, SendToTB.Text, SubjTB.Text, richTextBox1.Text);
                MessageBox.Show("email sent");
            }
            catch (SmtpException err)
            {
                MessageBox.Show(String.Format("{0}", err.StatusCode));
            }
            catch (Exception err)
            {
                MessageBox.Show(String.Format("{0}", err.Message));
            }
        }
    }
}
