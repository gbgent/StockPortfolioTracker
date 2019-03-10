using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackerProccesorLibrary
{
    public class MainFormProcessor
    {
        public void UpdateMainFormPanel(ref Form dform)
        {
            // Remove the Top Level desingation for the Form
            dform.TopLevel = false;

            //Anchor Form for Expansion and contraction of window
            dform.Anchor = (AnchorStyles.Bottom |
                                          AnchorStyles.Left |
                                          AnchorStyles.Top |
                                          AnchorStyles.Right);

        }
    }
}
