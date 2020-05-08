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
using System.Diagnostics;

namespace Assign1CNS
{
    public partial class FormDES : Form
    {
        public FormDES()
        {
            InitializeComponent();
        }

        private string inputFile, outputFile;
        private string key, mode;
        private bool isFile = true;
        private string isOption;

        private void btnGen_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            tbKey.Text = Convert.ToBase64String(des.Key);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.tbInput.Text = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFile)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "All Files (*.*)|*.*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    this.tbOutput.Text = saveFile.FileName;
                }
            }
            else
            {
                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    this.tbOutput.Text = folderBrowserDialog2.SelectedPath;
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.isFile = true;
            this.tbKey.Clear();
            this.tbInput.Clear();
            this.tbOutput.Clear();
            this.cbMode.Text = "";
            this.inputFile = "";
            this.outputFile = "";
            this.isOption = "";
            if (this.pbLoading.Value > 0)
            {
                this.pbLoading.Value = 0;
            }
            MessageBox.Show("Reset successful!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            this.isFile = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
            }

        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                string txtMode = cbMode.Text;
                string tailEncrypt = ".encrypt";

                this.key = tbKey.Text;
                this.inputFile = tbInput.Text;
                this.outputFile = tbOutput.Text;
                this.mode = cbMode.Text;


                if (key.Length < 8)
                {
                    MessageBox.Show("Please enter the key lenght must be greater than or equal to 8!");
                    return;
                }
                //if (isFile)
                //{
                //    if (!File.Exists(inputFile))
                //    {
                //        MessageBox.Show("The input file does not exist!");
                //        return;
                //    }
                //}
                //else
                //{
                //    if (!Directory.Exists(inputFile))
                //    {
                //        MessageBox.Show("The input folder does not exist!");
                //        return;
                //    }
                //}
                if (inputFile == "")
                {
                    MessageBox.Show("The input is empty!");
                    return;
                }
                if (txtMode == "")
                {
                    MessageBox.Show("The mode is not selected");
                    return;
                }

                //if (isFile)
                //{
                //    if (!File.Exists(outputFile))
                //    {
                //        MessageBox.Show("The output file does not exist!");
                //        return;
                //    }
                //}
                //else
                //{
                //    if (!Directory.Exists(outputFile))
                //    {
                //        MessageBox.Show("The output folder does not exist!");
                //        return;
                //    }
                //}

                if (outputFile == "")
                {
                    MessageBox.Show("The output is empty!");
                    return;
                }


                foreach (RadioButton item in gbOption.Controls)
                {
                    if (item.Checked)
                    {
                        isOption = item.Text;
                        break;
                    }
                }

                if (isOption == "")
                {
                    MessageBox.Show("The option is not selected!");
                    return;
                }

                if (isFile)
                {
                    string[] output = tbInput.Text.Split('.');
                    int outputLenght = output.Length;
                    if (isOption == "Encrypt")
                    {
                        this.outputFile = tbOutput.Text + "." + output[outputLenght - 1] + tailEncrypt;
                        executeDesAlgorithm(key, mode, inputFile, outputFile, isOption);
                    }
                    else
                    {
                        this.outputFile = tbOutput.Text + "." + output[outputLenght - 2];
                        executeDesAlgorithm(key, mode, inputFile, outputFile, isOption);
                    }
                }
                else
                {

                    string[] filePaths = Directory.GetFiles(inputFile, "*", SearchOption.AllDirectories);

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("Folder is empty!");
                        return;
                    }

                    for (int i = 0; i < filePaths.Length; i++)
                    {

                        if (isOption == "Encrypt")
                        {
                            this.outputFile = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i]) + tailEncrypt;
                            executeDesAlgorithm(key, mode, filePaths[i], outputFile, isOption);
                        }
                        else
                        {
                            string pathFileName = Path.GetFileName(filePaths[i]);
                            if (pathFileName.LastIndexOf(tailEncrypt) != -1)
                            {
                                int fileNameLength = pathFileName.Length - tailEncrypt.Length;
                                this.outputFile = tbOutput.Text + "\\" + pathFileName.Substring(0, fileNameLength);
                                executeDesAlgorithm(key, mode, filePaths[i], outputFile, isOption);
                            }
                        }

                    }

                }
                sw.Stop();
                double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                MessageBox.Show("Done!"+"\nThe total time the program has executed : " + elapsedMs.ToString() + " s");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed:" + ex.Message);
            }
            
        }

        private void executeDesAlgorithm(string key, string mode, string inputFile, string outputFile, string isOption)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(key);


                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fsOutput = new FileStream(outputFile, FileMode.OpenOrCreate, FileAccess.Write);
                fsOutput.SetLength(0);

                long totlen = fsInput.Length;
                int numberBytesRead = 10485760, len;
                byte[] bin = new byte[numberBytesRead];
                long rdlen = 0;

                pbLoading.Minimum = 0;
                pbLoading.Maximum = 100;


                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                if (mode == "ECB")
                {
                    des.Mode = CipherMode.ECB;
                }
                else if (mode == "CBC")
                {
                    des.Mode = CipherMode.CBC;
                }
                else if (mode == "CFB")
                {
                    des.Mode = CipherMode.CFB;
                }



                CryptoStream enStream;

                if (isOption == "Encrypt")
                {
                    enStream = new CryptoStream(fsOutput, des.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
                }
                else
                {
                    enStream = new CryptoStream(fsOutput, des.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
                }

                while (rdlen < totlen)
                {
                    len = fsInput.Read(bin, 0, numberBytesRead);
                    enStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                    string txtResult = "Filename is processing : " + Path.GetFileName(inputFile) + "\n Success: " + ((long)(rdlen * 100) / totlen).ToString() + " %";
                    this.lbMessage.Text = txtResult;
                    this.lbMessage.Refresh();
                    pbLoading.Value = (int)((rdlen * 100) / totlen);
                }
                enStream.Close();
                fsOutput.Close();
                fsInput.Close();            
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed : " + e.Message);
            }
        }
    }
}
