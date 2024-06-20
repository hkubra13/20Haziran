using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20Haziran
{
    public partial class Form1 : Form
    {
        BindingSource kitapBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            kitapBindingSource.DataSource = kitaplarDAO.getAllKitaplar();
            dataGridView1.DataSource = kitapBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            kitapBindingSource.DataSource = kitaplarDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = kitapBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }



        /*
private void label6_Click(object sender, EventArgs e)
{
   ((Label)sender).Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
} */
    }
}