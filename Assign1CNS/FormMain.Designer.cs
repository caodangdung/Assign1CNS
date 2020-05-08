namespace Assign1CNS
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDES = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDES
            // 
            this.btnDES.BackgroundImage = global::Assign1CNS.Properties.Resources.des;
            this.btnDES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDES.Location = new System.Drawing.Point(336, 300);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(210, 170);
            this.btnDES.TabIndex = 0;
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnHash
            // 
            this.btnHash.AutoSize = true;
            this.btnHash.BackgroundImage = global::Assign1CNS.Properties.Resources.hashAlgorithm;
            this.btnHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHash.Location = new System.Drawing.Point(595, 492);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(210, 170);
            this.btnHash.TabIndex = 1;
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.BackgroundImage = global::Assign1CNS.Properties.Resources.rsa;
            this.btnRSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSA.Location = new System.Drawing.Point(815, 300);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(210, 170);
            this.btnRSA.TabIndex = 2;
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Assign1CNS.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(1117, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 170);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(256, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 152);
            this.label1.TabIndex = 4;
            this.label1.Text = "         WELCOME TO\r\nENCRYPT AND DECRYPT";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assign1CNS.Properties.Resources.encrypt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnDES);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

