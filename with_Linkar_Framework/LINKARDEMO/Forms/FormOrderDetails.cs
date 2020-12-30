//NEWFRAMEWORK: Linkar Framework Libraries
using Linkar.Functions.Persistent.MV;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINKARDEMO
{
    public partial class FormOrderDetails : Form
    {

        LinkarClient _LinkarClt; //NEWFRAMEWORK: Replace LinkarClt for LinkarClient

        public FormOrderDetails(LinkarClient linkarClt) //NEWFRAMEWORK: Replace LinkarClt for LinkarClient
        {
            _LinkarClt = linkarClt;
            InitializeComponent();
            txtHelp.Text = "In this form the \"Select\" method is used with \"onlyitems\" option to load the grid on the left.\r\nRecords are read every time they are focused using the \"Read\" method with the \"calculated\" option\r\nIn the select box you can write an order id to go directly to it\r\nTo load the data, a standard class is used that collects the MV buffer and assigns it to each property.";
            cLkOrdersBindingSource.DataSource = new CLkOrders(this._LinkarClt);
        }

        #region -- Operations Bar

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filename = "";
            string selectClause = this.txtSelect.Text;
            string sortClause = "";
            string usingDict = "";

            int regPage = 0;
            int numPag = 0;

            CLkOrders clkorders = new CLkOrders(this._LinkarClt);
            //Call to FindAll method of CLkOrders class
            if (string.IsNullOrEmpty(selectClause))
                clkorders.SelectAll(sortClause, filename, regPage, numPag, true, false, false);
            else
                clkorders.FindAll(sortClause, selectClause, regPage, numPag, filename, usingDict, true, false, false);

            if (clkorders != null)
            {
                if (clkorders.LstErrors != null && clkorders.LstErrors.Count > 0)
                {
                    MessageBox.Show(string.Join("\r\n", clkorders.LstErrors));
                }
                //Draw customers data
                cLkOrdersBindingSource.DataSource = clkorders;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cLkOrdersBindingSource.DataSource = new CLkOrders(this._LinkarClt);
        }

        #endregion

        #region -- Methods

        private CLkOrder GetCurrentRecord()
        {
            CLkOrder record = null;
            if (cLkOrdersBindingSource != null && cLkOrdersBindingSource.Current != null)
                record = (CLkOrder)cLkOrdersBindingSource.Current;                           
            return record;
        }

        private void DrawRecord(CLkOrder record)
        {
            if (record != null)
            {
                txtId.Text = record.Id;
                txtCustomer.Text = record.Customer;                
                txtDate.Text = record.Date.HasValue ? record.Date.Value.ToShortDateString() : "";
                txtTotalOrder.Text = record.ITotalOrder.ToString();
                txtCustomerName.Text = record.ICustomerName;
            }
        }

        #endregion

        private void dgRecords_SelectionChanged(object sender, EventArgs e)
        {
            CLkOrder clkorder = GetCurrentRecord();
            if (clkorder != null)
            {
                try
                {
                    clkorder.ReadRecord(true, "");
                    DrawRecord(GetCurrentRecord());
                    lstLstItemsBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    string msgErr = FormDemo.GetExceptionInfo(ex);
                    MessageBox.Show(this, msgErr, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
