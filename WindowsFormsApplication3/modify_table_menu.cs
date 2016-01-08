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
    public partial class modify_table_menu : Form
    {
        public modify_table_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modify_site st = new modify_site(modify_search_engine.Myclass.sitecode);
            st.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modify_pollution pp = new modify_pollution(modify_search_engine.Myclass.sitecode);
            pp.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modify_site_environment ss = new modify_site_environment(modify_search_engine.Myclass.sitecode);
            ss.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modify_search_engine ss = new modify_search_engine();
            ss.Show();
        }

    }
}
