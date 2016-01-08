using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication3
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
            webBrowser1.ObjectForScripting = this;
        }

        private void map_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "/HTMLPage4.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] objects = new object[2];
            objects[0] = search_engine.Myclass.lng;
            objects[1] = search_engine.Myclass.lat;

            webBrowser1.Document.InvokeScript("SetCenter",objects);
        }

        public void getPoi()
        {
            object[] objects = new object[2];
            objects[0] = search_engine.Myclass.lng;
            objects[1] = search_engine.Myclass.lat;
            webBrowser1.Document.InvokeScript("SetCenter", objects);
        }
    }
}
