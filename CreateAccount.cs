using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Password_Manager
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxPassword2.Text)
            {
                if (!File.Exists("users.txt"))
                {
                    using (StreamWriter sw = File.CreateText("users.txt"))
                    {

                        sw.WriteLine(hash(textBoxUsername.Text));
                        sw.WriteLine(hash(textBoxPassword.Text));
                    }
                }
                else
                {

                    bool found = false;
                    using (StreamReader sr = File.OpenText("users.txt"))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            if(s == hash(textBoxUsername.Text))
                            {
                                found = true;
                            }
                            //skip password line
                            sr.ReadLine();
                        }
                    }


                    if (found == false)
                    {
                        using (StreamWriter sw = File.AppendText("users.txt"))
                        {
                            sw.WriteLine(hash(textBoxUsername.Text));
                            sw.WriteLine(hash(textBoxPassword.Text));
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account with that username already exists");
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
