using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project_Khouloud_Nasrallah_Tarek_Tarshishi
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string pass = passtxt.Text;

            if(username=="admin" && pass == "admin")
            {
                Form3 f = new Form3();
                f.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password ");
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
