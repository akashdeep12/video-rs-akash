using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells[0].Value.ToString();

                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox3.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operationclass d = new operationclass();
            bool h = d.addcustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (h == true)
            {
                MessageBox.Show("Cutomer Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operationclass f = new operationclass();
            bool g = f.updatecustomer(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (g == true)
            {
                MessageBox.Show("Customer Updated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operationclass f = new operationclass();
            f.deletecustomer(textBox5.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            MessageBox.Show("Customer deleted");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet6.Customer);

        }
    }
}
