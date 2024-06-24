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
    public partial class YazarSil : Form
    {
        public YazarSil()
        {
            InitializeComponent();
        }

        private void YazarSil_Load(object sender, EventArgs e)
        {
            YazarDAO yazarDAO = new YazarDAO();
            DataTableCollection tables = yazarDAO.GetYazarId();


            yAd_txt.DataSource = tables[0];
            yAd_txt.DisplayMember = "yazarAd";
            yAd_txt.ValueMember = "yazarId";



        }

        private void YazarSil2_Click(object sender, EventArgs e)
        {
            YazarDAO yazarDAO = new YazarDAO();
            int result = yazarDAO.DeleteYazar((int)yAd_txt.SelectedValue);
            MessageBox.Show(result + " yazar silindi.");
        }
    }
}
