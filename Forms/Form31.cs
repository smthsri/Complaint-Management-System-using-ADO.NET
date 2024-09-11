﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sun21_p
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }
        // Public variable to store the registration number for use in other forms
        public static string a;

        // Event handler for button1 click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if both text boxes are not empty
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Define the connection string
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30";

                // Create and open a connection within a using block for proper disposal
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM stu WHERE Reg_No = @Reg_No AND Password = @Password", conn))
                    {
                        // Use Add with parameter type to avoid issues with implicit conversions
                        cmd.Parameters.Add("@Reg_No", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBox2.Text;

                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            ada.Fill(dt);

                            // Check if any rows were returned
                            if (dt.Rows.Count > 0)
                            {
                                a = textBox1.Text; // Store the registration number
                                MessageBox.Show("Login success...", "Title");
                                Form33 form = new Form33();
                                form.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials", "Title");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter both Reg_No and Password", "Input Error");
            }
        }

        // Event handler for button2 click
        private void button2_Click(object sender, EventArgs e)
        {
            Form28 form = new Form28();
            form.ShowDialog();
            this.Close();
        }
       
    }
}
