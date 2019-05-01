using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerProcessorLibrary
{
    public interface IValueUpdater
    {
        /* This Interface if for the sharing of the DataModel between Forms.
        *  In the form you need the Data you need the following:
        *
        *  ie
        *     public partial class SomeForm : Form, IValueUpdater
        *  
        *  Then in the the form you are gathering the DataModel data you
        *  need the following constructor:
        * 
        *      private IValueUpdater calledForm;
        *      
        *      public FormBeingCalled(I<Datamodelref>Requester caller)
        *      {
        *         code in the constructor
        *      }       
        *       
        */

        void UpdateValue();
    }
}
