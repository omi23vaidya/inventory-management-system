using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            d.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            store2 d = new store2();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login d = new login();
            d.Show();
            this.Hide();
        }
    }
}
