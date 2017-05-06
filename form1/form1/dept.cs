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
    public partial class dept : Form
    {
        public int g=0, f=0, h=0;
        public dept()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Garments_update g = new Garments_update();
            g.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Garments_update g = new Garments_update();
            g.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Garments_update g = new Garments_update();
            g.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Food_update g = new Food_update();
            g.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Food_update g = new Food_update();
            g.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            Food_update g = new Food_update();
            g.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            HomeAppliances_update g = new HomeAppliances_update();
            g.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            HomeAppliances_update g = new HomeAppliances_update();
            g.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dept d = new dept();
            HomeAppliances_update g = new HomeAppliances_update();
            g.Show();
            this.Hide();
        }

        private void gbutton_Click(object sender, EventArgs e)
        {
            g = 1;
            MessageBox.Show(Convert.ToString(g));
            garments_view g1 = new garments_view(g);
            g1.Show();
            this.Hide();

        }

        private void fbutton_Click(object sender, EventArgs e)
        {
            g = 2;
            garments_view g1 = new garments_view(g);
            g1.Show();
            this.Hide();
        }

        private void hbutton_Click(object sender, EventArgs e)
        {
            g = 3;
            garments_view g1 = new garments_view(g);
            g1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login d = new login();
            d.Show();
            this.Hide();
        }

        
    }
}
