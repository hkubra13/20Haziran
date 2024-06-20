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
                yazarAd = yAd_txt.Text,
                sayfaNo = Int32.Parse(sayfaS_txt.Text),
                yayınevi = yEv_txt.Text,
                basimTarihi = DateTime.Parse(bTarih_txt.Text),

            };

            KitaplarDAO kitaplarDAO = new KitaplarDAO();
            int result = kitaplarDAO.addOneKitap(kitap);
            MessageBox.Show(result + " yeni satır eklendi.");
        }
    }
}
