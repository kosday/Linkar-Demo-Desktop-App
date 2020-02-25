namespace LINKARDEMO
{
    partial class FormDemo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtFreeText = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLinkarPort = new System.Windows.Forms.NumericUpDown();
            this.txtLinkarHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntryPoint = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrdersList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinkarPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Free Text:";
            // 
            // txtFreeText
            // 
            this.txtFreeText.Location = new System.Drawing.Point(298, 84);
            this.txtFreeText.Name = "txtFreeText";
            this.txtFreeText.Size = new System.Drawing.Size(125, 20);
            this.txtFreeText.TabIndex = 13;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(79, 84);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(125, 20);
            this.txtLanguage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Language:";
            // 
            // txtLinkarPort
            // 
            this.txtLinkarPort.Location = new System.Drawing.Point(365, 33);
            this.txtLinkarPort.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.txtLinkarPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.txtLinkarPort.Name = "txtLinkarPort";
            this.txtLinkarPort.Size = new System.Drawing.Size(58, 20);
            this.txtLinkarPort.TabIndex = 5;
            this.txtLinkarPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // txtLinkarHost
            // 
            this.txtLinkarHost.Location = new System.Drawing.Point(79, 6);
            this.txtLinkarHost.Name = "txtLinkarHost";
            this.txtLinkarHost.Size = new System.Drawing.Size(125, 20);
            this.txtLinkarHost.TabIndex = 1;
            this.txtLinkarHost.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EntryPoint Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Linkar Host";
            // 
            // txtEntryPoint
            // 
            this.txtEntryPoint.Location = new System.Drawing.Point(79, 32);
            this.txtEntryPoint.Name = "txtEntryPoint";
            this.txtEntryPoint.Size = new System.Drawing.Size(125, 20);
            this.txtEntryPoint.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EntryPoint:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Linkar User:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 20);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "admin";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(116, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(217, 128);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Enabled = false;
            this.btnCustomers.Location = new System.Drawing.Point(14, 174);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 16;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Enabled = false;
            this.btnItems.Location = new System.Drawing.Point(116, 174);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 23);
            this.btnItems.TabIndex = 17;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Enabled = false;
            this.btnOrderDetails.Location = new System.Drawing.Point(217, 174);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(97, 23);
            this.btnOrderDetails.TabIndex = 18;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrdersList
            // 
            this.btnOrdersList.Enabled = false;
            this.btnOrdersList.Location = new System.Drawing.Point(331, 174);
            this.btnOrdersList.Name = "btnOrdersList";
            this.btnOrdersList.Size = new System.Drawing.Size(92, 23);
            this.btnOrdersList.TabIndex = 19;
            this.btnOrdersList.Text = "Order Lists";
            this.btnOrdersList.UseVisualStyleBackColor = true;
            this.btnOrdersList.Click += new System.EventHandler(this.btnOrdersList_Click);
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.Controls.Add(this.btnOrdersList);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFreeText);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLinkarPort);
            this.Controls.Add(this.txtLinkarHost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntryPoint);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Name = "FormDemo";
            this.Text = "Demo";
            ((System.ComponentModel.ISupportInitialize)(this.txtLinkarPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtFreeText;
        public System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown txtLinkarPort;
        public System.Windows.Forms.TextBox txtLinkarHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEntryPoint;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrdersList;
    }
}

