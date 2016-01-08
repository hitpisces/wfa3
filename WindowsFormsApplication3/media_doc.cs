using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class media_doc : Form
    {
        public media_doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet plist = new DataSet();
            try
            {
                string strConnection = "Data Source=(local);Initial Catalog = cdsj;Integrated Security=true";//Initial catalog后面跟数据库的名字
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();//数据库链接打开
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * FROM site_photos Where site_code =" + "'" + "JA01010008201" + "'";
                cmd.Connection = conn;//
                SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
                dbAdapter.Fill(plist, "photolist");
                conn.Close();//关闭数据库连接

                treeView2.Nodes.Clear();//清除treeView已有查询结果

                foreach (DataRow row in plist.Tables["photolist"].Rows)
                {
                    for(int i =1;i<plist.Tables["photolist"].Columns.Count;i++)
                    {
                        TreeNode node = treeView2.Nodes.Add(row[i].ToString());
                    }                    
                }
            }
                   
            catch (Exception)
            {
                MessageBox.Show("警告：连接错误！无法找到图片！");
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectPic = treeView2.SelectedNode.Text;
            pictureBox1.Image=Image.FromFile(@"D:\ftp01\JA01010008201\pic\" + selectPic);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\ftp01\JA01010008201\pic\" + " /2.png");
        }
    }
}
