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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM request", "datasource = 127.0.0.1;port=3325; database = covid19; username = root; password =");
                DataSet ds = new DataSet();
                da.Fill(ds, "request");
                dataGridView1.DataSource = ds.Tables["request"].DefaultView;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            fillcombo();

            
        }

        private void fillcombo()
        {
            comboBox2.Items.Add("ACCEPT");
            comboBox2.Items.Add("REJECT");
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            string query = "SELECT * FROM request";
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

        private void button1_Click(object sender, EventArgs e)
        {
            String status = comboBox2.SelectedItem.ToString();
            string name = comboBox1.SelectedItem.ToString();
            string MySQLConnectionString = "datasource=127.0.0.1;port=3325;username=root;password=;database=covid19";
            string query = "UPDATE request SET status = '"+status+"' WHERE name = '"+ name+"' ";
            string location = textBox1.Text;
            string theDate = dateTimePicker1.Value.ToShortDateString();
            String query1 = "INSERT INTO reservation (name,date,location) VALUES ('" + name + "','" + theDate + "','"+location+"');";
            MySqlConnection dbConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            MySqlCommand cmd1 = new MySqlCommand(query1, dbConnection);
            try
            {
                dbConnection.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();
                dbConnection.Close();
                if(status == "ACCEPT")
                {
                    dbConnection.Open();
                    MySqlDataReader myReader1 = cmd1.ExecuteReader();
                }

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error : " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}
