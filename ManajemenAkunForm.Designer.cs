namespace clo4konstruksi
{
    partial class ManajemenAkunForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.loadAdminButton = new MetroFramework.Controls.MetroButton();
            this.setActiveButton = new MetroFramework.Controls.MetroButton();
            this.setInactiveButton = new MetroFramework.Controls.MetroButton();
            this.deleteAdminButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.createAdminButton = new MetroFramework.Controls.MetroButton();
            this.kembaliButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Manajemen Akun Admin";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(23, 82);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(754, 100);
            this.usersDataGridView.TabIndex = 1;
            // 
            // loadAdminButton
            // 
            this.loadAdminButton.Location = new System.Drawing.Point(60, 186);
            this.loadAdminButton.Name = "loadAdminButton";
            this.loadAdminButton.Size = new System.Drawing.Size(150, 25);
            this.loadAdminButton.TabIndex = 2;
            this.loadAdminButton.Text = "Muat Ulang Data";
            this.loadAdminButton.UseSelectable = true;
            this.loadAdminButton.Click += new System.EventHandler(this.loadAdminButton_Click);
            // 
            // setActiveButton
            // 
            this.setActiveButton.Location = new System.Drawing.Point(242, 186);
            this.setActiveButton.Name = "setActiveButton";
            this.setActiveButton.Size = new System.Drawing.Size(150, 25);
            this.setActiveButton.TabIndex = 3;
            this.setActiveButton.Text = "Aktifkan Akun Terpilih";
            this.setActiveButton.UseSelectable = true;
            this.setActiveButton.Click += new System.EventHandler(this.setActiveButton_Click);
            // 
            // setInactiveButton
            // 
            this.setInactiveButton.Location = new System.Drawing.Point(418, 186);
            this.setInactiveButton.Name = "setInactiveButton";
            this.setInactiveButton.Size = new System.Drawing.Size(150, 25);
            this.setInactiveButton.TabIndex = 4;
            this.setInactiveButton.Text = "Non-Aktifkan Akun Terpilih";
            this.setInactiveButton.UseSelectable = true;
            this.setInactiveButton.Click += new System.EventHandler(this.setInactiveButton_Click);
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.Location = new System.Drawing.Point(595, 186);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(150, 25);
            this.deleteAdminButton.TabIndex = 5;
            this.deleteAdminButton.Text = "Hapus Akun Terpilih";
            this.deleteAdminButton.UseSelectable = true;
            this.deleteAdminButton.Click += new System.EventHandler(this.deleteAdminButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kembaliButton);
            this.groupBox1.Controls.Add(this.createAdminButton);
            this.groupBox1.Controls.Add(this.newPasswordTextBox);
            this.groupBox1.Controls.Add(this.newUsernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buat Akun Admin Baru";
            // 
            // newUsernameTextBox
            // 
            // 
            // 
            // 
            this.newUsernameTextBox.CustomButton.Image = null;
            this.newUsernameTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.newUsernameTextBox.CustomButton.Name = "";
            this.newUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newUsernameTextBox.CustomButton.TabIndex = 1;
            this.newUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newUsernameTextBox.CustomButton.UseSelectable = true;
            this.newUsernameTextBox.CustomButton.Visible = false;
            this.newUsernameTextBox.Lines = new string[0];
            this.newUsernameTextBox.Location = new System.Drawing.Point(6, 19);
            this.newUsernameTextBox.MaxLength = 32767;
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.PasswordChar = '\0';
            this.newUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newUsernameTextBox.SelectedText = "";
            this.newUsernameTextBox.SelectionLength = 0;
            this.newUsernameTextBox.SelectionStart = 0;
            this.newUsernameTextBox.ShortcutsEnabled = true;
            this.newUsernameTextBox.Size = new System.Drawing.Size(181, 23);
            this.newUsernameTextBox.TabIndex = 0;
            this.newUsernameTextBox.UseSelectable = true;
            this.newUsernameTextBox.WaterMark = "Username Baru";
            this.newUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPasswordTextBox
            // 
            // 
            // 
            // 
            this.newPasswordTextBox.CustomButton.Image = null;
            this.newPasswordTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.newPasswordTextBox.CustomButton.Name = "";
            this.newPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPasswordTextBox.CustomButton.TabIndex = 1;
            this.newPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPasswordTextBox.CustomButton.UseSelectable = true;
            this.newPasswordTextBox.CustomButton.Visible = false;
            this.newPasswordTextBox.Lines = new string[0];
            this.newPasswordTextBox.Location = new System.Drawing.Point(7, 49);
            this.newPasswordTextBox.MaxLength = 32767;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.SelectionLength = 0;
            this.newPasswordTextBox.SelectionStart = 0;
            this.newPasswordTextBox.ShortcutsEnabled = true;
            this.newPasswordTextBox.Size = new System.Drawing.Size(180, 23);
            this.newPasswordTextBox.TabIndex = 1;
            this.newPasswordTextBox.UseSelectable = true;
            this.newPasswordTextBox.WaterMark = "Password Baru";
            this.newPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createAdminButton
            // 
            this.createAdminButton.Location = new System.Drawing.Point(7, 80);
            this.createAdminButton.Name = "createAdminButton";
            this.createAdminButton.Size = new System.Drawing.Size(180, 23);
            this.createAdminButton.TabIndex = 2;
            this.createAdminButton.Text = "Buat Akun";
            this.createAdminButton.UseSelectable = true;
            this.createAdminButton.Click += new System.EventHandler(this.createAdminButton_Click);
            // 
            // kembaliButton
            // 
            this.kembaliButton.Location = new System.Drawing.Point(7, 109);
            this.kembaliButton.Name = "kembaliButton";
            this.kembaliButton.Size = new System.Drawing.Size(180, 23);
            this.kembaliButton.TabIndex = 3;
            this.kembaliButton.Text = "Kembali ke Dashboard\n";
            this.kembaliButton.UseSelectable = true;
            this.kembaliButton.Click += new System.EventHandler(this.kembaliButton_Click);
            // 
            // ManajemenAkunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteAdminButton);
            this.Controls.Add(this.setInactiveButton);
            this.Controls.Add(this.setActiveButton);
            this.Controls.Add(this.loadAdminButton);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ManajemenAkunForm";
            this.Text = "ManajemenAkunForm";
            this.Load += new System.EventHandler(this.ManajemenAkunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private MetroFramework.Controls.MetroButton loadAdminButton;
        private MetroFramework.Controls.MetroButton setActiveButton;
        private MetroFramework.Controls.MetroButton setInactiveButton;
        private MetroFramework.Controls.MetroButton deleteAdminButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox newPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox newUsernameTextBox;
        private MetroFramework.Controls.MetroButton kembaliButton;
        private MetroFramework.Controls.MetroButton createAdminButton;
    }
}