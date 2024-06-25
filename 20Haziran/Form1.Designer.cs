namespace _20Haziran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            sil_button = new Button();
            YazarEkle = new Button();
            groupBox1 = new GroupBox();
            YazarSil = new Button();
            Sekme = new TabControl();
            Kitap = new TabPage();
            label2 = new Label();
            textBoxYazarAdı = new TextBox();
            YazarAdıAra = new Button();
            label1 = new Label();
            Yayınevi = new TabPage();
            dataGridViewYayınevi = new DataGridView();
            textBoxYayınevi = new TextBox();
            YayıneviAra = new Button();
            YayıneviGoster = new Button();
            groupBox2 = new GroupBox();
            YayıneviEkle = new Button();
            YayıneviSil = new Button();
            Yazar = new TabPage();
            dataGridViewYazar = new DataGridView();
            textBoxYazar = new TextBox();
            YazarAra = new Button();
            YazarGoster = new Button();
            groupBox3 = new GroupBox();
            label3 = new Label();
            textBoxYayıneviAdı = new TextBox();
            YayıneviAd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            Sekme.SuspendLayout();
            Kitap.SuspendLayout();
            Yayınevi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYayınevi).BeginInit();
            groupBox2.SuspendLayout();
            Yazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYazar).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(628, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 0;
            button1.Text = "Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 246);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(1168, 67);
            button2.Name = "button2";
            button2.Size = new Size(94, 27);
            button2.TabIndex = 2;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(828, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(6, 41);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 4;
            button3.Text = "Kitap Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(728, 11);
            button4.Name = "button4";
            button4.Size = new Size(94, 27);
            button4.TabIndex = 6;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // sil_button
            // 
            sil_button.Location = new Point(146, 41);
            sil_button.Name = "sil_button";
            sil_button.Size = new Size(118, 29);
            sil_button.TabIndex = 7;
            sil_button.Text = "Kitap Sil";
            sil_button.UseVisualStyleBackColor = true;
            sil_button.Click += sil_button_Click;
            // 
            // YazarEkle
            // 
            YazarEkle.Location = new Point(6, 38);
            YazarEkle.Name = "YazarEkle";
            YazarEkle.Size = new Size(118, 29);
            YazarEkle.TabIndex = 8;
            YazarEkle.Text = "Yazar Ekle";
            YazarEkle.UseVisualStyleBackColor = true;
            YazarEkle.Click += YazarEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sil_button);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(46, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 102);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekle/Sil";
            // 
            // YazarSil
            // 
            YazarSil.Location = new Point(146, 38);
            YazarSil.Name = "YazarSil";
            YazarSil.Size = new Size(118, 29);
            YazarSil.TabIndex = 10;
            YazarSil.Text = "Yazar Sil";
            YazarSil.UseVisualStyleBackColor = true;
            YazarSil.Click += YazarSil_Click;
            // 
            // Sekme
            // 
            Sekme.Controls.Add(Kitap);
            Sekme.Controls.Add(Yayınevi);
            Sekme.Controls.Add(Yazar);
            Sekme.Location = new Point(-1, 0);
            Sekme.Name = "Sekme";
            Sekme.SelectedIndex = 0;
            Sekme.Size = new Size(1316, 500);
            Sekme.TabIndex = 11;
            // 
            // Kitap
            // 
            Kitap.Controls.Add(label3);
            Kitap.Controls.Add(textBoxYayıneviAdı);
            Kitap.Controls.Add(YayıneviAd);
            Kitap.Controls.Add(label2);
            Kitap.Controls.Add(textBoxYazarAdı);
            Kitap.Controls.Add(YazarAdıAra);
            Kitap.Controls.Add(label1);
            Kitap.Controls.Add(dataGridView1);
            Kitap.Controls.Add(groupBox1);
            Kitap.Controls.Add(textBox1);
            Kitap.Controls.Add(button4);
            Kitap.Controls.Add(button2);
            Kitap.Controls.Add(button1);
            Kitap.Location = new Point(4, 29);
            Kitap.Name = "Kitap";
            Kitap.Padding = new Padding(3);
            Kitap.Size = new Size(1308, 467);
            Kitap.TabIndex = 0;
            Kitap.Text = "Kitap";
            Kitap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(828, 122);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 14;
            label2.Text = "Yazar Adı :";
            // 
            // textBoxYazarAdı
            // 
            textBoxYazarAdı.Location = new Point(828, 145);
            textBoxYazarAdı.Name = "textBoxYazarAdı";
            textBoxYazarAdı.Size = new Size(334, 27);
            textBoxYazarAdı.TabIndex = 13;
            // 
            // YazarAdıAra
            // 
            YazarAdıAra.Location = new Point(1168, 145);
            YazarAdıAra.Name = "YazarAdıAra";
            YazarAdıAra.Size = new Size(94, 27);
            YazarAdıAra.TabIndex = 12;
            YazarAdıAra.Text = "Ara";
            YazarAdıAra.UseVisualStyleBackColor = true;
            YazarAdıAra.Click += YazarAdıAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(828, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 11;
            label1.Text = "Kitap Adı :";
            // 
            // Yayınevi
            // 
            Yayınevi.Controls.Add(dataGridViewYayınevi);
            Yayınevi.Controls.Add(textBoxYayınevi);
            Yayınevi.Controls.Add(YayıneviAra);
            Yayınevi.Controls.Add(YayıneviGoster);
            Yayınevi.Controls.Add(groupBox2);
            Yayınevi.Location = new Point(4, 29);
            Yayınevi.Name = "Yayınevi";
            Yayınevi.Padding = new Padding(3);
            Yayınevi.Size = new Size(1308, 467);
            Yayınevi.TabIndex = 1;
            Yayınevi.Text = "Yayınevi";
            Yayınevi.UseVisualStyleBackColor = true;
            // 
            // dataGridViewYayınevi
            // 
            dataGridViewYayınevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYayınevi.Location = new Point(50, 50);
            dataGridViewYayınevi.Name = "dataGridViewYayınevi";
            dataGridViewYayınevi.RowHeadersWidth = 51;
            dataGridViewYayınevi.Size = new Size(776, 246);
            dataGridViewYayınevi.TabIndex = 14;
            // 
            // textBoxYayınevi
            // 
            textBoxYayınevi.Location = new Point(50, 17);
            textBoxYayınevi.Name = "textBoxYayınevi";
            textBoxYayınevi.Size = new Size(334, 27);
            textBoxYayınevi.TabIndex = 16;
            // 
            // YayıneviAra
            // 
            YayıneviAra.Location = new Point(390, 17);
            YayıneviAra.Name = "YayıneviAra";
            YayıneviAra.Size = new Size(103, 27);
            YayıneviAra.TabIndex = 15;
            YayıneviAra.Text = "Yayınevi Ara";
            YayıneviAra.UseVisualStyleBackColor = true;
            YayıneviAra.Click += YayıneviAra_Click;
            // 
            // YayıneviGoster
            // 
            YayıneviGoster.Location = new Point(732, 17);
            YayıneviGoster.Name = "YayıneviGoster";
            YayıneviGoster.Size = new Size(94, 27);
            YayıneviGoster.TabIndex = 13;
            YayıneviGoster.Text = "Göster";
            YayıneviGoster.UseVisualStyleBackColor = true;
            YayıneviGoster.Click += YayıneviGoster_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(YayıneviEkle);
            groupBox2.Controls.Add(YayıneviSil);
            groupBox2.Location = new Point(50, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 102);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ekle/Sil";
            // 
            // YayıneviEkle
            // 
            YayıneviEkle.Location = new Point(6, 43);
            YayıneviEkle.Name = "YayıneviEkle";
            YayıneviEkle.Size = new Size(118, 29);
            YayıneviEkle.TabIndex = 9;
            YayıneviEkle.Text = "Yayınevi Ekle";
            YayıneviEkle.UseVisualStyleBackColor = true;
            YayıneviEkle.Click += YayıneviEkle_Click;
            // 
            // YayıneviSil
            // 
            YayıneviSil.Location = new Point(146, 43);
            YayıneviSil.Name = "YayıneviSil";
            YayıneviSil.Size = new Size(118, 29);
            YayıneviSil.TabIndex = 11;
            YayıneviSil.Text = "Yayınevi Sil";
            YayıneviSil.UseVisualStyleBackColor = true;
            YayıneviSil.Click += YayıneviSil_Click;
            // 
            // Yazar
            // 
            Yazar.Controls.Add(dataGridViewYazar);
            Yazar.Controls.Add(textBoxYazar);
            Yazar.Controls.Add(YazarAra);
            Yazar.Controls.Add(YazarGoster);
            Yazar.Controls.Add(groupBox3);
            Yazar.Location = new Point(4, 29);
            Yazar.Name = "Yazar";
            Yazar.Padding = new Padding(3);
            Yazar.Size = new Size(1308, 467);
            Yazar.TabIndex = 2;
            Yazar.Text = "Yazar";
            Yazar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewYazar
            // 
            dataGridViewYazar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYazar.Location = new Point(69, 68);
            dataGridViewYazar.Name = "dataGridViewYazar";
            dataGridViewYazar.RowHeadersWidth = 51;
            dataGridViewYazar.Size = new Size(776, 246);
            dataGridViewYazar.TabIndex = 18;
            // 
            // textBoxYazar
            // 
            textBoxYazar.Location = new Point(69, 35);
            textBoxYazar.Name = "textBoxYazar";
            textBoxYazar.Size = new Size(334, 27);
            textBoxYazar.TabIndex = 20;
            // 
            // YazarAra
            // 
            YazarAra.Location = new Point(409, 35);
            YazarAra.Name = "YazarAra";
            YazarAra.Size = new Size(103, 27);
            YazarAra.TabIndex = 19;
            YazarAra.Text = "Yazar Ara";
            YazarAra.UseVisualStyleBackColor = true;
            YazarAra.Click += YazarAra_Click;
            // 
            // YazarGoster
            // 
            YazarGoster.Location = new Point(751, 35);
            YazarGoster.Name = "YazarGoster";
            YazarGoster.Size = new Size(94, 27);
            YazarGoster.TabIndex = 17;
            YazarGoster.Text = "Göster";
            YazarGoster.UseVisualStyleBackColor = true;
            YazarGoster.Click += YazarGoster_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(YazarEkle);
            groupBox3.Controls.Add(YazarSil);
            groupBox3.Location = new Point(69, 336);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(270, 102);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekle/Sil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(828, 204);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 17;
            label3.Text = "Yayınevi Adı :";
            // 
            // textBoxYayıneviAdı
            // 
            textBoxYayıneviAdı.Location = new Point(828, 227);
            textBoxYayıneviAdı.Name = "textBoxYayıneviAdı";
            textBoxYayıneviAdı.Size = new Size(334, 27);
            textBoxYayıneviAdı.TabIndex = 16;
            // 
            // YayıneviAd
            // 
            YayıneviAd.Location = new Point(1168, 227);
            YayıneviAd.Name = "YayıneviAd";
            YayıneviAd.Size = new Size(94, 27);
            YayıneviAd.TabIndex = 15;
            YayıneviAd.Text = "Ara";
            YayıneviAd.UseVisualStyleBackColor = true;
            YayıneviAd.Click += YayıneviAd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 498);
            Controls.Add(Sekme);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            Sekme.ResumeLayout(false);
            Kitap.ResumeLayout(false);
            Kitap.PerformLayout();
            Yayınevi.ResumeLayout(false);
            Yayınevi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYayınevi).EndInit();
            groupBox2.ResumeLayout(false);
            Yazar.ResumeLayout(false);
            Yazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYazar).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button sil_button;
        private Button YazarEkle;
        private GroupBox groupBox1;
        private Button YazarSil;
        private TabControl Sekme;
        private TabPage Kitap;
        private TabPage Yayınevi;
        private TabPage Yazar;
        private GroupBox groupBox2;
        private Button YayıneviEkle;
        private Button YayıneviSil;
        private GroupBox groupBox3;
        private DataGridView dataGridViewYayınevi;
        private TextBox textBoxYayınevi;
        private Button YayıneviAra;
        private Button YayıneviGoster;
        private DataGridView dataGridViewYazar;
        private TextBox textBoxYazar;
        private Button YazarAra;
        private Button YazarGoster;
        private Label label2;
        private TextBox textBoxYazarAdı;
        private Button YazarAdıAra;
        private Label label1;
        private Label label3;
        private TextBox textBoxYayıneviAdı;
        private Button YayıneviAd;
    }
}
