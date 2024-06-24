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
            YayıneviEkle = new Button();
            groupBox1 = new GroupBox();
            YazarSil = new Button();
            YayıneviSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 23);
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
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 246);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(387, 23);
            button2.Name = "button2";
            button2.Size = new Size(94, 27);
            button2.TabIndex = 2;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(6, 115);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 4;
            button3.Text = "Kitap Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(487, 23);
            button4.Name = "button4";
            button4.Size = new Size(94, 27);
            button4.TabIndex = 6;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // sil_button
            // 
            sil_button.Location = new Point(159, 115);
            sil_button.Name = "sil_button";
            sil_button.Size = new Size(118, 29);
            sil_button.TabIndex = 7;
            sil_button.Text = "Kitap Sil";
            sil_button.UseVisualStyleBackColor = true;
            sil_button.Click += sil_button_Click;
            // 
            // YazarEkle
            // 
            YazarEkle.Location = new Point(6, 45);
            YazarEkle.Name = "YazarEkle";
            YazarEkle.Size = new Size(118, 29);
            YazarEkle.TabIndex = 8;
            YazarEkle.Text = "Yazar Ekle";
            YazarEkle.UseVisualStyleBackColor = true;
            YazarEkle.Click += YazarEkle_Click;
            // 
            // YayıneviEkle
            // 
            YayıneviEkle.Location = new Point(6, 80);
            YayıneviEkle.Name = "YayıneviEkle";
            YayıneviEkle.Size = new Size(118, 29);
            YayıneviEkle.TabIndex = 9;
            YayıneviEkle.Text = "Yayınevi Ekle";
            YayıneviEkle.UseVisualStyleBackColor = true;
            YayıneviEkle.Click += YayıneviEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(YayıneviSil);
            groupBox1.Controls.Add(YazarSil);
            groupBox1.Controls.Add(sil_button);
            groupBox1.Controls.Add(YazarEkle);
            groupBox1.Controls.Add(YayıneviEkle);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(23, 341);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 173);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekle/Sil";
            // 
            // YazarSil
            // 
            YazarSil.Location = new Point(159, 45);
            YazarSil.Name = "YazarSil";
            YazarSil.Size = new Size(118, 29);
            YazarSil.TabIndex = 10;
            YazarSil.Text = "Yazar Sil";
            YazarSil.UseVisualStyleBackColor = true;
            YazarSil.Click += YazarSil_Click;
            // 
            // YayıneviSil
            // 
            YayıneviSil.Location = new Point(159, 80);
            YayıneviSil.Name = "YayıneviSil";
            YayıneviSil.Size = new Size(118, 29);
            YayıneviSil.TabIndex = 11;
            YayıneviSil.Text = "Yayınevi Sil";
            YayıneviSil.UseVisualStyleBackColor = true;
            YayıneviSil.Click += YayıneviSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 718);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button YayıneviEkle;
        private GroupBox groupBox1;
        private Button YazarSil;
        private Button YayıneviSil;
    }
}
