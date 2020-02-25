using LinkarClient;
using LinkarCommon;
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
    public partial class FormItems : Form
    {

        LinkarClt _LinkarClt;

        public FormItems(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
            InitializeComponent();
            txtHelp.Text = "In this form the \"Select\" method is used with \"calculated\" option to load all data selected.\r\nIn the select box you can write a item description or id.\r\nTo load the data, a standard class is used that collects the MV buffer and assigns it to each property.\r\nThis class has CRUD methods to see how they work.";
            cLkItemsBindingSource.DataSource = new CLkItems(this._LinkarClt);
        }

        #region -- Operations Bar

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Create new CLkItem object
            CLkItem clkitem = new CLkItem(_LinkarClt, true);
            cLkItemsBindingSource.Add(clkitem);
            cLkItemsBindingSource.MoveLast();
            ChangeBarStatus(true, true);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkItem clkitem = GetCurrentRecord();
            if (clkitem != null)
                ChangeBarStatus(true, false);
            else
                MessageBox.Show("Need select one record");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkItem clkitem = GetCurrentRecord();
            if (clkitem != null)
            {                
                string ge = "";
                //Call DeleteItem method from CLkItem
                try
                {
                    clkitem.DeleteRecord("");
                    //Remove customer from customers list and grid
                    cLkItemsBindingSource.Remove(clkitem);
                    cLkItemsBindingSource.MoveFirst();
                }
                catch (Exception ex)
                {
                    string msgErr = FormDemo.GetExceptionInfo(ex);
                    MessageBox.Show(this, msgErr, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filename = "";
            string selectClause = this.txtSelect.Text;
            string sortClause = "";
            string usingDict = "";

            int regPage = 0;
            int numPag = 0;

            CLkItems clkitems = new CLkItems(this._LinkarClt);
            //Call to FindAll method of CLkItems class
            clkitems.FindAll(sortClause, selectClause, regPage, numPag, filename, usingDict);

            if (clkitems != null)
            {
                if (clkitems.LstErrors != null && clkitems.LstErrors.Count > 0)
                {
                    MessageBox.Show(string.Join("\r\n", clkitems.LstErrors));
                }
                //Draw customers data
                cLkItemsBindingSource.DataSource = clkitems;
                ChangeBarStatus(false, false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkItem clkitem = GetCurrentRecord();
            if (clkitem != null)
            {
                GetRecord(ref clkitem);
                //Save or create new item
                if (clkitem.Status != LinkarMainClass.StatusTypes.NEW)
                {
                    //Call the WriteItem method from CLkItem
                    try
                    {
                        clkitem.WriteRecord("");
                        ChangeBarStatus(false, false);
                    }
                    catch (Exception ex)
                    {
                        string msgErr = FormDemo.GetExceptionInfo(ex);
                        MessageBox.Show(this, msgErr, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Call the NewItem method from CLkItem
                    try
                    {
                        clkitem.NewRecord("");
                        ChangeBarStatus(false, false);
                    }
                    catch (Exception ex)
                    {
                        string msgErr = FormDemo.GetExceptionInfo(ex);
                        MessageBox.Show(this, msgErr, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CLkItem clkitem = GetCurrentRecord();
            if (clkitem != null)
            {
                //Reject the changes in the class
                if (clkitem.Status != LinkarMainClass.StatusTypes.NEW)
                {
                    //Call the method Reject changes of CLkItem
                    clkitem.RejectChanges();
                    DrawRecord(clkitem);
                }
                else
                {
                    cLkItemsBindingSource.Remove(clkitem);
                    cLkItemsBindingSource.MoveFirst();
                }
            }
            ChangeBarStatus(false, false);
        }

        #endregion

        #region -- Methods

        private void ChangeBarStatus(bool inEditMode, bool isNew)
        {
            if (inEditMode)
            {
                btnNew.Enabled = false;
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnSelect.Enabled = false;
                txtSelect.Enabled = false;
                dgRecords.Enabled = false;

                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtCode.Enabled = isNew;
                txtDescription.Enabled = true;
                txtStock.Enabled = true;
            }
            else
            {
                btnNew.Enabled = true;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                btnSelect.Enabled = true;
                txtSelect.Enabled = true;
                dgRecords.Enabled = true;

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                txtCode.Enabled = false;
                txtDescription.Enabled = false;
                txtStock.Enabled = false;
            }
        }

        private CLkItem GetCurrentRecord()
        {
            CLkItem record = null;
            if (cLkItemsBindingSource != null && cLkItemsBindingSource.Current != null)
                record = (CLkItem)cLkItemsBindingSource.Current;                           
            return record;
        }

        private void DrawRecord(CLkItem record)
        {
            if (record != null)
            {
                txtCode.Text = record.Code;
                txtDescription.Text = record.Description;
                txtStock.Value = (decimal)record.Stock;
            }
        }

        private void GetRecord(ref CLkItem record)
        {
            record.Code = txtCode.Text;
            record.Description = txtDescription.Text;
            record.Stock = (double)txtStock.Value;
        }

        #endregion

        private void cLkItemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DrawRecord(GetCurrentRecord());
        }
    }
}
