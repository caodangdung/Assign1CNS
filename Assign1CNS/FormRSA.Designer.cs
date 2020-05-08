namespace Assign1CNS
{
    partial class FormRSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRSA));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.cbkey = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbLoad = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbModulus = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenFile.Location = new System.Drawing.Point(880, 346);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(107, 35);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(880, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 75, 10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSize = true;
            this.btnOpenFolder.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.btnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenFolder.Location = new System.Drawing.Point(1007, 345);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(10, 73, 10, 10);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(131, 35);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // cbkey
            // 
            this.cbkey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkey.FormattingEnabled = true;
            this.cbkey.Items.AddRange(new object[] {
            "512bits",
            "1024bits",
            "2048bits",
            "4096bits"});
            this.cbkey.Location = new System.Drawing.Point(909, 158);
            this.cbkey.Margin = new System.Windows.Forms.Padding(15);
            this.cbkey.Name = "cbkey";
            this.cbkey.Size = new System.Drawing.Size(110, 24);
            this.cbkey.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(926, 493);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 35);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.AutoSize = true;
            this.btnExecute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExecute.BackgroundImage")));
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(762, 493);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(93, 35);
            this.btnExecute.TabIndex = 21;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // gbOption
            // 
            this.gbOption.AutoSize = true;
            this.gbOption.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.gbOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOption.Controls.Add(this.rbDecrypt);
            this.gbOption.Controls.Add(this.rbEncrypt);
            this.gbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOption.Location = new System.Drawing.Point(438, 455);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(298, 108);
            this.gbOption.TabIndex = 20;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.rbDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbDecrypt.Location = new System.Drawing.Point(195, 44);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(97, 29);
            this.rbDecrypt.TabIndex = 1;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.rbEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbEncrypt.Location = new System.Drawing.Point(19, 44);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(96, 29);
            this.rbEncrypt.TabIndex = 0;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(427, 679);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            this.lbMessage.TabIndex = 25;
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLoad.Image = global::Assign1CNS.Properties.Resources.bg;
            this.lbLoad.Location = new System.Drawing.Point(264, 623);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(139, 39);
            this.lbLoad.TabIndex = 24;
            this.lbLoad.Text = "Loading";
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(430, 627);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(376, 35);
            this.pbLoading.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::Assign1CNS.Properties.Resources.bg;
            this.label1.Location = new System.Drawing.Point(248, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = global::Assign1CNS.Properties.Resources.bg;
            this.label5.Location = new System.Drawing.Point(248, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modulus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::Assign1CNS.Properties.Resources.bg;
            this.label3.Location = new System.Drawing.Point(248, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Public Exponent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(248, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Private Exponent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(248, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(248, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output";
            // 
            // tbKey
            // 
            this.tbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbKey.Enabled = false;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(479, 156);
            this.tbKey.Margin = new System.Windows.Forms.Padding(15);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(376, 23);
            this.tbKey.TabIndex = 4;
            // 
            // tbModulus
            // 
            this.tbModulus.Enabled = false;
            this.tbModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModulus.Location = new System.Drawing.Point(479, 198);
            this.tbModulus.Margin = new System.Windows.Forms.Padding(15);
            this.tbModulus.Name = "tbModulus";
            this.tbModulus.Size = new System.Drawing.Size(376, 23);
            this.tbModulus.TabIndex = 14;
            // 
            // tbE
            // 
            this.tbE.Enabled = false;
            this.tbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbE.Location = new System.Drawing.Point(479, 246);
            this.tbE.Margin = new System.Windows.Forms.Padding(15);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(376, 23);
            this.tbE.TabIndex = 16;
            // 
            // tbD
            // 
            this.tbD.Enabled = false;
            this.tbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbD.Location = new System.Drawing.Point(479, 297);
            this.tbD.Margin = new System.Windows.Forms.Padding(15);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(376, 23);
            this.tbD.TabIndex = 18;
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(479, 350);
            this.tbInput.Margin = new System.Windows.Forms.Padding(15);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(376, 23);
            this.tbInput.TabIndex = 5;
            // 
            // tbOutput
            // 
            this.tbOutput.Enabled = false;
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(479, 404);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(15);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(376, 23);
            this.tbOutput.TabIndex = 7;
            // 
            // btnGen
            // 
            this.btnGen.AutoSize = true;
            this.btnGen.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.btnGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGen.Location = new System.Drawing.Point(1044, 156);
            this.btnGen.Margin = new System.Windows.Forms.Padding(10, 13, 10, 10);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(107, 35);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.ImageKey = "(none)";
            this.btnExit.Location = new System.Drawing.Point(1027, 627);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(456, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 78);
            this.label7.TabIndex = 28;
            this.label7.Text = "RSA ALGORITHM";
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assign1CNS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbModulus);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbkey);
            this.Name = "FormRSA";
            this.Text = "FormRSA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModulus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.ComboBox cbkey;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbLoad;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label7;
    }
}