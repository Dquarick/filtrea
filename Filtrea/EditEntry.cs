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
            /*for (int i = 0; i < lvCurOrder.Items.Count; ++i)
            {
                if (lvCurOrder.Items[i].Selected)
                {
                    lvCurOrder.Items[i].SubItems[0].Text = "EDITED";
                    lvCurOrder.Items[i].SubItems[1].Text = "99";
                    lvCurOrder.Items[i].SubItems[2].Text = "$69";
                }
                
            }
            */ 
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQty.Text = "";
            this.Close();
        }
    }
}
