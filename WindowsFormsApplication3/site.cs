using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//连接数据库
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//连接数据库

namespace WindowsFormsApplication3
{
    public partial class site : Form
    {
        public site()
        {
            InitializeComponent();
            foreach (Control c in groupBox4.Controls)//this.Controls是得到当前窗体里所有控件的集合，Control是一个控件对象（textbox也是控件继承了Control）
            {
                if (c is TextBox)//判断c是不是Textbox类型的
                {
                    TextBox temp = c as TextBox;//如果是则转换为Textbox类型的（as是转换用的关键字）
                    temp.ReadOnly = true;
                }
            }
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

        }


/// 把输入的场地代码赋给site中textbox1
        public site(string text)
              : this()
        {
            textBox1.Text = text;
            string strConnection = "Data Source=(local);Initial Catalog=cdsj;Integrated Security=True";
            SqlConnection lo_con = new SqlConnection(strConnection);
            lo_con.Open();

            SqlCommand lo_cmd = new SqlCommand(); //创建命令对象
            lo_cmd.CommandText = "select * from site_info where site_code = " + textBox1.Text + ""; //写SQL语句
            lo_cmd.Connection = lo_con; //指定连接对象，即上面创建的
            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); 
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

        
        


            
            
            
            
      

        
    
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void site_property_TextChanged(object sender, EventArgs e)
        {

        }

        private void site_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void longitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void site_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
                   
        }

        private void checkY_heavymetal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void site_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_menu tt = new table_menu();
            tt.Show();
            //this.Hide();

        }
       

    }
}
