using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace test
{
    public partial class user_manager : Form
    {
        private OracleConnection conn;
        public user_manager(OracleConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void user_list_Click(object sender, EventArgs e)
        {

        }

        private void list_user_button_Click(object sender, EventArgs e)
        {
            list_user_list_box.Visible = true;
            String sql = "SELECT * FROM all_users where user_id>=(Select user_id from all_Users where username='U_ADMIN') and user_id < 1279990";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list_user_list_box.Items.Add(reader["USERNAME"]);
            }

        }

        private void list_user_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_user_data_grid_view.Visible = true;
            String user_name_role = list_user_list_box.GetItemText(list_user_list_box.SelectedItem);
            String sql = "select * from DBA_SYS_PRIVS where grantee='" + user_name_role + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            DataTable user_role_data_table = new DataTable();
            user_role_data_table.Load(cmd.ExecuteReader());
            list_user_data_grid_view.DataSource = user_role_data_table;
        }

        private void method_edit_user_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = method_edit_user_combobox.SelectedIndex;
            label1.Text = "Content";
            if (id == 0)
            {
                label1.Text = "Adding new user";
                String sql = "select * from Cu_Tri where CT_USERNAME=Null";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_edit_user_combobox.Items.Add(reader["USERNAME"]);
                }
                
            }
            else if(id == 1)
            {
                label1.Text = "Editing user";
            }
            else
            {
                label1.Text = "Deleting user";
            }
        }
    }
}