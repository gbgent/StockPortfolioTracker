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

namespace StockTrackerApp
{
    public partial class BrokerageForm : Form
    {
        //Local Class Variables
        List<BrokerageModel> Brokers = new List<BrokerageModel>();  // List of Brokerages

        BrokerageModel oldInfo = new BrokerageModel();  // Brokerage Selected for use to revert back before saving

        bool InfoChanged = false;  // Flag for changed information


        public BrokerageForm()
        {
            InitializeComponent();
        }

        private void BrokerageForm_Load(object sender, EventArgs e)
        {
            LoadBrokers();

            UpdateDisplay();

        }

        // UPdates the Brokerage Information being displayed
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
                LoadDisplay();

                // UnEnable Save and Revert Button
                btn_Save.Enabled = false;
                btn_Revert.Enabled = false;

            }
            else
            {
                // Set Text Boxes to UnEnable
                SetEdit(false);

                // UnEnable Save and Revert Button
                LoadDisplay(); btn_Save.Enabled = false;
                btn_Revert.Enabled = false;

            }
        }

        private void LoadDisplay()
        {
            // Load the Selected Brokerage Information
            BrokerageModel model = (BrokerageModel)cb_Select.SelectedItem;
            oldInfo = model;

            LoadDisplay(model);
                       
        }

        private void LoadDisplay(BrokerageModel model)
        {
            chk_Edit.Checked = false;
            txt_BrokerageName.Text = model.BrokerageName;
            txt_Address.Text = model.BrokerageAddress;
            txt_AccountNum.Text = model.AccountNum;
            txt_BrokerName.Text = model.Broker;
            txt_PhoneNum.Text = model.PhoneNum;
            txt_Email.Text = model.Email;
            txt_CommissionRate.Text = model.CommissionRate.ToString("N2");

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

        private void LoadBrokers()
        {
            UseTempValues();

            //Todo - Add Method to load Brokerages

            UpdateSelections();
            
        }

        private void UpdateSelections()
        {
            cb_Select.DataSource = null;
            cb_Select.DataSource = Brokers;
            cb_Select.DisplayMember = "Brokeragename";
            cb_Select.ValueMember = "BrokerId";

        }

        private void UpdateSelections(int x)
        {
            cb_Select.DataSource = null;
            cb_Select.DataSource = Brokers;
            cb_Select.DisplayMember = "Brokeragename";
            cb_Select.ValueMember = "BrokerId";
            cb_Select.SelectedIndex = x;

        }

        private void UseTempValues()
        {
            BrokerageModel item1 = new BrokerageModel();
            BrokerageModel item2 = new BrokerageModel();

            item1.BrokerId = 1;
            item1.BrokerageName = "Ameritrade";
            item1.CommissionRate = 6.95M;

            item2.BrokerId = 2;
            item2.BrokerageName = "Etrade";
            item2.CommissionRate = 7.95M;

            Brokers.Add(item1);
            Brokers.Add(item2);
        }

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

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            InfoChanged = true;
        }

        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Select.SelectedIndex != -1)
            {
                // Load the new information
                LoadDisplay();
            }
        }

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BrokerageModel newBroker = new BrokerageModel();

            newBroker.BrokerageName = txt_BrokerageName.Text;
            newBroker.BrokerageAddress = txt_Address.Text;
            newBroker.AccountNum = txt_AccountNum.Text;
            newBroker.Broker = txt_BrokerName.Text;
            newBroker.PhoneNum = txt_PhoneNum.Text;
            newBroker.Email = txt_Email.Text;
            newBroker.CommissionRate = Convert.ToDecimal(txt_CommissionRate.Text);

            // ToDo - Add code to save to Data Base;

            //Add to list of Brokerages
            Brokers.Add(newBroker);

            UpdateSelections(Brokers.Count - 1);
            SetEdit(false);
            cb_Select.Visible = true;
            chk_Edit.Visible = true;

            btn_Save.Enabled = false;
            btn_Revert.Enabled = false;


        }

        private void btn_Revert_Click(object sender, EventArgs e)
        {
            LoadDisplay(oldInfo);

            //ToDo - Check on Why Error Message is Showing on This Button.
        }
    }
}
