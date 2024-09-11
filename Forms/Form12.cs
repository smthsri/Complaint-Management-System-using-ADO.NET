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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("update stucomplaint set Complaint=@Complaint where Reg_No=@Reg_No", conn);
                cmd.Parameters.AddWithValue("@Reg_No",Form5.a);
                cmd.Parameters.AddWithValue("@Complaint", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Form7 f = new Form7();
                f.ShowDialog();
                this.Close();
            }
            
        }
    }
}
