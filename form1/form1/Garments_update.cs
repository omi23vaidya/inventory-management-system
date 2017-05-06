using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace form1
{
    public partial class Garments_update : Form
    {
        int gg;
        public Garments_update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gg = 1;
            garments_view g1 = new garments_view(gg);
            g1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gg = 1;
            garments_view g1 = new garments_view(gg);
            g1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox4.Text);
                String name = "Formal Shirts";
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                String query = "insert into garments values(@item, @qty)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@item", name));
                cmd.Parameters.Add(new SqlParameter("@qty", quantity));
                con.Open();
                cmd.ExecuteReader();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox5.Text);
                String name = "Denim Jeans";
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                String query = "insert into garments values(@item, @qty)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@item", name));
                cmd.Parameters.Add(new SqlParameter("@qty", quantity));
                con.Open();
                cmd.ExecuteReader();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox6.Text);
                String name = "Hoodies";
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                String query = "insert into garments values(@item, @qty)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@item", name));
                cmd.Parameters.Add(new SqlParameter("@qty", quantity));
                con.Open();
                cmd.ExecuteReader();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
