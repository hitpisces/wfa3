using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;//连接数据库
using System.Drawing;


namespace WindowsFormsApplication3
{
    public partial class readin_pollution : Form
    {
        public DataSet ds_mirror = new DataSet();
        public readin_pollution()
        {
            InitializeComponent();
            if(main_login.Myclass.auth_type == "11")
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataSet ds_pollution = new DataSet();
            ds_pollution.Tables.Clear();

            try
            {             
            SqlConnection lo_con = new SqlConnection(main_login.Myclass.strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand();
            lo_cmd.CommandText = "select * from pollutant_data where site_code = " + "'" + search_engine.Myclass.sitecode + "'";
            lo_cmd.Connection = lo_con;
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd);
            dbAdapter.Fill(ds_pollution, "pollutant_data");

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = ds_pollution.Tables["pollutant_data"];

            site_code_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][1].ToString();
            physical_state_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][23].ToString();
            general_type_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][2].ToString();
            CAS_code_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][3].ToString();
            CAS_name_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][4].ToString();
            abs_name_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][5].ToString();
            CHN_name_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][6].ToString();
            LD50_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][7].ToString();
            formula_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][8].ToString();
            molar_mass_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][11].ToString();
            apperance_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][12].ToString();
            density_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][13].ToString();
            boiling_point_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][14].ToString();
            solubility_in_water_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][15].ToString();
            solubility_in_solvent_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][16].ToString();
            Kow_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][17].ToString();
            vapor_pressure_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][18].ToString();
            henry_constant_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][21].ToString();
            refractive_index_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][19].ToString();
            flash_point_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][20].ToString();
            hazard_statement_tb.Text = ds_pollution.Tables["pollutant_data"].Rows[0][22].ToString();
            

            lo_cmd.CommandText = "select * from pollutant_source where site_code = " + "'" + search_engine.Myclass.sitecode + "'";
            lo_cmd.Connection = lo_con;
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd);
            dbAdapter3.Fill(ds_pollution, "pollutant_source");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds_pollution.Tables["pollutant_source"];

            pollutant_name_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][2].ToString();
            source_number_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][3].ToString();
            source_type_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][4].ToString();
            location_des_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][5].ToString();
            location_coordinate_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][6].ToString();
            lat_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][7].ToString();
            source_area_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][8].ToString();
            source_volume_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][9].ToString();
            trans_path_tb.Text = ds_pollution.Tables["pollutant_source"].Rows[0][10].ToString();

            lo_con.Close();
            ds_mirror.Tables.Clear();
            ds_mirror = ds_pollution.Clone();

            }
            catch(Exception)
            {
                MessageBox.Show("请检索后从左侧栏中选择一个场地");
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            LoopControls(this);
            if (MessageBox.Show("有空白内容，是否写入数据库？", "提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ds_mirror.Tables["pollutant_data"].Rows[0][1]=site_code_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][23]= physical_state_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][2]= general_type_tb.Text.ToString();
                CAS_code_tb.Text = ds_mirror.Tables["pollutant_data"].Rows[0][3].ToString();
                CAS_name_tb.Text = ds_mirror.Tables["pollutant_data"].Rows[0][4].ToString();
                abs_name_tb.Text = ds_mirror.Tables["pollutant_data"].Rows[0][5].ToString();
                CHN_name_tb.Text = ds_mirror.Tables["pollutant_data"].Rows[0][6].ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][7]= LD50_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][8]= formula_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][11]= molar_mass_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][12]= apperance_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][13]= density_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][14]= boiling_point_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][15]= solubility_in_water_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][16]= solubility_in_solvent_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][17]= Kow_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][18]= vapor_pressure_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][21]= henry_constant_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][19]= refractive_index_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][20]= flash_point_tb.Text.ToString();
                ds_mirror.Tables["pollutant_data"].Rows[0][22]= hazard_statement_tb.Text.ToString();

                
            }
           
                
                string strConnection = "Data Source=DESKTOP-SK2RD82;Initial Catalog=cdsj;Integrated Security=True";
                SqlConnection lo_conn = new SqlConnection(strConnection);
                //string haha
                /*
                string strConnectionn = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
                SqlConnection lo_conn = new SqlConnection(strConnectionn);
                string myinsert1 = "insert into cdsj.dbo.pollutant_data(site_code,physical_state,general_type,CAS_code,CAS_name,abs_name,CHN_name,LD50,formula,molar_mass,apperance,density,boiling_point,solubility_in_solvent,Kow,vapor_pressure,henry_constant,refractive_index,GHS_pictograms,GHS_signal_word,flash_point,hazard_statement) values ( '" + site_code_tb.Text + "','" + physical_state_tb.Text + "','" + general_type_tb.Text + "','" + CAS_code_tb.Text + "','" + CAS_name_tb.Text + "','" + abs_name_tb + "','" + CHN_name_tb +"','"+ LD50_tb.Text + "','" + formula_tb.Text + "','" + molar_mass_tb.Text + "','" + apperance_tb.Text + "','" + density_tb.Text + "','" + boiling_point_tb.Text + "','" + solubility_in_water_tb.Text + "','" + solubility_in_solvent_tb.Text + "','" + Kow_tb.Text + "','" + vapor_pressure_tb.Text + "','" + henry_constant_tb.Text + "','" + refractive_index_tb.Text + "','"  + flash_point_tb.Text + "','" + hazard_statement_tb.Text + "')";
                SqlCommand addCommand1 = new SqlCommand(myinsert1, lo_conn);
                addCommand1.Connection.Open();
                addCommand1.ExecuteNonQuery();
                addCommand1.Connection.Close();                       
                                  

                string myinsert2 = "insert into cdsj.dbo.pollutant_source(site_code,pollutant_name,source_number,source_type,location_des,location_coordinate,source_area,source_volume,trans_path) values ( '" + site_code_tb.Text + "','" + pollutant_name_tb.Text + "','" + source_number_tb.Text + "','" + source_type_tb.Text + "','" + location_des_tb.Text + "','" + location_coordinate_tb.Text + "','" + source_area_tb.Text + "','" + source_volume_tb.Text + "','" + trans_path_tb.Text + "')";
                SqlCommand addCommand2 = new SqlCommand(myinsert2, lo_conn);
                addCommand2.Connection.Open();
                addCommand2.ExecuteNonQuery();
                addCommand2.Connection.Close();



                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    string strConnection1 = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
                    SqlConnection lo_con1 = new SqlConnection(strConnection1);
                    string cmdinsert = "insert into cdsj.dbo.site_event(site_code,start_time,end_time,brief_description,event_detail,health_risk) values ( '" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "')";
                    SqlCommand Command = new SqlCommand(cmdinsert, lo_con1);
                    Command.Connection.Open();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
                 */
                MessageBox.Show("录入完成！");

           
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            physical_state_tb.Text = dataGridView2.SelectedRows[0].Cells["physical_state1"].Value.ToString();
            general_type_tb.Text = dataGridView2.SelectedRows[0].Cells["general_type1"].Value.ToString();
            CAS_code_tb.Text = dataGridView2.SelectedRows[0].Cells["CAS_code1"].Value.ToString();
            CAS_name_tb.Text = dataGridView2.SelectedRows[0].Cells["CAS_name1"].Value.ToString();
            abs_name_tb.Text = dataGridView2.SelectedRows[0].Cells["abs_name1"].Value.ToString();
            CHN_name_tb.Text = dataGridView2.SelectedRows[0].Cells["CHN_name1"].Value.ToString();
            LD50_tb.Text = dataGridView2.SelectedRows[0].Cells["LD501"].Value.ToString();
            formula_tb.Text = dataGridView2.SelectedRows[0].Cells["formula1"].Value.ToString();
            molar_mass_tb.Text = dataGridView2.SelectedRows[0].Cells["molar_mass1"].Value.ToString();
            apperance_tb.Text = dataGridView2.SelectedRows[0].Cells["apperance1"].Value.ToString();
            density_tb.Text = dataGridView2.SelectedRows[0].Cells["density1"].Value.ToString();
            boiling_point_tb.Text = dataGridView2.SelectedRows[0].Cells["boiling_point1"].Value.ToString();
            solubility_in_water_tb.Text = dataGridView2.SelectedRows[0].Cells["solubility_in_water1"].Value.ToString();
            solubility_in_solvent_tb.Text = dataGridView2.SelectedRows[0].Cells["solubility_in_solvent1"].Value.ToString();
            Kow_tb.Text = dataGridView2.SelectedRows[0].Cells["Kow1"].Value.ToString();
            vapor_pressure_tb.Text = dataGridView2.SelectedRows[0].Cells["vapor_pressure1"].Value.ToString();
            henry_constant_tb.Text = dataGridView2.SelectedRows[0].Cells["henry_constant1"].Value.ToString();
            refractive_index_tb.Text = dataGridView2.SelectedRows[0].Cells["refractive_index1"].Value.ToString();
            flash_point_tb.Text = dataGridView2.SelectedRows[0].Cells["flash_point1"].Value.ToString();
            hazard_statement_tb.Text = dataGridView2.SelectedRows[0].Cells["hazard_statement1"].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pollutant_name_tb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            source_number_tb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            source_type_tb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            location_des_tb.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            location_coordinate_tb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lat_tb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            source_area_tb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            source_volume_tb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            trans_path_tb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        
        public void LoopControls(Control container)//循环窗体控件
        {
            int i = 0;
            foreach(Control c in container.Controls){
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text)){
                        tb.BackColor = Color.Yellow;
                        i++;
                    }
                }
            if (c.HasChildren)
                {
                    LoopControls(c);
                }
            }            
        }
        
 




    }
}
