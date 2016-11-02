using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrea
{
    public partial class inputPreferenceForm : Form
    {
        public inputPreferenceForm()
        {
            InitializeComponent();
        }

        //Allows the user to select an input file with a customer list
        private void btnCustomerFile_Click(object sender, EventArgs e)
        {
            inputFileDialog.ShowDialog();
        }

        private void btnCostFile_Click(object sender, EventArgs e)
        {
            inputFileDialog.ShowDialog();
        }
    }
}
