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
    public partial class modify_pollution : Form
    {
        public modify_pollution()
        {
            InitializeComponent();
        }

        public modify_pollution(string text)
            : this()
        {
            site_code.Text = text;

            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from pollutant_data where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            DataSet ds_pollution = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds_pollution, "pollutant_data"); //用返回的结果集填充数据集

            physical_state.Text = ds_pollution.Tables["pollutant_data"].Rows[0][1].ToString();
            general_type.Text = ds_pollution.Tables["pollutant_data"].Rows[0][2].ToString();
            CAS_code.Text = ds_pollution.Tables["pollutant_data"].Rows[0][3].ToString();
            CAS_name.Text = ds_pollution.Tables["pollutant_data"].Rows[0][4].ToString();
            abs_name.Text = ds_pollution.Tables["pollutant_data"].Rows[0][5].ToString();
            CHN_name.Text = ds_pollution.Tables["pollutant_data"].Rows[0][6].ToString();
            LD50.Text = ds_pollution.Tables["pollutant_data"].Rows[0][7].ToString();
            formula.Text = ds_pollution.Tables["pollutant_data"].Rows[0][8].ToString();
            molar_mass.Text = ds_pollution.Tables["pollutant_data"].Rows[0][9].ToString();
            apperance.Text = ds_pollution.Tables["pollutant_data"].Rows[0][10].ToString();
            density.Text = ds_pollution.Tables["pollutant_data"].Rows[0][11].ToString();
            boiling_point.Text = ds_pollution.Tables["pollutant_data"].Rows[0][12].ToString();
            solubility_in_water.Text = ds_pollution.Tables["pollutant_data"].Rows[0][13].ToString();
            solubility_in_solvent.Text = ds_pollution.Tables["pollutant_data"].Rows[0][14].ToString();
            Kow.Text = ds_pollution.Tables["pollutant_data"].Rows[0][15].ToString();
            vapor_pressure.Text = ds_pollution.Tables["pollutant_data"].Rows[0][16].ToString();
            henry_constant.Text = ds_pollution.Tables["pollutant_data"].Rows[0][17].ToString();
            refractive_index.Text = ds_pollution.Tables["pollutant_data"].Rows[0][18].ToString();
            GHS_signal_word.Text = ds_pollution.Tables["pollutant_data"].Rows[0][19].ToString();
            flash_point.Text = ds_pollution.Tables["pollutant_data"].Rows[0][20].ToString();
            hazard_statement.Text = ds_pollution.Tables["pollutant_data"].Rows[0][21].ToString();
             
            lo_cmd.CommandText = "select * from pollutant_source where site_code = " + site_code.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
            //    DataSet ds3 = new DataSet(); //创建数据集对象
            dbAdapter3.Fill(ds_pollution, "pollutant_source"); //用返回的结果集填充数据集

            pollutant_name.Text = ds_pollution.Tables["pollutant_source"].Rows[0][1].ToString();
            source_number.Text = ds_pollution.Tables["pollutant_source"].Rows[0][2].ToString();
            source_type.Text = ds_pollution.Tables["pollutant_source"].Rows[0][3].ToString();
            location_des.Text = ds_pollution.Tables["pollutant_source"].Rows[0][4].ToString();
            location_coordinate.Text = ds_pollution.Tables["pollutant_source"].Rows[0][5].ToString();
            source_area.Text = ds_pollution.Tables["pollutant_source"].Rows[0][6].ToString();
            source_volume.Text = ds_pollution.Tables["pollutant_source"].Rows[0][7].ToString();
            trans_path.Text = ds_pollution.Tables["pollutant_source"].Rows[0][8].ToString();

            lo_con.Close();
        }

       
        private void site_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modify_pollution_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cdsjDataSet3.site_event”中。您可以根据需要移动或删除它。
            this.site_eventTableAdapter.Fill(this.cdsjDataSet3.site_event);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConnectionn = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_conn = new SqlConnection(strConnectionn);
            string update1 = "UPDATE cdsj.dbo.pollutant_data SET site_code = '" + site_code.Text + "',physical_state = '" + physical_state.Text + "',general_type = '" + general_type.Text + "',CAS_code = '" + CAS_code.Text + "',CAS_name = '" + CAS_name.Text + "',abs_name = '" + abs_name.Text + "',CHN_name = '" + CHN_name.Text + "',LD50 = '" + LD50.Text + "',formula = '" + formula.Text + "',molar_mass = '" + molar_mass.Text + "',apperance = '" + apperance.Text + "',density = '" + density.Text + "',boiling_point = '" + boiling_point.Text + "',solubility_in_solvent = '" + solubility_in_solvent.Text + "',Kow = '" + Kow.Text + "',vapor_pressure = '" + vapor_pressure.Text + "',henry_constant = '" + henry_constant.Text + "',refractive_index = '" + refractive_index.Text + "',GHS_signal_word = '" + GHS_signal_word.Text + "',flash_point = '" + flash_point.Text + "',hazard_statement = '" + hazard_statement.Text + "'where site_code = '" + site_code.Text + "'"; 
            SqlCommand addCommand1 = new SqlCommand(update1, lo_conn);
            addCommand1.Connection.Open();
            addCommand1.ExecuteNonQuery();
            addCommand1.Connection.Close();

            string update2 = "UPDATE cdsj.dbo.pollutant_source SET site_code = '" + site_code.Text + "',pollutant_name = '" + pollutant_name.Text + "',source_number = '" + source_number.Text + "',source_type = '" + source_type.Text + "',location_des = '" + location_des.Text + "',location_coordinate = '" + location_coordinate.Text + "',source_area = '" + source_area.Text + "',source_volume = '" + source_volume.Text + "',trans_path = '" + trans_path.Text + "'where site_code = '" + site_code.Text + "'"; //录入地基信息表中第二个groupbox
            SqlCommand addCommand2 = new SqlCommand(update2, lo_conn);
            addCommand2.Connection.Open();
            addCommand2.ExecuteNonQuery();
            addCommand2.Connection.Close();

            MessageBox.Show("修改完成！");               //关闭对象并释放所占内存空间    
            //this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            modify_table_menu mm = new modify_table_menu();
            mm.Show();
            this.Hide();
        }
    }
}
