using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//连接数据库
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//连接数据库



namespace WindowsFormsApplication3
{
    public partial class main_login : Form
    {
        public main_login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public class Myclass
        {
            public static string auth_type = "";//定义全局变量auth_type,根据用户名获取auth_type
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
                MessageBox.Show("提示：请输入用户名和密码！");
                SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog = cdsj;Integrated Security=true");//建立数据库连接
                conn.Open();//打开连接
                SqlCommand cmd = new SqlCommand("select * from login where username = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'", conn);//建立命令对象。查询输入的用户名密码是否在数据库中
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                   MessageBox.Show("登录成功！");
                   sdr.Close();
                   string sql20 = "select auth_type from login where username = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";//查询登录权限
                   SqlCommand cmd20 = new SqlCommand(sql20, conn);//建立命令对象
                   string auth_type = (string)cmd20.ExecuteScalar();//通过executescalar方法返回单值
                   Myclass.auth_type = auth_type;
                   //menu f2 = new menu();
                   search_engine f2 = new search_engine();
                   f2.Show();
                   this.Hide();
                }
                else
                { 
                    MessageBox.Show("提示：用户名或密码错误！");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                sdr.Close();
                conn.Close();//关闭连接。对象并释放所占内存空间
        }

                     
    }
}
