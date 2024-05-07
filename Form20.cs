﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBPROJ4
{


    public partial class Form20 : Form
    {
        string Selection = "";
        string date = "";
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5
            Form19 form19 = new Form19();

            // Show Form6
            form19.Show();

            // Optionally, you can hide Form1
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5
            Form1 form1 = new Form1();

            // Show Form6
            form1.Show();

            // Optionally, you can hide Form1
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string childname = textBox3.Text.Trim();
            string medicalinfo = textBox6.Text.Trim();
            string allergy = textBox4.Text.Trim();
            string diet = textBox5.Text.Trim();

            // Your connection string
            string cnstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS01;Initial Catalog=DBPROJECT;Integrated Security=True;Encrypt=false";

            // Your SQL query using parameterized query to prevent SQL injection
            string sqlquery = "INSERT INTO Child (Name, DateOfBirth, Gender, MedicalInfo, Allergies, DietaryRequirements) " +
                              "VALUES (@Name, @DateOfBirth, @Gender, @MedicalInfo, @Allergies, @DietaryRequirements);";

            try
            {
                // Create a connection
                using (SqlConnection con = new SqlConnection(cnstring))
                {
                    con.Open();

                    // Create a command with the SQL query and the connection
                    using (SqlCommand cm = new SqlCommand(sqlquery, con))
                    {
                        // Add parameters to the command
                        cm.Parameters.AddWithValue("@Name", childname);
                        cm.Parameters.AddWithValue("@DateOfBirth", dateTimePicker2.Value);
                        cm.Parameters.AddWithValue("@Gender", comboBox2.SelectedItem.ToString());
                        cm.Parameters.AddWithValue("@MedicalInfo", medicalinfo);
                        cm.Parameters.AddWithValue("@Allergies", allergy);
                        cm.Parameters.AddWithValue("@DietaryRequirements", diet);

                        // Execute the query
                        cm.ExecuteNonQuery();
                    }
                }

                label2.Text = "Child record inserted successfully.";
            }
            catch (Exception ex)
            {
                label2.Text = "Error: " + ex.Message;
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection = comboBox2.SelectedItem.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker2.ToString();
        }
    }
}

