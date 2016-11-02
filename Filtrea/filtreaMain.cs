using System; //access to the OS
using System.Windows.Forms; //Windows controls and forms
using Excel; //reading .xslx files
using System.Collections.Generic; //lists

namespace Filtrea
{

    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        /*FUNCTIONS RUNNING AT PROCESS START*/
        
        //following three functions initialize containers by reading data in .xlsx files
        private void iniCustomerList()
        {
            foreach (var worksheet in Workbook.Worksheets(@"C:\Users\Dave Quarick\Desktop\cs\Filtrea\clientList.xlsx"))
            {
                foreach (var row in worksheet.Rows)
                {
                    if (row.Cells[0].Text != "Client Name")
                        cboxCustomer.Items.Add(row.Cells[0].Text);
                }
            }
        }

        List<Component> mediaHardware = new List<Component>();
        private void iniMediaList(ref List<Component> hardware)
        {
            foreach (var worksheet in Workbook.Worksheets(@"C:\Users\Dave Quarick\Desktop\cs\Filtrea\mediaList.xlsx"))
            {
                foreach (var row in worksheet.Rows)
                {
                    if (row.Cells[0].Text != "Component")
                    {
                        Component productPart = new Component();

                        productPart.setName(row.Cells[0].Text);
                        productPart.setCost(double.Parse(row.Cells[1].Text));
                        hardware.Add(productPart);
                    }
                }
            }
        }

        List<Component> frames = new List<Component>();
        private void iniFrameList(ref List <Component> frames)
        {

            //Populates a list of all possible frame types
            foreach (var worksheet in Workbook.Worksheets(@"C:\Users\Dave Quarick\Desktop\cs\Filtrea\frameList.xlsx"))
            {
                foreach (var row in worksheet.Rows)
                {
                    //hardcoded to read from the first column
                    if (row.Cells[0].Text != "Width")
                    {
                        //populates combobox with all possible frame types
                        cboxChannel.Items.Add(row.Cells[0].Text);

                        //creating a new Component object
                        Component productPart = new Component();

                        //adding the object to a list of all possible frame types
                        productPart.setCost(double.Parse(row.Cells[1].Text));
                        productPart.setName(row.Cells[0].Text);
                        frames.Add(productPart);
                    }
                }
            }
        }

        //clearing previous item's specs for a new custom order
        private void clearFields()
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
            cboxChannel.Text = null;
            panPt.Hide();
            panTs.Hide();
            panMb.Hide();
            panGrom.Hide();
        }

        /*STARTING THE PROCESS*/
        private void formMain_Load(object sender, EventArgs e)
        {
            iniCustomerList();
            iniMediaList(ref mediaHardware);
            iniFrameList(ref frames);
            clearFields();
        }

        /*INPUT VALIDATION*/
        //product quantity
        private bool validProductQuantity()
        {
            bool valIn = true;
            int productQuantity = 0;
    
            if (!int.TryParse(txtQty.Text, out productQuantity))
            {
                MessageBox.Show("Must provide valid input for product quantity.");
                valIn = false;
            }

            return valIn;
        }

        //media selection
        private bool validMediaSelection()
        {
            bool valIn = true;

            if (!cbAlum.Checked && !cbCarb.Checked && !cbLens.Checked)
            {
                MessageBox.Show("Must select filter media.");
                valIn = false;
            }

            return valIn;
        }

        //TODO: didn't test for negative input ... Come on me... 
        //product dimensions
        private bool validProductDimension()
        {
            double dimension;
            bool valIn = true;

            if (!double.TryParse(txtWidth.Text, out dimension) || 
                !double.TryParse(txtHeight.Text, out dimension))
            {
                MessageBox.Show("Must input valid product dimensions.");
                valIn = false; 
            }
            return valIn; 
        }

        //TODO: needs to adjust for new components added to .xslx file
        //hardware quantities
        private bool validHardwareQuantity()
        {
            bool valIn = true;
            int pieceCount = 0;

            CheckBox[] hardware = {cbPT, cbTS, cbMB, cbGrom};
            TextBox[] quantity = {txtPtQty, txtTsQty, txtMbQty, txtGromQty};
            const int HARDWARE_TYPES = 4;

            for (int i = 0; i < HARDWARE_TYPES ; ++i)
            {
                if(hardware[i].Checked && !int.TryParse(quantity[i].Text, out pieceCount))
                {
                    string caseSwitch = hardware[i].Text;

                    switch (caseSwitch)
                    {
                        case "Pull Tab":
                            MessageBox.Show("Enter valid input for PT quantity.");
                            valIn = false;
                            break;

                        case "Tension Spring":
                            MessageBox.Show("Enter valid input for TS quantity.");
                            valIn = false;
                            break;

                        case "Mounting Bracket":
                            MessageBox.Show("Enter valid input for MB quantity.");
                            valIn = false;
                            break;

                        case "Grommet":
                            MessageBox.Show("Enter valid input for Grommet quantity.");
                            valIn = false;
                            break;
                    }
                }
            }
            return valIn;
        }

        //Input validation: ALL FIELDS 
        private bool inputCheck()
        {
            bool valIn = true;
  
            if (!validProductQuantity() || !validMediaSelection() 
                || !validProductDimension() || !validHardwareQuantity())
            {
                valIn = false;
            }

            return valIn;
        }

        //showing fields for selected hardware components
        private void showHardware(Panel lbls, Panel fields)
        {
            lbls.Show();
            fields.Show();
        }

        //positioning of selected hardware components
        string hardwarePos(CheckBox Ss, CheckBox Ls)
        {
            string position = "";

            if (Ss.Checked)
                position += " " + Ss.Text;

            if (Ls.Checked)
                position += " " + Ls.Text;

            return position;
        }

        //adding product specs to the entry
        void specs2Entry(ref string [] record)
        {
            //adding item dimensions to entry
            record[0] += txtWidth.Text + " X " + txtHeight.Text;

            //specifications to entry
            CheckBox[] components = { cbAlum, cbCarb, cbLens, cbPT, cbTS, cbMB, cbGrom };
            int MATERIALS_COUNT = components.Length;

            for (int i = 0; i < MATERIALS_COUNT ; ++i)
            {

                if (components[i].Checked)
                {
                    string caseSwitch = components[i].Text;

                    switch (caseSwitch)
                    {
                        case "Aluminium":
                            record[0] += " " + components[i].Text;
                            break;

                        case "Carbon":
                            record[0] += " " + components[i].Text;
                            break;

                        case "Lens":
                            record[0] += " " + components[i].Text;
                            break;

                        case "Pull Tab":
                            record[0] += " - " + txtPtQty.Text + " PT" + hardwarePos(cbPtSs, cbPtLs);
                            break;

                        case "Tension Spring":
                            record[0] += " - " + txtTsQty.Text + " TS" + hardwarePos(cbTsSs, cbPtLs); 
                            break;

                        case "Mounting Bracket":
                            record[0] += " - " + txtMbQty.Text + " MB" + hardwarePos(cbMbSs, cbMbLs);
                            break;

                        case "Grommet":
                            record[0] += " - " + txtGromQty.Text + " Grommet" + hardwarePos(cbGromSs, cbGromLs);
                            break;
                    }
                }
            }
        }

        //REFACTOR ME! Could create a child class that inherits from Panel... 
        //hiding fields for hardware that isn't used
        private void clearHardware (ref Panel pan, ref TextBox qty, ref RadioButton pos1, 
            ref RadioButton pos2, ref CheckBox side1, ref CheckBox side2) {

            pan.Hide();
            qty.Text = "";
            pos1.Checked = false;
            pos2.Checked = false;
            side1.Checked = false;
            side2.Checked = false;
            }

        //passed comprehensive list of components, string naming a selected component, get component's price
        private double getCost(List<Component> componentList, string name)
        {
            double cost = 0;

            for (int i = 0; i < componentList.Count; ++i)
            {
                if (componentList[i].getName() == name)
                {
                    cost += componentList[i].getCost();
                }
            }
 
            return cost;
        }

        //returns surface area of product media
        private double getArea()
        {
            double surfaceArea = 0;

            surfaceArea = double.Parse(txtWidth.Text) * double.Parse(txtHeight.Text);
            return surfaceArea;
        }

        //returns total linear feet of product frame 
        private double getPerimeter()
        {
            double perimeter = (double.Parse(txtHeight.Text) + double.Parse(txtWidth.Text)) * 2;
            return perimeter;
        }

        private double calcPrice()
        {
            double total = 0;

            //components that a user can select
            CheckBox[] componentSelection = { cbAlum, cbCarb, cbLens, cbPT, cbTS, cbMB, cbGrom };

                    //based on what's checked iterate the part list and read price, calculate cost * qty
                    for (int i = 0; i < componentSelection.Length; ++i)
                    {

                        if (componentSelection[i].Checked)
                        {

                            string caseSwitch = componentSelection[i].Text;

                            switch (caseSwitch)
                            {
                                case "Aluminium":
                                total += getCost(mediaHardware, caseSwitch) * getArea();
                                        break; 

                                //TODO: Check if expanded aluminium is in the components .xlsx file
                                case "Carbon":
                                        total += getCost(mediaHardware, caseSwitch) * getArea();
                                        total += getCost(mediaHardware, "Expanded Aluminium") * getArea();
                                        break;

                                    case "Lens":
                                        total += getCost(mediaHardware, caseSwitch) * getArea();
                                        break;

                                    case "Pull Tab":
                                        total += getCost(mediaHardware, caseSwitch) * double.Parse(txtPtQty.Text);
                                        break;

                                    case "Tension Spring":
                                        total += getCost(mediaHardware, caseSwitch) * double.Parse(txtTsQty.Text);
                                        break;

                                    case "Mounting Bracket":
                                        total += getCost(mediaHardware, caseSwitch) * double.Parse(txtMbQty.Text);
                                        break;

                                    case "Grommet":
                                        total += getCost(mediaHardware, caseSwitch) * double.Parse(txtGromQty.Text);
                                        break;
                                }
                        }
                }

            //Considering the quantity of an item that's been ordered
            total *= double.Parse(txtQty.Text);

            return total;
            }

        /*FORM EVENT CODE*/ 
        
        //adding product's specs, qty, and price to current order
        private void btnAdd2Order_Click(object sender, EventArgs e)
        {
            //adding to order if form input is valid
            if (inputCheck())
            {
                //container for product specs
                string[] record = { "", "", "" };

                specs2Entry(ref record);
                record[1] = txtQty.Text;

                //adds item price to the entry
                record[2] = "$ " + calcPrice().ToString();

                //allocating for and adding new entry to listview 
                ListViewItem lvi = new ListViewItem(record);
                lvCurOrder.Items.Add(lvi);
            }
        }

        //TODO: Add functionality to the pop-up interface
        //editing an entry
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectCount = 0;
            int currentItems = lvCurOrder.Items.Count;

            for (int i = 0; i < currentItems ; i++)
            {
                if (lvCurOrder.Items[i].Selected)
                {
                    ++selectCount;
                }
            }

            int caseSwitch = selectCount;

            switch (selectCount)
            {
                case 0:
                    MessageBox.Show("Must select an entry to edit.");
                    break;

                case 1:
                    EditEntry popup = new EditEntry();
                    popup.Show();
                    break;

                default:
                    MessageBox.Show("Must select a singular entry to edit.");
                    break;
            }
        }

        //clears fields for entry of an additional product
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //removes selected entries from current order
        private void btnDelete_Click(object sender, EventArgs e)
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


        /* should print material prep instructions, fab diagram, package label, 
        shipping label, invoice, enters transaction into ledger*/
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        //clears form for an order by a new client
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            lvCurOrder.Items.Clear();
            clearFields();
            cboxCustomer.Text = null;
        }
        
        //show or hide component fields - refactor this shit
        private void cbPT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPT.Checked)
            {
                showHardware(panHardLbl, panPt);
            }

            if (!cbPT.Checked)
            {
                clearHardware(ref panPt, ref txtPtQty, ref rbPtCen, 
                              ref rbPtOther, ref cbPtSs, ref cbPtLs);
            }
        }

        private void cbTS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTS.Checked)
            {
                showHardware(panHardLbl, panTs);
            }

            if (!cbTS.Checked)
            {
                clearHardware(ref panTs, ref txtTsQty, ref rbTsCen,
                                 ref rbTsOther, ref cbTsSs, ref cbTsLs);
            }
        }

        private void cbMB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMB.Checked)
            {
                showHardware(panHardLbl, panMb);
            }

            if (!cbMB.Checked)
            {
                clearHardware(ref panMb, ref txtMbQty, ref rbMbCen,
                                 ref rbMbOther, ref cbMbSs, ref cbMbLs);
            }
        }

        private void cbGrom_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGrom.Checked)
            {
                showHardware(panHardLbl, panGrom);
            }

            if (!cbGrom.Checked)
            {
                clearHardware(ref panGrom, ref txtGromQty, ref rbGromCen,
                                 ref rbGromOther, ref cbGromSs, ref cbGromLs);
            }
        }

        /* MENU EVENTS */
        //exiting from the "File" menu item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Allows users to select input files for cost and customers
        private void inputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputPreferenceForm popup = new inputPreferenceForm();
            popup.Show();
        }

        //Allows users to select output files for ledger
        private void outputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputPreferenceForm popup = new outputPreferenceForm();
            popup.Show();
        }

    }
}
