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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            String query = "DELETE FROM vaccin WHERE name = '"+name+"';";
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

        private void Form5_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        public void fillcombo()
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            string query = "SELECT * FROM vaccin";
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
                        comboBox1.Items.Add(myReader.GetString(1));
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
