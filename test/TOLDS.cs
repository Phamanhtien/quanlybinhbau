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
    public partial class TOLDS : Form
    {
        private OracleConnection conn;
        private String userName;
        private String ct_donvi;
        public TOLDS(OracleConnection connect, String user_name)
        {
            InitializeComponent();
            conn = connect;
            userName = user_name;
        }
        private void setCT_DONVI()
        {
            String dv_number = userName.Substring(userName.Length - 3, userName.Length - 1);
            String ct_donvi = "DV" + dv_number;
        }

        private void TOLDS_Load(object sender, EventArgs e)
        {
            String sql = "select* from U_ADMIN.v_nhanviendexuat";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String manv = reader["MANV"].ToString();
                String hoten = reader["HOTEN"].ToString();
                String infomation = manv + " : " + hoten;
                danhsanhdexuat_listCheckbox.Items.Add(infomation);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int numberchecked = danhsanhdexuat_listCheckbox.Items.Count;
            for (int i = 0; i < numberchecked-1; i++)
            {
                String checked_value = danhsanhdexuat_listCheckbox.CheckedItems[i].ToString();
                int index = checked_value.IndexOf(" : ");
                String manv = checked_value.Substring(0, index);
                String name = "u_admin.SP_ThemCuTri";
                label1.Text = manv;
                /*
                OracleCommand cmd = new OracleCommand(name,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("c_ma", OracleDbType.NVarchar2).Value=manv;
                cmd.ExecuteNonQuery();
                */
            }
        }
    }
}
