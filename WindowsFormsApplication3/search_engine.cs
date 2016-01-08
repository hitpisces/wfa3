using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApplication3
{
    public partial class search_engine : Form
    {
        public search_engine()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public static DataSet ds = new DataSet();//窗体内的全局DataSet

        private void search_engine_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            
            //绑定数据到comboBox
            ArrayList cblist = new ArrayList();
            cblist.Add(new DictionaryEntry("场地属性", "site_property"));
            cblist.Add(new DictionaryEntry("场地地址", "site_address"));
            cblist.Add(new DictionaryEntry("所在省份", "position_province"));
            cblist.Add(new DictionaryEntry("所在城市", "position_city"));
            cblist.Add(new DictionaryEntry("场地名称", "site_nickname"));
            //cblist.Add(new DictionaryEntry("污染物名称", "position_description"));

            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = cblist;

            readin_site rsf = new readin_site();
            rsf.TopLevel = false;
            tabPage1.Controls.Add(rsf);
            //tabControl1.TabPages.Add(tabPage1); 动态添加tabPage时加入此行并调整窗体
            rsf.Parent = tabControl1.TabPages["tabPage1"];
            rsf.FormBorderStyle = FormBorderStyle.None;
            rsf.Dock = System.Windows.Forms.DockStyle.Fill;
            rsf.Show();

            this.tabControl1.SelectedIndex=0;//选择初始化后的tabPage

        }

        public class Myclass
        {
            public static string sitecode = "";//全局变量sitecode,从search_engine场地代码中输入，用于site中
            public static string sitename = "";//全局变量场地名称
            public static string lng = "";//全局变量lng，场地经度坐标
            public static string lat = "";//全局变量lat, 场地纬度坐标
            public static DataSet selectedDs = new DataSet();//全局变量数据集，放置treeView选定节点关键字的所有数据表          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string strConnection = "Data Source=(local);Initial Catalog = cdsj;Integrated Security=true";//Initial catalog后面跟数据库的名字
            SqlConnection conn = new SqlConnection(strConnection);
            conn.Open();//数据库链接打开
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM site_info Where " + comboBox1.SelectedValue.ToString()+ " LIKE '%" + textBox1.Text.Trim() + "%'";
            cmd.Connection = conn;//此处需进一步改写为针对污染物的模糊查询
            //SqlDataReader sdr = cmd.ExecuteReader();
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            dbAdapter.Fill(ds, "searchResult");
            conn.Close();//关闭数据库连接
            
            treeView1.Nodes.Clear();//清除treeView已有查询结果

            foreach (DataRow row in ds.Tables["searchResult"].Rows)
            {
                TreeNode node = treeView1.Nodes.Add(row[12].ToString());
            }
           
            }           
            catch (Exception)
            {
                MessageBox.Show("警告：数据库连接错误！");
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                readin_site rsf = new readin_site();
                rsf.TopLevel = false;
                tabPage1.Controls.Add(rsf);
                //tabControl1.TabPages.Add(tabPage1); 动态添加tabPage时加入此行并调整窗体
                rsf.Parent = tabControl1.TabPages["tabPage1"];
                rsf.FormBorderStyle = FormBorderStyle.None;
                rsf.Dock = System.Windows.Forms.DockStyle.Fill;
                rsf.Show();

            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                readin_pollution rpf = new readin_pollution();
                rpf.TopLevel = false;
                tabPage2.Controls.Add(rpf);
                rpf.Parent = tabControl1.TabPages["tabPage2"];
                rpf.FormBorderStyle = FormBorderStyle.None;
                rpf.Dock = System.Windows.Forms.DockStyle.Fill;
                rpf.Show();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                readin_site_environment rse = new readin_site_environment();
                rse.TopLevel = false;
                rse.Parent = tabControl1.TabPages["tabPage3"];
                rse.FormBorderStyle = FormBorderStyle.None;
                rse.Dock = System.Windows.Forms.DockStyle.Fill;
                rse.Show();
            }
            else if (tabControl1.SelectedTab.Name  == "tabPage4")
            {
                risk_accessment ras = new risk_accessment();
                ras.TopLevel = false;
                ras.Parent = tabControl1.TabPages["tabPage4"];
                ras.FormBorderStyle = FormBorderStyle.None;
                ras.Dock = System.Windows.Forms.DockStyle.Fill;
                ras.Show();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                map mp = new map();
                mp.TopLevel = false;
                mp.Parent = tabControl1.TabPages["tabPage5"];
                mp.FormBorderStyle = FormBorderStyle.None;
                mp.Dock = System.Windows.Forms.DockStyle.Fill;
                mp.Show();

            }
            else if (tabControl1.SelectedTab.Name == "tabPage6")
            {
                media_doc mdf = new media_doc();
                mdf.TopLevel = false;
                mdf.Parent = tabControl1.TabPages["tabPage6"];
                mdf.FormBorderStyle = FormBorderStyle.None;
                mdf.Dock = System.Windows.Forms.DockStyle.Fill;
                mdf.Show();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage7")
            {
                webBrowser2.Navigate("http://www.basechem.org/");
                webBrowser2.ObjectForScripting = this;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(main_login.Myclass.auth_type);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectNd = "site_nickname ="+ "'"+ treeView1.SelectedNode.Text+ "'";
            DataRow[] dataRows = ds.Tables["searchResult"].Select(selectNd);
            Myclass.sitecode = dataRows[0][0].ToString();
            Myclass.lng = dataRows[0][3].ToString();
            Myclass.lat = dataRows[0][4].ToString();
            Myclass.sitename = dataRows[0][12].ToString();
        }

        private void 生成报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "/sample_report.doc");
        }

        private void 提交报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:kyo_moller@hotmail.com.cn?body=附件是场地报告，请查收！&subject=场地报告");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistics sta = new statistics();
            sta.Show();
        }

        private void hERA评估工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\HERA\\HERA.exe");
        }


        private void 层次分析法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "/AHP.exe");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", " PrScrn.dll PrScrn");
        }

        private void nPL筛选方法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
