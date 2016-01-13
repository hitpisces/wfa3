using System;
using System.Text;
using System.Data.SqlClient;//连接数据库
using System.Windows.Forms;
using System.Security.Cryptography;



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
            public static string strConnection = "Data Source=WIN-H71C4G8Z0AL;Initial Catalog=cdsj;Persist Security Info=True;User ID=sa;Password=sustc@10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
                MessageBox.Show("提示：请输入用户名和密码！");
                SqlConnection conn = new SqlConnection(Myclass.strConnection);//建立数据库连接
                conn.Open();//打开连接
                SqlCommand cmd = new SqlCommand("select * from login where username = '" + textBox1.Text.Trim() + "' and password = '" + GetMD5Hash(textBox2.Text.Trim()) + "'", conn);//建立命令对象。查询输入的用户名密码是否在数据库中
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                if (sdr.HasRows)
                {
                   sdr.Close();
                   string sql20 = "select auth_type from login where username = '" + textBox1.Text.Trim() + "' and password = '" + GetMD5Hash(textBox2.Text.Trim()) + "'";//查询登录权限
                   SqlCommand cmd20 = new SqlCommand(sql20, conn);//建立命令对象
                   string auth_type = (string)cmd20.ExecuteScalar();//通过executescalar方法返回单值
                   Myclass.auth_type = auth_type;
                   
                switch (Myclass.auth_type)
                {
                    case ("00"):
                        MessageBox.Show("提示：您将以系统管理员身份登录，请慎重操作！");
                        break;

                    case ("01"):
                        MessageBox.Show("提示：您将以审核者身份登录，请慎重操作！");
                        break;

                    case ("10"):
                        MessageBox.Show("提示：您将以数据录入者身份登录，请慎重操作！");
                        break;

                    case ("11"):
                        MessageBox.Show("提示：您将以普通用户身份登录，无法写数据库！");
                        break;
                }
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

        public static string GetMD5Hash(string strInput)
        {
            if (strInput == null)
            {
                return null;
            }
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(strInput));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

                     
    }
}
