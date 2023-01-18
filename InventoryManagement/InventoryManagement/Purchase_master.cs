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
    public partial class Purchase_master : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gonza\source\repos\InventoryManagement\InventoryManagement\Inv.mdf;Integrated Security=True;Connect Timeout=30");
        public Purchase_master()
        {
            InitializeComponent();
        }

        private void Purchase_master_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_product_name();
            fill_dealer_name();
        }

        public void fill_product_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBoxProdName.Items.Add(dr["product_name"].ToString());
            }

        }

        private void comboBoxProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name where product_name='"+ comboBoxProdName.Text +"'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelUnit.Text = dr["units"].ToString();

            }

        }

        public void fill_dealer_name() 
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxDn.Items.Add(dr["dealer_name"].ToString());
            }

        }

        private void textBoxPp_Leave(object sender, EventArgs e)
        {
            textBoxPt.Text = Convert.ToString(Convert.ToInt32(textBoxPq.Text) * Convert.ToInt32(textBoxPp.Text));
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            int i;

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Stocks where product_name='" + comboBoxProdName.Text + "'";
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            i = Convert.ToInt32(dt1.Rows.Count.ToString());
            if(i== 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into purchase_master values('" + comboBoxProdName.Text + "','" + textBoxPq.Text + "','" + labelUnit.Text + "','" + textBoxPp.Text + "','" + textBoxPt.Text + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + comboBoxDn.Text + "','" + comboBoxPuT.Text + "','" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" + textBoxProfit.Text + "')";
                cmd.ExecuteNonQuery();


                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Stocks values('" + comboBoxProdName.Text + "','" + textBoxPq.Text + "','" + labelUnit.Text + "')";
                cmd3.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into purchase_master values('" + comboBoxProdName.Text + "','" + textBoxPq.Text + "','" + labelUnit.Text + "','" + textBoxPp.Text + "','" + textBoxPt.Text + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + comboBoxDn.Text + "','" + comboBoxPuT.Text + "','" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" + textBoxProfit.Text + "')";
                cmd2.ExecuteNonQuery();

                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update Stocks set product_quantity2=product_quantity2 + " + textBoxPq.Text +" where product_name='"+ comboBoxProdName.Text +"' ";
                cmd4.ExecuteNonQuery();
            }

           

            MessageBox.Show("Record has been successfully Added!");
        }
    }
}
