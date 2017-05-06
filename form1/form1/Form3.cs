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
    public partial class store2 : Form
    {
        int g;
        public store2()
        {
            InitializeComponent();
        }

       

        private void food_Click(object sender, EventArgs e)
        {
            g = 4;
            //MessageBox.Show(Convert.ToString(g));
            garments_view g1 = new garments_view(g);
            g1.Show();
            this.Hide();
        }

       
    }
}
