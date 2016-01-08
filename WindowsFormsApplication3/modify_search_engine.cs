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
    public partial class modify_search_engine : Form
    {
        public modify_search_engine()
        {
            InitializeComponent();
        }

        public class Myclass
        {
            public static string sitecode = "";//定义全局变量sitecode,从search_engine场地代码中输入，用于site中
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog = cdsj;Integrated Security=true");//Initial catalog后面跟数据库的名字
            conn.Open();//数据库链接打开
            SqlCommand cmd = new SqlCommand("select * from site_info where site_code = '" + textBox1.Text.Trim() + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            Myclass.sitecode = this.textBox1.Text;//保存输入的场地代码


            if (sdr.HasRows)
            {
                MessageBox.Show("查询成功！");
                modify_table_menu f4 = new modify_table_menu();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("查询失败！请重新输入");
            }
            conn.Close();//关闭对象并释放所占内存空间
            sdr.Close(); 









        }

        private void button2_Click(object sender, EventArgs e)
        {
            statistics mm = new statistics();
            mm.Show();
        }
    }
}
