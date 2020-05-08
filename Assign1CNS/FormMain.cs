using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign1CNS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            FormDES formDES = new FormDES();
            formDES.ShowDialog();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            FormHash formHash = new FormHash();
            formHash.ShowDialog();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            FormRSA formRSA = new FormRSA();
            formRSA.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
