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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("update faccomplaint set Complaint=@Complaint where Email_id=@Email_id", conn);
                cmd.Parameters.AddWithValue("@Email_id", Form10.a);
                cmd.Parameters.AddWithValue("@Complaint", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Form13 f = new Form13();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
