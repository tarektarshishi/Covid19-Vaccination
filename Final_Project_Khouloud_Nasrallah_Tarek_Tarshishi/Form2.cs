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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fillcombo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
                        combo.Items.Add(myReader.GetString(1));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error : " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            insertQuery();
        }

        private void age_ValueChanged(object sender, EventArgs e)
        {
            age.Maximum = 100;
            age.Minimum = 18;
        }

        private void insertQuery()
        {
            string Name = nametxt.Text;
            int Age = (int)age.Value;
            string Gender = "";
            if (male.Checked)
            {
                Gender = "male";
            }
            if (female.Checked)
            {
                Gender = "female";
            }

            string type = combo.SelectedItem.ToString();

            string Location = locationtxt.Text;
            string Status = "pending";
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";

            String query = "INSERT INTO request (name,age,gender,location,type,status) VALUES ('" + Name + "','" + Age + "','" + Gender + "','" + Location + "','"+type+ "','" + Status + "');";
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

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }
    }
}
