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
using System.Data.Sql;
using System.Data.OleDb;//连接数据库
using System.Windows.Forms.DataVisualization.Charting;//引入series命名空间

namespace WindowsFormsApplication3
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }


        public DataSet ds_pollution = new DataSet();


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=cdsj;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter();
            dbAdapter4.SelectCommand = new SqlCommand("procGetData", conn);  //存储过程名称procGetData
            dbAdapter4.SelectCommand.CommandType = CommandType.StoredProcedure;
            dbAdapter4.SelectCommand.Parameters.Add("@sc", System.Data.SqlDbType.NVarChar, 50);   //传入参数
            dbAdapter4.SelectCommand.Parameters["@sc"].Value = search_engine.Myclass.sitecode;

            ds_pollution.Tables.Clear();
            dbAdapter4.Fill(ds_pollution, "pt");
            conn.Close();

            chart1.Hide();
            chart2.Show();
            chart2.Series.Clear();

            Series dataTable1Series = new Series("污染物浓度 mg/L");
            dataTable1Series.Points.DataBind(ds_pollution.Tables["pt"].AsEnumerable(), "test_time", "concentration", "");
            dataTable1Series.XValueType = ChartValueType.DateTime; //设置X轴类型为时间
            dataTable1Series.ChartType = SeriesChartType.Line;  //设置Y轴为折线
            dataTable1Series.Color = System.Drawing.Color.Red; //设置线条颜色
            chart2.Series.Add(dataTable1Series);

        }



        private void statistics_Load(object sender, EventArgs e)
        {
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand();
            lo_cmd.CommandText = "select * from pollutant_source where site_code = "+"'"+search_engine.Myclass.sitecode+"'";
            lo_cmd.Connection = lo_con;
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd);
            dbAdapter3.Fill(ds_pollution, "dt");
            lo_con.Close();

            textBox1.Text = search_engine.Myclass.sitename;
            textBox2.Text = search_engine.Myclass.sitecode;
            textBox3.Text = ds_pollution.Tables["dt"].Compute("sum(source_area)", "true").ToString();
            textBox4.Text = ds_pollution.Tables["dt"].Compute("sum(source_volume)", "true").ToString();
            textBox5.Text = "0";
            textBox6.Text = "20000";
            textBox7.Text = ds_pollution.Tables["dt"].Compute("sum(source_number)", "true").ToString();
            textBox8.Text = ds_pollution.Tables["dt"].Compute("count(source_volume)", "true").ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=cdsj;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter();
            dbAdapter4.SelectCommand = new SqlCommand("procPieData", conn);  //存储过程名称procPieData
            dbAdapter4.SelectCommand.CommandType = CommandType.StoredProcedure;
            dbAdapter4.SelectCommand.Parameters.Add("@sc", System.Data.SqlDbType.NVarChar, 50);   //传入参数
            dbAdapter4.SelectCommand.Parameters["@sc"].Value = search_engine.Myclass.sitecode;

            ds_pollution.Tables.Clear();
            dbAdapter4.Fill(ds_pollution, "pt2");
            conn.Close();

            chart2.Hide();
            chart1.Show();
            chart1.Series.Clear();

            DataView dv = new DataView(ds_pollution.Tables["pt2"]);
            Series piechart = new Series("污染物分类");
            piechart.Points.DataBindXY(dv, "pollutant_name", dv, "source_area");
            piechart.ChartType = SeriesChartType.Pie;
            chart1.Series.Add(piechart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=cdsj;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter();
            dbAdapter4.SelectCommand = new SqlCommand("procGetData", conn);  //存储过程名称procGetData
            dbAdapter4.SelectCommand.CommandType = CommandType.StoredProcedure;
            dbAdapter4.SelectCommand.Parameters.Add("@sc", System.Data.SqlDbType.NVarChar, 50);   //传入参数
            dbAdapter4.SelectCommand.Parameters["@sc"].Value = search_engine.Myclass.sitecode;

            ds_pollution.Tables.Clear();
            dbAdapter4.Fill(ds_pollution, "pt");
            conn.Close();

            chart1.Hide();
            chart2.Show();
            chart2.Series.Clear();

            Series dataTable1Series = new Series("污染物浓度 mg/L");
            dataTable1Series.Points.DataBind(ds_pollution.Tables["pt"].AsEnumerable(), "test_time", "concentration", "");
            dataTable1Series.XValueType = ChartValueType.DateTime; //设置X轴类型为时间
            dataTable1Series.ChartType = SeriesChartType.Bar;  //设置Y轴为柱图
            dataTable1Series.Color = System.Drawing.Color.Pink; //设置线条颜色
            chart2.Series.Add(dataTable1Series);
        }
    }
}
