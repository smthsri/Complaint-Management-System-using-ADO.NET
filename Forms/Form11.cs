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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public static string c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from stucomplaint where Reg_No=@Reg_No",conn);
            cmd.Parameters.AddWithValue("@Reg_No",Form5.a);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SqlDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                c=r[0]as string;
                d=r[1]as string;
            }
            label4.Text = c;
            label5.Text = d;
            c = "";
            d = "";

        }
    }
}
