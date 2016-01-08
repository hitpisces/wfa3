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
    public partial class readin_table_menu : Form
    {
        public readin_table_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readin_site st = new readin_site();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readin_pollution pp = new readin_pollution();
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readin_site_environment ss = new readin_site_environment();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            statistics mm = new statistics();
            mm.Show();
        }
    }
}
