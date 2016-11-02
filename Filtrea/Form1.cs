using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel; 

namespace Filtrea
{
    public partial class formMain : Form
    {

        //Global storage for elements of the total cost
        double channelCost = 0;
        double mediaCost = 0;
        double hardwareCost = 0;
        double shippingCost = 0;

        //Global storage for infile paths
        string customerListPath = "";
        string pricingChartPath = "";

        //Global Storage for outfile paths
        string ledgerPath = "";
      
        public formMain()
        {
            InitializeComponent();
            
        }

        private void clearFields ()
        {

            cbAlum.Checked = false;
            cbCarb.Checked = false;
            cbLens.Checked = false;
            cbPT.Checked = false;
            cbTS.Checked = false;
            cbMB.Checked = false;
            cbGrom.Checked = false;
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtQty.Text = "";
            cboxChannel.Text = "";
        }
        
        private void deleteEntry()
        {
            for (int i = 0; i < lvCurOrder.Items.Count; i++)
            {
                if (lvCurOrder.Items[i].Selected)
                {
                    lvCurOrder.Items[i].Remove();
                    i--;
                }
            }
        }

        private void iniCustomerList()
        {
            
            //iterates each worksheet in workbook found at path C:\...
            foreach (var worksheet in Workbook.Worksheets(@"C:\Users\Dave\Desktop\customerList.xlsx"))
            {
                //iterates row by row
                foreach (var row in worksheet.Rows)
                {

                    if (row.Cells[1].Text != "Client Name")
                        cboxCustomer.Items.Add(row.Cells[1].Text);
                }
            }
        }

        private void hideHardwareQtys()
        {

            txtPtQty.Hide();
            txtTsQty.Hide();
            txtGromQty.Hide();
            txtMbQty.Hide();
        }

        //Actions performed upon opening of the app
        private void formMain_Load(object sender, EventArgs e)
        {

            //Populates Combobox with the current customer list
            iniCustomerList();
            hideHardwareQtys();

        }

        //How can I get rid of this without Designer getting its panties wadded?
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
       {

        }

        //Adds a product's specs, qty, and price to the current order
        private void btnAdd2Order_Click(object sender, EventArgs e)
        {
            //Container for specification information
            string[] record = {"", "", ""};

            //Adding channel dimensions to entry
            record[0] = cboxChannel.Text + " "; 

            //Checking for media type

            //Aluminium
            if (cbAlum.Checked && !cbCarb.Checked && !cbLens.Checked)
            {
                record[0] += "Aluminium ";
            }

            //Carbon
            if (cbCarb.Checked && !cbAlum.Checked && !cbLens.Checked)
            {
                record[0] += "Carbon ";
            }

            //Aluminium Carbon
            if (cbAlum.Checked && cbCarb.Checked && !cbLens.Checked)
            {
                record[0] += "Aluminium Carbon ";
            }

            //Aluminium Lens
            if (cbAlum.Checked && !cbCarb.Checked && cbLens.Checked)
            {
                record[0] += "Aluminium Lens ";
            }

            //Carbon Lens 
            if (!cbAlum.Checked && cbCarb.Checked && cbLens.Checked)
            {
                record[0] += "Carbon Lens ";
            }

            //Aluminium Caron Lens
            if (cbAlum.Checked && cbCarb.Checked && cbLens.Checked)
            {
                record[0] += "Aluminium Carbon Lens ";
            }

            //Adding dimensions to entry
            record[0] += txtWidth.Text + " X " + txtHeight.Text;

            //Checking for hardware
            if (cbPT.Checked)
            {
                record[0] += " PT";
            }

            if (cbTS.Checked)
            {
                record[0] += " TS";
            }

            if (cbMB.Checked)
            {
                record[0] += " MB";
            }

            if (cbGrom.Checked)
            {
                record[0] += " Grom";
            }

            //Adding the quantity to entry
            record[1] += txtQty.Text;

            //Reading in cost calculating price and adding it to entry

            record[2] = "$" + (channelCost + mediaCost + hardwareCost).ToString();

            
            //allocating for and adding new entry to listview 
            ListViewItem lvi = new ListViewItem(record);
            lvCurOrder.Items.Add(lvi);
        }

        //Clears fields for entry of an additional product
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //Deletes the selected entry from the current order
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteEntry();
        }

        /*Prints material prep instructions, fab diagram, package label, 
        shipping label, invoice, enters transaction into ledger*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            /* string exMessage = "";

            try
            {
                if (cboxCustomer.Text == "")
                {
                    exMessage += "- Must select a customer before printing order.";

                }

                if (lvCurOrder.Items.Count == 0)
                {
                    exMessage += "\n- There must be items in the order to print the order.";
                }
            }

            catch (Exception printEx)
            {

            }
       
    */ 
        }

        //Initiates a new customer order
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            lvCurOrder.Items.Clear();
            clearFields();
            cboxCustomer.Text = "";
        }

        //Allows an order entry to be edited
        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvCurOrder.Items.Count; ++i)
            {
                if (lvCurOrder.Items[i].Selected)
                {
                    lvCurOrder.Items[i].SubItems[0].Text = "EDITED";
                    lvCurOrder.Items[i].SubItems[1].Text = "99";
                    lvCurOrder.Items[i].SubItems[2].Text = "$69";
                }
            }
        }

        //Show quantity text boxes for hardware if checks are selected
        private void cbPT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPT.Checked)
            {
                txtPtQty.Show();
            }

            if (!cbPT.Checked)
            {
                txtPtQty.Hide();
                txtPtQty.Text = "";
            }
        }

        private void cbTS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTS.Checked)
            {
                txtTsQty.Show();
            }

            if (!cbTS.Checked)
            {
                txtTsQty.Hide();
                txtTsQty.Text = "";
            }
        }

        private void cbMB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMB.Checked)
            {
                txtMbQty.Show();
            }

            if (!cbMB.Checked)
            {
                txtMbQty.Hide();
                txtMbQty.Text = "";
            }
        }

        private void cbGrom_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGrom.Checked)
            {
                txtGromQty.Show();
            }

            if (!cbGrom.Checked)
            {
                txtGromQty.Hide();
                txtGromQty.Text = "";
            }
        }

        //Exiting from the "File" Menu Item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Allows users to select input files for cost and customers
        private void inputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        //Allows users to select output files for ledger
        private void outputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
