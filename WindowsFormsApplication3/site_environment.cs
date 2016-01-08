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
    public partial class site_environment : Form
    {
        public site_environment()
        {
            InitializeComponent();
            foreach (Control c in groupBox1.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
            foreach (Control c in groupBox2.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
            foreach (Control c in groupBox3.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
            foreach (Control c in groupBox4.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
            foreach (Control c in groupBox5.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
        }

/// <summary>
/// 把输入的场地代码赋给site中textbox1的方法
/// </summary>
/// <param name="text"></param>
        
        
        public site_environment(string text)
              : this()
        {
            site_code.Text = text;
    
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_demographics where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            DataSet ds_site_en = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds_site_en, "site_demographics"); //用返回的结果集填充数据集

            site_code.Text = ds_site_en.Tables["site_demographics"].Rows[0][0].ToString();
            location.Text = ds_site_en.Tables["site_demographics"].Rows[0][1].ToString();
            pollution_onsite.Text = ds_site_en.Tables["site_demographics"].Rows[0][2].ToString();
            distance_to_population.Text = ds_site_en.Tables["site_demographics"].Rows[0][3].ToString();
            
            lo_cmd.CommandText = "select * from site_meteorology where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter2.Fill(ds_site_en, "site_meteorology"); //用返回的结果集填充数据集

            precipitation.Text = ds_site_en.Tables["site_meteorology"].Rows[0][1].ToString();
            wind.Text = ds_site_en.Tables["site_meteorology"].Rows[0][2].ToString();
            ave_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][3].ToString();
            highest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][4].ToString();
            lowest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][5].ToString();



            lo_cmd.CommandText = "select * from site_sw where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter3.Fill(ds_site_en, "site_sw"); //用返回的结果集填充数据集

            sw_type.Text = ds_site_en.Tables["site_sw"].Rows[0][1].ToString();
            use_as_dw.Text = ds_site_en.Tables["site_sw"].Rows[0][2].ToString();
            served_population.Text = ds_site_en.Tables["site_sw"].Rows[0][3].ToString();
            other_use.Text = ds_site_en.Tables["site_sw"].Rows[0][4].ToString();
            flowrate.Text = ds_site_en.Tables["site_sw"].Rows[0][5].ToString();
            downstream_prop.Text = ds_site_en.Tables["site_sw"].Rows[0][6].ToString();
            recharge.Text = ds_site_en.Tables["site_sw"].Rows[0][7].ToString();
            watershed.Text = ds_site_en.Tables["site_sw"].Rows[0][8].ToString();
            sw_pollutant.Text = ds_site_en.Tables["site_sw"].Rows[0][9].ToString();
            sw_pollutant_des.Text = ds_site_en.Tables["site_sw"].Rows[0][10].ToString();



            lo_cmd.CommandText = "select * from site_soil where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter4.Fill(ds_site_en, "site_soil"); //用返回的结果集填充数据集

            landfill.Text = ds_site_en.Tables["site_soil"].Rows[0][1].ToString();
            landfill_description.Text = ds_site_en.Tables["site_soil"].Rows[0][2].ToString();
            gastation.Text = ds_site_en.Tables["site_soil"].Rows[0][3].ToString();
            gastation_des.Text = ds_site_en.Tables["site_soil"].Rows[0][4].ToString();
            storagetank.Text = ds_site_en.Tables["site_soil"].Rows[0][5].ToString();
            storagetank_des.Text = ds_site_en.Tables["site_soil"].Rows[0][6].ToString();
            soil_type.Text = ds_site_en.Tables["site_soil"].Rows[0][7].ToString();
            soil_pollutant.Text = ds_site_en.Tables["site_soil"].Rows[0][8].ToString();
            soil_pollutant_des.Text = ds_site_en.Tables["site_soil"].Rows[0][9].ToString();

            lo_cmd.CommandText = "select * from site_gw where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter5 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter5.Fill(ds_site_en, "site_gw"); //用返回的结果集填充数据集

            velocity.Text = ds_site_en.Tables["site_gw"].Rows[0][1].ToString();
            acquifer_depth.Text = ds_site_en.Tables["site_gw"].Rows[0][2].ToString();
            acquifer_thickness.Text = ds_site_en.Tables["site_gw"].Rows[0][3].ToString();
            K_value.Text = ds_site_en.Tables["site_gw"].Rows[0][4].ToString();
            gw_pollutants.Text = ds_site_en.Tables["site_gw"].Rows[0][5].ToString();
            plumage.Text = ds_site_en.Tables["site_gw"].Rows[0][6].ToString();
            gw_pollutant_des.Text = ds_site_en.Tables["site_gw"].Rows[0][7].ToString();
            
            lo_con.Close();
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void site_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_menu tt = new table_menu();
            tt.Show();
        }
    }
}
