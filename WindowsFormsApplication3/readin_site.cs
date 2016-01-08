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
    public partial class readin_site : Form
    {
        public readin_site()
        {
            InitializeComponent();
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
                string myinsert1 = "insert into cdsj.dbo.site_info(site_code,site_property,sit_address,longitude,latitude,contact_name,contact_tel,contact_fax,contact_address,contact_Email,site_description) values ( '" + sitecode_textBox.Text + "','" + site_property.Text + "','" + site_address.Text + "','" + longitude.Text + "','" + latitude.Text + "','" + contact_name.Text + "','" + contact_fax.Text + "','" + contact_tel.Text + "','" + contact_Email.Text + "','" + contact_address.Text + "','" + site_description.Text + "')";
                SqlCommand addCommand1 = new SqlCommand(myinsert1, lo_conn);
                addCommand1.Connection.Open();
                addCommand1.ExecuteNonQuery();
                addCommand1.Connection.Close();

                string myinsert2 = "insert into cdsj.dbo.site_general(site_code,site_type,early_use,now_use,source_type,heavymetal_control_zone,drinkingwater_protection_zone,farmland) values ( '" + sitecode_textBox.Text + "','" + site_type.Text + "','" + early_use.Text + "','" + now_use.Text + "','" + source_type.Text + "','" + heavymetal_control_zone.Text + "','" + drinkingwater_protection_zone.Text + "','" + farmland.Text + "')";
                SqlCommand addCommand2 = new SqlCommand(myinsert2, lo_conn);
                addCommand2.Connection.Open();
                addCommand2.ExecuteNonQuery();
                addCommand2.Connection.Close();

                string myinsert3 = "insert into cdsj.dbo.site_history(site_code,star_date,end_date,owner_name,type,major_products,byproducts,major_pollutants,potential_pollutants) values ( '" + sitecode_textBox.Text + "','" + star_date.Text + "','" + end_date.Text + "','" + owner_name1.Text + "','" + type.Text + "','" + major_products.Text + "','" + byproducts.Text + "','" + major_pollutants.Text + "','" + potential_pollutants.Text + "')";
                SqlCommand addCommand3 = new SqlCommand(myinsert3, lo_conn);
                addCommand3.Connection.Open();
                addCommand3.ExecuteNonQuery();
                addCommand3.Connection.Close();
                */

                MessageBox.Show("录入完成！");    
            }
              
        }


         private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
                SqlConnection lo_con = new SqlConnection(strConnection);
                lo_con.Open();

                SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
                lo_cmd.CommandText = "select * from site_info where site_code = " + "'" + search_engine.Myclass.sitecode + "'"; //写SQL语句
                lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
                SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd);
                DataSet ds_site = new DataSet(); //创建数据集对象
                dbAdapter.Fill(ds_site, "site_info"); //将数据表填充到数据集

                sitecode_textBox.Text = ds_site.Tables["site_info"].Rows[0][0].ToString();//通过数据集给textbox赋值
                site_property.Text = ds_site.Tables["site_info"].Rows[0][1].ToString();
                site_address.Text = ds_site.Tables["site_info"].Rows[0][2].ToString();
                longitude.Text = ds_site.Tables["site_info"].Rows[0][3].ToString();
                latitude.Text = ds_site.Tables["site_info"].Rows[0][4].ToString();
                contact_name.Text = ds_site.Tables["site_info"].Rows[0][5].ToString();
                contact_tel.Text = ds_site.Tables["site_info"].Rows[0][6].ToString();
                contact_address.Text = ds_site.Tables["site_info"].Rows[0][7].ToString();
                contact_Email.Text = ds_site.Tables["site_info"].Rows[0][8].ToString();
                site_description.Text = ds_site.Tables["site_info"].Rows[0][9].ToString();

                lo_cmd.CommandText = "select * from site_general where site_code = " + "'" + search_engine.Myclass.sitecode + "'";//写SQL语句
                lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
                SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
                dbAdapter2.Fill(ds_site, "site_general"); //用返回的结果集填充数据集

                site_type.Text = ds_site.Tables["site_general"].Rows[0][1].ToString();
                early_use.Text = ds_site.Tables["site_general"].Rows[0][2].ToString();
                now_use.Text = ds_site.Tables["site_general"].Rows[0][3].ToString();
                source_type.Text = ds_site.Tables["site_general"].Rows[0][4].ToString();
                heavymetal_control_zone.Text = ds_site.Tables["site_general"].Rows[0][5].ToString();
                drinkingwater_protection_zone.Text = ds_site.Tables["site_general"].Rows[0][6].ToString();
                farmland.Text = ds_site.Tables["site_general"].Rows[0][7].ToString();


                lo_cmd.CommandText = "select * from site_history where site_code = " + "'" + search_engine.Myclass.sitecode + "'" + "order by star_date asc"; //写SQL语句
                lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
                SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
                dbAdapter3.Fill(ds_site, "site_history"); //用返回的结果集填充数据集

                star_date.Text = ds_site.Tables["site_history"].Rows[0][2].ToString();
                end_date.Text = ds_site.Tables["site_history"].Rows[0][3].ToString();
                owner_name1.Text = ds_site.Tables["site_history"].Rows[0][4].ToString();
                type.Text = ds_site.Tables["site_history"].Rows[0][5].ToString();
                major_products.Text = ds_site.Tables["site_history"].Rows[0][6].ToString();
                byproducts.Text = ds_site.Tables["site_history"].Rows[0][7].ToString();
                major_pollutants.Text = ds_site.Tables["site_history"].Rows[0][8].ToString();
                potential_pollutants.Text = ds_site.Tables["site_history"].Rows[0][9].ToString();
                dataGridView_siteHistory.AutoGenerateColumns = false;
                dataGridView_siteHistory.DataSource = ds_site.Tables["site_history"];

                lo_cmd.CommandText = "select * from owner_info where site_code = " + "'" + search_engine.Myclass.sitecode + "'" + "order by time_from asc"; //写SQL语句
                lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
                SqlDataAdapter dbAdapter4 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
                dbAdapter4.Fill(ds_site, "owner_info"); //用返回的结果集填充数据集

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds_site.Tables["owner_info"];

                lo_con.Close();
             }
             catch (Exception)
            {
                MessageBox.Show("请检索后从左侧栏选取一个场地");
            }
        }

         private void dataGridView_siteHistory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             star_date.Text = dataGridView_siteHistory.SelectedRows[0].Cells[0].Value.ToString();
             end_date.Text = dataGridView_siteHistory.SelectedRows[0].Cells[1].Value.ToString();
             owner_name1.Text = dataGridView_siteHistory.SelectedRows[0].Cells[2].Value.ToString();
             type.Text = dataGridView_siteHistory.SelectedRows[0].Cells[3].Value.ToString();
             major_products.Text = dataGridView_siteHistory.SelectedRows[0].Cells[4].Value.ToString();
             byproducts.Text = dataGridView_siteHistory.SelectedRows[0].Cells[5].Value.ToString();
             major_pollutants.Text = dataGridView_siteHistory.SelectedRows[0].Cells[6].Value.ToString();
             potential_pollutants.Text = dataGridView_siteHistory.SelectedRows[0].Cells[7].Value.ToString();
         }

    }
}
