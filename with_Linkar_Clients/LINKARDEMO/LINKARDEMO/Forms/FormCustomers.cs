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
    public partial class FormCustomers : Form
    {

        LinkarClt _LinkarClt;

        public FormCustomers(LinkarClt linkarClt)
        {
            _LinkarClt = linkarClt;
            InitializeComponent();
            txtHelp.Text = "In this form the \"Select\" method is used with \"calculated\" option to load all data selected.\r\nIn the select box you can write a customer name or id.\r\nTo load the data, a standard class is used that collects the MV buffer and assigns it to each property.\r\nThis class has CRUD methods to see how they work.";
            cLkCustomersBindingSource.DataSource = new CLkCustomers(this._LinkarClt);
        }

        #region -- Operations Bar

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Create new CLkCustomer object
            CLkCustomer clkcustomer = new CLkCustomer(_LinkarClt, true);
            cLkCustomersBindingSource.Add(clkcustomer);
            cLkCustomersBindingSource.MoveLast();
            ChangeBarStatus(true, true);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkCustomer clkcustomer = GetCurrentRecord();
            if (clkcustomer != null)
                ChangeBarStatus(true, false);
            else
                MessageBox.Show("Need select one record");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkCustomer clkcustomer = GetCurrentRecord();
            if (clkcustomer != null)
            {
                //Call DeleteItem method from CLkCustomer
                try
                {
                    clkcustomer.DeleteRecord("");
                    //Remove customer from customers list and grid
                    cLkCustomersBindingSource.Remove(clkcustomer);
                    cLkCustomersBindingSource.MoveFirst();
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

            try
            {
                CLkCustomers clkcustomers = new CLkCustomers(this._LinkarClt);
                //Call to FindAll method of CLkCustomers class
                clkcustomers.FindAll(sortClause, selectClause, regPage, numPag, filename, usingDict);
                if (clkcustomers != null)
                {
                    if (clkcustomers.LstErrors != null && clkcustomers.LstErrors.Count > 0)
                    {
                        MessageBox.Show(string.Join("\r\n", clkcustomers.LstErrors));
                    }
                    //Draw customers data
                    cLkCustomersBindingSource.DataSource = clkcustomers;
                    ChangeBarStatus(false, false);
                }
            }
            catch (Exception ex)
            {
                string msgErr = FormDemo.GetExceptionInfo(ex);
                MessageBox.Show(this, msgErr, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get current customer
            CLkCustomer clkcustomer = GetCurrentRecord();
            if (clkcustomer != null)
            {
                GetRecord(ref clkcustomer);
                //Save or create new item
                if (clkcustomer.Status != LinkarMainClass.StatusTypes.NEW)
                {

                    string ge = "";
                    //Call the WriteItem method from CLkCustomer
                    try
                    {
                        clkcustomer.WriteRecord("");
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
                    //Call the NewItem method from CLkCustomer
                    try
                    {
                        clkcustomer.NewRecord("");
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
            CLkCustomer clkcustomer = GetCurrentRecord();
            if (clkcustomer != null)
            {
                //Reject the changes in the class
                if (clkcustomer.Status != LinkarMainClass.StatusTypes.NEW)
                {
                    //Call the method Reject changes of CLkCustomer
                    clkcustomer.RejectChanges();
                    DrawRecord(clkcustomer);
                }
                else
                {
                    cLkCustomersBindingSource.Remove(clkcustomer);
                    cLkCustomersBindingSource.MoveFirst();
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
                txtName.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
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
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
            }
        }

        private CLkCustomer GetCurrentRecord()
        {
            CLkCustomer record = null;
            if (cLkCustomersBindingSource != null && cLkCustomersBindingSource.Current != null)
                record = (CLkCustomer)cLkCustomersBindingSource.Current;
            return record;
        }

        private void DrawRecord(CLkCustomer record)
        {
            if (record != null)
            {
                txtCode.Text = record.Code;
                txtName.Text = record.Name;
                txtAddress.Text = record.Address;
                txtPhone.Text = record.Phone;
            }
        }

        private void GetRecord(ref CLkCustomer record)
        {
            record.Code = txtCode.Text;
            record.Name = txtName.Text;
            record.Address = txtAddress.Text;
            record.Phone = txtPhone.Text;
        }

        #endregion

        private void cLkCustomersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DrawRecord(GetCurrentRecord());
        }
    }
}
