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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(usertxt.Text == string.Empty))
                {

                    if (!(passtxt.Text == string.Empty))
                    {

                        String str = "Server=.;Database=store1;Trusted_Connection=True;";

                        String query = "select * from login1 where uname = '" + usertxt.Text + "'and pass = '" + this.passtxt.Text + "'";

                        SqlConnection con = new SqlConnection(str);

                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader dbr;

                        con.Open();

                        dbr = cmd.ExecuteReader();

                        int count = 0;

                        while (dbr.Read())
                        {

                            count = count + 1;

                        }

                        if (count == 1)
                        {

                            login obj = new login();

                            select dmain = new select();
                            dmain.Show(); //after login Redirect to second window
                            this.Hide();//after login hide the  Login window

                        }

                        else if (count > 1)
                        {

                            MessageBox.Show("Duplicate username and password", "login page");

                        }

                        else
                        {

                            MessageBox.Show(" username and password incorrect", "login page");

                        }

                    }

                    else
                    {

                        MessageBox.Show(" password empty", "login page");

                    }

                }
                else
                {

                    MessageBox.Show(" username empty", "login page");

                }

                // con.Close();



            }

            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }

        }
    }
}
