using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String userName = username_textbox.Text;
            String password = password_textbox.Text;
            string oradb = "Data Source=localhost:1521/XE;User Id="+userName+";Password="+password+";";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            this.Hide();
            if(userName == "U_ADMIN")
            {
                user_manager userManage = new user_manager(conn);
                userManage.Closed += (s, args) => this.Close();
                userManage.Show();
            }
            else if(userName == "A_ADMIN")
            {
                access_control accessConTrolManage = new access_control();
                accessConTrolManage.Closed += (s, args) => this.Close();
                accessConTrolManage.Show();
            }
            else
            {
                String user_role;
                user_role = userName.Substring(0, userName.Length - 2);
                if (String.Compare(user_role,"CUTRI",true)==0)
                {
                    vote_form voteForm = new vote_form(conn,userName);
                    voteForm.Closed += (s, args) => this.Close();
                    voteForm.Show();
                }
                else if(String.Compare(user_role,"TOGS")==0)
                {

                }
                else if(String.Compare(user_role,"ToLDS")==0)
                {
                    TOLDS toLDS = new TOLDS(conn,userName);
                    toLDS.Closed += (s, args) => this.Close();
                    toLDS.Show();
                }    
                else if(String.Compare(user_role,"TOTDKQ")==0)
                {

                }
                else if (String.Compare(user_role, "BTC") == 0)
                {
                    BTCForm BTC = new BTCForm();
                    BTC.Closed += (s,agrs) => this.Close();
                    BTC.Show();
                }
            }
            String sql = "select * from user_role_privs";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader reader = cmd.ExecuteReader();
            this.Hide();
            
        }
    }
}
