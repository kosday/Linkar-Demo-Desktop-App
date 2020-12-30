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
    public partial class FormOrderLists : Form
    {
        LinkarClient _LinkarClt; //NEWFRAMEWORK: Replace LinkarClt for LinkarClient
        int currentPage = 1;
        int numRegforPag = 100;

        public FormOrderLists(LinkarClient linkarClt) //NEWFRAMEWORK: Replace LinkarClt for LinkarClient
        {
            _LinkarClt = linkarClt;
            InitializeComponent();
            txtHelp.Text = "In this form the \"Select\" method is used with \"calculated\" option to load the grid.\r\nIn the select box you can write an order id to go directly to it\r\nTo load the data, a standard class is used that collects the MV buffer and assigns it to each property.\r\nClicking on each line, you can view the Multivalue and Subvalue groups.";
            cLkOrdersBindingSource.DataSource = new CLkOrders(this._LinkarClt);
        }

        #region -- Operations Bar

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Select(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cLkOrdersBindingSource.DataSource = new CLkOrders(this._LinkarClt);
        }

        #endregion

        #region -- Methods

        private void Select(int numPag)
        {
            string filename = "";
            string selectClause = this.txtSelect.Text;
            string sortClause = "";
            string usingDict = "";

            currentPage = numPag;

            CLkOrders clkorders = new CLkOrders(this._LinkarClt);
            //Call to FindAll or SelectAll method of CLkOrders class
            if (string.IsNullOrEmpty(selectClause))
                clkorders.SelectAll(sortClause, filename, numRegforPag, currentPage, false, true, true);
            else
                clkorders.FindAll(sortClause, selectClause, numRegforPag, currentPage, filename, usingDict, false, true, true);

            if (clkorders != null)
            {
                if (clkorders.LstErrors != null && clkorders.LstErrors.Count > 0)
                {
                    MessageBox.Show(string.Join("\r\n", clkorders.LstErrors));
                }
                cLkOrdersBindingSource.DataSource = clkorders;
            }
        }

        #endregion


        private void cLkOrdersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 > 0)
                Select(currentPage - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CLkOrders clkorders = (CLkOrders)cLkOrdersBindingSource.DataSource;
            if (clkorders != null)
            {
                double t = (clkorders.totalRecords / numRegforPag);
                if ((currentPage + 1) <= t)
                    Select(currentPage + 1);
            }
        }
    }
}
