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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete stucomplaint where Reg_No=@Reg_No", conn);
            cmd.Parameters.AddWithValue("@Reg_No", Form5.a);
            cmd.ExecuteNonQuery();
            conn.Close();
            label4.Text = "";
            label5.Text = "";
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
        public static string c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\susmi\\OneDrive\\Documents\\ciet p.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from stucomplaint where Reg_No=@Reg_No", conn);
            cmd.Parameters.AddWithValue("@Reg_No", Form5.a);
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
    }
}
