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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.ShowDialog();
            this.Close();
        }
        public static string c, d;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from faccomplaint where Email_id=@Email_id", conn);
            cmd.Parameters.AddWithValue("@Email_id", Form10.a);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                c = r[0] as string;
                d = r[1] as string;
            }
            label4.Text = c;
            label5.Text = d;
            c = "";
            d = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete faccomplaint where Email_id=@Email_id", conn);
            cmd.Parameters.AddWithValue("@Email_id", Form10.a);
            cmd.ExecuteNonQuery();
            conn.Close();
            label4.Text = "";
            label5.Text = "";
            Form13 f = new Form13();
            f.ShowDialog();
            this.Close();
        }
    }
}
