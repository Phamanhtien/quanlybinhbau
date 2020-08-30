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
    public partial class vote_form : Form
    {
        private OracleConnection conn;
        private String ct_username;
        public vote_form(OracleConnection connnect,String username)
        {
            InitializeComponent();
            conn = connnect;
            ct_username = username;

        }

        private void vote_form_Load(object sender, EventArgs e)
        {
            String sql = "select * from U_admin.V_UngCuVien";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String MANV = reader["CT_MANV"].ToString();
                String FullName = reader["CT_HOTEN"].ToString();
                String ung_cu_vien_information = MANV + " : " + FullName;
                list_candidate.Items.Add(ung_cu_vien_information);
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int numberItemChecked = list_candidate.CheckedItems.Count;
            if(numberItemChecked == 3)
            {
                String theOne = list_candidate.CheckedItems[0].ToString();
                String theSecond = list_candidate.CheckedItems[1].ToString();
                String theThird = list_candidate.CheckedItems[2].ToString();
                String sql_query_manv = "select "+ct_username;
                String sql_call_procetrue = "";
                MessageBox.Show("Bình chọn thành công");
            }
            else
            {
                String message = "Số lượng bình chọn không hợp lệ, vui lòng chọn lại";
                String tiltle = "Lỗi bình chọn";    
                MessageBox.Show(message, tiltle);
            }    

        }
    }
}
