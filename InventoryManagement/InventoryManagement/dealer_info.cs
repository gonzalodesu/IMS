using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
   
    public partial class dealer_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gonza\source\repos\InventoryManagement\InventoryManagement\Inv.mdf;Integrated Security=True");
        public dealer_info()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con .CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dealer_info values('"+ textBoxDname.Text +"','"+ textBoxCname.Text +"','"+ textBoxCt.Text +"','"+ textBoxAs.Text +"','"+ textBoxCy.Text +"')";
            cmd.ExecuteNonQuery();

            textBoxDname.Text = "";
            textBoxCname.Text = "";
            textBoxCt.Text = "";
            textBoxAs.Text = "";
            textBoxCy.Text = "";

            dg();
            MessageBox.Show("record added successfully !");
        }

        private void dealer_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
                con.Open();
            dg();
        }

        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dealer_info where id= "+ id +" ";
            cmd.ExecuteNonQuery();

            dg();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info where id="+ id +"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["dealer_name"].ToString();
                textBox2.Text = dr["dealer_company_name"].ToString();
                textBox3.Text = dr["contact"].ToString();
                textBox4.Text = dr["address"].ToString();
                textBox5.Text = dr["city"].ToString();
            }
        }

        private void buttonUpdate2_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dealer_info set dealer_name='"+ textBox1.Text +"',dealer_company_name='"+ textBox2.Text +"',contact='"+ textBox3.Text +"',address='"+ textBox4.Text +"',city='"+ textBox5.Text +"' where id=" + id + "";
            cmd.ExecuteNonQuery();

            panel2.Visible=false;
            dg();

        }
    }

        
    }
    

