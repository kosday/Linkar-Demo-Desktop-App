namespace LINKARDEMO
{
    partial class FormOrderDetails
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
            this.dgRecords = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLkOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgSubvalues = new System.Windows.Forms.DataGridView();
            this.deliveryDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLstPartialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstLstItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgMultivalues = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLkOrdersBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubvalues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstPartialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultivalues)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.txtSelect.Location = new System.Drawing.Point(213, 5);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(298, 20);
            this.txtSelect.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(517, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgRecords);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 478);
            this.panel2.TabIndex = 2;
            // 
            // dgRecords
            // 
            this.dgRecords.AllowUserToAddRows = false;
            this.dgRecords.AllowUserToDeleteRows = false;
            this.dgRecords.AutoGenerateColumns = false;
            this.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dgRecords.DataSource = this.cLkOrdersBindingSource;
            this.dgRecords.Location = new System.Drawing.Point(4, 4);
            this.dgRecords.MultiSelect = false;
            this.dgRecords.Name = "dgRecords";
            this.dgRecords.ReadOnly = true;
            this.dgRecords.Size = new System.Drawing.Size(193, 471);
            this.dgRecords.TabIndex = 0;
            this.dgRecords.SelectionChanged += new System.EventHandler(this.dgRecords_SelectionChanged);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLkOrdersBindingSource
            // 
            this.cLkOrdersBindingSource.AllowNew = true;
            this.cLkOrdersBindingSource.DataSource = typeof(LINKARDEMO.CLkOrders);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgSubvalues);
            this.panel3.Controls.Add(this.dgMultivalues);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtTotalOrder);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.txtCustomer);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(218, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 478);
            this.panel3.TabIndex = 3;
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
            this.dgSubvalues.Location = new System.Drawing.Point(19, 324);
            this.dgSubvalues.Name = "dgSubvalues";
            this.dgSubvalues.ReadOnly = true;
            this.dgSubvalues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubvalues.Size = new System.Drawing.Size(624, 141);
            this.dgSubvalues.TabIndex = 15;
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
            this.dgMultivalues.Location = new System.Drawing.Point(19, 150);
            this.dgMultivalues.Name = "dgMultivalues";
            this.dgMultivalues.ReadOnly = true;
            this.dgMultivalues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMultivalues.Size = new System.Drawing.Size(624, 141);
            this.dgMultivalues.TabIndex = 14;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SubValues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "MultiValues";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(420, 48);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(232, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Location = new System.Drawing.Point(420, 15);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(232, 20);
            this.txtTotalOrder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Order";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(85, 84);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(198, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(85, 48);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(198, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(85, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(115, 20);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
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
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 596);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrderDetails";
            this.Text = "Order Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLkOrdersBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubvalues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstPartialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLstItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultivalues)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgRecords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.BindingSource cLkOrdersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgSubvalues;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lstLstPartialBindingSource;
        private System.Windows.Forms.BindingSource lstLstItemsBindingSource;
        private System.Windows.Forms.DataGridView dgMultivalues;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iItemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iItemStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}