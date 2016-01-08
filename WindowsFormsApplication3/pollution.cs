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
    public partial class pollution : Form
    {
        public pollution()
        {
            InitializeComponent();

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox temp = c as TextBox;
                    temp.ReadOnly = true;
                }
            }
           
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    TextBox temp = c as TextBox;
                    temp.ReadOnly = true;
                }
            }
        }

        public pollution(string text)
            : this()
        {
            site_code.Text = text;

            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();
            SqlCommand lo_cmd = new SqlCommand(); 
            lo_cmd.CommandText = "select * from pollutant_data where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); 
            DataSet ds_pollution = new DataSet(); 
            dbAdapter.Fill(ds_pollution, "pollutant_data"); 

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
             
            
            lo_cmd.CommandText = "select * from pollutant_source where site_code = " + site_code.Text + ""; 
            lo_cmd.Connection = lo_con; 
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); 
            dbAdapter3.Fill(ds_pollution, "pollutant_source"); 

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








        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_menu tt = new table_menu();
            tt.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string str = "";
            System.Object nullObject = 0;
            System.Object nullObjStr = str;
            this.webBrowser1.Navigate("http://www.baidu.com/");
            //this.webBrowser1.Navigate("http://www.anychem.com/dict/search/" + CHN_name.ToString());
        }

        private void density_TextChanged(object sender, EventArgs e)
        {

        }

        private void CAS_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void pollution_Load(object sender, EventArgs e)
        {
            // 这行代码将数据加载到表“cdsjDataSet1.site_event”中
            this.site_eventTableAdapter.Fill(this.cdsjDataSet1.site_event);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
