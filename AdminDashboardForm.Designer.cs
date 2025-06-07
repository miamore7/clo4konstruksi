namespace clo4konstruksi
{
    partial class AdminDashboardForm
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
            this.logoutButton = new MetroFramework.Controls.MetroButton();
            this.lihatAkunButton = new MetroFramework.Controls.MetroButton();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.loadDataButton = new MetroFramework.Controls.MetroButton();
            this.manajemenAdminGroupBox = new System.Windows.Forms.GroupBox();
            this.setInactiveButton = new MetroFramework.Controls.MetroButton();
            this.setActiveButton = new MetroFramework.Controls.MetroButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.manajemenAdminGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(701, 31);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseSelectable = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // lihatAkunButton
            // 
            this.lihatAkunButton.Location = new System.Drawing.Point(584, 31);
            this.lihatAkunButton.Name = "lihatAkunButton";
            this.lihatAkunButton.Size = new System.Drawing.Size(111, 23);
            this.lihatAkunButton.TabIndex = 5;
            this.lihatAkunButton.Text = "Manajemen Akun";
            this.lihatAkunButton.UseSelectable = true;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToOrderColumns = true;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Location = new System.Drawing.Point(23, 63);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(555, 150);
            this.itemsDataGridView.TabIndex = 6;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(584, 63);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(192, 23);
            this.loadDataButton.TabIndex = 7;
            this.loadDataButton.Text = "Tampilkan Semua Barang";
            this.loadDataButton.UseSelectable = true;
            // 
            // manajemenAdminGroupBox
            // 
            this.manajemenAdminGroupBox.Controls.Add(this.setInactiveButton);
            this.manajemenAdminGroupBox.Controls.Add(this.setActiveButton);
            this.manajemenAdminGroupBox.Controls.Add(this.usersDataGridView);
            this.manajemenAdminGroupBox.Location = new System.Drawing.Point(23, 219);
            this.manajemenAdminGroupBox.Name = "manajemenAdminGroupBox";
            this.manajemenAdminGroupBox.Size = new System.Drawing.Size(753, 208);
            this.manajemenAdminGroupBox.TabIndex = 8;
            this.manajemenAdminGroupBox.TabStop = false;
            this.manajemenAdminGroupBox.Text = "Manajemen Admin";
            this.manajemenAdminGroupBox.Visible = false;
            // 
            // setInactiveButton
            // 
            this.setInactiveButton.Location = new System.Drawing.Point(561, 48);
            this.setInactiveButton.Name = "setInactiveButton";
            this.setInactiveButton.Size = new System.Drawing.Size(186, 23);
            this.setInactiveButton.TabIndex = 2;
            this.setInactiveButton.Text = "Non-Aktifkan";
            this.setInactiveButton.UseSelectable = true;
            // 
            // setActiveButton
            // 
            this.setActiveButton.Location = new System.Drawing.Point(561, 19);
            this.setActiveButton.Name = "setActiveButton";
            this.setActiveButton.Size = new System.Drawing.Size(186, 23);
            this.setActiveButton.TabIndex = 1;
            this.setActiveButton.Text = "Aktifkan";
            this.setActiveButton.UseSelectable = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 19);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(549, 183);
            this.usersDataGridView.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manajemenAdminGroupBox);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.lihatAkunButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.manajemenAdminGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton logoutButton;
        private MetroFramework.Controls.MetroButton lihatAkunButton;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private MetroFramework.Controls.MetroButton loadDataButton;
        private System.Windows.Forms.GroupBox manajemenAdminGroupBox;
        private MetroFramework.Controls.MetroButton setInactiveButton;
        private MetroFramework.Controls.MetroButton setActiveButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
    }
}