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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }
        public static string c, d, f;

        private void button1_Click(object sender, EventArgs e)
        {
            Form32 f = new Form32();
            f.ShowDialog();
            this .Close();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from facresponse where Email_id=@Email_id", conn);
            cmd.Parameters.AddWithValue("@Email_id", Form32.a);
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
            label7.Text = d;
        }
    }
}
