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
    public partial class EditEntry : Form
    {
        public EditEntry()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtQty.Text != "")
                formMain.lvCurOrder.SelectedItems[0].SubItems[1].Text = txtQty.Text;
            if (txtPrice.Text != "")
                formMain.lvCurOrder.SelectedItems[0].SubItems[2].Text = "$ " + txtPrice.Text;
            Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQty.Text = "";
            Close();
        }
    }
}
