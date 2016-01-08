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
    public partial class modify_site_environment : Form
    {
        public modify_site_environment()
        {
            InitializeComponent();
        }

         public modify_site_environment(string text)
              : this()
        {
            site_code.Text = text;
    
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); 
            lo_cmd.CommandText = "select * from site_demographics where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); 
            DataSet ds_site_en = new DataSet(); 
            dbAdapter.Fill(ds_site_en, "site_demographics"); 

            site_code.Text = ds_site_en.Tables["site_demographics"].Rows[0][0].ToString();
            location.Text = ds_site_en.Tables["site_demographics"].Rows[0][1].ToString();
            population_onsite.Text = ds_site_en.Tables["site_demographics"].Rows[0][2].ToString();
            distance_to_population.Text = ds_site_en.Tables["site_demographics"].Rows[0][3].ToString();
            
            lo_cmd.CommandText = "select * from site_meteorology where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd); 
            dbAdapter2.Fill(ds_site_en, "site_meteorology"); 

            precipitation.Text = ds_site_en.Tables["site_meteorology"].Rows[0][1].ToString();
            wind.Text = ds_site_en.Tables["site_meteorology"].Rows[0][2].ToString();
            ave_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][3].ToString();
            highest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][4].ToString();
            lowest_temp.Text = ds_site_en.Tables["site_meteorology"].Rows[0][5].ToString();



            lo_cmd.CommandText = "select * from site_sw where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); 
            dbAdapter3.Fill(ds_site_en, "site_sw"); 

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



            lo_cmd.CommandText = "select * from site_soil where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter(lo_cmd); 
            dbAdapter4.Fill(ds_site_en, "site_soil"); 

            landfill.Text = ds_site_en.Tables["site_soil"].Rows[0][1].ToString();
            landfill_description.Text = ds_site_en.Tables["site_soil"].Rows[0][2].ToString();
            gastation.Text = ds_site_en.Tables["site_soil"].Rows[0][3].ToString();
            gastation_des.Text = ds_site_en.Tables["site_soil"].Rows[0][4].ToString();
            storagetank.Text = ds_site_en.Tables["site_soil"].Rows[0][5].ToString();
            storagetank_des.Text = ds_site_en.Tables["site_soil"].Rows[0][6].ToString();
            soil_type.Text = ds_site_en.Tables["site_soil"].Rows[0][7].ToString();
            soil_pollutant.Text = ds_site_en.Tables["site_soil"].Rows[0][8].ToString();
            soil_pollutant_des.Text = ds_site_en.Tables["site_soil"].Rows[0][9].ToString();

            lo_cmd.CommandText = "select * from site_gw where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter5 = new SqlDataAdapter(lo_cmd); 
            dbAdapter5.Fill(ds_site_en, "site_gw"); 

            velocity.Text = ds_site_en.Tables["site_gw"].Rows[0][1].ToString();
            acquifer_depth.Text = ds_site_en.Tables["site_gw"].Rows[0][2].ToString();
            acquifer_thickness.Text = ds_site_en.Tables["site_gw"].Rows[0][3].ToString();
            K_value.Text = ds_site_en.Tables["site_gw"].Rows[0][4].ToString();
            gw_pollutants.Text = ds_site_en.Tables["site_gw"].Rows[0][5].ToString();
            plumage.Text = ds_site_en.Tables["site_gw"].Rows[0][6].ToString();
            gw_pollutant_des.Text = ds_site_en.Tables["site_gw"].Rows[0][7].ToString();
            
            lo_con.Close();
          
          }










        private void button1_Click(object sender, EventArgs e)
        {
            string strConnectionn = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_conn = new SqlConnection(strConnectionn);
            string update1 = "UPDATE cdsj.dbo.site_demographics SET site_code = '" + site_code.Text + "',location = '" + location.Text + "',population_onsite = '" + population_onsite.Text + "',distance_to_population = '" + distance_to_population.Text + "'where site_code = '" + site_code.Text + "'";
            SqlCommand addCommand1 = new SqlCommand(update1, lo_conn);
            addCommand1.Connection.Open();
            addCommand1.ExecuteNonQuery();
            addCommand1.Connection.Close();

            string update2 = "UPDATE cdsj.dbo.site_meteorology SET site_code = '" + site_code.Text + "',precipitation = '" + precipitation.Text + "',wind = '" + wind.Text + "',ave_temp = '" + ave_temp.Text + "',highest_temp = '" + highest_temp.Text + "',lowest_temp = '" + lowest_temp.Text + "'where site_code = '" + site_code.Text + "'";
            SqlCommand addCommand2 = new SqlCommand(update2, lo_conn);
            addCommand2.Connection.Open();
            addCommand2.ExecuteNonQuery();
            addCommand2.Connection.Close();

            string update3 = "UPDATE cdsj.dbo.site_sw SET site_code =  '" + site_code.Text + "',sw_type = '" + sw_type.Text + "',use_as_dw = '" + use_as_dw.Text + "' ,served_population = '" + served_population.Text + "',other_use = '" + other_use.Text + "',flowrate = '" + flowrate.Text + "',downstream_prop = '" + downstream_prop.Text + "',recharge = '" + recharge.Text + "',watershed = '" + watershed.Text + "',sw_pollutant = '" + sw_pollutant.Text + "' ,sw_pollutant_des = '" + sw_pollutant_des.Text + "'where site_code = '" + site_code.Text + "'";
            SqlCommand addCommand3 = new SqlCommand(update3, lo_conn);
            addCommand3.Connection.Open();
            addCommand3.ExecuteNonQuery();
            addCommand3.Connection.Close();                         

            string update4 = "UPDATE cdsj.dbo.site_soil SET site_code = '" + site_code.Text + "',landfill = '" + landfill.Text + "',landfill_description = '" + landfill_description.Text + "',gastation = '" + gastation.Text + "',gastation_des = '" + gastation_des.Text + "',storagetank = '" + storagetank.Text + "',storagetank_des ='" + storagetank_des.Text + "',soil_type = '" + soil_type.Text + "',soil_pollutant = '" + soil_pollutant.Text + "',soil_pollutant_des = '" + soil_pollutant_des.Text + "'where site_code = '" + site_code.Text + "'";
            SqlCommand addCommand4 = new SqlCommand(update4, lo_conn);
            addCommand4.Connection.Open();
            addCommand4.ExecuteNonQuery();
            addCommand4.Connection.Close();

            string update5 = "UPDATE cdsj.dbo.site_gw SET site_code = '" + site_code.Text + "',velocity = '" + velocity.Text + "',acquifer_depth = '" + acquifer_depth.Text + "',acquifer_thickness = '" + acquifer_thickness.Text + "',K_value = '" + K_value.Text + "',gw_pollutants = '" + gw_pollutants.Text + "',plumage = '" + plumage.Text + "',gw_pollutant_des = '" + gw_pollutant_des.Text + "' where site_code = '" + site_code.Text + "'";
            SqlCommand addCommand5 = new SqlCommand(update5, lo_conn);
            addCommand5.Connection.Open();
            addCommand5.ExecuteNonQuery();
            addCommand5.Connection.Close();

            MessageBox.Show("录入完成！");                   
         }

        private void site_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modify_table_menu mm = new modify_table_menu();
            mm.Show();
            this.Hide();
        }
    }
}
