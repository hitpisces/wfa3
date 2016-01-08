using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//连接数据库
using System.Data.OleDb;//连接数据库

namespace WindowsFormsApplication3
{
    public partial class risk_accessment : Form
    {
        public risk_accessment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
                SqlConnection lo_con = new SqlConnection(strConnection);
                lo_con.Open();
                SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
                lo_cmd.CommandText = "select * from site_event where site_code = " + "'" + search_engine.Myclass.sitecode + "'" + "order by start_time asc"; //写SQL语句
                lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
                SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
                DataSet RA = new DataSet(); //创建数据集对象
                dbAdapter.Fill(RA, "site_event"); //用返回的结果集填充数据集
                lo_con.Close();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RA.Tables["site_event"];
            }
            catch (Exception)
            {
                MessageBox.Show("请检索后从左侧栏选取一个场地");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main_login.Myclass.auth_type == "user      ")
            {
                MessageBox.Show("当前身份是用户，无法读写数据库！");
            }
            else if (main_login.Myclass.auth_type == "admin     ")
            {
                MessageBox.Show("保存完成！");
            }
        }
    }
}
