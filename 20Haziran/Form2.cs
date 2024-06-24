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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Kitap kitap = new Kitap()
            {
                kitapAd = kAd_txt.Text,
                yazarId = (int)yAd_txt.SelectedValue,
                sayfaNo = int.Parse(sayfaS_txt.Text),
                yayıneviId = (int)yEv_txt.SelectedValue,
                basimTarihi = dateTimePicker1.Value,

            };

            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            int result = kitaplarDAO.addOneKitap(kitap);
            MessageBox.Show(result + " yeni satır eklendi.");
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            YazarDAO yazarDAO = new YazarDAO();
            DataTableCollection tables = yazarDAO.GetYazarId();


            yAd_txt.DataSource = tables[0];
            yAd_txt.DisplayMember = "yazarAd";
            yAd_txt.ValueMember = "yazarId";




            YayıneviDAO yayıneviDAO = new YayıneviDAO();
            DataTableCollection tables2 = yayıneviDAO.GetYayıneviId();

            yEv_txt.DataSource = tables2[0];
            yEv_txt.DisplayMember = "yayıneviAd";
            yEv_txt.ValueMember = "yayıneviId";

        }
    }
}
