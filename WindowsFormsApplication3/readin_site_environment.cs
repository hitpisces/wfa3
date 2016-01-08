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
    public partial class readin_site_environment : Form
    {
        public readin_site_environment()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            site_code.Text = search_engine.Myclass.sitecode;
            try
            { 
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_demographics where site_code = " + "'" + site_code.Text + "'"; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            DataSet ds_site_en = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds_site_en, "site_demographics"); //用返回的结果集填充数据集

            site_code.Text = ds_site_en.Tables["site_demographics"].Rows[0][0].ToString();
            population_onsite.Text = ds_site_en.Tables["site_demographics"].Rows[0][1].ToString();
            distance_to_population.Text = ds_site_en.Tables["site_demographics"].Rows[0][2].ToString();

            lo_cmd.CommandText = "select * from site_meteorology where site_code = " + "'" + site_code.Text + "'"; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter2.Fill(ds_site_en, "site_meteorology"); //用返回的结果集填充数据集

            precipitation.Text = ds_site_en.Tables["site_meteorology"].Rows[0][1].ToString();
            wind.Text = ds_site_en.Tables["site_meteorology"].Rows[0][2].ToString();
            ave_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][3].ToString();
            highest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][4].ToString();
            lowest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][5].ToString();



            lo_cmd.CommandText = "select * from site_sw where site_code = " + "'" + site_code.Text + "'"; //写SQL语句
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



            lo_cmd.CommandText = "select * from site_soil where site_code = " + "'" + site_code.Text + "'"; //写SQL语句
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

            lo_cmd.CommandText = "select * from site_gw where site_code = " + "'" + site_code.Text + "'"; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter5 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            dbAdapter5.Fill(ds_site_en, "site_gw"); //用返回的结果集填充数据集

            velocity.Text = ds_site_en.Tables["site_gw"].Rows[0][1].ToString();
            acquifer_depth.Text = ds_site_en.Tables["site_gw"].Rows[0][3].ToString();
            acquifer_thickness.Text = ds_site_en.Tables["site_gw"].Rows[0][2].ToString();
            K_value.Text = ds_site_en.Tables["site_gw"].Rows[0][4].ToString();
            gw_pollutants.Text = ds_site_en.Tables["site_gw"].Rows[0][5].ToString();
            plumage.Text = ds_site_en.Tables["site_gw"].Rows[0][6].ToString();
            gw_des.Text = ds_site_en.Tables["site_gw"].Rows[0][7].ToString();


            lo_con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("请检索后从左侧栏中选择一个场地");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (main_login.Myclass.auth_type == "user      ")
            {
                MessageBox.Show("当前身份是用户，无法读写数据库！");
            }
            else if (main_login.Myclass.auth_type == "admin     ")
            {
                /*
                string strConnectionn = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
                SqlConnection lo_conn = new SqlConnection(strConnectionn);
                string myinsert1 = "insert into cdsj.dbo.site_demographics(site_code,location,population_onsite,distance_to_population) values ( '" + site_code.Text + "','" + population_onsite.Text + "','" + distance_to_population.Text + "')";
                SqlCommand addCommand1 = new SqlCommand(myinsert1, lo_conn);
                addCommand1.Connection.Open();
                addCommand1.ExecuteNonQuery();
                addCommand1.Connection.Close();

                string myinsert2 = "insert into cdsj.dbo.site_meteorology(site_code,precipitation,wind,ave_temp,highest_temp,lowest_temp) values ('" + site_code.Text + "','" + precipitation.Text + "','" + wind.Text + "','" + ave_temp.Text + "','" + highest_temp.Text + "','" + lowest_temp.Text + "')";
                SqlCommand addCommand2 = new SqlCommand(myinsert2, lo_conn);
                addCommand2.Connection.Open();
                addCommand2.ExecuteNonQuery();
                addCommand2.Connection.Close();

                string myinsert3 = "insert into cdsj.dbo.site_sw(site_code,sw_type,use_as_dw,served_population,other_use,flowrate,downstream_prop,recharge,watershed,sw_pollutant,sw_pollutant_des) values ( '" + site_code.Text + "','" + sw_type.Text + "','" + use_as_dw.Text + "','" + served_population.Text + "','" + other_use.Text + "','" + flowrate.Text + "','" + downstream_prop.Text + "','" + recharge.Text + "','" + watershed.Text + "','" + sw_pollutant.Text + "','" + sw_pollutant_des.Text + "')";
                SqlCommand addCommand3 = new SqlCommand(myinsert3, lo_conn);
                addCommand3.Connection.Open();
                addCommand3.ExecuteNonQuery();
                addCommand3.Connection.Close();

                string myinsert4 = "insert into cdsj.dbo.site_soil(site_code,landfill,landfill_description,gastation,gastation_des,storagetank,storagetank_des,soil_type,soil_pollutant,soil_pollutant_des) values ( '" + site_code.Text + "','" + landfill.Text + "','" + landfill_description.Text + "','" + gastation.Text + "','" + gastation_des.Text + "','" + storagetank.Text + "','" + storagetank_des.Text + "','" + soil_type.Text + "','" + soil_pollutant.Text + "','" + soil_pollutant_des.Text + "')";
                SqlCommand addCommand4 = new SqlCommand(myinsert4, lo_conn);
                addCommand4.Connection.Open();
                addCommand4.ExecuteNonQuery();
                addCommand4.Connection.Close();

                string myinsert5 = "insert into cdsj.dbo.site_gw(site_code,velocity,acquifer_depth,acquifer_thickness,K_value,gw_pollutants,plumage,gw_pollutant_des) values ( '" + site_code.Text + "','" + velocity.Text + "','" + acquifer_depth.Text + "','" + acquifer_thickness.Text + "','" + K_value.Text + "','" + gw_pollutants.Text + "','" + plumage.Text + "')";
                SqlCommand addCommand5 = new SqlCommand(myinsert5, lo_conn);
                addCommand5.Connection.Open();
                addCommand5.ExecuteNonQuery();
                addCommand5.Connection.Close();
                */
                MessageBox.Show("录入完成！");
            }
        }
    }
}
