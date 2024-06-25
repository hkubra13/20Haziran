using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20Haziran
{
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }

        private void YazarEkle2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(YazarEkle_txt.Text))
            {
                MessageBox.Show("Lütfen bir yazar ismi giriniz.");
                return;
            }

            Yazar yazar = new Yazar()
            {
                yazarAd = YazarEkle_txt.Text,
            };

            YazarDAO yazarDAO = new YazarDAO();
            int result = yazarDAO.AddOneYazar(yazar);
            MessageBox.Show(result + " yeni satır eklendi.");
        }

        

    }
}
