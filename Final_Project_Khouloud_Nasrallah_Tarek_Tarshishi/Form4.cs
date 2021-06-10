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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            String query = "INSERT INTO vaccin (name) VALUES ('" + name + "');";
            MySqlConnection dbConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);

            try
            {
                dbConnection.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();


                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error : " + ex.Message);
            }
        }
    }
}
