namespace Assign1CNS
{
    partial class FormHash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHash));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbHash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.cbHash = new System.Windows.Forms.ComboBox();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.tbCompare = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Assign1CNS.Properties.Resources.bgHash;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.lbInput);
            this.flowLayoutPanel1.Controls.Add(this.lbHash);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lbOutput);
            this.flowLayoutPanel1.Controls.Add(this.tbInput);
            this.flowLayoutPanel1.Controls.Add(this.cbHash);
            this.flowLayoutPanel1.Controls.Add(this.cbOption);
            this.flowLayoutPanel1.Controls.Add(this.tbCompare);
            this.flowLayoutPanel1.Controls.Add(this.tbOutput);
            this.flowLayoutPanel1.Controls.Add(this.cbInput);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 328);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbInput.Image = ((System.Drawing.Image)(resources.GetObject("lbInput.Image")));
            this.lbInput.Location = new System.Drawing.Point(10, 10);
            this.lbInput.Margin = new System.Windows.Forms.Padding(10);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(93, 39);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "Input";
            // 
            // lbHash
            // 
            this.lbHash.AutoSize = true;
            this.lbHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHash.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbHash.Image = ((System.Drawing.Image)(resources.GetObject("lbHash.Image")));
            this.lbHash.Location = new System.Drawing.Point(10, 69);
            this.lbHash.Margin = new System.Windows.Forms.Padding(10);
            this.lbHash.Name = "lbHash";
            this.lbHash.Size = new System.Drawing.Size(250, 39);
            this.lbHash.TabIndex = 1;
            this.lbHash.Text = "Hash Algorithm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Option";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(10, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compare with";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbOutput.Image = ((System.Drawing.Image)(resources.GetObject("lbOutput.Image")));
            this.lbOutput.Location = new System.Drawing.Point(10, 246);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(10);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(118, 39);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "Output";
            // 
            // tbInput
            // 
            this.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(285, 15);
            this.tbInput.Margin = new System.Windows.Forms.Padding(15);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(545, 30);
            this.tbInput.TabIndex = 4;
            // 
            // cbHash
            // 
            this.cbHash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHash.FormattingEnabled = true;
            this.cbHash.Items.AddRange(new object[] {
            "MD5",
            "SHA1"});
            this.cbHash.Location = new System.Drawing.Point(285, 75);
            this.cbHash.Margin = new System.Windows.Forms.Padding(15);
            this.cbHash.Name = "cbHash";
            this.cbHash.Size = new System.Drawing.Size(545, 33);
            this.cbHash.TabIndex = 11;
            // 
            // cbOption
            // 
            this.cbOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            "Compare with other file or text",
            "Generate file or text code"});
            this.cbOption.Location = new System.Drawing.Point(285, 138);
            this.cbOption.Margin = new System.Windows.Forms.Padding(15);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(545, 33);
            this.cbOption.TabIndex = 15;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // tbCompare
            // 
            this.tbCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompare.Location = new System.Drawing.Point(285, 201);
            this.tbCompare.Margin = new System.Windows.Forms.Padding(15);
            this.tbCompare.Name = "tbCompare";
            this.tbCompare.Size = new System.Drawing.Size(545, 30);
            this.tbCompare.TabIndex = 5;
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(285, 261);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(15);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(545, 30);
            this.tbOutput.TabIndex = 7;
            // 
            // cbInput
            // 
            this.cbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Items.AddRange(new object[] {
            "Text",
            "File"});
            this.cbInput.Location = new System.Drawing.Point(860, 15);
            this.cbInput.Margin = new System.Windows.Forms.Padding(15);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(110, 33);
            this.cbInput.TabIndex = 12;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.AutoSize = true;
            this.btnExecute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExecute.BackgroundImage")));
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnExecute.Location = new System.Drawing.Point(384, 457);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(93, 35);
            this.btnExecute.TabIndex = 17;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnReset.Location = new System.Drawing.Point(716, 457);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 35);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnExit.Location = new System.Drawing.Point(910, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenInput
            // 
            this.btnOpenInput.AutoSize = true;
            this.btnOpenInput.BackgroundImage = global::Assign1CNS.Properties.Resources.bgHash;
            this.btnOpenInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInput.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpenInput.Location = new System.Drawing.Point(1005, 130);
            this.btnOpenInput.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnOpenInput.Name = "btnOpenInput";
            this.btnOpenInput.Size = new System.Drawing.Size(107, 35);
            this.btnOpenInput.TabIndex = 17;
            this.btnOpenInput.Text = "Open File";
            this.btnOpenInput.UseVisualStyleBackColor = true;
            this.btnOpenInput.Click += new System.EventHandler(this.btnOpenInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(373, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 78);
            this.label2.TabIndex = 20;
            this.label2.Text = "HASH ALGORITHM";
            // 
            // FormHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assign1CNS.Properties.Resources.bgHash3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnOpenInput);
            this.Name = "FormHash";
            this.Text = "FormHash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbCompare;
        private System.Windows.Forms.ComboBox cbHash;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenInput;
        private System.Windows.Forms.Label label2;
    }
}