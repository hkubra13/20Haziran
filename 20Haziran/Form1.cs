using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace _20Haziran
{
    public partial class Form1 : Form
    {
        KitaplarDAO kitaplarDAO = new KitaplarDAO();
        Yay�neviDAO yay�neviDAO = new Yay�neviDAO();
        YazarDAO yazarDAO = new YazarDAO();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource kitapBindingSource = new BindingSource();
            kitapBindingSource.DataSource = kitaplarDAO.getAllKitaplar();
            columns(kitapBindingSource);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource kitapBindingSource = new BindingSource();
            kitapBindingSource.DataSource = kitaplarDAO.searchTitles(textBox1.Text, textBoxYay�neviAd�.Text, textBoxYazarAd�.Text);
            columns(kitapBindingSource);
        }

        private void columns(BindingSource kitapBindingSource)
        {
            dataGridView1.DataSource = kitapBindingSource;
            dataGridView1.Columns["yazarId"].Visible = false;
            dataGridView1.Columns["yay�neviId"].Visible = false;

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


                Kitap kitap = kitaplarDAO.gosterKitap((int)dataGridView1.Rows[rowClicked].Cells[0].Value);

                Form3 form3 = new Form3(kitap);
                form3.Show();
            }
            else
            {
                MessageBox.Show("L�tfen bir sat�r se�iniz.");
            }
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("L�tfen bir sat�r se�iniz.");
                return;
            }
            int rowClicked = dataGridView1.CurrentRow.Index;
            int sayi = rowClicked;
            int kitapID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;


            int result = kitaplarDAO.deleteKitap(kitapID);
            MessageBox.Show(result + " kay�t silindi");


        }

        private void YazarEkle_Click(object sender, EventArgs e)
        {
            YazarEkle yazarekle = new YazarEkle();
            yazarekle.Show();
        }

        private void Yay�neviEkle_Click(object sender, EventArgs e)
        {
            Yay�neviEkle yay�neviekle = new Yay�neviEkle();
            yay�neviekle.Show();
        }

        private void YazarSil_Click(object sender, EventArgs e)
        {
            YazarSil yazarsil = new YazarSil();
            yazarsil.Show();

        }

        private void Yay�neviSil_Click(object sender, EventArgs e)
        {
            Yay�neviSil yay�nevisil = new Yay�neviSil();
            yay�nevisil.Show();
        }

        private void Yay�neviGoster_Click(object sender, EventArgs e)
        {
            BindingSource yay�neviBindingSource = new BindingSource();
            yay�neviBindingSource.DataSource = yay�neviDAO.getAllYay�nevleri();
            dataGridViewYay�nevi.DataSource = yay�neviBindingSource;
        }

        private void Yay�neviAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYay�nevi.Text))
            {
                MessageBox.Show("L�tfen bir yay�nevi ismi giriniz.");
                return;
            }
            BindingSource yay�neviBindingSource = new BindingSource();
            yay�neviBindingSource.DataSource = yay�neviDAO.searchTitles(textBoxYay�nevi.Text);
            dataGridViewYay�nevi.DataSource = yay�neviBindingSource;

        }

        private void YazarGoster_Click(object sender, EventArgs e)
        {
            BindingSource yazarBindingSource = new BindingSource();
            yazarBindingSource.DataSource = yazarDAO.getAllYazarlar();
            dataGridViewYazar.DataSource = yazarBindingSource;
        }

        private void YazarAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYazar.Text))
            {
                MessageBox.Show("L�tfen bir yazar ismi giriniz.");
                return;
            }
            BindingSource yazarBindingSource = new BindingSource();
            yazarBindingSource.DataSource = yazarDAO.searchTitles(textBoxYazar.Text);
            dataGridViewYazar.DataSource = yazarBindingSource;
        }


    }
}