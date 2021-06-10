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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            string query = "SELECT * FROM reservation WHERE name = '" + name + "' ";
            MySqlConnection dbConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            try
            {
                dbConnection.Open();

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        MessageBox.Show("YOUR REQUEST WAS ACCEPTED YOU WILL GET VACCINATED AT :" + myReader.GetString(2) + " In" + myReader.GetString(3));
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error : " + ex.Message);
            }
        }
    }
}
