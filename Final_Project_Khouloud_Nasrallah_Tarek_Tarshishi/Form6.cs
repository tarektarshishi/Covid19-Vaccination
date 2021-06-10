using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project_Khouloud_Nasrallah_Tarek_Tarshishi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM request WHERE name = '"+name+"'", "datasource = 127.0.0.1;port=3325; database = covid19; username = root; password =");
                DataSet ds = new DataSet();
                da.Fill(ds, "request");
                dataGridView1.DataSource = ds.Tables["request"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
