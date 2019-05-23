using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTrackerProcessorLibrary;

namespace StockTrackerApp
{
    public partial class BrokerageForm : Form
    {
        //Local Class Variables
        List<BrokerageModel> Brokers = new List<BrokerageModel>();  // List of Brokerages

        BrokerageModel oldInfo = new BrokerageModel();  // Brokerage Selected for use to revert back before saving

        bool InfoChanged = false;  // Flag for changed information        

        STProcessor proc = new STProcessor();
       
        // Default Constructor for Form
        public BrokerageForm()
        {
            InitializeComponent();
        }

        // Load Method
        private void BrokerageForm_Load(object sender, EventArgs e)
        {
            LoadBrokers();

            UpdateDisplay();

        }

        // Updates the Brokerage Information being displayed
        private void UpdateDisplay()
        {
            // Determine the number of Brokers Use has
            if (cb_Select.Items.Count == 0)  // No Brokers, Set up to add broker
            {
                // Hide the Selection Combo Box and Edit Check Box
                cb_Select.Visible = false;
                chk_Edit.Visible = false;
                
                // Set Text Boxes to Enable
                SetEdit(true);

                // UnEnable new Button
                btn_New.Enabled = false;

            }
            else if (cb_Select.Items.Count == 1)
            {
                // Hide Selection Combo Box
                cb_Select.Visible = false;

                // Set Text Boxes to UnEnable
                SetEdit(false);

                // Load the information into the proper locatoin
                LoadSelectedBroker();

                // UnEnable Save and Revert Button
                btn_Save.Enabled = false;
                btn_Revert.Enabled = false;
                btn_New.Enabled = true;

            }
            else
            {
                // Set Text Boxes to UnEnable
                SetEdit(false);

                // UnEnable Save and Revert Button
                LoadSelectedBroker();
                btn_Save.Enabled = false;
                btn_Revert.Enabled = false;

            }
        }

        // Retrieve the Selected Brokers Information
        private void LoadSelectedBroker()
        {
            if (cb_Select.SelectedItem == null)
            {
                cb_Select.SelectedIndex = 0;
            }
            // Load the Selected Brokerage Information
            BrokerageModel model = (BrokerageModel)cb_Select.SelectedItem;
            oldInfo = model;
                        
            LoadDisplay(model);                       
        }

        // Update the Form Display
        private void LoadDisplay(BrokerageModel model)
        {

            chk_Edit.Checked = false;
            txt_BrokerageName.Text = model.BrokerageName;
            txt_Address.Text = model.BrokerageAddress;
            txt_AccountNum.Text = model.AccountNum;
            txt_BrokerName.Text = model.BrokerName;
            txt_PhoneNum.Text = model.PhoneNum;
            txt_Email.Text = model.Email;
            txt_CommissionRate.Text = model.CommissionRate.ToString("N2");

            // Set Info Change Flag to False
            InfoChanged = false;
        }

        // Sets the Enable property of textboxes
        private void SetEdit(bool v)
        {
            foreach (Control mctl in this.Controls)
            {
                if (mctl is GroupBox)
                {
                    foreach (Control ctl in mctl.Controls)
                    {
                        if (ctl is TextBox)
                            ctl.Enabled = v;
                    }
                }
                else if (mctl is TextBox)
                {
                    mctl.Enabled = v;
                }
            }
        }

        // Retrieve Brokers from Database
        private void LoadBrokers()
        {
           //Add Method to load Brokerages
            Brokers = GlobalConfig.Connection.Broker_GetAll();

            UpdateSelections();
        }

        // Update the Combo Box for Brokerages Base Method
        private void UpdateSelections()
        {
            cb_Select = proc.LoadBrokerComboBox();
        }

        // Update the Combo Box for Brokerages Passing Index of 
        // Brokerage to Display
        private void UpdateSelections(int x)
        {
            cb_Select = proc.LoadBrokerComboBox();
            cb_Select.SelectedIndex = x;
        }
                
        // Method to handle the change in checked status
        // Of the Edit Check Box
        private void chk_Edit_CheckedChanged(object sender, EventArgs e)
        {
            // Check for Changed Information
            if (!InfoChanged)
            {
                if (chk_Edit.Checked)
                {
                    // Set Textboxes to Enabled for editing
                    SetEdit(true);

                    // Enable all Buttons
                    btn_New.Enabled = true;
                    btn_Save.Enabled = true;
                    btn_Revert.Enabled = true;
                }
                else
                {
                    // Set Textboxes to UnEnabled
                    SetEdit(false);

                    // UnEnable Save and Revert Buttons
                    btn_Revert.Enabled = false;
                    btn_Save.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("You have Changed the Information.\n" +
                                "Please Save or Revert.", "Information Changed");
            }
        }

        // Method to handle the changing of 
        // Broker information
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            InfoChanged = true;
        }

        // Method to handle the Combo Box Selection Change
        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Select.SelectedIndex != -1)
            {
                // Load the new information
                LoadSelectedBroker();
            }
        }

        // Method to handle New Button Click
        private void btn_New_Click(object sender, EventArgs e)
        {
            if (!InfoChanged)
            {
                cb_Select.SelectedIndex = -1;  // No Selected Item

                // Clear all Textboxes
                foreach (Control mctl in this.Controls)
                {
                    if (mctl is GroupBox)
                    {
                        foreach (Control ctl in mctl.Controls)
                        {
                            if (ctl is TextBox)
                                ctl.Text = string.Empty;
                        }
                    }
                    else if (mctl is TextBox)
                    {
                        mctl.Text = string.Empty;
                    }
                }

                // Set all Textboxes to Enabled
                SetEdit(true);

                //Hide Select ComboBox and Edit Checkbox
                cb_Select.Visible = false;
                chk_Edit.Visible = false;

                // Rename Revert Button to Cancel
                btn_Revert.Text = "Cancel";

                //Enable Save Button
                btn_Save.Enabled = true;
                btn_Revert.Enabled = true;
                btn_New.Enabled = false;

                // Set OldInfo to a new instance
                oldInfo = new BrokerageModel();
                
            }
            else
            {
                MessageBox.Show("You have Changed the Information.\n" +
                                "Please Save or Revert.", "Information Changed");
            }
        }

        // Method to Save Info to DataBase
        // Includes updating Existing Info
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cb_Select.SelectedIndex == -1)  // Check for New Broker
            {
                BrokerageModel newBroker = new BrokerageModel();

                // Gather Information
                newBroker.BrokerageName = txt_BrokerageName.Text;
                newBroker.BrokerageAddress = txt_Address.Text;
                newBroker.AccountNum = txt_AccountNum.Text;
                newBroker.BrokerName = txt_BrokerName.Text;
                newBroker.PhoneNum = txt_PhoneNum.Text;
                newBroker.Email = txt_Email.Text;
                newBroker.CommissionRate = Convert.ToDecimal(txt_CommissionRate.Text);

                // Save to Database;
                GlobalConfig.Connection.Broker_AddNew(newBroker);

                //Add to list of Brokerages
                Brokers.Add(newBroker);

                UpdateSelections(Brokers.Count - 1);
                SetEdit(false);
                cb_Select.Visible = true;
                chk_Edit.Visible = true;

                btn_Save.Enabled = false;
                btn_Revert.Enabled = false;
            }
            else
            {
                // Gather information
                oldInfo.BrokerageName = txt_BrokerageName.Text;
                oldInfo.BrokerageAddress = txt_Address.Text;
                oldInfo.AccountNum = txt_AccountNum.Text;
                oldInfo.BrokerName = txt_BrokerName.Text;
                oldInfo.PhoneNum = txt_PhoneNum.Text;
                oldInfo.Email = txt_Email.Text;
                oldInfo.CommissionRate = Convert.ToDecimal(txt_CommissionRate.Text);

                // Update Database
                GlobalConfig.Connection.Broker_Update(oldInfo);
                               
                SetEdit(false);
                cb_Select.Visible = true;
                chk_Edit.Visible = true;

                btn_Save.Enabled = false;
                btn_Revert.Enabled = false;

                InfoChanged = false;
                chk_Edit.Checked = false;
            }
        }

        // Method to handle Revert Button Event
        private void btn_Revert_Click(object sender, EventArgs e)
        {
            if (btn_Revert.Text == "Revert")
            {// Set InfoChanged to False because
             // Reverting to unchanged information
                InfoChanged = false;

                LoadDisplay(oldInfo);
            }
            else
            {
                //Show Select ComboBox and Edit Checkbox
                cb_Select.Visible = true;
                chk_Edit.Visible = true;
                btn_New.Enabled = true;
                btn_Revert.Text = "Revert";

                UpdateDisplay();
            }
        }
    }
}
