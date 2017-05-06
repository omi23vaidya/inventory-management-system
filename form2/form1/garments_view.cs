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
    public partial class garments_view : Form
    {
        int gar;
        public garments_view(int g)
        {
            InitializeComponent();
             gar = g;

        }

        private void garments_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store1DataSet5.food1' table. You can move, or remove it, as needed.
            this.food1TableAdapter.Fill(this.store1DataSet5.food1);
            // TODO: This line of code loads data into the 'store1DataSet2.homeappliances' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'store1DataSet1.food' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'store1DataSet.garments' table. You can move, or remove it, as needed.
            dept d = new dept();
            //MessageBox.Show(Convert.ToString(gar));
            if (gar == 1)
            {
                dataGridView1.DataSource = garmentsBindingSource;
                this.garmentsTableAdapter.Fill(this.store1DataSet.garments);
                
            }
            else if (gar == 2)
            {
                dataGridView1.DataSource = bindingSource3;
                this.food1TableAdapter.Fill(this.store1DataSet5.food1);
            }
            else if (gar == 3)
            {
                dataGridView1.DataSource = bindingSource2;
                this.homeappliancesTableAdapter.Fill(this.store1DataSet2.homeappliances);
            }
            else if (gar == 4)
            {
                dataGridView1.DataSource = bindingSource1;
                this.foodTableAdapter.Fill(this.store1DataSet1.food);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void garmentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bk_Click(object sender, EventArgs e)
        {
            if (gar == 2)
            {
                dept d = new dept();
                d.Show();
                this.Hide();
            }
            else if (gar == 4)
            {
                select d = new select();
                d.Show();
                this.Hide();
            }
        }

        
    }
}
