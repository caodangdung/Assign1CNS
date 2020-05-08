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


namespace Assign1CNS
{
    public partial class FormHash : Form
    {

        public FormHash()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            if (cbInput.Text == "")
            {
                MessageBox.Show("Option of input is empty!");
                return;
            }
            if (tbInput.Text == "")
            {
                MessageBox.Show("Input is empty!");
                return;
            }

            if (cbHash.Text == "")
            {
                MessageBox.Show("Hash algorithm is empty!");
                return;
            }

            if (cbOption.Text == "")
            {
                MessageBox.Show("Option is empty!");
                return;
            }

            if (cbOption.Text == "Compare with other file or text" && tbCompare.Text == "")
            {
                MessageBox.Show("Compare is empty!");
                return;
            }
         
            if (cbInput.Text == "Text")
            {
                hashText();
            }
            else
            {
                String txt = tbInput.Text;
                if (!File.Exists(txt))
                {
                    MessageBox.Show("The input file does not exist!");
                    return;
                }

                if (cbHash.Text=="MD5")
                {
                    tbOutput.Text = hashFile(tbInput.Text, new MD5CryptoServiceProvider());
                }
                else
                {
                    tbOutput.Text = hashFile(tbInput.Text, new SHA1Managed());
                }
               
            }

            if (cbOption.Text== "Compare with other file or text" && tbOutput.Text==tbCompare.Text)
            {
                MessageBox.Show("Match!");
            }
            else if (cbOption.Text == "Compare with other file or text" && tbOutput.Text != tbCompare.Text)
            {
                MessageBox.Show("Don't match!");
            }
           
        }

        private void hashText()
        {
            var inputBytes = Encoding.ASCII.GetBytes(tbInput.Text);
            byte[] hashBytes;

            if (cbHash.Text=="MD5")
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                hashBytes = md5.ComputeHash(inputBytes);
            }
            else
            {
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                hashBytes = sha1.ComputeHash(inputBytes);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }

            tbOutput.Text = stringBuilder.ToString();
        }

        private string hashFile(string fileName,HashAlgorithm hashAlgorithm)
        {
            using (var stream = File.OpenRead(fileName))
            {
                return BitConverter.ToString(hashAlgorithm.ComputeHash(stream)).Replace("-", "");
            }
        }

        private void btnOpenInput_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.tbInput.Text = openFile.FileName;
            }
        }

        //private void btnOpenCompare_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    openFile.Filter = "All Files (*.*)|*.*";
        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        this.tbInput.Text = openFile.FileName;
        //    }
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
            cbInput.Text = "";
            cbHash.Text = "";
            cbOption.Text = "";
            tbCompare.Text = "";
            tbOutput.Text = "";
            MessageBox.Show("Reset successful!");
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInput.Text=="File")
            {
                this.btnOpenInput.Enabled = true;
               
            }
            else
            {
                this.btnOpenInput.Enabled = false;
                
            }
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption.Text== "Compare with other file or text")
            {
                this.tbCompare.Enabled = true;
            }
            else
            {
                this.tbCompare.Enabled = false;
            }
        }
    }
}
