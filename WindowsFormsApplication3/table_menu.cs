using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class table_menu : Form
    {
        public table_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            site st = new site(search_engine.Myclass.sitecode);//把search engine中的sitecode参数传给site
            st.Show();//显示site窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pollution pp = new pollution(search_engine.Myclass.sitecode);
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            site_environment ss = new site_environment(search_engine.Myclass.sitecode);
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            search_engine se = new search_engine();
            se.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
