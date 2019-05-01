using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackerDataLibrary.DataModels;

namespace StockTrackerProcessorLibrary
{
    public interface IStockRequester
    {
        /* This Interface if for the sharing of the DataModel between Forms.
       * In the form you need the Data you need the following:
       *  ie
       *      public partial class SomeForm : Form, I<Datamodelref>Requester
       *  
       * Then in the the form you are gathering the DataModel data you
       * need the following constructor:
       * 
       *      private I<Datamodelref>Requester callingForm;
       *      
       *      public FormBeingCalled(I<Datamodelref>Requester caller)
       *      {
       *         code in the constructor
       *       }c       
       *       
      */
       
        void StockSelected(StockModel stock);
    }
}
