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
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gonza\source\repos\InventoryManagement\InventoryManagement\Inv.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt=new DataTable();
        int total=0;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("product");
            dt.Columns.Add("price");
            dt.Columns.Add("quantity");
            dt.Columns.Add("total");
        }

        private void textBoxProduct_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;

            listBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Stocks where product_name like('"+textBoxProduct.Text +"%') ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_name"].ToString());

            }

        }

        private void textBoxProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;

                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxProduct.Text=listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    textBoxProduct.Focus();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from purchase_master where product_name='"+ textBoxProduct.Text +"' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBoxPrice.Text = dr["product_price"].ToString(); 
            }

        }

        private void textBoxQty_Leave(object sender, EventArgs e)
        {
            try
            {
                textBoxTotal.Text = Convert.ToString(Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQty.Text));
            }
            catch(Exception ex)
            {
                
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int Stocks = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Stocks where product_name='"+ textBoxProduct.Text +"'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach(DataRow dr1 in dt1.Rows)
            {
                Stocks = Convert.ToInt32(dr1["product_quantity2"].ToString());

            }

            if (Convert.ToInt32(textBoxQty.Text) > Stocks)
            {
                MessageBox.Show("This value is not available");
            }
            else
            {
                DataRow dr=dt.NewRow();
                dr["product"] = textBoxProduct.Text;
                dr["price"] = textBoxPrice.Text;
                dr["quantity"] = textBoxQty.Text;
                dr["total"] = textBoxTotal.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                total = total + Convert.ToInt16(dr["total"].ToString());

                labelTotal.Text = total.ToString();

            }

            textBoxProduct.Text = "";
            textBoxPrice.Text = "";
            textBoxQty.Text = "";
            textBoxTotal.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in dt.Rows)
                {
                    total = total + Convert.ToInt32(dr1["total"].ToString());
                    labelTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into order_user values('"+ textBoxFname.Text +"','"+ textBoxLname.Text +"','"+ comboBoxPtype.Text +"','"+ dateTimePicker1.Value.ToString("dd/MM/yyyy") +"')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2= con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from order_user order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();

            }
            foreach (DataRow dr in dt.Rows)
            {
                int quantity = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_item values('" + orderid.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["quantity"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                quantity = Convert.ToInt32(dr["quantity"].ToString());
                pname = dr["product"].ToString();


                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update Stocks set product_quantity2=product_quantity2-"+quantity+" where product_name='"+ pname.ToString() +"'";
                cmd6.ExecuteNonQuery();
            }

            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxProduct.Text = "";
            textBoxPrice.Text = "";
            textBoxQty.Text = "";
            textBoxTotal.Text = "";
            labelTotal.Text = "";

            dt.Clear();
            dataGridView1.DataSource = dt;
            MessageBox.Show("The record has been successfully inserted");


        }
    }
}
