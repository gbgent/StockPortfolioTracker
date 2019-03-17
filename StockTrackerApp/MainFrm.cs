using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTrackerProccesorLibrary;


namespace StockTrackerApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard();

            //Set New Form to show in Display
            // UpdateMainFormPanel(ref Form DisplayFrm);
            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.Bottom |
                                          AnchorStyles.Left |
                                          AnchorStyles.Top |
                                          AnchorStyles.Right);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }

        private void mnu_FileDashBoard_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard();

            //Set New Form to show in Display
            // UpdateMainFormPanel(ref Form DisplayFrm);
            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.Bottom |
                            AnchorStyles.Left |
                            AnchorStyles.Top |
                            AnchorStyles.Right);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }

        private void mnu_FileBroker_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            BrokerForm nForm = new BrokerForm();

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None );

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();

        }

        private void mnu_FileExit_Click(object sender, EventArgs e)
        {
            //Close the Application
            this.Close();
        }

        private void mnu_StockUpdateSingle_Click(object sender, EventArgs e)
        {
            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm();

            frm.ShowDialog();

        }

        private void mnu_Stock_View_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            StockView nForm = new StockView();

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }
    }
}
