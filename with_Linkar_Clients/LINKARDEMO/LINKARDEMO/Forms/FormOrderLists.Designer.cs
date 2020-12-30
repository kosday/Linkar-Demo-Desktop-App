namespace LINKARDEMO
{
    partial class FormOrderLists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgSubvalues = new System.Windows.Forms.DataGridView();
            this.lstLstPartialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstLstItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgMultivalues = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgRecords = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.deliveryDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLkOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCustomerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubvalues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstPartialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultivalues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLkOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSelect);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 30);
            this.panel1.TabIndex = 1;
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(210, 6);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(298, 20);
            this.txtSelect.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(595, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(514, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.dgSubvalues);
            this.panel2.Controls.Add(this.dgMultivalues);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgRecords);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 478);
            this.panel2.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(728, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 132);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgSubvalues
            // 
            this.dgSubvalues.AllowUserToAddRows = false;
            this.dgSubvalues.AllowUserToDeleteRows = false;
            this.dgSubvalues.AutoGenerateColumns = false;
            this.dgSubvalues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubvalues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryDateTimeDataGridViewTextBoxColumn,
            this.partialQuantityDataGridViewTextBoxColumn});
            this.dgSubvalues.DataSource = this.lstLstPartialBindingSource;
            this.dgSubvalues.Location = new System.Drawing.Point(5, 343);
            this.dgSubvalues.Name = "dgSubvalues";
            this.dgSubvalues.ReadOnly = true;
            this.dgSubvalues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubvalues.Size = new System.Drawing.Size(869, 125);
            this.dgSubvalues.TabIndex = 19;
            // 
            // lstLstPartialBindingSource
            // 
            this.lstLstPartialBindingSource.DataMember = "LstLstPartial";
            this.lstLstPartialBindingSource.DataSource = this.lstLstItemsBindingSource;
            // 
            // lstLstItemsBindingSource
            // 
            this.lstLstItemsBindingSource.DataMember = "LstLstItems";
            this.lstLstItemsBindingSource.DataSource = this.cLkOrdersBindingSource;
            // 
            // dgMultivalues
            // 
            this.dgMultivalues.AllowUserToAddRows = false;
            this.dgMultivalues.AllowUserToDeleteRows = false;
            this.dgMultivalues.AutoGenerateColumns = false;
            this.dgMultivalues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultivalues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.iTotalLineDataGridViewTextBoxColumn,
            this.iItemDescriptionDataGridViewTextBoxColumn,
            this.iItemStockDataGridViewTextBoxColumn});
            this.dgMultivalues.DataSource = this.lstLstItemsBindingSource;
            this.dgMultivalues.Location = new System.Drawing.Point(5, 193);
            this.dgMultivalues.Name = "dgMultivalues";
            this.dgMultivalues.ReadOnly = true;
            this.dgMultivalues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMultivalues.Size = new System.Drawing.Size(869, 119);
            this.dgMultivalues.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SubValues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "MultiValues";
            // 
            // dgRecords
            // 
            this.dgRecords.AllowUserToAddRows = false;
            this.dgRecords.AllowUserToDeleteRows = false;
            this.dgRecords.AutoGenerateColumns = false;
            this.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iTotalOrderDataGridViewTextBoxColumn,
            this.iCustomerNameDataGridViewTextBoxColumn});
            this.dgRecords.DataSource = this.cLkOrdersBindingSource;
            this.dgRecords.Location = new System.Drawing.Point(4, 4);
            this.dgRecords.MultiSelect = false;
            this.dgRecords.Name = "dgRecords";
            this.dgRecords.ReadOnly = true;
            this.dgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecords.Size = new System.Drawing.Size(869, 121);
            this.dgRecords.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtHelp);
            this.panel4.Location = new System.Drawing.Point(12, 533);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 51);
            this.panel4.TabIndex = 4;
            // 
            // txtHelp
            // 
            this.txtHelp.AcceptsReturn = true;
            this.txtHelp.Location = new System.Drawing.Point(4, 4);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(869, 44);
            this.txtHelp.TabIndex = 0;
            // 
            // deliveryDateTimeDataGridViewTextBoxColumn
            // 
            this.deliveryDateTimeDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDateTime";
            this.deliveryDateTimeDataGridViewTextBoxColumn.HeaderText = "DeliveryDateTime";
            this.deliveryDateTimeDataGridViewTextBoxColumn.Name = "deliveryDateTimeDataGridViewTextBoxColumn";
            this.deliveryDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partialQuantityDataGridViewTextBoxColumn
            // 
            this.partialQuantityDataGridViewTextBoxColumn.DataPropertyName = "PartialQuantity";
            this.partialQuantityDataGridViewTextBoxColumn.HeaderText = "PartialQuantity";
            this.partialQuantityDataGridViewTextBoxColumn.Name = "partialQuantityDataGridViewTextBoxColumn";
            this.partialQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLkOrdersBindingSource
            // 
            this.cLkOrdersBindingSource.DataSource = typeof(LINKARDEMO.CLkOrders);
            this.cLkOrdersBindingSource.CurrentChanged += new System.EventHandler(this.cLkOrdersBindingSource_CurrentChanged);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTotalLineDataGridViewTextBoxColumn
            // 
            this.iTotalLineDataGridViewTextBoxColumn.DataPropertyName = "ITotalLine";
            this.iTotalLineDataGridViewTextBoxColumn.HeaderText = "ITotalLine";
            this.iTotalLineDataGridViewTextBoxColumn.Name = "iTotalLineDataGridViewTextBoxColumn";
            this.iTotalLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iItemDescriptionDataGridViewTextBoxColumn
            // 
            this.iItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "IItemDescription";
            this.iItemDescriptionDataGridViewTextBoxColumn.HeaderText = "IItemDescription";
            this.iItemDescriptionDataGridViewTextBoxColumn.Name = "iItemDescriptionDataGridViewTextBoxColumn";
            this.iItemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iItemStockDataGridViewTextBoxColumn
            // 
            this.iItemStockDataGridViewTextBoxColumn.DataPropertyName = "IItemStock";
            this.iItemStockDataGridViewTextBoxColumn.HeaderText = "IItemStock";
            this.iItemStockDataGridViewTextBoxColumn.Name = "iItemStockDataGridViewTextBoxColumn";
            this.iItemStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTotalOrderDataGridViewTextBoxColumn
            // 
            this.iTotalOrderDataGridViewTextBoxColumn.DataPropertyName = "ITotalOrder";
            this.iTotalOrderDataGridViewTextBoxColumn.HeaderText = "ITotalOrder";
            this.iTotalOrderDataGridViewTextBoxColumn.Name = "iTotalOrderDataGridViewTextBoxColumn";
            this.iTotalOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iCustomerNameDataGridViewTextBoxColumn
            // 
            this.iCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "ICustomerName";
            this.iCustomerNameDataGridViewTextBoxColumn.HeaderText = "ICustomerName";
            this.iCustomerNameDataGridViewTextBoxColumn.Name = "iCustomerNameDataGridViewTextBoxColumn";
            this.iCustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormOrderLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 596);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrderLists";
            this.Text = "Order List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubvalues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstPartialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultivalues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLkOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgRecords;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCustomerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLkOrdersBindingSource;
        private System.Windows.Forms.DataGridView dgSubvalues;
        private System.Windows.Forms.DataGridView dgMultivalues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lstLstPartialBindingSource;
        private System.Windows.Forms.BindingSource lstLstItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iItemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iItemStockDataGridViewTextBoxColumn;
    }
}