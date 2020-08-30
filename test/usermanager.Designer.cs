namespace test
{
    partial class user_manager
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.userControl = new System.Windows.Forms.TabPage();
            this.user_tabControl = new System.Windows.Forms.TabControl();
            this.user_list = new System.Windows.Forms.TabPage();
            this.user_edit = new System.Windows.Forms.TabPage();
            this.user_grant = new System.Windows.Forms.TabPage();
            this.user_revoke = new System.Windows.Forms.TabPage();
            this.user_checking_privilage = new System.Windows.Forms.TabPage();
            this.user_edit_privilage = new System.Windows.Forms.TabPage();
            this.roleControl = new System.Windows.Forms.TabPage();
            this.role_tabControl = new System.Windows.Forms.TabControl();
            this.role_list = new System.Windows.Forms.TabPage();
            this.role_edit = new System.Windows.Forms.TabPage();
            this.role_grant = new System.Windows.Forms.TabPage();
            this.role_revoke = new System.Windows.Forms.TabPage();
            this.role_checking = new System.Windows.Forms.TabPage();
            this.role_edit_privilage = new System.Windows.Forms.TabPage();
            this.list_user_button = new System.Windows.Forms.Button();
            this.list_user_list_box = new System.Windows.Forms.ListBox();
            this.list_user_data_grid_view = new System.Windows.Forms.DataGridView();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.list_edit_user_combobox = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.method_edit_user_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_control.SuspendLayout();
            this.userControl.SuspendLayout();
            this.user_tabControl.SuspendLayout();
            this.user_list.SuspendLayout();
            this.user_edit.SuspendLayout();
            this.roleControl.SuspendLayout();
            this.role_tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_user_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.userControl);
            this.tab_control.Controls.Add(this.roleControl);
            this.tab_control.Location = new System.Drawing.Point(0, -1);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(800, 456);
            this.tab_control.TabIndex = 2;
            // 
            // userControl
            // 
            this.userControl.Controls.Add(this.user_tabControl);
            this.userControl.Location = new System.Drawing.Point(4, 22);
            this.userControl.Name = "userControl";
            this.userControl.Padding = new System.Windows.Forms.Padding(3);
            this.userControl.Size = new System.Drawing.Size(792, 430);
            this.userControl.TabIndex = 0;
            this.userControl.Text = "User";
            this.userControl.UseVisualStyleBackColor = true;
            // 
            // user_tabControl
            // 
            this.user_tabControl.Controls.Add(this.user_list);
            this.user_tabControl.Controls.Add(this.user_edit);
            this.user_tabControl.Controls.Add(this.user_grant);
            this.user_tabControl.Controls.Add(this.user_revoke);
            this.user_tabControl.Controls.Add(this.user_checking_privilage);
            this.user_tabControl.Controls.Add(this.user_edit_privilage);
            this.user_tabControl.Location = new System.Drawing.Point(-4, -1);
            this.user_tabControl.Name = "user_tabControl";
            this.user_tabControl.SelectedIndex = 0;
            this.user_tabControl.Size = new System.Drawing.Size(800, 430);
            this.user_tabControl.TabIndex = 0;
            // 
            // user_list
            // 
            this.user_list.Controls.Add(this.list_user_data_grid_view);
            this.user_list.Controls.Add(this.list_user_list_box);
            this.user_list.Controls.Add(this.list_user_button);
            this.user_list.Location = new System.Drawing.Point(4, 22);
            this.user_list.Name = "user_list";
            this.user_list.Padding = new System.Windows.Forms.Padding(3);
            this.user_list.Size = new System.Drawing.Size(792, 404);
            this.user_list.TabIndex = 0;
            this.user_list.Text = "List";
            this.user_list.UseVisualStyleBackColor = true;
            this.user_list.Click += new System.EventHandler(this.user_list_Click);
            // 
            // user_edit
            // 
            this.user_edit.Controls.Add(this.label1);
            this.user_edit.Controls.Add(this.method_edit_user_combobox);
            this.user_edit.Controls.Add(this.textBox1);
            this.user_edit.Controls.Add(this.comboBox3);
            this.user_edit.Controls.Add(this.list_edit_user_combobox);
            this.user_edit.Controls.Add(this.button1);
            this.user_edit.Location = new System.Drawing.Point(4, 22);
            this.user_edit.Name = "user_edit";
            this.user_edit.Padding = new System.Windows.Forms.Padding(3);
            this.user_edit.Size = new System.Drawing.Size(792, 404);
            this.user_edit.TabIndex = 1;
            this.user_edit.Text = "Edit";
            this.user_edit.UseVisualStyleBackColor = true;
            // 
            // user_grant
            // 
            this.user_grant.Location = new System.Drawing.Point(4, 22);
            this.user_grant.Name = "user_grant";
            this.user_grant.Size = new System.Drawing.Size(792, 404);
            this.user_grant.TabIndex = 2;
            this.user_grant.Text = "Grant";
            this.user_grant.UseVisualStyleBackColor = true;
            // 
            // user_revoke
            // 
            this.user_revoke.Location = new System.Drawing.Point(4, 22);
            this.user_revoke.Name = "user_revoke";
            this.user_revoke.Size = new System.Drawing.Size(792, 404);
            this.user_revoke.TabIndex = 3;
            this.user_revoke.Text = "Revoke";
            this.user_revoke.UseVisualStyleBackColor = true;
            // 
            // user_checking_privilage
            // 
            this.user_checking_privilage.Location = new System.Drawing.Point(4, 22);
            this.user_checking_privilage.Name = "user_checking_privilage";
            this.user_checking_privilage.Size = new System.Drawing.Size(792, 404);
            this.user_checking_privilage.TabIndex = 4;
            this.user_checking_privilage.Text = "Checking Privilage";
            this.user_checking_privilage.UseVisualStyleBackColor = true;
            // 
            // user_edit_privilage
            // 
            this.user_edit_privilage.Location = new System.Drawing.Point(4, 22);
            this.user_edit_privilage.Name = "user_edit_privilage";
            this.user_edit_privilage.Size = new System.Drawing.Size(792, 404);
            this.user_edit_privilage.TabIndex = 5;
            this.user_edit_privilage.Text = "Edit Privilage";
            this.user_edit_privilage.UseVisualStyleBackColor = true;
            // 
            // roleControl
            // 
            this.roleControl.Controls.Add(this.role_tabControl);
            this.roleControl.Location = new System.Drawing.Point(4, 22);
            this.roleControl.Name = "roleControl";
            this.roleControl.Padding = new System.Windows.Forms.Padding(3);
            this.roleControl.Size = new System.Drawing.Size(792, 430);
            this.roleControl.TabIndex = 1;
            this.roleControl.Text = "Role";
            this.roleControl.UseVisualStyleBackColor = true;
            // 
            // role_tabControl
            // 
            this.role_tabControl.Controls.Add(this.role_list);
            this.role_tabControl.Controls.Add(this.role_edit);
            this.role_tabControl.Controls.Add(this.role_grant);
            this.role_tabControl.Controls.Add(this.role_revoke);
            this.role_tabControl.Controls.Add(this.role_checking);
            this.role_tabControl.Controls.Add(this.role_edit_privilage);
            this.role_tabControl.Location = new System.Drawing.Point(0, 2);
            this.role_tabControl.Name = "role_tabControl";
            this.role_tabControl.SelectedIndex = 0;
            this.role_tabControl.Size = new System.Drawing.Size(796, 431);
            this.role_tabControl.TabIndex = 0;
            // 
            // role_list
            // 
            this.role_list.Location = new System.Drawing.Point(4, 22);
            this.role_list.Name = "role_list";
            this.role_list.Padding = new System.Windows.Forms.Padding(3);
            this.role_list.Size = new System.Drawing.Size(788, 405);
            this.role_list.TabIndex = 0;
            this.role_list.Text = "List";
            this.role_list.UseVisualStyleBackColor = true;
            // 
            // role_edit
            // 
            this.role_edit.Location = new System.Drawing.Point(4, 22);
            this.role_edit.Name = "role_edit";
            this.role_edit.Padding = new System.Windows.Forms.Padding(3);
            this.role_edit.Size = new System.Drawing.Size(788, 405);
            this.role_edit.TabIndex = 1;
            this.role_edit.Text = "Edit";
            this.role_edit.UseVisualStyleBackColor = true;
            // 
            // role_grant
            // 
            this.role_grant.Location = new System.Drawing.Point(4, 22);
            this.role_grant.Name = "role_grant";
            this.role_grant.Size = new System.Drawing.Size(788, 405);
            this.role_grant.TabIndex = 2;
            this.role_grant.Text = "Grant";
            this.role_grant.UseVisualStyleBackColor = true;
            // 
            // role_revoke
            // 
            this.role_revoke.Location = new System.Drawing.Point(4, 22);
            this.role_revoke.Name = "role_revoke";
            this.role_revoke.Size = new System.Drawing.Size(788, 405);
            this.role_revoke.TabIndex = 3;
            this.role_revoke.Text = "Revoke";
            this.role_revoke.UseVisualStyleBackColor = true;
            // 
            // role_checking
            // 
            this.role_checking.Location = new System.Drawing.Point(4, 22);
            this.role_checking.Name = "role_checking";
            this.role_checking.Size = new System.Drawing.Size(788, 405);
            this.role_checking.TabIndex = 4;
            this.role_checking.Text = "Checking";
            this.role_checking.UseVisualStyleBackColor = true;
            // 
            // role_edit_privilage
            // 
            this.role_edit_privilage.Location = new System.Drawing.Point(4, 22);
            this.role_edit_privilage.Name = "role_edit_privilage";
            this.role_edit_privilage.Size = new System.Drawing.Size(788, 405);
            this.role_edit_privilage.TabIndex = 5;
            this.role_edit_privilage.Text = "Edit Privilage";
            this.role_edit_privilage.UseVisualStyleBackColor = true;
            // 
            // list_user_button
            // 
            this.list_user_button.Location = new System.Drawing.Point(3, 16);
            this.list_user_button.Name = "list_user_button";
            this.list_user_button.Size = new System.Drawing.Size(75, 23);
            this.list_user_button.TabIndex = 0;
            this.list_user_button.Text = "LIST USER";
            this.list_user_button.UseVisualStyleBackColor = true;
            this.list_user_button.Click += new System.EventHandler(this.list_user_button_Click);
            // 
            // list_user_list_box
            // 
            this.list_user_list_box.FormattingEnabled = true;
            this.list_user_list_box.Location = new System.Drawing.Point(6, 54);
            this.list_user_list_box.MultiColumn = true;
            this.list_user_list_box.Name = "list_user_list_box";
            this.list_user_list_box.Size = new System.Drawing.Size(133, 329);
            this.list_user_list_box.Sorted = true;
            this.list_user_list_box.TabIndex = 1;
            this.list_user_list_box.Visible = false;
            this.list_user_list_box.SelectedIndexChanged += new System.EventHandler(this.list_user_list_box_SelectedIndexChanged);
            // 
            // list_user_data_grid_view
            // 
            this.list_user_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_user_data_grid_view.Location = new System.Drawing.Point(145, 54);
            this.list_user_data_grid_view.Name = "list_user_data_grid_view";
            this.list_user_data_grid_view.Size = new System.Drawing.Size(622, 329);
            this.list_user_data_grid_view.TabIndex = 2;
            this.list_user_data_grid_view.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // list_edit_user_combobox
            // 
            this.list_edit_user_combobox.FormattingEnabled = true;
            this.list_edit_user_combobox.Location = new System.Drawing.Point(8, 101);
            this.list_edit_user_combobox.Name = "list_edit_user_combobox";
            this.list_edit_user_combobox.Size = new System.Drawing.Size(121, 21);
            this.list_edit_user_combobox.TabIndex = 2;
            this.list_edit_user_combobox.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(245, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // method_edit_user_combobox
            // 
            this.method_edit_user_combobox.FormattingEnabled = true;
            this.method_edit_user_combobox.Items.AddRange(new object[] {
            "ADD USER",
            "DELETE USER",
            "EDIT USER"});
            this.method_edit_user_combobox.Location = new System.Drawing.Point(8, 34);
            this.method_edit_user_combobox.Name = "method_edit_user_combobox";
            this.method_edit_user_combobox.Size = new System.Drawing.Size(121, 21);
            this.method_edit_user_combobox.TabIndex = 5;
            this.method_edit_user_combobox.SelectedIndexChanged += new System.EventHandler(this.method_edit_user_combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // user_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_control);
            this.Name = "user_manager";
            this.Text = "User Manager";
            this.tab_control.ResumeLayout(false);
            this.userControl.ResumeLayout(false);
            this.user_tabControl.ResumeLayout(false);
            this.user_list.ResumeLayout(false);
            this.user_edit.ResumeLayout(false);
            this.user_edit.PerformLayout();
            this.roleControl.ResumeLayout(false);
            this.role_tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_user_data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage userControl;
        private System.Windows.Forms.TabPage roleControl;
        private System.Windows.Forms.TabControl user_tabControl;
        private System.Windows.Forms.TabPage user_list;
        private System.Windows.Forms.TabPage user_edit;
        private System.Windows.Forms.TabPage user_grant;
        private System.Windows.Forms.TabPage user_revoke;
        private System.Windows.Forms.TabPage user_checking_privilage;
        private System.Windows.Forms.TabPage user_edit_privilage;
        private System.Windows.Forms.TabControl role_tabControl;
        private System.Windows.Forms.TabPage role_list;
        private System.Windows.Forms.TabPage role_edit;
        private System.Windows.Forms.TabPage role_grant;
        private System.Windows.Forms.TabPage role_revoke;
        private System.Windows.Forms.TabPage role_checking;
        private System.Windows.Forms.TabPage role_edit_privilage;
        private System.Windows.Forms.DataGridView list_user_data_grid_view;
        private System.Windows.Forms.ListBox list_user_list_box;
        private System.Windows.Forms.Button list_user_button;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox list_edit_user_combobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox method_edit_user_combobox;
        private System.Windows.Forms.Label label1;
    }
}

