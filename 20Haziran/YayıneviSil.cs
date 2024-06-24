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
    public partial class YayıneviSil : Form
    {
        public YayıneviSil()
        {
            InitializeComponent();
        }

        private void YayıneviSil2_Click(object sender, EventArgs e)
        {

            YayıneviDAO yayıneviDAO = new YayıneviDAO();
            int result = yayıneviDAO.DeleteYayınevi((int)yEv_txt.SelectedValue);
            MessageBox.Show(result + " yayınevi silindi.");

        }

        private void YayıneviSil_Load(object sender, EventArgs e)
        {
            YayıneviDAO yayıneviDAO = new YayıneviDAO();
            DataTableCollection tables2 = yayıneviDAO.GetYayıneviId();

            yEv_txt.DataSource = tables2[0];
            yEv_txt.DisplayMember = "yayıneviAd";
            yEv_txt.ValueMember = "yayıneviId";
        }
    }
}
