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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sun21_p
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        public static string a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==textBox4.Text && textBox1.Text!="" &&textBox2.Text!="")
            {
                a = textBox2.Text;
                b = textBox3.Text;
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into stu values(@Name,@Reg_No,@Password)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Reg_No", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password",(textBox3.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registered Succesfully...", "Title");
                Form3 form = new Form3();
                form.ShowDialog();
                this.Close();
            
                
            }
            else
            {
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Invalid Credentials...","Title");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }
    }
}
