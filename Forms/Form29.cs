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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into sturesponse values(@Reg_No,@Status)", conn);
                cmd.Parameters.AddWithValue("@Reg_No", Form24.a);
                cmd.Parameters.AddWithValue("@Status", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Form21 f = new Form21();
                f.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form24 f = new Form24();
            f.ShowDialog();
            this.Close();
        }
    }
}
