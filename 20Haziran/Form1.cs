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
        KitaplarDAO kitaplarDAO = new KitaplarDAO();
        YayýneviDAO yayýneviDAO = new YayýneviDAO();
        YazarDAO yazarDAO = new YazarDAO();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            kitapBindingSource.DataSource = kitaplarDAO.getAllKitaplar();
            columns(kitapBindingSource);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir kitap ismi giriniz.");
                return;
            }

            kitapBindingSource.DataSource = kitaplarDAO.searchTitles(textBox1.Text);
            columns(kitapBindingSource);


        }

        private void columns(BindingSource kitapBindingSource)
        {
            dataGridView1.DataSource = kitapBindingSource;
            dataGridView1.Columns["yazarId"].Visible = false;
            dataGridView1.Columns["yayýneviId"].Visible = false;

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
                MessageBox.Show("Lütfen bir satýr seçiniz.");
            }
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir satýr seçiniz.");
                return;
            }
            int rowClicked = dataGridView1.CurrentRow.Index;
            int sayi = rowClicked;
            int kitapID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;


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

        private void YayýneviGoster_Click(object sender, EventArgs e)
        {
            kitapBindingSource.DataSource = yayýneviDAO.getAllYayýnevleri();
            dataGridViewYayýnevi.DataSource = kitapBindingSource;
        }

        private void YayýneviAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYayýnevi.Text))
            {
                MessageBox.Show("Lütfen bir yayýnevi ismi giriniz.");
                return;
            }

            kitapBindingSource.DataSource = yayýneviDAO.searchTitles(textBoxYayýnevi.Text);
            dataGridViewYayýnevi.DataSource = kitapBindingSource;

        }

        private void YazarGoster_Click(object sender, EventArgs e)
        {
            kitapBindingSource.DataSource = yazarDAO.getAllYazarlar();
            dataGridViewYazar.DataSource = kitapBindingSource;
        }

        private void YazarAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYazar.Text))
            {
                MessageBox.Show("Lütfen bir yazar ismi giriniz.");
                return;
            }

            kitapBindingSource.DataSource = yazarDAO.searchTitles(textBoxYazar.Text);
            dataGridViewYazar.DataSource = kitapBindingSource;
        }

        private void YazarAdýAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYazarAdý.Text))
            {
                MessageBox.Show("Lütfen bir yazar ismi giriniz.");
                return;
            }

            kitapBindingSource.DataSource = kitaplarDAO.searchAuthors(textBoxYazarAdý.Text);
            columns(kitapBindingSource);
        }

        private void YayýneviAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYayýneviAdý.Text))
            {
                MessageBox.Show("Lütfen bir yayýnevi ismi giriniz.");
                return;
            }

            kitapBindingSource.DataSource = kitaplarDAO.searchPublishers(textBoxYayýneviAdý.Text);
            columns(kitapBindingSource);
        }
    }
}