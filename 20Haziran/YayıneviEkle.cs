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
    public partial class YayıneviEkle : Form
    {
        public YayıneviEkle()
        {
            InitializeComponent();
        }

        private void YayıneviEkle2_Click(object sender, EventArgs e)
        {
            Yayınevi yayınevi = new Yayınevi()
            {
                yayıneviAd = YayıneviEkle_txt.Text,
            };

            YayıneviDAO yayıneviDAO = new YayıneviDAO();
            int result = yayıneviDAO.AddOneYazar(yayınevi);
            MessageBox.Show(result + " yeni satır eklendi.");
        }
    }
}
