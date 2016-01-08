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
    public partial class modify_site : Form
    {
        public modify_site()
        {
            InitializeComponent();
        }

        public modify_site(string text)
              : this()
        {
            textBox1.Text = text;
            ///链接SQL server数据库
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();

            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_info where site_code = " + textBox1.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); //建立数据适配器，dataadpter是dataset和数据源之间的一个桥梁，用于从数据源中检索数据并填充DataSet中的表
            DataSet ds_site = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds_site, "site_info"); //将数据表填充到数据集

            site_property.Text = ds_site.Tables["site_info"].Rows[0][1].ToString();//通过数据集给textbox赋值
            site_address.Text = ds_site.Tables["site_info"].Rows[0][2].ToString();
            longitude.Text = ds_site.Tables["site_info"].Rows[0][3].ToString();
            latitude.Text = ds_site.Tables["site_info"].Rows[0][4].ToString();
            contact_name.Text = ds_site.Tables["site_info"].Rows[0][5].ToString();
            contact_tel.Text = ds_site.Tables["site_info"].Rows[0][6].ToString();
            contact_address.Text = ds_site.Tables["site_info"].Rows[0][7].ToString();
            contact_Email.Text = ds_site.Tables["site_info"].Rows[0][8].ToString();
            site_description.Text = ds_site.Tables["site_info"].Rows[0][9].ToString();

            lo_cmd.CommandText = "select * from site_general where site_code = " + textBox1.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
         //   DataSet ds = new DataSet(); //创建数据集对象
            dbAdapter2.Fill(ds_site, "site_general"); //用返回的结果集填充数据集

            site_type.Text = ds_site.Tables["site_general"].Rows[0][1].ToString();
            early_use.Text = ds_site.Tables["site_general"].Rows[0][2].ToString();
            now_use.Text = ds_site.Tables["site_general"].Rows[0][3].ToString();
            source_type.Text = ds_site.Tables["site_general"].Rows[0][4].ToString();
            heavymetal_control_zone.Text = ds_site.Tables["site_general"].Rows[0][5].ToString();
            drinkingwater_protection_zone.Text = ds_site.Tables["site_general"].Rows[0][6].ToString();
            farmland.Text = ds_site.Tables["site_general"].Rows[0][7].ToString();


            lo_cmd.CommandText = "select * from site_history where site_code = " + textBox1.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
        //    DataSet ds3 = new DataSet(); //创建数据集对象
            dbAdapter3.Fill(ds_site, "site_history"); //用返回的结果集填充数据集

            star_date.Text = ds_site.Tables["site_history"].Rows[0][1].ToString();
            end_date.Text = ds_site.Tables["site_history"].Rows[0][2].ToString();
            owner_name1.Text = ds_site.Tables["site_history"].Rows[0][3].ToString();
            type.Text = ds_site.Tables["site_history"].Rows[0][4].ToString();
            major_products.Text = ds_site.Tables["site_history"].Rows[0][5].ToString();
            byproducts.Text = ds_site.Tables["site_history"].Rows[0][6].ToString();
            major_pollutants.Text = ds_site.Tables["site_history"].Rows[0][7].ToString();
            potential_pollutants.Text = ds_site.Tables["site_history"].Rows[0][8].ToString();

            lo_cmd.CommandText = "select * from owner_info where site_code = " + textBox1.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter4 = new SqlDataAdapter(lo_cmd); //注意与上面的区分开
       //     DataSet ds = new DataSet(); //创建数据集对象
            dbAdapter4.Fill(ds_site, "owner_info"); //用返回的结果集填充数据集

            owner_name2.Text = ds_site.Tables["owner_info"].Rows[0][1].ToString();
            owner_company.Text = ds_site.Tables["owner_info"].Rows[0][2].ToString();
            owner_tel.Text = ds_site.Tables["owner_info"].Rows[0][3].ToString();
            owner_address.Text = ds_site.Tables["owner_info"].Rows[0][4].ToString();
            owner_fax.Text = ds_site.Tables["owner_info"].Rows[0][5].ToString();
            owner_email.Text = ds_site.Tables["owner_info"].Rows[0][6].ToString();
            time_from.Text = ds_site.Tables["owner_info"].Rows[0][7].ToString();
            time_to.Text = ds_site.Tables["owner_info"].Rows[0][8].ToString();
            ownership_status.Text = ds_site.Tables["owner_info"].Rows[0][9].ToString();

            lo_con.Close();
   
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void site_property_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            string strConnectionn = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_conn = new SqlConnection(strConnectionn);
            string update1 = "UPDATE cdsj.dbo.site_info SET site_code =  '" + textBox1.Text + "',site_property = '" + site_property.Text + "',sit_address = '" + site_address.Text + "',longitude = '" + longitude.Text + "',latitude = '" + latitude.Text + "',contact_name = '" + contact_name.Text + "',contact_tel = '" + contact_tel.Text + "',contact_fax = '" + contact_fax.Text + "',contact_address = '" + contact_address.Text + "',contact_Email = '" + contact_Email.Text + "',site_description = '" + site_description.Text + "'where site_code = '" + textBox1.Text + "'";//录入地基信息表中第一个groupbox
            SqlCommand addCommand1 = new SqlCommand(update1, lo_conn);
            addCommand1.Connection.Open();
            addCommand1.ExecuteNonQuery();
            addCommand1.Connection.Close();                         //执行插入语句

            string update2 = "UPDATE cdsj.dbo.site_general SET site_code =  '" + textBox1.Text + "',site_type = '" + site_type.Text + "',early_use = '" + early_use.Text + "',now_use = '" + now_use.Text + "',source_type = '" + source_type.Text + "',heavymetal_control_zone = '" + heavymetal_control_zone.Text + "',drinkingwater_protection_zone = '" + drinkingwater_protection_zone.Text + "',farmland = '" + farmland.Text + "' where site_code = '" + textBox1.Text + "'";//录入地基信息表中第二个groupbox
            SqlCommand addCommand2 = new SqlCommand(update2, lo_conn);
            addCommand2.Connection.Open();
            addCommand2.ExecuteNonQuery();
            addCommand2.Connection.Close();

            string update3 = "UPDATE cdsj.dbo.site_history SET site_code = '" + textBox1.Text + "',star_date = '" + star_date.Text + "',end_date = '" + end_date.Text + "',owner_name = '" + owner_name1.Text + "',type = '" + type.Text + "',major_products = '" + major_products.Text + "',byproducts = '" + byproducts.Text + "',major_pollutants = '" + major_pollutants.Text + "',potential_pollutants = '" + potential_pollutants.Text + "' where site_code = '" + textBox1.Text + "'";//录入第三个groupbox
            SqlCommand addCommand3 = new SqlCommand(update3, lo_conn);
            addCommand3.Connection.Open();
            addCommand3.ExecuteNonQuery();
            addCommand3.Connection.Close();                         //执行插入语句

            string update4 = "UPDATE cdsj.dbo.owner_info SET site_code = '" + textBox1.Text + "',owner_name = '" + owner_name2.Text + "',owner_company = '" + owner_company.Text + "',owner_tel = '" + owner_tel.Text + "',owner_address = '" + owner_address.Text + "',owner_fax = '" + owner_fax.Text + "',owner_email = '" + owner_email.Text + "',time_from = '" + time_from.Text + "',time_to = '" + time_to.Text + "',ownership_status = '" + ownership_status.Text + "'where site_code = '" + textBox1.Text + "'";
            SqlCommand addCommand4 = new SqlCommand(update4, lo_conn);
            addCommand4.Connection.Open();
            addCommand4.ExecuteNonQuery();
            addCommand4.Connection.Close();

            MessageBox.Show("修改完成！");               //关闭对象并释放所占内存空间    
            //this.Hide();
    

        }

        private void site_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cdsjDataSet2);

        }

        private void modify_site_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cdsjDataSet2.site_info”中。您可以根据需要移动或删除它。
            this.site_infoTableAdapter.Fill(this.cdsjDataSet2.site_info);

        }

        private void site_infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modify_table_menu mm = new modify_table_menu();
            mm.Show();
            this.Hide();

        }







    }
}
