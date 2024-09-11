using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
            this.Close();
        }
        public static string c, d;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text && textBox1.Text != "" && textBox2.Text != "")
            {

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into fac values(@Name,@Email_id,@Password)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email_id", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", (textBox3.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Registered...","Title");
                Form8 form = new Form8();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Invalid credentials","Title");
            }

        }
    }
}
