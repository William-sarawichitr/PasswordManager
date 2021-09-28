using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Manager;
using System.IO;
using static Password_Manager.Program;

namespace Password_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string userHash = hash(textBoxUsername.Text);

            if (!File.Exists("users.txt"))
            {
                using (StreamWriter sw = File.CreateText("users.txt"))
                {
                }
            }
            else
            {
                using (StreamReader sr = File.OpenText("users.txt"))
                {
                    string s = "";
                    bool found = false;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s == hash(textBoxUsername.Text))
                        {
                            found = true;
                            string p = sr.ReadLine();
                            if (p == hash(textBoxPassword.Text))
                            {
                                Globals.USER = textBoxUsername.Text;
                                Globals.USERHASH = hash(textBoxUsername.Text);
                                Program.OpenDetailFormOnClose = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                            }
                        }

                        //skip password line
                        sr.ReadLine();
                    }
                    
                    if (found == false)
                    {
                        MessageBox.Show("Account with that name does not exist");
                    }
                }
            }

        }
        static string hash(string sSourceData)
        {
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

           return ByteArrayToString(tmpHash);
        }
        static string ByteArrayToString(byte[] arrInput)
        {
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (int i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }
    }
}
