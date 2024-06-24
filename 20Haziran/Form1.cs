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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowClicked = dataGridView1.CurrentRow.Index;

                KitaplarDAO kitaplarDAO = new KitaplarDAO();
                Kitap kitap = kitaplarDAO.gosterKitap((int)dataGridView1.Rows[rowClicked].Cells[0].Value);

                Form3 form3 = new Form3(kitap);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satýr seçiniz.");
            }
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int kitapID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            int result = kitaplarDAO.deleteKitap(kitapID);
            MessageBox.Show(result + " kayýt silindi");
        }

        private void YazarEkle_Click(object sender, EventArgs e)
        {
            YazarEkle yazarekle = new YazarEkle();
            yazarekle.Show();
        }

        private void YayýneviEkle_Click(object sender, EventArgs e)
        {
            YayýneviEkle yayýneviekle = new YayýneviEkle();
            yayýneviekle.Show();
        }

        private void YazarSil_Click(object sender, EventArgs e)
        {
            YazarSil yazarsil = new YazarSil();
            yazarsil.Show();

        }

        private void YayýneviSil_Click(object sender, EventArgs e)
        {
            YayýneviSil yayýnevisil = new YayýneviSil();
            yayýnevisil.Show();
        }
    }
}