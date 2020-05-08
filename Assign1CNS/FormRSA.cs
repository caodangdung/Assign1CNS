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
using System.Xml;
using System.Diagnostics;

namespace Assign1CNS
{
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
        }

        private string pathKeyXML = "";
        private bool isFile = true;
        private string inputFile, outputFile;
        private string isOption = "";

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                int keyLength = 0;
                string txtKey = cbkey.Text;
                switch (txtKey)
                {
                    case "512bits":
                        {
                            keyLength = 512;
                            break;
                        }
                    case "1024bits":
                        {
                            keyLength = 1024;
                            break;
                        }
                    case "2048bits":
                        {
                            keyLength = 2048;
                            break;
                        }
                    case "4096bits":
                        {
                            keyLength = 4096;
                            break;
                        }
                    default:
                        break;
                }

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keyLength);

                string pathKey = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "key.xml");

                File.WriteAllText(pathKey, rsa.ToXmlString(true));

                pathKeyXML = pathKey;
                tbKey.Text = pathKey;

                if (File.Exists(pathKeyXML))
                {
                    if (Path.GetExtension(pathKeyXML) == ".xml")
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(File.ReadAllText(pathKeyXML));
                        try
                        {
                            XmlNode xmlNode = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                            tbModulus.Text = xmlNode.InnerText;
                            xmlNode = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                            tbE.Text = xmlNode.InnerText;
                            xmlNode = xml.SelectSingleNode("/RSAKeyValue/D");
                            tbD.Text = xmlNode.InnerText;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed : " + ex.Message);
                        }
                    }
                }
                MessageBox.Show("Generate key successfully with length! " + keyLength.ToString() + " bits.\nPath: " + pathKeyXML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message);
            }


        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.tbInput.Text = openFile.FileName;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            this.isFile = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
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

        private void executeRsaAlgorithm(RSAParameters parametersRSA, string inputFile, string outputFile, string isOption)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                fsOutput.SetLength(0);

                long totlen = fsInput.Length;
                int numberBytesRead, len;
                byte[] bin, encryptedData;
                long rdlen = 0;

                pbLoading.Minimum = 0;
                pbLoading.Maximum = 100;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(parametersRSA);


                if (isOption == "Encrypt")
                {
                    numberBytesRead = ((rsa.KeySize - 384) / 8) + 37;
                }

                else
                {
                    numberBytesRead = rsa.KeySize / 8;
                }

                while (rdlen < totlen)
                {

                    bin = new byte[numberBytesRead];
                    len = fsInput.Read(bin, 0, numberBytesRead);

                    if (isOption == "Encrypt")
                    {
                        encryptedData = rsa.Encrypt(bin, false);
                    }
                    else
                    {
                        encryptedData = rsa.Decrypt(bin, false);
                    }


                    fsOutput.Write(encryptedData, 0, encryptedData.Length);
                    rdlen = rdlen + len;


                    string txtResult = "Filename is processing : " + Path.GetFileName(inputFile) + "\n Success: " + ((long)(rdlen * 100) / totlen).ToString() + " %";
                    this.lbMessage.Text = txtResult;
                    this.lbMessage.Refresh();
                    pbLoading.Value = (int)((rdlen * 100) / totlen);
                }
                fsOutput.Close();
                fsInput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.isFile = true;
            this.tbKey.Clear();
            this.tbModulus.Clear();
            this.tbE.Clear();
            this.tbD.Clear();
            this.tbInput.Clear();
            this.tbOutput.Clear();
            this.pathKeyXML = "";
            this.cbkey.Text = "";
            this.isOption = "";
            if (this.pbLoading.Value > 0)
            {
                this.pbLoading.Value = 0;
            }

            MessageBox.Show("Reset successful!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                string tailEncrypt = ".encrypt";

                this.inputFile = tbInput.Text;
                this.outputFile = tbOutput.Text;

                if (cbkey.Text == "")
                {
                    MessageBox.Show("Option of key is empty!");
                    return;
                }

                if (tbKey.Text == "")
                {
                    MessageBox.Show("Key is empty!");
                    return;
                }

                if (inputFile == "")
                {
                    MessageBox.Show("The input is empty!");
                    return;
                }

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

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(File.ReadAllText(pathKeyXML));

                if (isFile)
                {
                    string[] output = tbInput.Text.Split('.');
                    int outputLenght = output.Length;
                    if (isOption == "Encrypt")
                    {
                        this.outputFile = tbOutput.Text + "." + output[outputLenght - 1] + tailEncrypt;
                        executeRsaAlgorithm(rsa.ExportParameters(true), inputFile, outputFile, isOption);
                    }
                    else
                    {
                        this.outputFile = tbOutput.Text + "." + output[outputLenght - 2];
                        executeRsaAlgorithm(rsa.ExportParameters(true), inputFile, outputFile, isOption);
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
                            executeRsaAlgorithm(rsa.ExportParameters(true), filePaths[i], outputFile, isOption);
                        }
                        else
                        {
                            string pathFileName = Path.GetFileName(filePaths[i]);
                            if (pathFileName.LastIndexOf(tailEncrypt) != -1)
                            {
                                int fileNameLength = pathFileName.Length - tailEncrypt.Length;
                                this.outputFile = tbOutput.Text + "\\" + pathFileName.Substring(0, fileNameLength);
                                executeRsaAlgorithm(rsa.ExportParameters(true), filePaths[i], outputFile, isOption);
                            }
                        }

                    }
                }
                sw.Stop();
                double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                MessageBox.Show("Done!" + "\nThe total time the program has executed : " + elapsedMs.ToString() + " s");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed:" + ex.Message);
            }

        }
    }
}
