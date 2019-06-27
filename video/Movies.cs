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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet3.Movies);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                    textBox6.Text = row.Cells[0].Value.ToString();
                    textBox7.Text = row.Cells[1].Value.ToString();
                    textBox8.Text = row.Cells[2].Value.ToString();
                    textBox9.Text = row.Cells[3].Value.ToString();
                    textBox10.Text = row.Cells[4].Value.ToString();
                    textBox11.Text = row.Cells[5].Value.ToString();
                    textBox12.Text = row.Cells[6].Value.ToString();
                    textBox13.Text = row.Cells[7].Value.ToString();


                }
            }
            catch (Exception e1)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operationclass f = new operationclass();
            bool g = f.insertnewmovie(textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox13.Text);
            if (g == true)
            {
                MessageBox.Show("New Movie Inserted");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operationclass f = new operationclass();
            bool g = f.updatemovie(textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox13.Text);
            MessageBox.Show("Updated");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            operationclass d = new operationclass();
            bool g = d.deletemovie(textBox6.Text);
            if (g == true)
            {
                MessageBox.Show("Movie Deleted");
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                

                            }
        }
    }
}
