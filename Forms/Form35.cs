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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }
        public static string a;
        private void button4_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from faccomplaint where Email_id=@Email_id", conn);
            cmd.Parameters.AddWithValue("@Email_id", textBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 f = new Form23();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Complaint is RESOLVED...", "Title");
            Form26 f = new Form26();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your Complaint is REJECTED...", "Title");
            Form27 f = new Form27();
            f.ShowDialog();
        }
    }
}
