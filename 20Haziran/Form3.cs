using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Haziran
{
    public partial class Form3 : Form
    {
        private Kitap kitap;
        public Form3(Kitap kitap)
        {
            InitializeComponent();
            this.kitap = kitap;
            kAd_txt.Text = kitap.kitapAd;
            yAd_txt.Text = kitap.yazarAd;
            sayfaS_txt.Text = kitap.sayfaNo.ToString();
            yEv_txt.Text = kitap.yayınevi;
            dateTimePicker1.Value = kitap.basimTarihi;

        }

        private void button3_Click(object sender, EventArgs e)
        {


            kitap.kitapAd = kAd_txt.Text;
            kitap.yazarAd = yAd_txt.Text;
            kitap.sayfaNo = int.Parse(sayfaS_txt.Text);
            kitap.yayınevi = yEv_txt.Text;
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
    }
}
