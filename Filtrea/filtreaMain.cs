using System;
using System.Windows.Forms;
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
        private void iniClientList()
        {
            //@ represents the active directory during the program's runtime
            foreach (var worksheet in Workbook.Worksheets(@"clientList.xlsx"))
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
            foreach (var worksheet in Workbook.Worksheets(@"mediaList.xlsx"))
            {
                foreach (var row in worksheet.Rows)
                {
                    if (row.Cells[0].Text != "Component")
                    {
                        Component productPart = new Component();

                        productPart.Name = row.Cells[0].Text;
                        productPart.Cost = double.Parse(row.Cells[1].Text);
                        hardware.Add(productPart);
                    }
                }
            }
        }

        List<Component> frames = new List<Component>();
        private void iniFrameList(ref List<Component> frames)
        {

            //populates dropdown with types of filter frames
            foreach (var worksheet in Workbook.Worksheets(@"frameList.xlsx"))
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
                        productPart.Name = row.Cells[0].Text;
                        productPart.Cost = double.Parse(row.Cells[1].Text);
                        frames.Add(productPart);
                    }
                }
            }
        }

        private void iniMarkupFactor()
        {

            double[] markupFactors = { 1.25, 1.5, 1.75, 2, 2.25, 2.5, 2.75, 3 };
            int NUM_FACTORS = markupFactors.Length;

            //maybe change this to a foreach?
            for (int i = 0; i < NUM_FACTORS; ++i)
            {
                cboxMarkup.Items.Add(markupFactors[i]);
            }
        }

        //clearing previous item's specs for a new custom order
        private void clearFields()
        {
            cbAlum.Checked = cbCarb.Checked = cbLens.Checked = cbPT.Checked =
                cbTS.Checked = cbMB.Checked = cbGrom.Checked = false;

            txtHeight.Text = txtWidth.Text = txtLensDim1.Text =
                txtLensDim2.Text = txtQty.Text = "";

            cboxChannel.Text = null;

            panPt.Hide();
            panTs.Hide();
            panMb.Hide();
            panGrom.Hide();
        }

        /*STARTING THE PROCESS*/
        private void formMain_Load(object sender, EventArgs e)
        {
            panLens.Hide();
            iniClientList();
            iniMediaList(ref mediaHardware);
            iniFrameList(ref frames);
            iniMarkupFactor();
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

            if (dimension <= 0) {
                MessageBox.Show("Must input positive dimensions.");
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

            CheckBox[] hardware = { cbPT, cbTS, cbMB, cbGrom };
            TextBox[] quantity = { txtPtQty, txtTsQty, txtMbQty, txtGromQty };
            const int HARDWARE_TYPES = 4;

            for (int i = 0; i < HARDWARE_TYPES; ++i)
            {
                if (hardware[i].Checked && !int.TryParse(quantity[i].Text, out pieceCount))
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

        private bool validMarkupFactor()
        {

            if (cboxMarkup.Text == "")
            {
                MessageBox.Show("Must enter a Markup Factor.");
                return false;
            }

            return true;
        }

        private bool validLensDimensions()
        {
            if (cbLens.Checked)
            {
                if (double.Parse(txtLensDim1.Text) <= 0 || double.Parse(txtLensDim2.Text) <= 0)
                {
                    MessageBox.Show("Must enter positive lens dimensions.");
                    return false;
                }
            }

            return true;
        }

        //INPUT VALIDATION: ALL FIELDS 
        private bool inputCheck()
        {

            if (!validProductQuantity() || !validMediaSelection()
                || !validProductDimension() || !validHardwareQuantity()
                || !validMarkupFactor() || !validLensDimensions())
            {
                return false;
            }
        
            return true;
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
            record[0] += cboxChannel.Text + " Frame: " + txtWidth.Text + "\" X " + txtHeight.Text + "\"";

            //specifications to entry
            CheckBox[] components = { cbAlum, cbCarb, cbLens, cbPT, cbTS, cbMB, cbGrom };
            int MATERIALS_COUNT = components.Length;

            for (int i = 0; i < MATERIALS_COUNT ; ++i)
            {

                if (components[i].Checked)
                {
                    string componentName = components[i].Text;

                    switch (componentName)
                    {
                        case "Aluminium":
                            record[0] += " " + components[i].Text;
                            break;

                        case "Carbon":
                            record[0] += " " + components[i].Text;
                            break;

                        case "Lens":
                            record[0] += " " + components[i].Text;
                            record[0] += " " + " - Lens: " + txtLensDim1.Text + "\" X " + txtLensDim2.Text + "\"";
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
            ref RadioButton pos2, ref CheckBox side1, ref CheckBox side2)
        {
            pan.Hide();
            qty.Text = "";
            pos1.Checked = false;
            pos2.Checked = false;
            side1.Checked = false;
            side2.Checked = false;
        }

        //passed comprehensive list of components, string naming a selected component, get component's price
        private double calcCost(List<Component> componentList, string name)
        {
            double cost = 0;
            int NUM_COMPONENTS = componentList.Count;

            for (int i = 0; i < NUM_COMPONENTS; ++i)
            {
                if (componentList[i].Name == name)
                {
                    cost += componentList[i].Cost;
                }
            }
            return cost;
        }

        //returns surface area of product media in inches
        private double calcArea()
        {
              return double.Parse(txtWidth.Text) * double.Parse(txtHeight.Text);
        }

        //returns total length of product frame in inches
        private double calcPerimeter()
        {
            return (double.Parse(txtHeight.Text) + double.Parse(txtWidth.Text)) * 2;
        }

        private string calcFilterPrice()
        {
            double total = 0;
            const int INCHES_TO_FEET = 12;

            //components that a user can select
            CheckBox[] componentSelection = { cbAlum, cbCarb, cbLens, cbPT, cbTS, cbMB, cbGrom };
            int NUM_COMPONENTS = componentSelection.Length;

            //based on what's checked, iterate the part list, read costs, and calculate cost * qty
            for (int i = 0; i < NUM_COMPONENTS ; ++i)
                    {
                        if (componentSelection[i].Checked)
                        {
                            string caseSwitch = componentSelection[i].Text;

                            switch (caseSwitch)
                            {
                                case "Aluminium":
                                        total += (calcCost(mediaHardware, caseSwitch) / INCHES_TO_FEET) * calcArea();
                                        break; 

                                //TODO: Check if expanded aluminium is in the components .xlsx file
                                case "Carbon":
                                        total += (calcCost(mediaHardware, caseSwitch) / INCHES_TO_FEET) * calcArea();
                                        total += (calcCost(mediaHardware, "Expanded Aluminium") / INCHES_TO_FEET) * calcArea();
                                        break;

                                    case "Lens":
                                        total += (calcCost(mediaHardware, caseSwitch) / INCHES_TO_FEET) * calcArea();
                                        break;

                                    case "Pull Tab":
                                        total += calcCost(mediaHardware, caseSwitch) * double.Parse(txtPtQty.Text);
                                        break;

                                    case "Tension Spring":
                                        total += calcCost(mediaHardware, caseSwitch) * double.Parse(txtTsQty.Text);
                                        break;

                                    case "Mounting Bracket":
                                        total += calcCost(mediaHardware, caseSwitch) * double.Parse(txtMbQty.Text);
                                        break;

                                    case "Grommet":
                                        total += calcCost(mediaHardware, caseSwitch) * double.Parse(txtGromQty.Text);
                                        break;
                                }
                        }
                }
            total += calcCost(frames, cboxChannel.Text) * calcPerimeter() / INCHES_TO_FEET;

            //considering quantity of an item that's been ordered
            total *= double.Parse(txtQty.Text);

            //multiplying cost by markup factor to determine price
            total *= double.Parse(cboxMarkup.Text);

            total = Math.Round(total, 2);

            return total.ToString("0.00");
            }

        /*EVENT HANDLERS FOR FORM MAIN*/ 
        
        //adding product's specs, qty, and price to current order
        private void btnAdd2Order_Click(object sender, EventArgs e)
        {
            //adding to order if form input is valid
            if (inputCheck())
            {
                //container for product specs
                string[] record = { "", "", "" };

                specs2Entry(ref record);

                //item qty to entry
                record[1] = txtQty.Text;

                //adds item price to the entry
                record[2] = "$ " + calcFilterPrice().ToString();

                //allocating for and adding new entry to listview 
                ListViewItem lvi = new ListViewItem(record);
                lvCurOrder.Items.Add(lvi);
            }
        }

        //TODO: Add functionality to the pop-up interface
        //start editing an entry
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedCount = 0;
            int currentItems = lvCurOrder.Items.Count;

            for (int i = 0; i < currentItems; ++i)
            {
                if (lvCurOrder.Items[i].Selected)
                {
                    ++selectedCount;
                }
            }

            int caseSwitch = selectedCount;

            switch (selectedCount)
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

        //prints list view using ObjectListView project
        private void btnPrint_Click(object sender, EventArgs e)
        {
            BrightIdeasSoftware.ListViewPrinter printer = new BrightIdeasSoftware.ListViewPrinter();
            printer.AlwaysCenterListHeader = true;
            printer.ListView = lvCurOrder;
            printer.DocumentName = "Duraflow Industries Order" + "Client: " + cboxCustomer.Text;
            printer.Header = "Duraflow Industries Order" + " | Client: " + cboxCustomer.Text;
            printer.DefaultPageSettings.Margins.Top = 5;
            printer.DefaultPageSettings.Margins.Left = 5;
            printer.DefaultPageSettings.Margins.Right = 5;
            printer.IsListHeaderOnEachPage = true;
            printer.Footer = "Duraflow Industries - " + DateTime.Now.ToString("dddd, dd.MMMM yyyy HH:mm");
            printer.PrintPreview();
        }

        //clears form for an order by a new client
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            lvCurOrder.Items.Clear();
            clearFields();
            cboxCustomer.Text = null;
            cboxMarkup.Text = null;
        }
        
        //show or hide component fields - refactor this shit
        private void cbPT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPT.Checked)
            {
                showHardware(panHardLbl, panPt);
            }

            else
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

            else
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

            else
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

            else
            {
                clearHardware(ref panGrom, ref txtGromQty, ref rbGromCen,
                                 ref rbGromOther, ref cbGromSs, ref cbGromLs);
            }
        }

                private void cbLens_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLens.Checked)
            {
                panLens.Show();
            }

            else
            {
                panLens.Hide();
                txtLensDim1.Text = "";
                txtLensDim2.Text = "";
            }
        }

        /* MENU EVENTS */
        //exiting from the "File" menu item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*should allow users to select input files for client, frames, and components
        private void inputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputPreferenceForm popup = new inputPreferenceForm();
            popup.Show();
        }

        //should allow users to select output file for custom orders ledger
        private void outputFilePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputPreferenceForm popup = new outputPreferenceForm();
            popup.Show();
        }
        */
    }
}
