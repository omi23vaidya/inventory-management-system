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
    public partial class Food_update : Form
    {
        int gf,q1,up;
        public Food_update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gf = 2;
            garments_view g1 = new garments_view(gf);
            g1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gf = 2;
            garments_view g1 = new garments_view(gf);
            g1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox4.Text);
                
                String name = "Veggie Nuggets";
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                String query = "select * from food where item = 'Veggie Nuggets'";
                SqlCommand
                 cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    q1 = dbr.GetInt32(1);
                }
                //MessageBox.Show(Convert.ToString(q1));
                up = q1 + quantity;
                dbr.Close();
                query = "update food set qty=" + up + "where item='Veggie Nuggets'";
                cmd = new SqlCommand(query, con);
               
                
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox5.Text);
                String name = "Veggie Nuggets";
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                String query = "select * from food where item = 'Maggie Packets'";
                SqlCommand
                 cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    q1 = dbr.GetInt32(1);
                }
                //MessageBox.Show(Convert.ToString(q1));
                up = q1 + quantity;
                dbr.Close();
                query = "update food set qty=" + up + "where item='Maggie Packets'";
                cmd = new SqlCommand(query, con);


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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox6.Text);
                String name = "Choco Bars";
               
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                String query = "select * from food where item = 'Choco Bars'";
                SqlCommand
                 cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    q1 = dbr.GetInt32(1);
                }
                //MessageBox.Show(Convert.ToString(q1));
                up = q1 + quantity;
                dbr.Close();
                query = "update food set qty=" + up + "where item='Choco Bars'";
                cmd = new SqlCommand(query, con);


                cmd.ExecuteReader();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox1.Text);
                String str = "Server=.;Database=store1;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(str);
                  con.Open();
                String query = "select * from food where item = 'Veggie Nuggets'";
                SqlCommand 
                 cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                 dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                     q1=dbr.GetInt32(1);
                }
                //MessageBox.Show(Convert.ToString(q1));
                up = q1 - quantity;
                //MessageBox.Show(Convert.ToString(up));
                query = "update food set qty=" + up + "where item='Veggie Nuggets'";
                dbr.Close();
               /*String name = "Veggie Nuggets";
                
                query = "insert into food values(@item, @qty)";*/
                cmd = new SqlCommand(query, con);
                //cmd.Parameters.Add(new SqlParameter("@item", name));
                //cmd.Parameters.Add(new SqlParameter("@qty", quantity));
               // con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("updated");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(textBox2.Text);
            String str = "Server=.;Database=store1;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            String query = "select * from food where item = 'Maggie Packets'";
            SqlCommand
             cmd = new SqlCommand(query, con);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                q1 = dbr.GetInt32(1);
            }
            //MessageBox.Show(Convert.ToString(q1));
            up = q1 - quantity;
            //MessageBox.Show(Convert.ToString(up));
            query = "update food set qty=" + up + "where item='Maggie Packets'";
            dbr.Close();
            /*String name = "Veggie Nuggets";
                
             query = "insert into food values(@item, @qty)";*/
            cmd = new SqlCommand(query, con);
            //cmd.Parameters.Add(new SqlParameter("@item", name));
            //cmd.Parameters.Add(new SqlParameter("@qty", quantity));
            // con.Open();
            cmd.ExecuteReader();
            MessageBox.Show("updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(textBox3.Text);
            String str = "Server=.;Database=store1;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            String query = "select * from food where item = 'Choco Bars'";
            SqlCommand
             cmd = new SqlCommand(query, con);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                q1 = dbr.GetInt32(1);
            }
            //MessageBox.Show(Convert.ToString(q1));
            up = q1 - quantity;
            //MessageBox.Show(Convert.ToString(up));
            query = "update food set qty=" + up + "where item='Choco Bars'";
            dbr.Close();
            /*String name = "Veggie Nuggets";
                
             query = "insert into food values(@item, @qty)";*/
            cmd = new SqlCommand(query, con);
            //cmd.Parameters.Add(new SqlParameter("@item", name));
            //cmd.Parameters.Add(new SqlParameter("@qty", quantity));
            // con.Open();
            cmd.ExecuteReader();
            MessageBox.Show("updated");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            d.Show();
            this.Hide();
        }
       
       
        
    }
}
