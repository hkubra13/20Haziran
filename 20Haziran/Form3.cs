using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Haziran
{
    public partial class Form3 : Form
    {

        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=_20Haziran;User ID=sa;Password=123456;Integrated Security=True;";

        private Kitap kitap;
        public Form3(Kitap kitap)
        {
            InitializeComponent();
            this.kitap = kitap;
            kAd_txt.Text = kitap.kitapAd;

            sayfaS_txt.Text = kitap.sayfaNo.ToString();
            yEv_txt.SelectedValue = kitap.yayınevi;
            dateTimePicker1.Value = kitap.basimTarihi;

        }

        private void button3_Click(object sender, EventArgs e)
        {


            kitap.kitapAd = kAd_txt.Text;
            kitap.yazarId = (int)yAd_txt.SelectedValue;
            kitap.sayfaNo = int.Parse(sayfaS_txt.Text);
            kitap.yayıneviId = (int)yEv_txt.SelectedValue;
            kitap.basimTarihi = dateTimePicker1.Value;




            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            int rowsAffected = kitaplarDAO.updateKitap(kitap);

            if (rowsAffected == 0)
            {
                MessageBox.Show("Güncelleme başarısız.");
            }
            else
            {
                MessageBox.Show("Güncelleme başarılı.");
            }




        }

        private void Form3_Load(object sender, EventArgs e)
        {



            YazarDAO yazarDAO = new YazarDAO();
            DataTableCollection tables = yazarDAO.GetYazarId();


            yAd_txt.DataSource = tables[0];
            yAd_txt.DisplayMember = "yazarAd";
            yAd_txt.ValueMember = "yazarId";
            yAd_txt.SelectedIndex = yAd_txt.FindStringExact(kitap.yazarAd);


            YayıneviDAO yayıneviDAO = new YayıneviDAO();
            DataTableCollection tables2 = yayıneviDAO.GetYayıneviId();

            yEv_txt.DataSource = tables2[0];
            yEv_txt.DisplayMember = "yayıneviAd";
            yEv_txt.ValueMember = "yayıneviId";
            yEv_txt.SelectedIndex = yEv_txt.FindStringExact(kitap.yayınevi);



        }
    }
}



/* 










 
 */