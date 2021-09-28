using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using static Password_Manager.Program;
using System.Xml.Serialization;

namespace Password_Manager
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();

            //RsaEncryption rsa = new RsaEncryption();

            string path = Globals.USERHASH + ".txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        string service = Decrypt(s);
                        var username = Decrypt(sr.ReadLine());
                        sr.ReadLine();
                        ListViewItem item = new ListViewItem(service);
                        item.SubItems.Add(username);
                        listCredentials.Items.Add(item);
                    }
                }
            }
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxPassword2.Text)
            {
                string path = Globals.USERHASH + ".txt";
                if(!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        //RsaEncryption rsa = new RsaEncryption();
                        sw.WriteLine(Encrypt(textBoxService.Text));
                        sw.WriteLine(Encrypt(textBoxUsername.Text));
                        sw.WriteLine(Encrypt(textBoxPassword.Text));
                        /*
                        sw.WriteLine(textBoxService.Text);
                        sw.WriteLine(textBoxUsername.Text);
                        sw.WriteLine(textBoxPassword.Text);
                        */

                        ListViewItem item = new ListViewItem(textBoxService.Text);
                        item.SubItems.Add(textBoxUsername.Text);
                        listCredentials.Items.Add(item);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(textBoxService.Text);
                        sw.WriteLine(textBoxUsername.Text);
                        sw.WriteLine(textBoxPassword.Text);

                        ListViewItem item = new ListViewItem(textBoxService.Text);
                        item.SubItems.Add(textBoxUsername.Text);
                        listCredentials.Items.Add(item);
                    }
                }
                textBoxService.Text = "";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxPassword2.Text = "";
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        public static string Encrypt(string text)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Globals.USERHASH));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string Decrypt(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Globals.USERHASH));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void PasswordManager_Load(object sender, EventArgs e)
        {

        }
    }
    /*
    public class RsaEncryption
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(1024);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }

        public string GetPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();
        }

        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privateKey);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }
    }
    */
}
